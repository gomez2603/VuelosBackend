import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import {ReactiveFormsModule} from '@angular/forms';
import {MatTableModule} from '@angular/material/table';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { VuelosComponent } from './Componentes/vuelos/vuelos.component';
import { AsientosComponent } from './Componentes/asientos/asientos.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatSnackBarModule} from '@angular/material/snack-bar';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import {MatCardModule} from '@angular/material/card';
import { MatIconModule} from '@angular/material/icon';
import {MatSelectModule} from '@angular/material/select';
import {MatDialogModule} from '@angular/material/dialog';
import {MatTabsModule} from '@angular/material/tabs';
import {MatInputModule} from '@angular/material/input';
import {MatButtonModule} from '@angular/material/button';
import { DatePipe } from '@angular/common';
import { DuracionPipe } from './pipes/duracion.pipe';
import { HorariollegadaPipe } from './pipes/horariollegada.pipe';
import { NormalPipe } from './pipes/normal.pipe';
import { RegistroComponent } from './Componentes/Login/registro/registro.component';
import { FormsModule } from '@angular/forms';
import { ReservacionesComponent } from './Componentes/reservaciones/reservaciones.component';
import { AuthInterceptor } from './Interceptors/auth.interceptor';
import { PagoTarjetaComponent } from './Componentes/pago-tarjeta/pago-tarjeta.component';
@NgModule({
  declarations: [
    AppComponent,
    VuelosComponent,
    AsientosComponent,
    DuracionPipe,
    HorariollegadaPipe,
    NormalPipe,
    RegistroComponent,
    ReservacionesComponent,
    PagoTarjetaComponent
  ],
  imports: [
    FormsModule,
    BrowserModule,
    ReactiveFormsModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    MatCardModule,
    MatIconModule,
    MatSelectModule,
    MatDialogModule,
    MatInputModule,
    MatButtonModule,
    MatTabsModule,
    MatSnackBarModule,
    MatTableModule,
    RouterModule
  ],
  providers: [{
    provide: HTTP_INTERCEPTORS,
    useClass:AuthInterceptor,
    multi: true
  },DatePipe],
  bootstrap: [AppComponent]
})
export class AppModule { }
