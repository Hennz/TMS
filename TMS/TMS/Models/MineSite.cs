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
        public String localMapFileAddr { get; set; }
        public float mapScale { get; private set; }

        public List<Router> siteRouters { get; private set; }
        public Dictionary<string, Member> siteMembers { get; private set; }
        public List<string> siteSensors { get; private set; }

        public delegate void OnUpdatedDelegate(float new_scale);

        public event OnUpdatedDelegate OnUpdated;

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

        public void Dispose()
        {
            siteRouters.Clear();
            siteMembers.Clear();
            siteSensors.Clear();
        }

        public void Init(int id, string siteN, string mapPath, float scale,
            List<Router> routers, Dictionary<string, Member> members, List<string> sensors)
        {
            siteId = id;
            siteName = siteN;
            localMapFileAddr = mapPath;
            mapScale = scale;

            siteRouters = routers;
            siteMembers = members;
            siteSensors = sensors;
        }

        public void UpdateScale(float new_scale)
        {
            mapScale = new_scale;
            OnUpdated(new_scale);
        }

    }
}
