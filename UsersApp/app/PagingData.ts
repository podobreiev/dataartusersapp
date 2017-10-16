export class PagingData {
    skip: number;
    take: number;

    constructor(skip: number, take: number) {
        this.skip = skip;
        this.take = take;
    }
}