import { Component, OnInit} from '@angular/core';


@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {
  
Users = [
  [
    {
      "id": 1,
      "img_url": "https://cb.scene7.com/is/image/Crate/JadePlantSSS21/$web_pdp_main_carousel_med$/210212144233/artificial-potted-jade-plant.jpg",
      "name": "Faux Potted Jade Plant",
      "view": "View",
      "boolean" : ""
    },
    {
      "id": 2,
      "img_url": "https://cb.scene7.com/is/image/Crate/PottedMonstera24inSHS20/$web_pdp_main_carousel_high$/191217102319/faux-potted-monstera.jpg",
      "name": "Faux Potted Monstera",
      "view": "View",
      "boolean" : ""
    },
    {
      "id": 3,
      "img_url": "https://cb.scene7.com/is/image/Crate/PottedZZPlantSHS20/$web_pdp_main_carousel_high$/191217102319/potted-zz-plant.jpg",
      "name": "Faux Potted ZZ Plant",
      "view": "View",
      "view_url":"https://www.google.com/",
      "boolean" : "false"
    }
    
  ],
  [
    {
      "id": 1,
      "img_url": "https://cb.scene7.com/is/image/Crate/JadePlantSSS21/$web_pdp_main_carousel_med$/210212144233/artificial-potted-jade-plant.jpg",
      "name": "Faux Potted Jade Plant",
      "view": "View",
      "boolean" : ""
    },
    {
      "id": 2,
      "img_url": "https://cb.scene7.com/is/image/Crate/PottedMonstera24inSHS20/$web_pdp_main_carousel_high$/191217102319/faux-potted-monstera.jpg",
      "name": "Faux Potted Monstera",
      "view": "View",
      "boolean" : ""
    },
    {
      "id": 3,
      "img_url": "https://cb.scene7.com/is/image/Crate/PottedZZPlantSHS20/$web_pdp_main_carousel_high$/191217102319/potted-zz-plant.jpg",
      "name": "Faux Potted ZZ Plant",
      "view": "View",
      "view_url":"https://www.google.com/",
      "boolean" : "false"
    }
 ]
]


  isNextLine:boolean = false;
  decimal: number = 0;

  constructor() 
  { 

  }

  ngOnInit() 
  {
    
  }
  
}
