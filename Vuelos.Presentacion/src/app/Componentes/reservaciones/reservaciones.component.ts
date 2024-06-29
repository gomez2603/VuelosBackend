import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ReservacionService } from 'src/app/Servicios/reservacion.service';
import { PagoTarjetaComponent } from '../pago-tarjeta/pago-tarjeta.component';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-reservaciones',
  templateUrl: './reservaciones.component.html',
  styleUrls: ['./reservaciones.component.css']
})
export class ReservacionesComponent implements OnInit {
 constructor(private _snackBar: MatSnackBar,private api:ReservacionService, public dialog:MatDialog){

 }
 
 reservaciones
  ngOnInit(): void {
    this.api.getReservaciones().subscribe((data=> {
      this.reservaciones =data
    }))
  }


  displayedColums: string[] = ['vueloId','vueloDestino','asientos','total','confirmacion','acciones']
  

  pagar(id:any){
    this.openDialog(id)
  } 


  openDialog(id:number): void {
    const dialogRef = this.dialog.open(PagoTarjetaComponent, {
      data:id ,
    });

    dialogRef.afterClosed().subscribe(result => {
      this.api.getReservaciones().subscribe((data)=>{
        this.reservaciones = data
      })
    });
  
}



  eliminar(id:any){
    this.api.delete(id).subscribe( (data)=>
      {
        this._snackBar.open("Su reservacion ha sido cancelada","Cerrar")
    },(error)=>{
     
      this._snackBar.open(error.error,"Cerrar")
      
    },
  ()=>{this.api.getReservaciones().subscribe((data)=>{
    this.reservaciones = data
  }) })
  }
}
