import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { VuelosComponent } from './Componentes/vuelos/vuelos.component';
import { AsientosComponent } from './Componentes/asientos/asientos.component';

const routes: Routes = [
  {path:'',component:VuelosComponent},
  {path:'asientos/:id',component:AsientosComponent },
  

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
