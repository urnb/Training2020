export class Patient{
    name:string="";
    address:string="";
    email:string="";
    Problems:Array<PatientProblem>=new Array<PatientProblem>();

}
export class PatientProblem{
    id:number=0;
    problem:boolean;
}