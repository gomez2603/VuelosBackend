import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpErrorResponse
} from '@angular/common/http';
import { Observable, catchError, throwError } from 'rxjs';
import { Router } from '@angular/router';

@Injectable()
export class AuthInterceptor implements HttpInterceptor {

  constructor(private router:Router) {}

  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    const token = localStorage.getItem("token")
    let req = request;
    if (token != null) {
      req = request.clone({
        setHeaders: {
          'Authorization':`Bearer ${token}`
        }
      });
    }
    return next.handle(req).pipe(
      catchError((err: HttpErrorResponse) => {
          console.log(err)
        if (err.status === 401) {
          console.log("Usuario No Authorizado")
          this.router.navigateByUrl('/login');
        }
        if (err.status === 0) {
          console.log("Usuario No Authorizado")
          this.router.navigateByUrl('/login');
        }

        return throwError(err);

      })
    );
   

        

   

    }
  }

