import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IVuelo } from '../Modelos/Ivuelo';
@Injectable({
  providedIn: 'root'
})
export class ApiService {
  url:string = "https://localhost:7202/api/"
  constructor(private http:HttpClient) { }


  getAllVuelos(destino?:string):Observable<IVuelo[]>{
    let direccion = this.url+"Vuelos"
    let params = new HttpParams().set('destino',destino||'')

    return this.http.get<IVuelo[]>(direccion,{params})
  }

  getOneVuelos(id:any):Observable<IVuelo>{
  let direccion = this.url+"Vuelos/"+id
  return this.http.get<IVuelo>(direccion)
  }
}
