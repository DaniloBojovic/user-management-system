import { Component, OnInit } from '@angular/core';
import { DynamicDialogConfig, DynamicDialogRef } from 'primeng/dynamicdialog';
import { User } from 'src/app/models/user';

@Component({
  selector: 'app-assign-dialog',
  templateUrl: './assign-dialog.component.html',
  styleUrls: ['./assign-dialog.component.css'],
})
export class AssignDialogComponent implements OnInit {
  isAdmin!: boolean;
  userId!: number;
  user!: User;

  constructor(
    public config: DynamicDialogConfig,
    public ref: DynamicDialogRef
  ) {
    this.user = this.config.data.user;
    this.userId = this.config.data.userId;
    this.isAdmin = this.config.data.isAdmin;
  }

  ngOnInit(): void {}

  onChange(event: any) {
    this.user.isAdmin = event.target.checked;
  }

  onYesClick() {
    this.ref.close(this.user);
  }

  onClose() {
    this.ref.close();
  }
}
