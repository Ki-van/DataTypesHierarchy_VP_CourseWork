using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace DataTypesHierarchy_VP_CourseWork
{

    public unsafe class DataType : IDescribable
    {
        private string name;
        protected uint size;
        public string Name { get => name;  
            set
            {
                if (DataTypes.IsNameUnique(name))
                {
                    name = value;
                }
                else
                    throw new Exception("Выбранное имя уже занято");
            }
        }
        public virtual uint Size { get; set; }

        public  virtual string GetDescription()
        {
            return Resource.DataTypeDescription;
        }
        
    }
    public class Scalar<T> : DataType
    {
        private  T value;
        public virtual T Value{ get => value; set { this.value = value; } }
        public override string GetDescription()
        {
            return Resource.ScalarTypeDescription;
        }
    }

    public static class DataTypes
    {
        public static bool IsNameUnique(string Name)
        {
            return true;
        }

        public static List<DataType> dataTypes;

        static DataTypes()
        {
            dataTypes = new List<DataType>();
        }

    }
 

    public class AggregateType : DataType
    {
        private List<DataType> components;
        public List<DataType> Components { get => components;
            set 
            {
                components = value;
                CalcSize(value);
            }
        }

        public AggregateType(string name, List<DataType> components)
        {
            Name = name;
            Components = components;
        }

        public override string GetDescription()
        {
            return "Агрегратный ебана";
        }

        private void CalcSize(List<DataType> dataTypes)
        {
            uint size = 1;
            foreach (var type in dataTypes)
                size += type.Size;

            Size = size;
        }

    }

    public class IndependentScalar<T> : Scalar<T>
    {
        public override string GetDescription()
        {
            return Resource.IndependentScalarDescription;
        }
    }

    public unsafe class DependentScalar : Scalar<DataType>
    {
        public Type PointerType { get; set; }

        public override DataType Value { get => base.Value; 
            set 
            {
                if (IsValueFitType(value))
                {
                    base.Value = value;
                }
                else
                    throw new Exception("Значение не соотвествует типу");
            }
        }
        public DependentScalar(string name, Type pointerType, DataType pointedTo ) 
        {
            PointerType = pointerType;
            Value = pointedTo;
            Name = name;
            Size = 4;
        }

        public override string GetDescription()
        {
            return "Указатель хуле";
        }

        public  bool IsValueFitType(DataType value)
        {
            if (value == null)
                return true;

            if (value.GetType() == PointerType)
                return true;
            
           return false;
        }

    }

    public static class Serialize
    {
        static Dictionary<DataType, XElement> links = new();
        static Dictionary<ulong, DataType> unresolvedPointers = new();
        static Dictionary<ulong, DataType> pointedOns = new();
        static ulong id = 1;
        public static void SaveToXML(string path)
        {
            links.Clear();
            XDocument xdoc = new XDocument();
            XElement xRoot = new XElement("DataTypes");
            foreach (DataType dataType in DataTypes.dataTypes)
                AddXElement(xRoot, dataType);

            xdoc.Add(xRoot);
            xdoc.Save(path);
        }

        private static void AddXElement(XElement xRoot, DataType dataType)
        {
            XElement xNode;
            if (links.ContainsKey(dataType))
            {
                xNode = links[dataType];
            }
            else
            {
                xNode = new XElement("Name");
                links.Add(dataType, xNode);
            }
            Type typeDataType = dataType.GetType();
            if (typeDataType == typeof(Number))
            {
                Number num = (Number)dataType;
                xNode.Name = "Number";
                xNode.Add(
                    new XElement("Name", num.Name),
                    new XElement("Size", num.Size),
                    new XElement("real", num.real),
                    new XElement("signed", num.signed),
                    new XElement("Value", num.Value)
                    );
                xRoot.Add(xNode);
                
            }
            else if (typeDataType == typeof(Character))
            {
                Character type = (Character)dataType;

                xNode.Name = "Character";
                xNode.Add(
                    new XElement("Name", type.Name),
                    new XElement("Value", type.Value)
                    );
                xRoot.Add(xNode);
            }
            else if (typeDataType == typeof(Boolean))
            {
                Boolean type = (Boolean)dataType;
                xNode.Name = "Boolean";
                xNode.Add(
                    new XElement("Name", type.Name),
                    new XElement("Value", type.Value)
                    );
                xRoot.Add(xNode);
            }
            else if (typeDataType == typeof(AggregateType))
            {
                AggregateType aggregateType = (AggregateType)dataType;
                xNode.Name = "AggregateType";
                xNode.Add(
                     new XElement("Name", aggregateType.Name)
                    );

                xRoot.Add(xNode);

                XElement components = new XElement("Components");
                xNode.Add(components);
                foreach (DataType component in aggregateType.Components)
                    AddXElement(components, component);
            }
            else if (typeDataType == typeof(DependentScalar))
            {
                DependentScalar dependentScalar = (DependentScalar)dataType;
                xNode.Name = "DependentScalar";
                xNode.Add(
                    new XElement("Name", dependentScalar.Name),
                    new XElement("PointerType", dependentScalar.PointerType.Name)
                    );
                xRoot.Add(xNode);
                
                if(links.ContainsKey(dataType))
                {
                    links[dataType].Add(new XAttribute("id", id));
                }
                else
                {
                    links.Add(dataType, new XElement("Name", new XAttribute("id", id)));
                }

                xNode.Add(new XElement("Value", id));
                id++;
            }
            else
                throw new Exception("Ошибка сериализации");
        }

        public static void LoadFromXml(string path)
        {
            DataTypes.dataTypes.Clear();
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(path);

            XmlElement xRoot = xdoc.DocumentElement;

            if (xRoot.HasChildNodes)
            {
                foreach (XmlElement xNode in xRoot)
                {
                    DataTypes.dataTypes.Add(DeserializeNode(xNode));
                }
            }
        }

        private static DataType DeserializeNode(XmlElement xNode)
        {
            DataType dataType = null;
            if (xNode.Name == "Number")
            {
                bool signed = false;
                bool real = true;
                uint size = 4;
                string name = "Name";
                decimal value = default(decimal);

                foreach(XmlNode node in xNode.ChildNodes)
                {
                    if(node.Name == "Name")
                    {
                        name = node.InnerText;
                    } 
                    if(node.Name == "Value")
                    {
                        value = decimal.Parse(node.InnerText);
                    } 
                    if(node.Name == "real")
                    {
                        real = bool.Parse(node.InnerText);
                    } 
                    if(node.Name == "Size")
                    {
                        size = uint.Parse(node.InnerText);
                    } 
                    if(node.Name == "signed")
                    {
                        signed = bool.Parse(node.InnerText);
                    }
                }

                dataType = new Number(signed, real, size, name, value);

            }
            if(xNode.Name == "Boolean")
            {
                string name = "Name";
                bool value = default(bool);

                foreach (XmlNode node in xNode.ChildNodes)
                {
                    if (node.Name == "Name")
                    {
                        name = node.InnerText;
                    }
                    if (node.Name == "Value")
                    {
                        value = bool.Parse(node.InnerText);
                    }
                }

                dataType = new Boolean(name, value);
            }
            if(xNode.Name == "Character")
            {
                string name = "Name";
                char value = default(char);

                foreach (XmlNode node in xNode.ChildNodes)
                {
                    if (node.Name == "Name")
                    {
                        name = node.InnerText;
                    }
                    if (node.Name == "Value")
                    {
                        value = char.Parse(node.InnerText);
                    }
                }

                dataType = new Character(name, value);
            }
            if(xNode.Name == "AggregateType")
            {
                string name = "Name";
                List<DataType> components = new();
                foreach (XmlNode node in xNode.ChildNodes)
                {
                    if (node.Name == "Name")
                    {
                        name = node.InnerText;
                    }
                    if(node.Name == "Components")
                    {
                        foreach (XmlElement childNode in node.ChildNodes)
                        {
                            components.Add(DeserializeNode(childNode));
                        }
                    }

                    dataType = new AggregateType(name, components);
                }
            }
            if(xNode.Name == "DependentScalar")
            {
                string name = "Name";
                Type pointerType = null;
                DataType value = null;
                foreach(XmlNode node in xNode.ChildNodes)
                {
                    if (node.Name == "Name") 
                    {
                        name = node.InnerText;
                    }

                    if(node.Name == "PointerType")
                    {
                       if(node.InnerText == "Number")
                       {
                            pointerType = typeof(Number);
                       }
                        if (node.InnerText == "Character")
                        {
                            pointerType = typeof(Character);
                        }
                        if (node.InnerText == "Boolean")
                        {
                            pointerType = typeof(Boolean);
                        }
                        if (node.InnerText == "AggregateType")
                        {
                            pointerType = typeof(AggregateType);
                        }
                        if (node.InnerText == "DependentScalar")
                        {
                            pointerType = typeof(DependentScalar);
                        }
                    }

                    if (node.Name == "Value")
                    {
                        id = ulong.Parse(node.InnerText);
                        if (pointedOns.ContainsKey(id))
                            value = pointedOns[id];
                        else
                            unresolvedPointers.Add(id, dataType);
                    }
                }
                dataType = new DependentScalar(name, pointerType, value);
            }

            if (xNode.HasAttribute("id"))
            {
                pointedOns.Add(uint.Parse(xNode.GetAttribute("id")), dataType);
            }

            return dataType;
        }
    }


}
