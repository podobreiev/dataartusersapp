import { Component, Input, Output, EventEmitter, OnInit } from '@angular/core';
import { PagingData } from './PagingData';

@Component({
    selector: 'paging',
    templateUrl: 'app/paging.component.html',
    inputs: ['isUsersPanelVisible'],
})
export class PagingComponent implements OnInit {
    pageSize: number = 10;
    currentPage: number = 1;
    @Input() usersTotal: number;
    @Output() requestUsers = new EventEmitter<PagingData>();    

    getUsers(skip: number, take: number) {
        let pagingData = new PagingData(skip, take);
        this.requestUsers.emit(pagingData);
    }

    goLeft() {
        if (this.currentPage > 1) {
            this.currentPage--;
            this.getUsers((this.currentPage - 1) * this.pageSize, this.pageSize);
        }
    }

    goRight() {
        if (this.usersTotal - this.currentPage * this.pageSize > 0) {
            this.getUsers(this.currentPage * this.pageSize, this.pageSize)
            this.currentPage++;
        }        
    }

    ngOnInit() {
        this.getUsers(0, this.pageSize);
    }
}