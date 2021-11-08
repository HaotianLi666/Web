import { Component, OnInit, Input } from '@angular/core';
import { PlantService } from '../../../services/plant.service';
import { Plant } from '../../../models/plant';
import { PLANTS } from '../../../mock-plants';

@Component({
  selector: 'app-add-plants',
  templateUrl: './add-plants.component.html',
  styleUrls: ['./add-plants.component.css']
})
export class AddPlantsComponent implements OnInit {
  @Input() plant: Plant;
  title: string = 'Plant Tracker'

  plants: Plant[] = [];  

  constructor(private platService: PlantService) { }

  ngOnInit(): void{
    this.platService.getPlants().subscribe((plants) => (this.
    plants = plants));
  }

  toggleAddPlant(){
    console.log('toggle');
  }

  deletePlant(plant: Plant){
    this.platService
    .deletePlant(plant)
    .subscribe(
      () => (this.plants = this.plants.filter((t) => t.id !== 
      plant.id))
    );
  }
}
