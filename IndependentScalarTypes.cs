using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataTypesHierarchy_VP_CourseWork
{

    public class Number : IndependentScalar<decimal>
    {
        public bool signed;
        public bool real;
        public override decimal Value { get => base.Value; 
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
        public override uint Size
        {
            get => size;
            set
            {
                if (real)
                {
                    if (value == 4 || value == 8)
                    {
                        size = value;
                    }
                    else
                        throw new Exception("Вещественное число может занимать только 4 или 8 байт");
                }
                else
                {
                    if (value == 1 || value == 2 || value == 4 || value == 8)
                    {
                        size = value;
                    }
                    else
                        throw new Exception("Целое число может занимать 1, 2, 4 или 8 байт");
                }


            }
        }

        public Number(string name)
            : this(true, false, 4, name, 0) { }

        public Number(bool real, uint size, string name, decimal value):this(false, real, size, name, value) { }

        public Number(bool signed, bool real, uint size, string name, decimal value)
        {
            Name = name;
            this.real = real;
            this.signed = signed;
            this.Size = size;
            this.Value = value;
        }


        public override string GetDescription()
        {
            return String.Format("Число ебана");
        }

        private bool IsValueFitType(decimal value)
        {
            bool result = false;

            if (size == 1 && signed == false)
            {
                byte temp = (byte)value;
                if (temp == value)
                    result = true;
            }
            else if (size == 1 && signed == true)
            {
                sbyte temp = (sbyte)value;
                if (temp == value)
                    result = true;
            }
            else if (size == 2 && signed == true)
            {
                short temp = (short)value;
                if (temp == value)
                    result = true;
            }
            else if (size == 2 && signed == false)
            {
                ushort temp = (ushort)value;
                if (temp == value)
                    result = true;
            }
            else if (size == 4 && signed == true && real == false)
            {
                int temp = (int)value;
                if (temp == value)
                    result = true;
            }
            else if (size == 4 && signed == false && real == false)
            {
                uint temp = (uint)value;
                if (temp == value)
                    result = true;
            }
            else if (size == 8 && signed == true && real == false)
            {
                long temp = (long)value;
                if (temp == value)
                    result = true;
            }
            else if (size == 8 && signed == false && real == false)
            {
                ulong temp = (ulong)value;
                if (temp == value)
                    result = true;
            }
            else if (size == 4 && real == true)
            {
                if ((double)value >= float.MinValue && (double)value <= float.MaxValue)
                    result = true;
            }
            else if (size == 8 && real == true)
            {
                    result = true;
            }

            return result;
        }

       
    }

    public class Character : IndependentScalar<char>
    {
        public Character(string name):this(name, default(char)) { }
        public Character(string name, char value)
        {
            this.Name = name;
            this.Value = value;
            this.Size = sizeof(char);
        }

        public override string GetDescription()
        {
            return "Символ что тут сказать";
        }
    }

    public class Boolean: IndependentScalar<bool>
    {
        public Boolean(string name, bool value)
        {
            this.Name = name;
            this.Value = value;
            this.Size = sizeof(bool);
        }
        public Boolean(string name) : this(name, default(bool)) { }
        public override string GetDescription()
        {
            return "Булево что тут сказать";
        }
    }
}
