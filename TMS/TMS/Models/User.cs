using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Models
{
    class User
    {
        public string username { get; private set; }
        public String fName { get; private set; }
        public String lName { get; private set; }

        public User(string uName, string f, string l)
        {
            username = uName;
            fName = f;
            lName = l;
        }
    }
}
