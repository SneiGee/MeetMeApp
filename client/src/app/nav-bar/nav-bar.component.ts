import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Observable } from 'rxjs';
import { IUser } from '../_models/user';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.css']
})
export class NavBarComponent implements OnInit {
  model: any = {}
  currentUser$: Observable<IUser>

  constructor(private accountService: AccountService, private router: Router, 
    private toastrService: ToastrService) { 
      this.currentUser$ = accountService.currentUser$;
    }

  ngOnInit(): void {
  }

  login() {
    this.accountService.login(this.model).subscribe(response => {
      this.router.navigateByUrl('/members')
    });
  }

  logout() {
    this.accountService.logout();
    this.router.navigateByUrl('/')
  }

}
