import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { ActivatedRoute, Router } from '@angular/router';
import { IVuelo } from 'src/app/Modelos/Ivuelo';
import { ApiService } from 'src/app/Servicios/api.service';
import { ReservacionService } from 'src/app/Servicios/reservacion.service';

@Component({
  selector: 'app-asientos',
  templateUrl: './asientos.component.html',
  styleUrls: ['./asientos.component.css']
})
export class AsientosComponent implements OnInit {
  id:any
  vuelo:IVuelo
  asientos = Array(30)
  asientosocupados:number[]= []
  asientosSeleccionados:number[]=[]
reservacion:FormGroup
userId = localStorage.getItem("UserId")
rol = localStorage.getItem("rol")

 
constructor(private _snackBar: MatSnackBar,private aroute:ActivatedRoute,private api:ApiService,private apireservacion:ReservacionService,private router:Router){

  this.id =  this.aroute.snapshot.paramMap.get('id') ;
}
  ngOnInit(): void {

    this.api.getOneVuelos(this.id).subscribe(data=>{
      this.vuelo =data
      if(this.vuelo.asientosOcupados > 0){
      this.generarAsientos(this.vuelo.asientosOcupados)
      }
    }) 
      
    this.asientos.fill(1).map((x, i) => i)
    
    this.reservacion = new FormGroup({
      vueloId: new FormControl(this.id),
      usuarioId: new FormControl(this.userId),
      asientos : new FormControl(''),
      total :new FormControl(''),
      estatus :new FormControl(0)
      
    }
     
    )
  }

add(asiento:number){

this.asientosSeleccionados.push(asiento)
let filtro = this.asientosSeleccionados.filter((item,index)=>{
  return this.asientosSeleccionados.indexOf(item) === index;
})
this.asientosSeleccionados = filtro


}

delete(asiento:number){
  const index = this.asientosSeleccionados.indexOf(asiento);
  if (index > -1) { // only splice array when item is found
    this.asientosSeleccionados.splice(index, 1); // 2nd parameter means remove one item only
  }
}

onSubmit(){
  let asientostomados = this.asientosSeleccionados.toString()
  let totalapagar  = this.asientosSeleccionados.length * this.vuelo.precio
  let categoria = localStorage.getItem("categoria")
  if(categoria == 'normal'){
    totalapagar =    Math.trunc(totalapagar*1.35)
  }
  if(categoria == 'ejecutivo'){
    totalapagar =    totalapagar*1.35
    totalapagar =  Math.trunc(totalapagar*1.45)
  }
  this.reservacion.patchValue(
    {asientos:asientostomados,total:totalapagar,estatus:0},
   
  )
  this.apireservacion.setReservacion(this.reservacion.value).subscribe((data)=>{
    this._snackBar.open("Se creo la reservacion Correctamente","Cerrar")
    this.router.navigate(['reservaciones'])
})
}
ocupado(id:number){
  console.log()
return this.asientosocupados.includes(id)
}

generarAsientos(ocupados:number){
  this.asientosocupados = Array.from({length: ocupados}, () => Math.floor(Math.random() * ocupados+1));
       
       console.log(this.asientosocupados)
}

 getRandomInt(max) {
  return Math.floor(Math.random() * max);
}
}


