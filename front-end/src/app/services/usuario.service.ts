import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { tap } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { LoginForm } from '../interfaces/login.interface';
import { Observable,of } from 'rxjs';

const base_url = environment.base_url;
@Injectable({
  providedIn: 'root'
})
export class UsuarioService {

  constructor(private http:HttpClient,private router:Router) { }

  login(formData:LoginForm)
  {
    return this.http.post(`${base_url}/Account/Login`,formData)
                .pipe(
                  tap((resp:any)=>{
                    console.log(resp);
                    localStorage.setItem('token',resp.token)
                  })
                )
  }

  
  validarToken():Observable<boolean> {
    const token = localStorage.getItem('token') || '';

    if (!token) {
      this.router.navigateByUrl('/pages/login');
      return;
  }


}
