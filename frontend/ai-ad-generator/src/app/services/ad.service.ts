import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AdService {

constructor(private http:HttpClient){}

generateAd(data:any){
return this.http.post("https://localhost:7146/api/Ads/generate", data);
}

}