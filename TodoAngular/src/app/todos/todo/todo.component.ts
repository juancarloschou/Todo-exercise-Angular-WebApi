import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms'

import { TodoService } from '../shared/todo.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-todo',
  templateUrl: './todo.component.html',
  styleUrls: ['./todo.component.css']
})
export class TodoComponent implements OnInit {

  constructor(private todoService: TodoService, private toastr: ToastrService) { }

  ngOnInit() {
    //al inicio (on ready)
    this.resetForm();
  }

  resetForm(form?: NgForm)
  {
    if(form != null) {
      form.reset();
    }
    this.todoService.selectedTodo = {Id:null, Name:'', IsComplete:false};
  }

  onSubmit(form: NgForm) {
    console.log(form.value);
    //fix porque a veces (tras submit) no recoge bien el valor del check si no lo hemos tocado
    if(form.value.IsComplete == null)
      form.value.IsComplete = false;
    //console.log(form.value.Name);
    //console.log(form.value.IsComplete);

    if(form.value.Id == null)
    {
      //insert
      console.log('insert');

      this.todoService.CreateTodo(form.value) //devuelve observer de json, nos suscribimos
        .subscribe(data => {
          console.log('vuelve del insert');
          this.resetForm(form);
          this.todoService.GetAllTodo(); //actualiza listado
          this.toastr.success('Todo añadido correctamente', 'Registro de tareas');
        });
    }
    else {
      //update
      console.log('update');

      this.todoService.UpdateTodo(form.value.Id, form.value) //devuelve observer de json, nos suscribimos
        .subscribe(data => {
          this.resetForm(form);
          this.todoService.GetAllTodo(); //actualiza listado
          this.toastr.info('Todo actualizado correctamente', 'Registro de tareas');
        });
    }
  }
}
