import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { StudentService } from 'src/student.service';


export interface ScheduleClassDto{
  Name:any;
  Surname:any;
  Email: any;
  ProfesorId:any;
  ScheduleId: any;
}

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  listProfesors: any = []
  listSchedules:any = []

  scheduleClass: ScheduleClassDto = {Name: '', Surname: '', Email:'', ProfesorId: 0, ScheduleId: 0};



  constructor(private toastrService: ToastrService, private studentService:StudentService, private router: Router) { }

  ngOnInit(): void {
    this.studentService.getAll().subscribe(response =>{
      this.listProfesors = response;
    },(err: any)=>{
      this.toastrService.error("Error "+ err.error.message)
    });
  }

  schedule(){  
      this.studentService.scheduleClass(this.scheduleClass).subscribe((returnedAction: string) =>{
        this.toastrService.success('Uspesno ste zakazali termin!');
      },
        (err:any) => {
          this.toastrService.error(err.error.message);
      });
  }

  
  selection(e:any){
    console.log(e.target.value)
    this.studentService.getSchedules(e.target.value).subscribe(response =>{
      this.listSchedules = response;
    },(err: any)=>{
      this.toastrService.error("Error "+ err.error.message)
    });
  }
}
