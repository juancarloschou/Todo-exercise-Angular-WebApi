import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { Http, Response, Headers, RequestOptions, RequestMethod } from '@angular/http';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';

import { TodoItem } from './todo.model';

@Injectable()
export class TodoService {

  selectedTodo: TodoItem;
  todoList: TodoItem[];

  constructor(private http: Http) { 
    //this.selectedTodo = {Id:null, Name:'', IsComplete:null};
  }

  CreateTodo(todo: TodoItem) {
    //insertar nuevo
    console.log(todo);

    var url = 'http://localhost:63649/api/todo';
    var entity = JSON.stringify(todo);

    console.log(entity);

    var headerOptions = new Headers({'content-Type':'application/json'});
    var requestOptions = new RequestOptions({method: RequestMethod.Post, headers: headerOptions});
    return this.http.post(url, entity, requestOptions)
      .map(x => x.json()); //map convierte de observer response a observer json
  }

  UpdateTodo(id: number, todo: TodoItem) {
    //actualizar existente
    var url = 'http://localhost:63649/api/todo/' + id;
    var entity = JSON.stringify(todo);
    var headerOptions = new Headers({'content-Type':'application/json'});
    var requestOptions = new RequestOptions({method: RequestMethod.Put, headers: headerOptions});
    return this.http.put(url, entity, requestOptions)
      .map(x => x.json()); //map convierte de observer response a observer json
  }

  DeleteTodo(id: number) {
    //borrar existente
    var url = 'http://localhost:63649/api/todo/' + id;
    return this.http.delete(url)
      .map(x => x.json()); //map convierte de observer response a observer json
  }

  GetAllTodo() {
    var url = 'http://localhost:63649/api/todo';
    this.http.get(url)
      .map((data: Response) => {
        return data.json() as TodoItem[];
      }) //map convierte de observer response a array de TodoItem
      .toPromise().then(x => {
        this.todoList = x;
        // console.log(this.todoList);
        // console.log(this.todoList.length);
        // console.log(this.todoList[0].name);
      }); //guardar el array de TodoItem en var todoList
  }
}
