using System;
using System.Collections.Generic;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.DataAnnotations;
//By default classes are private
//IEnumerable
//An IEnumerable is a list or a container which can hold some items. You can iterate through each element in the IEnumerable. You can not edit the items like adding, deleting, updating, etc. instead you just use a container to contain a list of items. It is the most basic type of list container.
//All you get in an IEnumerable is an enumerator that helps in iterating over the elements. 
//ICollection
//ICollection is another type of collection, which derives from IEnumerable and extends it’s functionality to add, remove, update element in the list. 
//ICollection also holds the count of elements in it and we does not need to iterate over all elements to get total number of elements.
//ICollection supports enumerating over the elements, filtering elements, adding new elements, deleting existing elements, updating existing elements and getting the count of available items in the list.
//IList
//IList extends ICollection. An IList can perform all operations combined from IEnumerable and ICollection, and some more operations like inserting or removing an element in the middle of a list.
//You can use a foreach loop or a for loop to iterate over the elements.
namespace ProjectLayer2
{
    public class Patient
    {
        [Required]
        public string name { get; set; }//name compulsory field
        public string address { get; set;}
        [Required]
        public int phoneno { get; set; } // phone no compulsory field
        public Nurse Nurse { get; set; }
        public WardBoy WardBoy { get; set; }
        List<Problems> problemsList;
        List<Allergy> allergyList;
        List<Nurse> nurseList;
        List<WardBoy> wardBoyList;
        Problems pr;
       
        //Problem he has mention
        //public Doctor assignDoctor { get; set; }//aggregation
        //Problems 
       //Problem and patient composition
       public void getDoctor()
        { 
        
        }
        public void getNurse()
        {

        }
        public void getWardBoy()
        {

        }
        public void getProblem()
        {

        }
        public void getAllergy()
        {

        }

    }
    public class Problems// allergy are patient specific and not visit specific
    { 
        
        //Patient p = new Patient();
        Treatment t;//Composition between Problems and Treatment that is if no problems then no need for treatment
        public string nameOfProblem;
        List<Treatment> treamentList;

    }
    public class Allergy
    {
        public string allergyname { get; set; }
        public string describeallergy { get; set; }
        public int durationofallergy { get; set; }

    }
    
    public class Treatment
    {
        public string medName;
        public string desciption;
        public int frequency;
     
    }
    
    public class Patientlog
    {
       
        Patient p;
        Allergy a;
        Treatment t;
        Doctor d;
        Problems pr;
        Nurse n;
        WardBoy wb;
        

        
    }

    public abstract class Staff //Abstract class can just have properties and function name but no body
    {
        protected string name { get; set; }
        protected int ID { get; set; }
        protected string address { get; set; }
        public string salary { get; set; }
        public string DOJ { get; set; }
        public string Department { get; set; }
        protected int sal { get; set; }
        
        //public abstract void joiningDate();// method is defined with abstract keyword and inherited overrides this method by override keyword

        //public void DisplayDept { get; set; }
       /*
        public void salaryFixed ()
        {
          
        }
      public void salaryVariable()
        {
           
        }*/

    }
    interface operationOnStaff
    {
        //By default all are public so no need to write public
        //Interfaces implements and not inherit
        //Methods are overridden by virtual keyword
        void promotion();
        void resign();
        void recruit();
    }
    public class Doctor : Staff, operationOnStaff//Doctor inherits staff and implements operationOnStaff
    {
        public string education { get; set; }//MBBS and or MD
        
       /*
        public override void joiningDate() {
           
        }*/
        Salary s;
        Treatment t;
        Patient p;
        Nurse n;
        WardBoy wb;
        public virtual void promotion() { throw new NotImplementedException(); }
        Patientlog pl;
       public void getDept()
        {

        }
        /*public override void salaryVariable()
        {

        }
        */
        public bool isAvailable()
        {   
            return true;
        }
      
        public void DoctorSalary()
        {
            
            s.VariableSalary();
            
        }

        public virtual void resign()
        {
            throw new NotImplementedException();
        }

        public virtual void recruit()
        {
            throw new NotImplementedException();
        }

        
    }
  
public class Nurse : Staff, operationOnStaff
    {
        Salary s ;
      WardBoy wb;
        /*
        public override void joiningDate()
        {
            throw new NotImplementedException();
        }*/

        public void NurseSalary()
        {
            s.FixedSalary();
        }
        public virtual void promotion() { }

        public virtual void recruit()
        {
            throw new NotImplementedException();
        }

        public virtual void resign()
        {
            throw new NotImplementedException();
        }
    }
  
    public class WardBoy : Staff, operationOnStaff
    {
        Salary s ;
        public void WardBoySalary()
        {
            s.FixedSalary();
        }
        public virtual void promotion() { }

        public virtual void resign()
        {
            throw new NotImplementedException();
        }

        public virtual void recruit()
        {
            throw new NotImplementedException();
        }
        /*
        public override void joiningDate()
        {
            throw new NotImplementedException();
        }*/
    }
    
   public class Salary
    {
        double salary=100000;
        public void FixedSalary()
        {
            Console.WriteLine(salary);
        }
        public void VariableSalary()
        {
            double addON_Salary = (salary) * 10 + salary;
        }
        /*
   public class Prescription
   {
       //for loop to display each and every details of patient
       Patient p = new Patient();
       public void prescription()
       {
          string patientName= p.name;
           string patientAddress = p.address;
           int patientPhoneNo = Convert.ToInt32(p.phoneno);
       }
   }
  */
        //    public class Manager : Staff
        //    {
        //        Salary s = new Salary();
        //        Patient p = new Patient();
        //        Nurse n = new Nurse();
        //        Doctor d = new Doctor();
        //        //d.isAvailable("Ok");
        //        WardBoy wb = new WardBoy();
        //        Patientlog pl = new Patientlog();
        //        public void ManagerSalary()
        //        {
        //            s.FixedSalary();
        //        }

        //}
    }

}
