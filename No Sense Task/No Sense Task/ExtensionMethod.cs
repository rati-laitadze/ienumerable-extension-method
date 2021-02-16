using System;
using System.Collections.Generic;
using System.Text;

namespace No_Sense_Task
{
    public static class ExtensionMethod
    {
        public static IEnumerable<T> ThisDoesntMakeAnySense<T>( this  IEnumerable<T> ts,
            Func<T, bool> Filter,
            Func<IEnumerable<T>> New)
        {
            foreach (var item in ts)
            {
                if (item == null)
                    throw new ArgumentNullException();
                if (Filter(item))
                    return ts ;
            }
            return New();
        }

    }
}
