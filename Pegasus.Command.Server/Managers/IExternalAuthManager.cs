﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pegasus.Command.Server.Managers
{
    public interface IExternalAuthManager
    {
        Task<(AuthenticationProperties authProps, string schemaName)> Challenge(string uri, string provider);
        Task<string> ExternalSignIn(HttpContext httpContext);
    }
}