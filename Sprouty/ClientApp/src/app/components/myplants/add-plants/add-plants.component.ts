import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-add-plants',
  templateUrl: './add-plants.component.html',
  styleUrls: ['./add-plants.component.css']
})
export class AddPlantsComponent implements OnInit {
  title: string = 'Add plant'
  constructor() { }

  ngOnInit() {
  }
  toggleAddPlant(){
    console.log('toggle');
  }
}
