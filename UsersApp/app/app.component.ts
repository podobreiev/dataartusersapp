import { Component } from '@angular/core';
import { User } from './User'
import { PagingData } from './PagingData';
import { HttpService } from './http.service';
import { UsersRangeResponse } from './UsersRangeResponse';

@Component({
    selector: 'my-app',
    templateUrl: 'app/app.component.html',
    providers: [HttpService]
})
export class AppComponent {
    users: Array<User> = [];
    selectedUser = new User(0, "", "", "", "", "", null, "", "", "");
    isUsersPanelVisible: boolean = true;
    usersTotal: number = 0;

    onDataArrive(data: any) {
        let response: UsersRangeResponse = data.json();
        this.users = response.UsersList;
        this.usersTotal = response.UsersTotal;
    }

    requestUsers(pagingData: PagingData) {
        this.httpService.getUsers(pagingData.skip, pagingData.take).
            subscribe((result) =>
            {
                this.onDataArrive(result);
            });
    }

    onSelected(user: User) {
        this.isUsersPanelVisible = false;
        this.selectedUser = user;
    }

    goBackClicked() {
        this.isUsersPanelVisible = true;
    }    

    constructor(private httpService: HttpService) {
        
    }
}