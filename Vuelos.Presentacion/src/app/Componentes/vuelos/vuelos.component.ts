import { Component, OnInit } from '@angular/core';
import { IVuelo } from 'src/app/Modelos/Ivuelo';
import { ApiService } from 'src/app/Servicios/api.service';
import { DatePipe } from '@angular/common';
import { MatSelect } from '@angular/material/select';



@Component({
  selector: 'app-vuelos',
  templateUrl: './vuelos.component.html',
  styleUrls: ['./vuelos.component.css']
})
export class VuelosComponent implements OnInit{
Vuelos:IVuelo[] = []
option:string=""
constructor(private api:ApiService,private datePipe: DatePipe){ }
  ngOnInit(): void {
    this.api.getAllVuelos(this.option).subscribe(data=>{
      this.Vuelos = data
    })
  }

destinos:string[]= [''  ,'ACA','QRO','MTY','CUN','TCN']

change(option:string){

this.option = option
  this.api.getAllVuelos(option).subscribe(data=>{
    this.Vuelos = data
  })
}




}
