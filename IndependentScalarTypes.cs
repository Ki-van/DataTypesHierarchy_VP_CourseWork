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
            if (real)
            {
                double minVal;
                double maxVal;
                if(Size ==  4)
                {
                    minVal = float.MinValue;
                    maxVal = float.MaxValue;
                }else
                {
                    minVal = double.MinValue;
                    maxVal = double.MaxValue;
                }
                return String.Format("Число с плавающей запятой" + "\r\n\r\n" + "Имя: {0} \r\nРазмер: {1} байт\r\nЗначение: {2}\r\nПринимаемые значение: от {3} до {4}\r\n" +
                    "Допустимые операции: логические, арифметические\r\n\r\n" +
                    "Используются для представления вещественных (не обязательно целых) чисел. В этом случае число записывается в" +
                    " виде x=a*10^b. Где 0<=a<1, а b — некоторое целое число из определённого диапазона. a называют мантиссой, b — порядком." +
                    " У мантиссы хранятся несколько цифр после запятой, а b — хранится полностью." + 
                     "\r\n", Name, Size, Value, minVal, maxVal);
            }
            else
            {

                return String.Format("Целочисленный тип" + "\r\n" + "Имя: {0} \r\nРазмер: {1} байт\r\nЗначение: {2}\r\nЗнаковое: {3}\r\n"
                    + "Допустимые операции:  все целочисленные типы поддерживают арифметические операторы, побитовые логические операторы," +
                    " операторы сравнения и равенства.\r\n\r\n"
                    + "Целочисленные типы содержат в себе значения, интерпретируемые как числа (знаковые и беззнаковые).", Name, Size, Value, signed ? "Да" : "Нет");
            }
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
            return String.Format("Символ" + "\r\n" + "Имя: {0} \r\nРазмер: {1} байт\r\nЗначение: {2}\r\nПринимает значения От U+0000 до U+FFFF\r\n " +
                "\r\nДопустимые операции: сравнение, проверку равенства, а также операции инкремента и декремента.", Name, Size, Value);
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
            return String.Format("Логическое значение" + "\r\n\r\n" + "Имя: {0} \r\nРазмер: {1} байт\r\nЗначение: {2}\r\nПринимает значения true или false\r\n\r\n " +
                "Для выполнения логических операций со значениями типа bool используйте логические операторы. Тип bool является типом " +
                "результата операторов сравнения и равенства. Выражение bool может быть управляющим условным выражением в операторах " +
                "if, do, while и for и условном операторе ?:.", Name, Size, Value);
        }
    }
}
