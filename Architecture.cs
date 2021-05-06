using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (value.GetType() == PointerType)
                return true;
            
           return false;
        }

    }



}
