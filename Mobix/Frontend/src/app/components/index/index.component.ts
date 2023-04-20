import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { ConfigService } from 'src/app/config/config.service';
import { SampleComponent } from '../carousel/carousel.component';
import { NgSimpleCarouselModule } from 'ng-simple-carousel/lib/carousel.module';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css']
})
export class IndexComponent implements OnInit {
  filterProizvod: string = '';
  constructor(private httpClient: HttpClient, private router: Router){}

  testirajWebApi(): void {
   
  }

  ngOnInit(): void {
  }
  
}
