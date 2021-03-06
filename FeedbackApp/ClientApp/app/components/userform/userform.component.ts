﻿import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'userform',
    templateUrl: './userform.component.html',
    styleUrls: ['./userform.component.css']
})
export class UserFormComponent {
    public userFormData: UserFormData;
    private _http: Http;
    private _baseUrl: string;

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        this._http = http;
        this._baseUrl = baseUrl;
        this.getFormData();
    }

    getFormData() {
        this._http.get(this._baseUrl + 'api/UserForm/Get/1').subscribe(result => {
            var data = result.json() as UserFormData;
            var count = 0;
            data.questionsList.forEach((x: QuestionViewModel) => {
                if (x.answerId == 0) {
                    x.answerId = count;
                    count--;
                }
            });
            this.userFormData = data;
        }, error => console.log(error));
    }

    onSubmit() {
        this.userFormData.questionsList.forEach((x) => {
            if (x.answerId < 0) {
                x.answerId = 0;
            }
        });
        this._http.post(this._baseUrl + 'api/UserForm', this.userFormData).subscribe(result => {
            this.getFormData();
        }, error => console.log(error));
    }
}

class UserFormData {
    userName: string;
    questionsList: QuestionViewModel[];
}

class QuestionViewModel {
    question: string;
    questionId: number;
    answer: string;
    answerId: number;
}