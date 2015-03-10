using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS
{
    public class Member
    {
        public string memberId { get; private set; }
        public string fName { get; private set; }
        public string mName { get; private set; }
        public string lName { get; private set; }

        public string address { get; private set; }
        public string province { get; private set; }
        public string city { get; private set; }

        public int pinNo { get; private set; }

        public string phoneNo { get; private set; }
        public string mobileNo { get; private set; }

        public bool isVehicle { get; private set; }

        public string tagId { get; private set; }

        public LinkedList<Router> path { get; private set; }

        public List<Shift> assignedShifts { get; private set; }

        public delegate void OnUpdatedDelegate();

        public event OnUpdatedDelegate OnPathUpdated;

        public event OnUpdatedDelegate OnInfoUpdated;


        public Member(string mId, string f, string m, string l,
            string addr, string prov, string cit, 
            int pNo,
            string phNo, string mNo,
            bool isV,
            string tId)
        {
            Update( mId, f, m, l,
                     addr, prov, cit,
                     pNo,
                     phNo, mNo,
                     isV,
                     tId);

            path = new LinkedList<Router>();
            assignedShifts = new List<Shift>();
        }

        public void AppendRouter(Router router)
        {
            // Remove this member from its current connected router
            if (path.First != null)
            {
                path.First.Value.hasConnectedMembers.Remove(this);
                path.First.Value.RequestUpdate();
            }

            path.AddFirst(router);
            router.hasConnectedMembers.AddLast(this);

            router.RequestUpdate();

            if (OnPathUpdated != null)
            {
                OnPathUpdated();
            }
        }

        /// <summary>
        /// Checks if a member has an active shift now
        /// </summary>
        /// <returns>Whether or not the miner's shift is taking place now</returns>
        public bool IsActive()
        {
            foreach (Shift s in assignedShifts)
            {
                if (s.startTime < DateTime.Now && s.endTime > DateTime.Now)
                {
                    return true;
                }
            }

            return false;
        }

        public void RequestInfoUpdate()
        {
            if (OnInfoUpdated != null)
            {
                OnInfoUpdated();
            }
        }

        public override string ToString()
        {
            return tagId + " " + lName + ", " + fName + (path.First == null ? "" : " - " + path.First.Value.location);
        }

        public void Update(string mId, string f, string m, string l,
            string addr, string prov, string cit,
            int pNo,
            string phNo, string mNo,
            bool isV,
            string tId)
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

            RequestInfoUpdate();

        }

    }
}
