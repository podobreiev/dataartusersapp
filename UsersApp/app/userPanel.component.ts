import { Component, EventEmitter, Output } from '@angular/core';
import { User } from './User'

@Component({
    selector: 'user-panel',
    templateUrl: 'app/userPanel.component.html',
    inputs: ['users', 'isUsersPanelVisible']
})
export class UserPanelComponent {
    @Output() onSelected = new EventEmitter<User>();

    onSelect(user: User) {
        this.onSelected.emit(user);
    }
}