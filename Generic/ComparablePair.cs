using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class ComparablePair<T, U> : IComparable<ComparablePair<T, U>> where T : IComparable<T> where U : IComparable<U>
    {
        private T t;

        private U u;

        public ComparablePair( T t , U u) 
        {
            this.t = t;
            this.u = u; 
        }

        public T First => t;

        public U Second => u;

        public int CompareTo(ComparablePair<T,U> other)
        {
            int result = t.CompareTo(other.t);
            if (result != 0)
            {
                return result;
            }
            else
            {
                return u.CompareTo(other.u);
            }
            
        }
    }






}
