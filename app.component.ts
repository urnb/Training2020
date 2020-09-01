import { Component } from '@angular/core';
import {Patient,PatientProblem} from "./app.model";
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'HospitalClient';
  patientobj:Patient = new Patient();
}
