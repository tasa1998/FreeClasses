import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FREE_PROFESORS_PATH, PROFESORS_SCHEDULE_PATH } from './paths';
import { Observable } from 'rxjs';

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
}
