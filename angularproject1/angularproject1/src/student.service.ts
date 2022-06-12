import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ADD_STUDENT_PATH, FREE_PROFESORS_PATH, PROFESORS_SCHEDULE_PATH } from './paths';
import { Observable } from 'rxjs';
import { ScheduleClassDto } from './app/home/home.component';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  constructor(private httpClient: HttpClient) { }

  getAll(): Observable<any>{
    return this.httpClient.get(FREE_PROFESORS_PATH);
  }

  getSchedules(id:any): Observable<any>{
    return this.httpClient.get(PROFESORS_SCHEDULE_PATH + '/' + id);
  }

  scheduleClass(scheduleClass:ScheduleClassDto):any{
    return this.httpClient.post(ADD_STUDENT_PATH, scheduleClass);
  }
}
