import { TestBed } from '@angular/core/testing';

import { PicoPlacaService } from './pico-placa.service';

describe('PicoPlacaService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: PicoPlacaService = TestBed.get(PicoPlacaService);
    expect(service).toBeTruthy();
  });
});
