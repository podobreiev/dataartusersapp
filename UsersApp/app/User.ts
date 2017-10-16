export class User {
    Id: number;
    FirstName: string;
    LastName: string;
    ImagePath: string;
    Job: string;
    Department: string;
    Birthday: Date;
    WorkPhone: string;
    PrivatePhone: string;
    UserInfo: string;

    constructor(id: number, firstName: string, lastName: string, imagePath: string, job: string, department: string, birthday: Date,
        workPhone: string, privatePhone: string, userInfo: string) {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.ImagePath = imagePath;
        this.Job = job;
        this.Department = department;
        this.Birthday = birthday;
        this.WorkPhone = workPhone;
        this.PrivatePhone = privatePhone;
        this.UserInfo = userInfo;
    }
}