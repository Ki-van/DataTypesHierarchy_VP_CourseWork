using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataTypesHierarchy_VP_CourseWork
{

    public class Number<T> : IndependentScalar<T>, ITypeSafety
    {
        public bool real;
        public bool signed;
        
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
                } else
                {
                    if(value > 1 && value < 8)
                    {

                    } else
                        throw new Exception("Целое число может занимать от 1 до 8 байт");
                }


            } 
        }
        


        public bool IsValueFitType<T>(T value)
        {
            return true;
        }

    }
    
}
