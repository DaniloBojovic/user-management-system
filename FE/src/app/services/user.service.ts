import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { User } from '../models/user';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  private url: string = 'http://localhost:46032/api/User';

  constructor(private http: HttpClient) {}

  getUsers(params?: any): Promise<any> {
    let queryParams = new HttpParams();
    queryParams = queryParams.append('startRow', params.lazyEvent.first);
    queryParams = queryParams.append('endRow', params.lazyEvent.rows);
    queryParams = queryParams.append('sortField', params.lazyEvent.sortField);
    queryParams = queryParams.append('sortOrder', params.lazyEvent.sortOrder);
    queryParams = queryParams.append(
      'globalFilter',
      params.lazyEvent.globalFilter
    );
    return this.http
      .get<any>(`${this.url}/getusers`, {
        params: queryParams,
      })
      .toPromise()
      .then((res) => res);
  }

  addUser(user: User) {
    user.id = null;
    return this.http.post(`${this.url}/user`, user);
  }

  updateUser(user: User) {
    return this.http.patch(`${this.url}/user`, user);
  }

  deleteUser(id: number) {
    return this.http.delete(`${this.url}/user/${id}`);
  }

  assignUser(user: User) {
    return this.http.patch(`${this.url}/user/assign`, user);
  }
}
