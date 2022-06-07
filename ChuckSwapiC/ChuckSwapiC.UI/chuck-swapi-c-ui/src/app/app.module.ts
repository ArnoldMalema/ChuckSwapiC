import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatFormFieldModule } from '@angular/material/form-field'; 
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatTabsModule} from '@angular/material/tabs';
import { Settings } from './services/_settings';
import { ChuckSwApiService } from './services/chuck-sw-api.service';
import { HttpClientModule } from '@angular/common/http';
import {MatSelectModule } from '@angular/material/select';


@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    MatFormFieldModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatSelectModule,
    MatTabsModule
  ],
  providers: [
    Settings,
    ChuckSwApiService
  ],
  bootstrap: [AppComponent]
})
export class AppModule {}

