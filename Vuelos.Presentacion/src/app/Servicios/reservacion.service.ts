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
  delete(id:number){
    let direccion = this.url+"Reservaciones/" +id
    return this.http.delete(direccion)
  }

  payReservacion(id:number){
    let direccion = this.url+"Reservaciones/pagar/" +id
    return this.http.get(direccion)
  }
}
