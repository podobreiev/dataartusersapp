import { Component, EventEmitter, Output } from "@angular/core";

@Component({
    selector: 'user-details',
    templateUrl: 'app/userDetails.component.html',
    inputs: ['user', 'isUsersPanelVisible'],
    styles: [`.invisible{display:none;}`]
})
export class UserDetailsComponent {
    @Output() goBackClicked = new EventEmitter();

    goBackClick() {
        this.goBackClicked.emit();
    }
}