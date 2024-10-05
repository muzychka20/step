using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public abstract class User
    {
        protected static int id = 1;
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
