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
        public string CEOFName { get; set; }
        public string CEOSName { get; set; }
        public string CEOLName { get; set; }
        public int NumberOfEmploees { get; set; }
        public string Adress {  get; set; }

        public Firm(string name, DateTime foundingDate, string businessProfile, string _CEOFname,
            string _CEOSName, string _CEOLName, int numberOfEmploees, string adress)
        { 
            Name = name; FoundingDate = foundingDate; BusinessProfile = businessProfile; CEOFName = _CEOFname;
            CEOSName = _CEOLName; CEOSName = _CEOLName; NumberOfEmploees = numberOfEmploees; Adress = adress;
        }
        public Firm()
        {
            Name = ""; FoundingDate = new DateTime(0); BusinessProfile = ""; CEOFName = ""; 
            CEOSName = ""; CEOLName = ""; NumberOfEmploees = 0; Adress = "";
        }
        public override string ToString()
        {
            return "Name: " + Name + ", Foundation date: " + FoundingDate + ", Business profile: " + BusinessProfile + 
                ", CEO Name: " + CEOFName + " " + CEOSName + " " + CEOLName + ", Number of emploees: " + NumberOfEmploees + ", Adress: " + Adress;
        }
    }
}
