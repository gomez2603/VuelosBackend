import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialog, MatDialogRef } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { ReservacionService } from 'src/app/Servicios/reservacion.service';

@Component({
  selector: 'app-pago-tarjeta',
  templateUrl: './pago-tarjeta.component.html',
  styleUrls: ['./pago-tarjeta.component.css']
})
export class PagoTarjetaComponent  {
TarjetaForm = new FormGroup({
  numeroTarjeta : new FormControl(''),
  caducidad: new FormControl(''),
  cvv: new FormControl(''),
  nombre: new FormControl (''),
  cp: new FormControl('')

})


  constructor(private _snackBar: MatSnackBar,private api:ReservacionService,  public dialogRef: MatDialogRef<PagoTarjetaComponent>, @Inject(MAT_DIALOG_DATA) public data: number){
    
  }
 
  onSubmit()
{
  this.api.payReservacion(this.data).subscribe((data)=>{
    this._snackBar.open("Su pago se Realizo correctamente","Cerrar")
    this.dialogRef.close()
  },(error) =>{
    this._snackBar.open("Reservacion Expirada","cerrar")
  }
  )

}

}
