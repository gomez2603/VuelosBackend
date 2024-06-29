import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'normal'
})
export class NormalPipe implements PipeTransform {

  transform(value: number, tipo: string): number {
    if(tipo  ==  "Normal"){
      value = value * 1.35
    return Math.trunc(value)
     
    } 
    else if(tipo=="Ejectutivo"){  
      value = value * 1.35
      value = value * 1.45
      return Math.trunc(value)
    }
    return value
   
  }

}
