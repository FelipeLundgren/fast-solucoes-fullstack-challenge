import { Component, OnInit } from '@angular/core';
import { RouterLink } from '@angular/router';
import { DatePipe } from '@angular/common'; // <-- Importamos o formatador de datas aqui!
import { MockDataService } from '../../services/mock-data';
import { Workshop } from '../../models/interfaces';

@Component({
  selector: 'app-workshops',
  standalone: true,
  imports: [RouterLink, DatePipe], // <-- E avisamos o Angular para usar ele aqui!
  templateUrl: './workshops.html'
})
export class Workshops implements OnInit {
  listaWorkshops: Workshop[] = [];

  constructor(private mockService: MockDataService) { }

  ngOnInit() {
    this.listaWorkshops = this.mockService.getWorkshops();
  }
}
