import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppComponent } from './app.component';

import { UsersComponent } from './components/users/users.component';
import { HttpClientModule } from '@angular/common/http';

//Primeng
import { ButtonModule } from 'primeng/button';
import { TableModule } from 'primeng/table';
import { InputTextModule } from 'primeng/inputtext';
import { ToolbarModule } from 'primeng/toolbar';
import { UserDialogComponent } from './components/users/user-dialog/user-dialog.component';
import { DialogService } from 'primeng/dynamicdialog';
import { ReactiveFormsModule } from '@angular/forms';
import { DeleteDialogComponent } from './components/users/delete-dialog/delete-dialog.component';
import { AssignDialogComponent } from './components/users/assign-dialog/assign-dialog.component';
//import { NgxPermissionsModule } from 'ngx-permissions';

@NgModule({
  declarations: [
    AppComponent,
    UsersComponent,
    UserDialogComponent,
    DeleteDialogComponent,
    AssignDialogComponent,
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    ButtonModule,
    HttpClientModule,
    TableModule,
    InputTextModule,
    ToolbarModule,
    ReactiveFormsModule,
    //NgxPermissionsModule.forRoot(),
  ],
  providers: [DialogService],
  bootstrap: [AppComponent],
})
export class AppModule {}
