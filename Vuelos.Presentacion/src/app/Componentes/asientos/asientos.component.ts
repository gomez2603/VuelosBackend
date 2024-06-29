import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { IVuelo } from 'src/app/Modelos/Ivuelo';
import { ApiService } from 'src/app/Servicios/api.service';

@Component({
  selector: 'app-asientos',
  templateUrl: './asientos.component.html',
  styleUrls: ['./asientos.component.css']
})
export class AsientosComponent implements OnInit {
  id:any
  vuelo:IVuelo
  asientos = Array(30)
  asientosSeleccionados:number[]=[]
constructor(private aroute:ActivatedRoute,private api:ApiService){

  this.id =  this.aroute.snapshot.paramMap.get('id') ;
}
  ngOnInit(): void {
    this.api.getOneVuelos(this.id).subscribe(data=>{
      this.vuelo =data
    }) 
    this.asientos.fill(1).map((x, i) => i)
  }
add(asiento:number){
  debugger
this.asientosSeleccionados.push(asiento)

console.log(this.asientosSeleccionados)
}


}
