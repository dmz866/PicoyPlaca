import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { PicoPlacaService } from 'src/app/services/pico-placa.service';
import { PicoPlacaModel } from 'src/app/models/PicoPlacaModel';
import { isNull, isNullOrUndefined } from 'util';

@Component({
  selector: 'app-pico-placa',
  templateUrl: './pico-placa.component.html',
  styleUrls: ['./pico-placa.component.css']
})
export class PicoPlacaComponent {
  model: PicoPlacaModel = new PicoPlacaModel();
  errorMessage: string;

  constructor(private pp: PicoPlacaService) { }

  revisarPlaca() {
    let fecha1: Date;

    if (!this.validForm()) {
      this.errorMessage = 'Ingrese todos los datos';
    }

    if (Number.isNaN(Date.parse(this.model.fechaStr))) {
      this.errorMessage = 'Fecha invalida';
      return;
    }

    fecha1 = new Date(Date.parse(this.model.fechaStr));
    this.model.fecha = new Date(fecha1.getFullYear(), fecha1.getMonth(), fecha1.getDate(), this.model.hora, 0, 0);
    this.pp.checkPicoPlaca(this.model);
  }

  validForm(): boolean {
    return (isNullOrUndefined(this.model.fechaStr) || isNullOrUndefined(this.model.hora));
  }
}
