import { Component, OnInit } from '@angular/core';
import { CarouselImage, CarouselController } from 'ng-simple-carousel';

@Component({
  selector: 'app-carousel',
  templateUrl: './carousel.component.html',
  styleUrls: ['./carousel.component.css']
})

export class SampleComponent {
  controllerButton = new CarouselController();

  images: CarouselImage[] = [
    { id: 'iphone11', src:'../assets/iphone11.jpg', srcset: '../assets/iphone11.jpg'},
    { id: 'huawei', src: '../assets/huawei.jpg', srcset: '../assets/huawei.jpg' },
    { id: 'samsung', src: '../assets/samsung.jpg', srcset: '../assets/samsung.jpg' }
  ];

  onImgChange(id: string) {
    console.log(id);
  }
}