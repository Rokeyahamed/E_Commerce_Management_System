using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBECommerce_Project.Entity
{
    public class EOrder
    {
        public String OrderID { set; get; }
        public String OrderSeller { set; get; }
        public String OrderCustomer { set; get; }
        public String ProductName { set; get; }
        public int ProductPrice { set; get; }
    }
}
