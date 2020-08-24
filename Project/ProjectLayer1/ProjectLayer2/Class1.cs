using System;
using System.Collections.Generic;
using System.Collections;
namespace ProjectLayer2
{
    public class Patient
    {
        public string name { get; set; }//name compulsory field
        public string address { get; set; }
        public int phoneno { get;  set; } // phone no compulsory field
        //Problem he has mention
        
    }
    public class Problems// allergy are patient specific and not visit specific
    { 
        public string allergyname { get; set; }
        public string describeallergy { get; set; }
        public string durationofallergy { get; set; }

    }
    public class Treatment
    {
        public string medname;
        public string desciption;
        public int frequency = 3;
    }
    
    public class Patientlog
    {
        public string date;
        public string time;
        public int nooftimesvisited;
    }

    public class Staff
    {
        public string name { get; set; }
        public int ID { get; set; }
        public string address { get; set; }
        public string salary { get; set; }
        public string DOJ { get; set; }
        public string Department { get; set; }

    }
    public class Doctor : Staff
    { public string education { get; set; }//MBBS and or MD
    }
    public class Nurse : Staff
    {
    }
    public class Manager : Staff
    {
    }
    public class WardBoy : Staff
    {
    }
   public class Salary
    {
        public void FixedSalary()
        {

        }
        public void VariableSalary()
        {

        }
    }
}
