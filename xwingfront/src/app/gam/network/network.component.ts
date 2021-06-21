import { Component, OnInit } from '@angular/core';
import { NetworkService, Adres } from './network.service';
import { HttpHeaders } from '@angular/common/http';
import {Player} from './../../models/player'
import {Ship} from './../../models/ship'
import {Trait} from './../../models/trait'
@Component({
  selector: 'app-network',
  templateUrl: './network.component.html',
  styleUrls: ['./network.component.css']
})
export class NetworkComponent implements OnInit {
  gracz: Player = {
    Name: "",
    Password: ""
  };
  nstatek: Ship = new Ship();
  test: number;
  attack:number;
  attack2:number;
  constructor(private NetworkService: NetworkService) { }
 // Adres: Adres;
  Dane: any;
  Header: any;
  AddPlayer: any;
  statek: string;

  ngOnInit(): void {
    //this.GetData();
  }
 /* GetAdress() {
    this.NetworkService.getConfig().subscribe((response) =>(
    this.Adres = response.body,
    this.Header = response.body.header,
    this.Adres.header = this.Header,
    console.log(response),
    this.GetData()
    ),
    error => this.Adres = error);
  } */
  GetData(statek){
    this.NetworkService.get('ships/'+statek).subscribe((response) => (
      this.Dane = response.body,
      console.log(response)
      ),
      error => this.Dane = error);
  }
  PostData(player){
    this.NetworkService.post('players/',player).subscribe((response) => (
      this.Dane = response.body,
      console.log(response)
      ),
      error => this.Dane = error);
  }
  PostStatek(){
    if(this.test==1){
      this.nstatek.Traits.push(new Trait("test"))
    }
    if(this.attack==1){
      this.nstatek.Traits.push(new Trait("attack",this.attack2))
    }
    this.NetworkService.post('ships/',this.nstatek).subscribe((response) => (
      this.Dane = response.body,
      console.log(response)
      ),
      error => this.Dane = error);
  }
}
