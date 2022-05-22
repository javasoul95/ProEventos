import { Component, OnInit } from '@angular/core';
import { AbstractControlOptions, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ValidatorField } from '@app/helpers/ValidatorField';

@Component({
  selector: 'app-perfil',
  templateUrl: './perfil.component.html',
  styleUrls: ['./perfil.component.scss']
})
export class PerfilComponent implements OnInit {

  form!: FormGroup;

  constructor(private fb: FormBuilder) { }

  ngOnInit() {
    this.validation();
  }

  private validation(): void {

    const formOptions: AbstractControlOptions = {
      validators: ValidatorField.MustMatch('pass', 'confirmationPass')
    };

    this.form = this.fb.group({
      title: ['',[Validators.required]],
      firstName: ['',[Validators.required]],
      lastName: ['',[Validators.required]],
      email: ['',[Validators.required, Validators.email]],
      phone: ['',[Validators.required]],
      function: ['',[Validators.required]],
      pass: ['',[Validators.required, Validators.minLength(8)]],
      confirmationPass: ['',[Validators.required]],
    }, formOptions);
  }

  public get f():any {return this.form.controls; }

  onSubmit(): void{
    if (this.form.invalid) {
      return;
    }
  }

  public formReset(event: any): void {
    event.preventDefault();
    this.form.reset();
  }
}
