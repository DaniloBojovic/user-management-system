import { Component, OnInit } from '@angular/core';
import { DynamicDialogConfig, DynamicDialogRef } from 'primeng/dynamicdialog';

@Component({
  selector: 'app-delete-dialog',
  templateUrl: './delete-dialog.component.html',
  styleUrls: ['./delete-dialog.component.css'],
})
export class DeleteDialogComponent implements OnInit {
  username!: string;
  userId!: number;

  constructor(
    public config: DynamicDialogConfig,
    public ref: DynamicDialogRef
  ) {
    this.username = this.config.data.userData.username;
    this.userId = this.config.data.userData.id;
  }

  ngOnInit(): void {}

  onYesClick() {
    this.ref.close(this.userId);
  }

  onClose() {
    this.ref.close();
  }
}
