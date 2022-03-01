﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshersInfo
{
    public class FresherDetail
    {
        public string name { get; set; }
        public string dateOfBirth { get; set; }
        public long mobileNumber { get; set; }
        public string address { get; set; }
        public string qualification { get; set; }

        public FresherDetail(string name, string dateOfBirth, long mobileNumber, string address, string qualification)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.mobileNumber = mobileNumber;
            this.address = address;
            this.qualification = qualification;
        }

        public FresherDetail() { }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("\nName: ").Append(name)
                    .Append("\nDate of birth: ").Append(dateOfBirth)
                    .Append("\nMobile Number: ").Append(mobileNumber)
                    .Append("\nAddress: ").Append(address)
                    .Append("\nQualification: ").Append(qualification).Append("\n");

            return stringBuilder.ToString();
        }
    }
}
