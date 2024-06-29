import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'horariollegada'
})
export class HorariollegadaPipe implements PipeTransform {

  transform(value: any, aumento:string): Date {
    let fecha = new Date(value)
    let split = aumento.split(':')
    let horas:number = parseInt(split[0])
    let minutos:number = parseInt(split[1])
    fecha.setHours(fecha.getHours() + horas )
    fecha.setMinutes(fecha.getMinutes() + minutos)
    return fecha;
  }

}
