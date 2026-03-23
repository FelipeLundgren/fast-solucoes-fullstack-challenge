import { Injectable } from '@angular/core';
import { Colaborador, Workshop } from '../models/interfaces';

@Injectable({
  providedIn: 'root'
})
export class MockDataService {

  // 1. Nossa lista falsa de colaboradores
  private colaboradores: Colaborador[] = [
    { id: 1, nome: 'Felipe (Estagiário)' },
    { id: 2, nome: 'Ana Silva' },
    { id: 3, nome: 'Carlos Souza' }
  ];

  // 2. Nossa lista falsa de workshops
  private workshops: Workshop[] = [
    {
      id: 1,
      nome: 'Introdução ao Angular',
      dataRealizacao: new Date('2026-04-10T14:00:00'),
      descricao: 'Aprenda a criar interfaces web modernas e reativas.',
      // Simulando que o Felipe e a Ana participaram deste:
      colaboradores: [this.colaboradores[0], this.colaboradores[1]]
    },
    {
      id: 2,
      nome: 'C# e APIs REST',
      dataRealizacao: new Date('2026-04-15T09:00:00'),
      descricao: 'Boas práticas na construção de APIs no backend.',
      // Simulando que o Felipe e o Carlos participaram deste:
      colaboradores: [this.colaboradores[0], this.colaboradores[2]]
    }
  ];

  constructor() { }

  // 3. Métodos que as nossas telas vão chamar para pegar os dados
  getColaboradores(): Colaborador[] {
    return this.colaboradores;
  }

  getWorkshops(): Workshop[] {
    return this.workshops;
  }

  getWorkshopById(id: number): Workshop | undefined {
    return this.workshops.find(w => w.id === id);
  }
}
