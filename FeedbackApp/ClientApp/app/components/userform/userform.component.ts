import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'userform',
    templateUrl: './userform.component.html',
    styleUrls: ['./userform.component.css']
})
export class UserFormComponent{
    public userFormData: UserFormData;
    private _http: Http;
    private _baseUrl: string;

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        this._http = http;
        this._baseUrl = baseUrl;
        http.get(baseUrl + 'api/UserForm/Get/1').subscribe(result => {
            console.log(result, 'res');
            this.userFormData = result.json() as UserFormData;
            console.log(this.userFormData, 'userform');
        }, error => console.log(error));
    }

    onSubmit(){
        console.log("clicked");
        this._http.post(this._baseUrl + 'api/UserForm', this.userFormData).subscribe(result => {
            console.log(result, 'res');
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