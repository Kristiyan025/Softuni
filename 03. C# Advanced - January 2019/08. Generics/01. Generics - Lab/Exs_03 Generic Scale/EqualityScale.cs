namespace Exs_03_Generic_Scale
{
    using System;

    public class EqualityScale<T> 
    {
        T left;
        T right;

        public EqualityScale(T first, T second)
        {
            this.left = first;
            this.right = second;
        }

        public bool AreEqual()
        {
            return this.left.Equals(this.right);
        }

    }
}
