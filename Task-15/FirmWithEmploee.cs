using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task_15
{
    internal class Emploee
    {
        public Name EmploeeName;
        public string Position;
        public string PhoneNumber;
        public string Email;
        public decimal Salary;

        public Emploee(Name emploeeName, string position, string phoneNumber, string email, decimal salary)
        {
            EmploeeName = emploeeName;
            Position = position;
            PhoneNumber = phoneNumber;
            Email = email;
            Salary = salary;
        }
        public Emploee()
        {
            EmploeeName = new Name();
            Position = "";
            PhoneNumber = "";
            Email = "";
            Salary = 0;
        }

        public override string ToString()
        {
            return "Name: " + EmploeeName + ", Position: " + Position + ", Phone number: " + PhoneNumber + ", Email: " + Email + ", Salary: " + Salary;
        }
    }


    internal class FirmWithEmploee : Firm
    {
        public List<Emploee> Emploees;

        public FirmWithEmploee(string name, DateTime foundingDate, string businessProfile, string _CEOFname,
            string _CEOSName, string _CEOLName, int numberOfEmploees, string adress, List<Emploee> emploees)
            : base(name, foundingDate, businessProfile, _CEOFname, _CEOSName, _CEOLName, numberOfEmploees, adress)
        {
            Emploees = emploees;
        }
        public FirmWithEmploee(string name, DateTime foundingDate, string businessProfile, 
            Name ceoName, int numberOfEmploees, string adress, List<Emploee> emploees)
            : base(name, foundingDate, businessProfile, ceoName, numberOfEmploees, adress)
        {
            Emploees = emploees;
        }
        public FirmWithEmploee(Firm other, List<Emploee> emploees)
            : base(other)
        {
            Emploees = emploees;
        }
        public FirmWithEmploee() : base()
        {
            Emploees = new List<Emploee>();
        }
        public override string ToString()
        {
            string s = "Firm:\n" + base.ToString() + "\n";
            s += "Emploees: " + "\n";
            for (int i = 0; i < Emploees.Count; i++)
            {
                s += $"#{i}: " + Emploees[i] + "\n";
            }
            return s;
        }
    }
}
