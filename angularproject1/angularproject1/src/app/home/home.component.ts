import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { StudentService } from 'src/student.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  name: any
  surname: any
  email: any
  listProfesors: any = []
  listSchedules:any = []
  profesorId: any
  scheduleId: any


  constructor(private toastrService: ToastrService, private studentService:StudentService, private router: Router) { }

  ngOnInit(): void {
    this.studentService.getAll().subscribe(response =>{
      this.listProfesors = response;
    },(err: any)=>{
      this.toastrService.error("Error "+ err.error.message)
    });
  }

  registration(){  
      
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
