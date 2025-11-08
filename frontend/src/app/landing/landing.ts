import { Component } from '@angular/core';
import { Router } from '@angular/router';
import {FormsModule} from '@angular/forms';

@Component({
  selector: 'app-landing',
  templateUrl: './landing.html',
  imports: [
    FormsModule
  ],
  styleUrls: ['./landing.css']
})
export class LandingComponent {
  constructor(private router: Router) {}

  selectedLanguage: string = 'bhs';
  translations: any = {
    bhs: {
      h2: 'DOBRODOŠLI!',
      aboutTitle: 'O nama',
      aboutText: `Karate Tournaments Management System je aplikacija razvijena iz ljubavi prema tradicionalnom karateu, sa ciljem da olakša organizaciju takmičenja, prijavu takmičara i upravljanje svim pratećim procesima.
      Posebna pažnja posvećena je tradicionalnom karateu, čime aplikacija doprinosi očuvanju i promociji ovog sporta.
      Aplikaciju su razvile dvije studentice Fakulteta informacijskih tehnologija Univerziteta "Džemal Bijedić" u Mostaru, s namjerom da karate sport učine pristupačnijim, efikasnijim i transparentnijim.
       Sistem omogućava praćenje rezultata i obavještenja u realnom vremenu, što olakšava komunikaciju između takmičara, trenera i organizatora.
       Trenutno je aplikacija namijenjena prvenstveno tržištu Bosne i Hercegovine, tačnije Savezu Bosne i Hercegovine, dok kroz nju promoviše principe tradicionalnog karatea i sportsku zajednicu kojoj svi takmičari pripadaju.`,
      contact: 'Kontakt',
      buttons: {
        login: 'Prijavite se',
        register: 'Registrujte se',
        guest: 'Nastavi kao gledatelj'
      }
    },
    en: {
      h2: 'WELCOME!',
      aboutTitle: 'About Us',
      aboutText: `The Karate Tournaments Management System is an application developed out of a passion for traditional karate, with the aim of facilitating tournament organization, competitor registration, and the management of all related processes. Special attention is given to traditional karate, allowing the application to contribute to the preservation and promotion of this sport.
                  The application was developed by two students from the Faculty of Information Technology at the University "Džemal Bijedić" in Mostar, with the goal of making karate more accessible, efficient, and transparent. The system enables real-time tracking of results and notifications, simplifying communication between competitors, coaches, and organizers.
                  Currently, the application is primarily intended for the Bosnian-Herzegovinian market, specifically the Karate Federation of Bosnia and Herzegovina, while promoting the principles of traditional karate and the sports community to which all competitors belong.`,
      contact: 'Contact',
      buttons: {
        login: 'Login',
        register: 'Register',
        guest: 'Continue as Guest'
      }
    }
  };

  changeLanguage(lang: string) {
    console.log('Promijenjen jezik:', lang);

  }

  goToApp() {
    this.router.navigate(['/dashboard']);
  }
}
