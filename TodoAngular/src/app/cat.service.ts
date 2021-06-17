import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { HttpClient } from '@angular/common/http';

export interface Cat {
  name: string;
}

@Injectable()
export class CatService {
  url:string;

  constructor(private http: HttpClient) {
    this.url = 'http://localhost:63649/api/';
  }

  getAllCats(): Observable<Cat[]> {
    return this.http.get<Cat[]>(this.url + 'cat');
  }

  getCat(name: string): Observable<Cat> {
    return this.http.get<Cat>(this.url + 'cat/' + name);
  }

  insertCat(cat: Cat): Observable<Cat> {
    return this.http.post<Cat>(this.url + 'cat/', cat);
  }

  updateCat(cat: Cat): Observable<void> {
    return this.http.put<void>(this.url + 'cat/' + cat.name, cat);
  }

  deleteCat(name: string) {
    return this.http.delete(this.url + 'cat/' + name);
  }
}
