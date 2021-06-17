import { Component, OnInit } from '@angular/core';

import { TodoService } from './shared/todo.service';

@Component({
  selector: 'app-todos',
  templateUrl: './todos.component.html',
  styleUrls: ['./todos.component.css'],
  providers: [TodoService]
})
export class TodosComponent implements OnInit {

  constructor(private todoService: TodoService) { }

  ngOnInit() {
  }

}
