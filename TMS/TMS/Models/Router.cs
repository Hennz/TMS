using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Models
{
    class Router
    {
        public String routerId { get; private set; } 
        public  String address { get; private set; }
        public String location { get; private set; }

        int posX, posY;

        bool isBlocked;

        public Router(String rId, String addr, String loc, int x, int y, bool iB)
        {
            routerId = rId;
            address = addr;
            location = loc;

            posX = x;
            posY = y;

            isBlocked = iB;
        }

        public void Update(String rId, String addr, String loc, int x, int y, bool iB)
        {
            routerId = rId;
            address = addr;
            location = loc;

            posX = x;
            posY = y;

            isBlocked = iB;

            // TODO: Put in SQL update logic for Routers
        }
    }
}
