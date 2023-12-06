using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_7
{
    internal class ClassProva
    {
        public int Id { get; set; }

        private string? Name { get; set; }

        protected bool? IsPublic { get; set; }

        public void SetPrivateString(string x)
        {
            Name = x;
        }

        public void SetProtectedBool(bool x)
        {
            IsPublic = x;
        }

        public string GetPrivateString()
        {
            if (Name == null)
            {
                throw new InvalidOperationException();
            }

            return Name;
        }

        public bool? GetProtectedBool()
        {
            return IsPublic;
        }
    }
}
