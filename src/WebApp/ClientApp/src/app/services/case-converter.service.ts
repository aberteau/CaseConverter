import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { BackendUrlService } from './backend-url.service';

@Injectable({ providedIn: 'root' })
export class CaseConverterService {

  constructor(private http: HttpClient, private urlService: BackendUrlService) { }

  convert(str: string): Observable<string> {
    let params = new HttpParams();
    params = params.append('str', str);

    const url = this.urlService.getApiUrl("/CaseConverter");
    return this.http.get(url, { params: params, responseType: 'text' });
  }
}
