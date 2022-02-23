using System;

namespace ECommerce.Models
{
    internal class ForignKeyAttribute : Attribute
    {
        private string v;

        public ForignKeyAttribute(string v)
        {
            this.v = v;
        }
    }
}