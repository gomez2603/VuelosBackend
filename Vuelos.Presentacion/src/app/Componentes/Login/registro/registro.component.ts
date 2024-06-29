import { Component, Inject } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialog, MatDialogRef } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { first } from 'rxjs';
import { UserLogin } from 'src/app/Modelos/UserLogin';
import { UserRegistro } from 'src/app/Modelos/UserRegistro';
import { LoginService } from 'src/app/Servicios/login.service';

@Component({
  selector: 'app-registro',
  templateUrl: './registro.component.html',
  styleUrls: ['./registro.component.css']
})
export class RegistroComponent {
 loginForm = new FormGroup({
  email: new FormControl(''),
  password:new FormControl('')
 })

  registro = new FormGroup({
    nombres: new FormControl(''),
    apellidos: new FormControl(''),
    email:new FormControl(''),
    contrasena: new FormControl(''),
    RolId: new FormControl(1)

  })

constructor(private _snackBar: MatSnackBar,public dialog:MatDialog, private loginService:LoginService, public dialogRef: MatDialogRef<RegistroComponent>,
  ){

}





  onSubmit(){

    let login = new UserLogin(this.loginForm.value.email,this.loginForm.value.password)

    
    this.loginService.login(login).subscribe( (data) =>{
      this.crearCookie(data)
      this._snackBar.open('Bienvenido','Cerrar')
      this.dialogRef.close();
  } )
}
onSubmitRegister(){
let registro = new UserRegistro(this.registro.value.nombres,this.registro.value.apellidos,this.registro.value.contrasena,this.registro.value.email,this.registro.value.RolId)

this.loginService.register(registro).subscribe((data)=>{
  this.dialogRef.close();
  this._snackBar.open('Registro Exitoso','Cerrar')
})
}

crearCookie(data:any){
   
   
  localStorage.setItem("token",data.token)
  localStorage.setItem("UserId",data.id)
  localStorage.setItem("name",data.nombres)
  localStorage.setItem("lastname",data.apellidos)
  localStorage.setItem("email",data.email)
  localStorage.setItem("rol",data.rolNombre)
  
}


}

