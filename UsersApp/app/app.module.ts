import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { UserPanelComponent } from './userPanel.component';
import { UserDetailsComponent } from './userDetails.component';
import { PagingComponent } from './paging.component';
import { HttpModule } from '@angular/http';

@NgModule({
    imports: [BrowserModule, FormsModule, HttpModule],
    declarations: [AppComponent, UserPanelComponent, UserDetailsComponent, PagingComponent],
    bootstrap: [AppComponent]
})
export class AppModule { }