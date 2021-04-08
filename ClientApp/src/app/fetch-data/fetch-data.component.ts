import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { LoaderService } from '../services/loader.service';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html',
})

export class FetchDataComponent {
  people: Person[];
  names = ["User Name", "First Name", "Last Name", "Gender"]
  directions = ["asc", "desc", ""]

  onClick(e) {
    this.loaderService.showLoader();
    const element = e.currentTarget;

    let direction = element.getAttribute('data-direction');

    const data = {
      property: element.innerText.replace(/\s/g, ""),
      direction: this.directions[direction++],
    }

    if (direction >= this.directions.length) {
      direction = 0;
    }

    element.setAttribute('data-direction', direction);

    this.http.post<Person[]>(this.baseUrl + 'people/ordered', JSON.stringify(data), {headers: { 'Content-Type': 'application/json' }}).subscribe(result => {
      this.people = result;
      this.loaderService.hideLoader();
    }, error => console.error(error));
  }

  constructor(private http: HttpClient, private loaderService: LoaderService, @Inject('BASE_URL') private baseUrl: string) {
    http.get<Person[]>(baseUrl + 'people').subscribe(result => {
      this.people = result;
      this.loaderService.hideLoader();
    }, error => console.error(error));
  }
}
