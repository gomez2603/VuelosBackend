import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'duracion'
})
export class DuracionPipe implements PipeTransform {

  transform(value: string, ...args: unknown[]): string {
    let split = value.split(':')
    return split[0]+' horas '+split[1]+' minutos';
  }

}
