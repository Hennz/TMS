using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS
{
    public class Router
    {
        public String routerId { get; private set; } 
        public  String address { get; private set; }
        public String location { get; private set; }

        public int posX { get; private set; }
        public int posY { get; private set; }

        public bool isBlocked { get; private set; }

        public LinkedList<Member> hasConnectedMember { get; private set; }

        public delegate void OnUpdatedDelegate(int new_x, int new_y, bool new_blocked);

        public event OnUpdatedDelegate OnUpdated;

        public Router(String rId, String addr, String loc, int x, int y, bool iB)
        {
            routerId = rId;
            address = addr;
            location = loc;

            posX = x;
            posY = y;

            isBlocked = iB;

            hasConnectedMember = new LinkedList<Member>();
            
        }

        public override string ToString()
        {
            return routerId;
        }

        public void Update(String rId, String addr, String loc, int x, int y, bool iB)
        {
            routerId = rId;
            address = addr;
            location = loc;

            posX = x;
            posY = y;

            isBlocked = iB;

            OnUpdated(posX, posY, isBlocked);
        }
    }
}
