using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBECommerce_Project.Entity
{
    public class EUser
    {
        public String Username { set; get; }
        public String Password { set; get; }
        public String FirstName { set; get; }
        public String LastName { set; get; }
        public String DOB { set; get; }
        public String AccountType { set; get; }
    }
}
