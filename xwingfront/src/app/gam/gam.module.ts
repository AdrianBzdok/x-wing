import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NetworkComponent } from './network/network.component';
import {NetworkService} from './network/network.service';

@NgModule({
  declarations: [NetworkComponent],
  imports: [
    CommonModule
  ]
})
export class GamModule { }
