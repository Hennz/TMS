using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Models
{
    class Member
    {
        public String memberId { get; private set; }
        public String fName { get; private set; }
        public String mName { get; private set; }
        public String lName { get; private set; }

        public String address { get; private set; }
        public String province { get; private set; }
        public String city { get; private set; }

        public int pinNo { get; private set; }

        public String phoneNo { get; private set; }
        public String mobileNo { get; private set; }

        public bool isVehicle { get; private set; }

        public String tagId { get; private set; }

        public LinkedList<Router> path { get; private set; }

        public Member(String mId, String f, String m, String l, 
            String addr, String prov, String cit, 
            int pNo,
            String phNo, String mNo,
            bool isV,
            String tId)
        {
            memberId = mId;

            fName = f;
            mName = m;
            lName = l;

            address = addr;
            province = prov;
            city = cit;

            pinNo = pNo;

            phoneNo = phNo;
            mobileNo = mNo;

            isVehicle = isV;

            tagId = tId;

            path = new LinkedList<Router>();
        }

        public void AppendRouter(Router router)
        {
            if (!path.Contains(router))
            {
                path.AddFirst(router);
            }
        }

        public LinkedList<Router> GetPath()
        {
            return path;
        }

        public void Update(String mId, String f, String m, String l,
            String addr, String prov, String cit,
            int pNo,
            String phNo, String mNo,
            bool isV,
            String tId)
        {
            memberId = mId;

            fName = f;
            mName = m;
            lName = l;

            address = addr;
            province = prov;
            city = cit;

            pinNo = pNo;

            phoneNo = phNo;
            mobileNo = mNo;

            isVehicle = isV;

            tagId = tId;

            // TODO: Put in SQL update logic for Members

        }

    }
}
