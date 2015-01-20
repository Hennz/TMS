using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Models
{
    class Member
    {
        String memberId { public get; private set; }
        String fName { public get; private set; }
        String mName { public get; private set; }
        String lName { public get; private set; }

        String address { public get; private set;}
        String province { public get; private set; }
        String city { public get; private set; }

        int pinNo { public get; private set; }

        String phoneNo { public get; private set; }
        String mobileNo { public get; private set; }

        bool isVehicle { public get; private set; }

        String tagId { public get; private set; }

        LinkedList<Router> path { public get; private set; }

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
