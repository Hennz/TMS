using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Models
{
    class Site
    {
        private static Site _instance;

        public String siteName { get; private set; }
        public String localMapFileAddr { get; private set; }
        public float mapScale { get; private set; }

        public static Site GetInstance() {
            if (_instance == null)  {
                _instance = new Site();
            }

            return _instance;
        }

        public void Init(String siteN, String mapPath, float scale)
        {
            siteName = siteN;
            localMapFileAddr = mapPath;
            mapScale = scale;
        }
    }
}
