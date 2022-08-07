import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { LazyLoadEvent } from 'primeng/api';
import { User } from 'src/app/models/user';
import { UserService } from 'src/app/services/user.service';
import { DialogService, DynamicDialogRef } from 'primeng/dynamicdialog';
import { UserDialogComponent } from './user-dialog/user-dialog.component';
import { DeleteDialogComponent } from './delete-dialog/delete-dialog.component';
import { NgxPermissionsService } from 'ngx-permissions';
import { AssignDialogComponent } from './assign-dialog/assign-dialog.component';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css'],
  providers: [DialogService],
})
export class UsersComponent implements OnInit {
  users!: User[];

  totalRecords!: number;

  loading!: boolean;

  ref!: DynamicDialogRef;

  lastTableLazyLoadEvent!: LazyLoadEvent;
  permissions!: string[];

  constructor(
    private userService: UserService,
    public dialogService: DialogService,
    private cdr: ChangeDetectorRef
  ) {}

  ngOnInit(): void {
    this.permissions = ['Reader', 'Admin'];
  }

  loadUsers(event: LazyLoadEvent): void {
    this.lastTableLazyLoadEvent = event;
    this.loading = true;

    this.userService.getUsers({ lazyEvent: event }).then((res) => {
      this.users = res.users;
      this.totalRecords = res.totalRecords;
      this.loading = false;
    });
  }

  load() {
    this.loadUsers(this.lastTableLazyLoadEvent);
  }

  addUser() {
    this.ref = this.dialogService.open(UserDialogComponent, {
      data: {},
      header: 'Add User',
      width: '50%',
      height: '40%',
    });
    this.ref.onClose.subscribe((user: User) => {
      //this.userService.addUser(user).subscribe(() => this.load());
      this.userService.addUser(user).subscribe({
        next: () => this.load(),
        error: (e) => console.error(e),
        complete: () => console.info('added'),
      });
    });
  }

  editUser(user: User) {
    this.ref = this.dialogService.open(UserDialogComponent, {
      data: {
        userData: user,
        isFormEdit: true,
      },
      header: 'Edit User',
      width: '50%',
      height: '40%',
    });
    this.ref.onClose.subscribe((user: User) => {
      this.userService.updateUser(user).subscribe({
        next: () => this.load(),
        error: (e) => console.error(e),
        complete: () => console.info('edited'),
      });
    });
  }

  deleteUser(user: User) {
    this.ref = this.dialogService.open(DeleteDialogComponent, {
      data: {
        userData: user,
        isFormEdit: true,
      },
      header: 'Delete User',
      width: '30%',
      height: '25%',
    });
    this.ref.onClose.subscribe((userId: number) => {
      console.log(userId);
      this.userService.deleteUser(userId).subscribe({
        next: () => this.load(),
        error: (e) => console.error(e),
        complete: () => console.info('deleted'),
      });
    });
  }

  assignUser(user: User) {
    this.ref = this.dialogService.open(AssignDialogComponent, {
      data: {
        user: user,
        userid: user.id,
        isAdmin: user.isAdmin,
        isFormEdit: true,
      },
      header: 'Assign User',
      width: '30%',
      height: '25%',
    });
    this.ref.onClose.subscribe((user: User) => {
      console.log(user.id);
      const id = user.id;
      this.userService.assignUser(user).subscribe({
        next: () => this.load(),
        error: (e) => console.error(e),
        complete: () => console.info('deleted'),
      });
    });
  }

  ngAfterViewInit() {
    this.cdr.detectChanges();
  }
}
