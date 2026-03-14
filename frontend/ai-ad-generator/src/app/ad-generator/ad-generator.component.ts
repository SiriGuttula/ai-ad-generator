import { Component } from '@angular/core';
import { AdService } from '../services/ad.service';

@Component({
selector: 'app-ad-generator',
templateUrl: './ad-generator.component.html',
styleUrls: ['./ad-generator.component.css']
})
export class AdGeneratorComponent {

productName="";
description="";
audience="";
platform="";
result="";

constructor(private adService:AdService){}

generateAd(){

  let data = {
  productName:this.productName,
  description:this.description,
  audience:this.audience,
  platform:this.platform
  }
  
  this.adService.generateAd(data)
  .subscribe((res:any)=>{
  
  this.result = JSON.stringify(res,null,2);
  
  })
  
  }

}