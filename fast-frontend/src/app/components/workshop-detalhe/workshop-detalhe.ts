import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, RouterLink } from '@angular/router';
import { MockDataService } from '../../services/mock-data';
import { Workshop } from '../../models/interfaces';
import { DatePipe } from '@angular/common'; // Para formatar a data bonitinha

@Component({
  selector: 'app-workshop-detalhe',
  standalone: true,
  imports: [RouterLink, DatePipe],
  templateUrl: './workshop-detalhe.html'
})
export class WorkshopDetalhe implements OnInit {
  workshopAtual: Workshop | undefined;

  // O ActivatedRoute serve para pegarmos aquele ID que vem lá na URL
  constructor(
    private route: ActivatedRoute,
    private mockService: MockDataService
  ) { }

  ngOnInit() {
    // Pega o ID da URL, transforma em número e busca no nosso serviço
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.workshopAtual = this.mockService.getWorkshopById(id);
  }
}
