using System;

namespace nguyenduyphan_lap456.Models
{
    internal class stringlengthAttribute : Attribute
    {
        private int v;

        public stringlengthAttribute(int v)
        {
            this.v = v;
        }
    }
}