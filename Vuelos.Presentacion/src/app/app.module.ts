import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { VuelosComponent } from './Componentes/vuelos/vuelos.component';
import { AsientosComponent } from './Componentes/asientos/asientos.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import {MatCardModule} from '@angular/material/card';
import { MatIconModule} from '@angular/material/icon';
import {MatSelectModule} from '@angular/material/select';
import { DatePipe } from '@angular/common';
import { DuracionPipe } from './pipes/duracion.pipe';
import { HorariollegadaPipe } from './pipes/horariollegada.pipe';
@NgModule({
  declarations: [
    AppComponent,
    VuelosComponent,
    AsientosComponent,
    DuracionPipe,
    HorariollegadaPipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    MatCardModule,
    MatIconModule,
    MatSelectModule
  ],
  providers: [DatePipe],
  bootstrap: [AppComponent]
})
export class AppModule { }
