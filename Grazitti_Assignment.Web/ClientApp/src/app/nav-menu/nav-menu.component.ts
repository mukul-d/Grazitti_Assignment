import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { AuthorizeService } from 'src/api-authorization/authorize.service';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit {

  /**
   *
   */
  constructor(private authService: AuthorizeService) { }

  isExpanded = false;
  isAuthorized: Observable<boolean>;
  ngOnInit(): void {
    this.isAuthorized = this.authService.isAuthenticated();
  }
  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
