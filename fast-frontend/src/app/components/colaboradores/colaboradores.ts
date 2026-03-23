import { Component, OnInit } from '@angular/core';
import { MockDataService } from '../../services/mock-data';
import { Colaborador } from '../../models/interfaces';

@Component({
  selector: 'app-colaboradores',
  standalone: true,
  templateUrl: './colaboradores.html'
})
export class Colaboradores implements OnInit {
  listaColaboradores: Colaborador[] = [];

  constructor(private mockService: MockDataService) { }

  ngOnInit() {
    // Pega os dados falsos do nosso serviço assim que a tela abre
    this.listaColaboradores = this.mockService.getColaboradores();
  }
}
