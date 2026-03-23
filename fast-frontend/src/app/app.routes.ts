import { Routes } from '@angular/router';
import { Colaboradores } from './components/colaboradores/colaboradores';
import { Workshops } from './components/workshops/workshops';
import { WorkshopDetalhe } from './components/workshop-detalhe/workshop-detalhe';

export const routes: Routes = [
  { path: '', redirectTo: '/workshops', pathMatch: 'full' },
  { path: 'colaboradores', component: Colaboradores },
  { path: 'workshops', component: Workshops },
  { path: 'workshops/:id', component: WorkshopDetalhe }
];
