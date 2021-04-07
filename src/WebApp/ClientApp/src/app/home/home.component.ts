import { Component } from '@angular/core';
import { CaseConverterService } from "../services/case-converter.service";

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

  inputText: string;

  outputText: string;

  constructor(private caseConverterService: CaseConverterService) {

  }

  convert() {
    this.caseConverterService.convert(this.inputText).subscribe(result => {
      this.outputText = result;
    }, error => console.error(error));
  }
}
