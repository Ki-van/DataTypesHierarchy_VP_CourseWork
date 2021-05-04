using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesHierarchy_VP_CourseWork
{
    public interface ITypeSafety
    {
        public abstract bool IsValueFitType<T>(T value);
    }
}
