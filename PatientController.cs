using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCwithWillis.Models;
using PatientLibrary;

namespace MVCwithWillis.Controllers
{
    public class PatientController : Controller
    {
        static PatientAddViewModel patientAddViewModel = new PatientAddViewModel();

       // static List<PatientProblem> currentPatientProblem = new List<PatientProblem>();

        public PatientController( IPatient p)
        {
            if(patientAddViewModel.allPatients is null)
            {
                patientAddViewModel.allPatients = new List<Patient>();
            }

        }
       
        public IActionResult Add() // Load the UI
        {
            return View("PatientAdd" , patientAddViewModel ); // <---- here will be the problem
        }

        [HttpPost]
        public IActionResult AddPatient(Patient obj) // When button is clicked
        {
            if(patientAddViewModel.currentPatient is null)
            {
                patientAddViewModel.currentPatient = obj;
            }
            /*
            //Patient obj = new Patient();
            // obj.name = Request.Form["txtname"];
            // obj.address = Request.Form["txtaddress"];
            obj.name = obj.name.ToUpper();
           
            foreach (var item in currentPatientProblem)
            {
                obj.problems.Add(item);
            }
            patients.Add(obj); // <-- SQL Server call
            currentPatientProblem = new List<PatientProblem>();
            return View("PatientAdd",patients);
            */
            return View("PatientAdd", patientAddViewModel);
        }
        [HttpPost]
        public IActionResult AddProblems(PatientProblem obj) // When button is clicked
        {
            patientAddViewModel.currentPatient.problems.Add(obj);
            return View("PatientAdd", patientAddViewModel);
        }
        /*
         public IActionResult AddTreatment(PatientAddViewModel obj)
         {
            if (patientAddViewModel.currentPatient is null)
            {
                
            }
            else
            {
                patientAddViewModel.current
            }
            return View("PatientAdd",patientAddViewModel);
         }
        */
        public IActionResult AddFinal()
        {
            patientAddViewModel.allPatients.Add(patientAddViewModel.currentPatient);
            patientAddViewModel.currentPatient = null;
            return View("PatientAdd", patientAddViewModel);
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}