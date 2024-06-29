import { Component, OnInit } from '@angular/core';
import { IVuelo } from 'src/app/Modelos/Ivuelo';
import { ApiService } from 'src/app/Servicios/api.service';
import { DatePipe } from '@angular/common';
import { MatSelect } from '@angular/material/select';
import { Router } from '@angular/router';
import { MatDialog } from '@angular/material/dialog';
import { RegistroComponent } from '../Login/registro/registro.component';



@Component({
  selector: 'app-vuelos',
  templateUrl: './vuelos.component.html',
  styleUrls: ['./vuelos.component.css']
})
export class VuelosComponent implements OnInit{
Vuelos:IVuelo[] = []
option:string=""
userId

constructor(private api:ApiService,private datePipe: DatePipe,private router:Router,public dialog: MatDialog){ }
  ngOnInit(): void {
    this.api.getAllVuelos(this.option).subscribe(data=>{
      this.Vuelos = data
    })
     this.userId = localStorage.getItem("UserId")
    console.log(this.userId)
  }

destinos:string[]= [''  ,'ACA','QRO','MTY','CUN','TCN']

change(option:string){

this.option = option
  this.api.getAllVuelos(option).subscribe(data=>{
    this.Vuelos = data
  })
}
openDialog(): void {
  const dialogRef = this.dialog.open(RegistroComponent, {
    
  });

  dialogRef.afterClosed().subscribe(result => {
  
  });
}

guardarPrecio(categoria:string){
  localStorage.setItem("categoria",categoria)
}



}
