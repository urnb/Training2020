export interface ICustomer{
    Add();
 
 }
 export class Customer implements ICustomer
 {
     customerName:string="";
     customerAmount:number=0;
     i:any =100;
     constructor(){
         this.customerAmount=0;
         this.customerName="";
 
     }
     Add(){}
     
 }
 class CustomerChild  extends Customer implements ICustomer{
 
 }