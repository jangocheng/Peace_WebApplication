﻿using Peace.Services.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;
using Peace.Model;
using Peace.Data;

namespace Peace.Services.Account
{
    public class FormsAuthenticationService:IAuthenticationService
    {
        private readonly IUserService _userService;
        private readonly TimeSpan _expirationTimeSpan;

        private User _cachedUser;

        public FormsAuthenticationService(IUserService userService)
        {
            _userService = userService;
            _expirationTimeSpan = FormsAuthentication.Timeout;
        }


        public void SignIn(User user, bool createPersistentCookie)
        {
            var now = DateTime.UtcNow.ToLocalTime();
            var ticket = new FormsAuthenticationTicket(1, user.Username, now, now.Add(_expirationTimeSpan),
                createPersistentCookie, user.Username, FormsAuthentication.FormsCookiePath);
            var encryptedTicket = FormsAuthentication.Encrypt(ticket);
            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket) { HttpOnly = true };
            if (ticket.IsPersistent)
            {
                cookie.Expires = ticket.Expiration;
            }
            cookie.Secure = FormsAuthentication.RequireSSL;
            cookie.Path = FormsAuthentication.FormsCookiePath;
            if (FormsAuthentication.CookieDomain != null)
            {
                cookie.Domain = FormsAuthentication.CookieDomain;
            }
            HttpContext.Response.Cookies.Add(cookie);
            //nop源码中没有这一句，务必保证webconfig中的认证是form的。
            FormsAuthentication.SetAuthCookie(user.Username, createPersistentCookie);
            _cachedUser = user;
        }

        public void SignOut()
        {
            _cachedUser = null;
            FormsAuthentication.SignOut();
        }

        public User GetAuthenticatedCustomer()
        {
            if (_cachedUser != null) return _cachedUser;
            if (HttpContext == null || HttpContext.Request == null || !HttpContext.Request.IsAuthenticated ||
                !(HttpContext.User.Identity is FormsIdentity))
            {
                return null;
            }
            var formsIdentity = (FormsIdentity)HttpContext.User.Identity;
            var user = GetAuthenticatedUserFromTicket(formsIdentity.Ticket);
            if (user != null && user.Active && !user.Deleted)//&& user.IsRegistered()
                _cachedUser = user;
            return _cachedUser;
        }

        public bool IsCurrentUser
        {
            get { return GetAuthenticatedCustomer() != null; }
        }

        public virtual User GetAuthenticatedUserFromTicket(FormsAuthenticationTicket ticket)
        {
            if (ticket == null)
                throw new ArgumentNullException("ticket");

            var usernameOrEmail = ticket.Name;

            if (String.IsNullOrWhiteSpace(usernameOrEmail))
                return null;

            var user = _userService.GetUserByUsername(usernameOrEmail);

            return user;
        }

        public HttpContextBase HttpContext
        {
            get { return new HttpContextWrapper(System.Web.HttpContext.Current); }
        }
    }
}
