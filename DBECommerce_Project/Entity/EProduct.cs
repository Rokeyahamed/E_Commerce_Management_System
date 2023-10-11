using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBECommerce_Project.Entity
{
    public class EProduct
    {
        public String ProductID { set; get; }
        public String ProductName { set; get; }
        public int ProductPrice { set; get; }
        public String ProductSeller { set; get; }
        public int ProductStock { set; get; }

    }
}
