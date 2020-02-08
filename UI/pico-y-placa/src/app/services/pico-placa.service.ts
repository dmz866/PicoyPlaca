import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Constants } from '../utils/Constants';
import { PicoPlacaModel } from '../models/PicoPlacaModel';

@Injectable({
  providedIn: 'root'
})
export class PicoPlacaService {
  constructor(private http: HttpClient) {}

  checkPicoPlaca(model: PicoPlacaModel) {
    const params = new HttpParams()
    .set('placa', model.placa)
    .set('fecha', model.fecha.toString());

    return this.http.get(`${ Constants.BASE_API_URL}checkPicoPlaca/`, {params: params});
  }
}
