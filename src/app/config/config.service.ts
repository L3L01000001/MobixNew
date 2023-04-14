import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';

@Injectable({
    providedIn: 'root'
})
export class ConfigService {
  apiUrl = 'http://localhost:7278';
  constructor(private http: HttpClient) { }

  httpOptions = {
    headers: new HttpHeaders({
        'Content-Type' : 'application/json',
    }),
  };

  getData(){
    return this.http.get(this.apiUrl + '/api/get-all-products')
  }
}