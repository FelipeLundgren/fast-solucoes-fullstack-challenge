import { Component } from '@angular/core';
import { RouterOutlet, RouterLink } from '@angular/router'; // 1. Importamos o RouterLink

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, RouterLink], // 2. Avisamos o Angular para usar ele aqui
  templateUrl: './app.html'
})
export class App {
  title = 'fast-frontend';
}
