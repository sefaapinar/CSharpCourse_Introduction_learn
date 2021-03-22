using System;

namespace Generics
{
    internal class Utilities
    {
        public Utilities()
        {
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        internal List<T> BuildList<T>(T v1, T v2, T v3)
        {
            throw new NotImplementedException();
        }
    }
}