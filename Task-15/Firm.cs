using System;
using System.Collections.Generic;
using System.Text;

namespace Task_15
{
    internal class Firm
    {
        public string Name { get; set; }
        public DateTime FoundingDate { get; set; }
        public string BusinessProfile { get; set; }
        public Name CeoName { get; set; }
        public int NumberOfEmploees { get; set; }
        public string Adress {  get; set; }

        public Firm(string name, DateTime foundingDate, string businessProfile, string _CEOFName,
            string _CEOSName, string _CEOLName, int numberOfEmploees, string adress)
        { 
            Name = name; FoundingDate = foundingDate; BusinessProfile = businessProfile;
            CeoName = new Name(_CEOFName, _CEOSName, _CEOLName);
            NumberOfEmploees = numberOfEmploees; Adress = adress;
        }
        public Firm(string name, DateTime foundingDate, string businessProfile, 
            Name ceoName, int numberOfEmploees, string adress)
        {
            Name = name; FoundingDate = foundingDate; BusinessProfile = businessProfile;
            CeoName = ceoName; NumberOfEmploees = numberOfEmploees; Adress = adress;
        }
        public Firm(Firm other)
        {
            Name = other.Name;
            FoundingDate = other.FoundingDate;
            BusinessProfile = other.BusinessProfile;
        }
        public Firm()
        {
            Name = ""; FoundingDate = new DateTime(0); BusinessProfile = "";  
            CeoName = new Task_15.Name(); NumberOfEmploees = 0; Adress = "";
        }
        public override string ToString()
        {
            return "Name: " + Name + ", Foundation date: " + FoundingDate + ", Business profile: " + BusinessProfile + 
                ", CEO Name: " + CeoName.FName + " " + CeoName.SName + " " + CeoName.LName + 
                ", Number of emploees: " + NumberOfEmploees + ", Adress: " + Adress;
        }
    }
}
