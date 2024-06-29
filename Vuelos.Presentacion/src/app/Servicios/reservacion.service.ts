import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ReservacionService {
url:string = "https://localhost:7202/api/"
UserId =localStorage.getItem("UserId")
  constructor(private http:HttpClient) { }

  setReservacion(reservacion:any){
    let direccion = this.url+'Reservaciones'
    return this.http.post(direccion,reservacion)
  }
  getReservaciones(){
    let direccion = this.url+'Reservaciones?Id='+ this.UserId
    return this.http.get(direccion)
  }
}
