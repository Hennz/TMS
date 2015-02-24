using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS
{
    public class EDBroadcast
    {
        public string content { get; private set; }

        public string createdByUser { get; private set; }

        public DateTime created { get; private set; }

        public EDBroadcast(string co, string u, DateTime cr)
        {
            content = co;
            createdByUser = u;
            created = cr;
        }
    }
}
