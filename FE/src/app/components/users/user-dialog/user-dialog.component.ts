import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { DynamicDialogConfig, DynamicDialogRef } from 'primeng/dynamicdialog';
import { User } from 'src/app/models/user';

@Component({
  selector: 'app-user-dialog',
  templateUrl: './user-dialog.component.html',
  styleUrls: ['./user-dialog.component.css'],
})
export class UserDialogComponent implements OnInit {
  userForm!: FormGroup;
  userData!: User;

  constructor(
    public ref: DynamicDialogRef,
    public config: DynamicDialogConfig
  ) {
    this.userData = this.config.data.userData;
  }

  ngOnInit(): void {
    this.userForm = new FormGroup({
      id: new FormControl(this.userData?.id),
      firstName: new FormControl(this.userData?.firstName, Validators.required),
      lastName: new FormControl(this.userData?.lastName),
      username: new FormControl(this.userData?.username),
      password: new FormControl(this.userData?.password),
      email: new FormControl(this.userData?.email),
      status: new FormControl(this.userData?.status),
      isAdmin: new FormControl(false),
    });
  }

  onSave() {
    this.ref.close(this.userForm.value);
  }

  onClose() {
    this.ref.close();
  }
}
