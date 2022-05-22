import { Component, OnInit, TemplateRef } from '@angular/core';
import { Router } from '@angular/router';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { Evento } from '@app/models/Evento';
import { EventoService } from '@app/services/Evento.service';

@Component({
  selector: 'app-evento-lista',
  templateUrl: './evento-lista.component.html',
  styleUrls: ['./evento-lista.component.scss']
})
export class EventoListaComponent implements OnInit {
  public eventos: Evento[] = [];
  public eventosFiltrados: Evento[] = [];

  public larguraImagem = 100;
  public margemImagem = 2;
  public mostrarImagem = false;
  private filtroListado = '';

  modalRef?: BsModalRef;

  constructor(
    private eventoService: EventoService,
    private modalService: BsModalService,
    private toastr: ToastrService,
    private spinner: NgxSpinnerService,
    private router: Router
  ) {}

  public ngOnInit() {
    this.getEventos();
    /** spinner starts on init */
    this.spinner.show();
  }

  public get filtroLista(): string {
    return this.filtroListado;
  }

  openModal(template: TemplateRef<any>): void {
    this.modalRef = this.modalService.show(template, {class: 'modal-sm'});
  }

  confirm(): void {
    this.toastr.success('O evento foi deletado com Sucesso', 'Deletado!');
    this.modalRef?.hide();
  }

  decline(): void {
    this.modalRef?.hide();
  }

  detalheEvento(id: number): void{
    this.router.navigate([`eventos/detalhe/${id}`]);
  }

  public set filtroLista(value: string) {
    this.filtroListado = value;
    this.eventosFiltrados = this.filtroLista ? this.filtrarEventos(this.filtroLista) : this.eventos;

  }

  public filtrarEventos(filtrarPor: string): Evento[] {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.eventos.filter(
      (evento: any) => evento.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
      evento.local.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    )
  }

  public alterarStatusImagem() {
    this.mostrarImagem = !this.mostrarImagem;
  }

  public getEventos(): void {
     this.eventoService.getEventos().subscribe({
      next: (evento: Evento[]) => {
        this.eventos = evento;
        this.eventosFiltrados = evento;
      },
      error: (error: any) => {
        this.spinner.hide(),
        this.toastr.error('Erro ao carregar os eventos','Error');
      },
      complete: () => this.spinner.hide()
     })
  }
}
