import { Component, OnInit } from '@angular/core';
import { ReservacionService } from 'src/app/Servicios/reservacion.service';

@Component({
  selector: 'app-reservaciones',
  templateUrl: './reservaciones.component.html',
  styleUrls: ['./reservaciones.component.css']
})
export class ReservacionesComponent implements OnInit {
 constructor(private api:ReservacionService){

 }
 
 reservaciones
  ngOnInit(): void {
    this.api.getReservaciones().subscribe((data=> {
      this.reservaciones =data
    }))
  }


  displayedColums: string[] = ['vueloId','vueloDestino','asientos','total','acciones']
  
}
