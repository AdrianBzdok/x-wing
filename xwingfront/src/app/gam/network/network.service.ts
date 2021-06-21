import { Injectable } from '@angular/core';
import {HttpClient, HttpResponse, HttpHeaders} from '@angular/common/http'
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class NetworkService {

  constructor(private http: HttpClient) { 
    this.GetAdress();
  }
  private configurl = 'assets/servip.json';
  Adres: Adres;
  Dane: any;
  private GetAdress() {
    this.getConfig().subscribe((response) =>(
    this.Adres = response.body,
    this.Adres.header = response.body.header
    ),
    error => this.Adres = error);
  }

  private getConfig(): Observable<HttpResponse<Adres>>{
    return this.http.get<Adres>(this.configurl, {observe: 'response'});
  }
  get(kom:string): Observable<HttpResponse<any>>{
    return this.http.get<any>(this.Adres.ip+this.Adres.url+kom,{observe: 'response',headers:this.Adres.header});
  }
  post(kom:string,object: any): Observable<HttpResponse<any>>{
    return this.http.post<any>(this.Adres.ip+this.Adres.url+kom,object,{observe: 'response',headers:this.Adres.header});
  }

}

export interface Adres {
  ip: string;
  url: string;
  header: any;
}