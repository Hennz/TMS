using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS
{
    class MineSite
    {
        private static MineSite _instance;

        public int siteId { get; private set; }
        public String siteName { get; private set; }
        public String localMapFileAddr { get; private set; }
        public float mapScale { get; private set; }

        public List<Router> siteRouters { get; private set; }
        public List<Member> siteMembers { get; private set; }

        public Router ContainsRouter(string rId) 
        {
            foreach (Router r in siteRouters)
            {
                if (rId.Equals(r.routerId))
                {
                    return r;
                }
            }

            return null;
        }

        public static MineSite GetInstance() {
            if (_instance == null)  {
                _instance = new MineSite();
            }

            return _instance;
        }

        public void Init(int id, string siteN, string mapPath, float scale, List<Router> routers, List<Member> members)
        {
            siteId = id;
            siteName = siteN;
            localMapFileAddr = mapPath;
            mapScale = scale;

            siteRouters = routers;
            siteMembers = members;
        }

    }
}
