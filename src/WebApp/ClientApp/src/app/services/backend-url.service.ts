import { Injectable, Inject } from '@angular/core';

@Injectable({ providedIn: 'root' })
export class BackendUrlService {

  constructor(@Inject('BASE_URL') private baseUrl: string) { }

  private getBaseUrl(): string {
    return this.baseUrl;
  }

  getUrl(relativePath: string): string {
    const path = relativePath.startsWith("/") ? relativePath.substring(1) : relativePath;
    const baseUrl = this.getBaseUrl();
    const url = `${baseUrl}${path}`;
    return url;
  }

  getApiUrl(relativePath: string): string {
    const path = relativePath.startsWith("/") ? relativePath.substring(1) : relativePath;
    const url = this.getUrl(`api/${path}`);
    return url;
  }
}
