import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule } from '@angular/common/http'

import { AppComponent } from './app.component';
import { ValueComponent } from './value/value.component';
import { CommonModule } from '@angular/common';

@NgModule({
  declarations: [	
    AppComponent,
      ValueComponent
   ],
  imports: [
    CommonModule,
    BrowserModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
