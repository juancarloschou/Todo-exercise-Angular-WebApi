import { Component, OnInit } from '@angular/core';

import { TodoService } from '../shared/todo.service';
import { TodoItem } from '../shared/todo.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.css']
})
export class TodoListComponent implements OnInit {

  constructor(private todoService: TodoService, private toastr: ToastrService) { }

  ngOnInit() {
    this.todoService.GetAllTodo();
  }

  showForEdit(todo: TodoItem)
  {
    //this.todoService.selectedTodo = todo;

    //copia de todo para que los cambios no afecten al objeto original
    this.todoService.selectedTodo = Object.assign({}, todo);
  }

  onDelete(id: number) {
    if(confirm('Seguro que deseas borrar este todo?') == true) {
      this.todoService.DeleteTodo(id)
        .subscribe(x => {
          this.todoService.GetAllTodo(); //actualizar listado
          this.toastr.warning('Todo borrado correctamente', 'Registro de tareas');
        })
    }
  }

}
