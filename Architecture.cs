using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesHierarchy_VP_CourseWork
{

    public class DataType : IDescribable
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
        private T value;
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
 

    public class Aggregate : DataType
    {
        ///TODO Конструкторы, методы сравнения по размеру 
        public List<DataType> components;

        public override string GetDescription()
        {
            throw new NotImplementedException();
        }
    }

    public class IndependentScalar<T> : Scalar<T>
    {
        public override string GetDescription()
        {
            return Resource.IndependentScalarDescription;
        }
    }

    public unsafe class DependentScalar<T> : Scalar<T>
    {
        public DataType pointerType;

        public List<DataType> exemplars;

        public override string GetDescription()
        {
            throw new NotImplementedException();
        }

        public  bool IsValueFitType<T>(T value)
        {
            throw new NotImplementedException();
        }
    }


}
