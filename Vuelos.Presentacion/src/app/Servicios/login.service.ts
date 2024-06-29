import { Injectable } from '@angular/core';
import { UserLogin } from '../Modelos/UserLogin';
import { HttpClient } from '@angular/common/http';
import { UserRegistro } from '../Modelos/UserRegistro';

@Injectable({
  providedIn: 'root'
})
export class LoginService {
 url:string = "https://localhost:7202/api/"
  constructor(private http:HttpClient) { }

  login(user:UserLogin) {
    let direccion = this.url+"Auth/Login"
    return this.http.post(direccion,user)
   }

   register(user:UserRegistro) {
       let direccion = this.url+"Auth/Register"
       return this.http.post(direccion,user)
   }

}
