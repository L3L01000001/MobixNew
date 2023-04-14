import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  isEnglish:boolean=true;
  isBosnian:any;

  title = 'Mobix';
  bosnianFooter: any;

}
