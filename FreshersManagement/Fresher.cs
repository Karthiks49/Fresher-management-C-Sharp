using System;
using System.Text;


public class Fresher
{
    public string name { get; set; }
    public DateOnly dateOfBirth { get; set; }
    public long mobileNumber { get; set; }
    public string address { get; set; }

    public Fresher(string name, DateOnly dateOfBirth, long mobileNumber, string address)
    { 
        this.name = name;
        this.dateOfBirth = dateOfBirth;
        this.mobileNumber = mobileNumber;
        this.address = address;
    }

    public Fresher() { }

    public override string ToString()
    {
        return String.Format("{0}, {1}, {2}, {3}", name, dateOfBirth, mobileNumber, address);
    }
}
