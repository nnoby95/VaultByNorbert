﻿using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serilog;

namespace TW.Vault.App
{
    [AttributeUsage(AttributeTargets.Method)]
    public class ExceptionInterceptionAttribute : ExceptionFilterAttribute
    {
        private static ILogger _logger = null;
        private static ILogger Logger
        {
            get
            {
                _logger ??= Log.ForContext<ExceptionInterceptionAttribute>();
                return _logger;
            }
        }


        public override void OnException(ExceptionContext context)
        {
            Lib.Security.AuthHeaders auth = null;
            try { auth = Lib.Security.AuthenticationUtil.ParseHeaders(context.HttpContext.Request.Headers); }
            catch { }

            if (context.Exception is not TaskCanceledException)
            {
                String message = "Exception thrown at endpoint: {endpoint}";
                if (auth != null)
                    message += " from request by user with token: " + auth.AuthToken;
                else
                    message += " (auth token unavailable)";
                Logger.Error(message, context.HttpContext.Request.Path.Value);
            }

            base.OnException(context);
        }
    }
}
