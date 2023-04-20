import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { SampleComponent } from '../carousel/carousel.component';
import { AppComponent } from 'src/app/app.component';
import { NgSimpleCarouselModule } from 'ng-simple-carousel';
import { IndexComponent } from './index.component';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  { path: '', component: IndexComponent }
];

@NgModule({
  declarations: [ 
    IndexComponent,
    SampleComponent
  ],
  imports: [
    BrowserModule, FormsModule, HttpClientModule,
    NgSimpleCarouselModule, SampleComponent, CommonModule,
    RouterModule.forChild(routes)
  ],
  exports:[
    IndexComponent,
    RouterModule
  ],
  bootstrap: [  ]
})
export class IndexModule { }
