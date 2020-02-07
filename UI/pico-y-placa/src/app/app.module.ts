import { BrowserModule } from '@angular/platform-browser';
import { Routes, RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { PicoPlacaComponent } from './components/pico-placa/pico-placa.component';
import { PicoPlacaService } from './services/pico-placa.service';
import { HttpClientModule } from '@angular/common/http';

const routes: Routes = [
  { path: '**', component: PicoPlacaComponent },
];

@NgModule({
  declarations: [
    AppComponent,
    PicoPlacaComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(routes)
  ],
  providers: [
    PicoPlacaService,
    HttpClientModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
