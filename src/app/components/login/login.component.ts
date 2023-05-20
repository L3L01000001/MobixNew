import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  model= {
  email: '',
  password: ''
  }
  rememberMe: any;
  constructor(private http: HttpClient, private router: Router) { }

  ngOnInit(): void {
  }

  btnLogin(){
    this.http.post<any>("https://localhost:7278/api/Login", this.model)
    .subscribe(res=>{
      console.log('Login successful:', res);
        // Handle successful login here (e.g., redirect, show success message)
      },
      (error) => {
        console.error('Login failed:', error);
        // Handle failed login here (e.g., display error message)
      });
    }
  }


