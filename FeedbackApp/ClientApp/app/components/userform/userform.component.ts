import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'userform',
    templateUrl: './userform.component.html',
    styleUrls: ['./userform.component.css']
})
export class UserFormComponent{
    public text = "hello world"

    public userFormData: UserFormData; 

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/UserForm/Get').subscribe(result => {
            console.log(result, 'res');
            this.userFormData = result.json() as UserFormData;
            console.log(this.userFormData, 'userform');
        }, error => console.log(error));
    }
}

class UserFormData {
    UserName: string;
    QuestionsList: QuestionViewModel[];
}

class QuestionViewModel {
    question: string;
    questionId: number;
    answer: string;
    answerId: number;
}