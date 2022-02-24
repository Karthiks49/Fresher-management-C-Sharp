using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshersInfo
{
    internal class FresherManagement
    {
        private static BindingList<FresherDetail> fresherList = new BindingList<FresherDetail>();

        private static BindingList<FresherDetail> Fresher
        {
            get { return fresherList; }
            set { fresherList = value; }
        }

        public void AddFresher(FresherDetail fresher)
        {
            Fresher.Add(fresher);
        }

        public BindingList<FresherDetail> GetFreshers()
        {
            return Fresher;
        }

        public void UpdateFresherList(string name, FresherDetail fresher)
        {
            foreach(FresherDetail candidate in fresherList)
            {
                if(name == candidate.name)
                {
                    candidate.name = fresher.name;
                    candidate.dateOfBirth = fresher.dateOfBirth;
                    candidate.mobileNumber = fresher.mobileNumber;
                    candidate.address = fresher.address;
                    candidate.qualification = fresher.qualification;
                    break;
                }
            }
        }
    }
}
