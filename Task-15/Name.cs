using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Task_15
{
    internal class Name
    {
        public string FName {  get; set; }
        public string SName { get; set; }
        public string LName { get; set; }
        public Name(string fName, string sName, string lName) { FName = fName; SName = sName; LName = lName;  }
        public Name() { FName = ""; SName = ""; LName = ""; }
        public override string ToString()
        {
            return FName + " " + SName + " " + LName;
        }
    }
}
