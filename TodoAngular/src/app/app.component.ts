import { Component } from '@angular/core';

import { CatService } from './cat.service';
import { Cat } from './cat.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [CatService]
})
export class AppComponent {
  /*
  title:string;;
  cats:Cat[];
  showEditCat:boolean = false;
  editCat:string;

  constructor(private catService: CatService) {
    this.title = "Aju soft";
    this.catService.getAllCats().subscribe(cats=> 
      {
        this.cats = cats;
      })
  }

  NuevoGato(cat) {
    alert('nuevo ' + cat.value);
    const nuevoCat:Cat = { name: cat.value };
    this.cats.push(nuevoCat);
    cat.value = '';
    return false;
  }

  EditarGato(cat) {
    alert('editar ' + cat.name);
    this.showEditCat = true;
    this.editCat = cat.name;
    return false;
  }

  ModificarGato(cat) {
    alert('guardar ' + cat.value);
    return false;
  }
  */
}
