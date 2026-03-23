export interface Colaborador {
  id: number;
  nome: string;
}

export interface Workshop {
  id: number;
  nome: string;
  dataRealizacao: Date;
  descricao: string;
  // O desafio pede a lista de colaboradores que participaram:
  colaboradores: Colaborador[];
}
