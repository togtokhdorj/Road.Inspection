using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Owin;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(Road.Inspection.Api.App_Start.Startup))]

namespace Road.Inspection.Api.App_Start
{
    public class Startup
    {
		public void Configuration(IAppBuilder app)
		{
			app.UseCors(CorsOptions.AllowAll);
			OAuthAuthorizationServerOptions option = new OAuthAuthorizationServerOptions
			{
				//TokenEndpointPath = new PathString("/token"),
				//Provider = new ApplicationAuthProvider(),
				//AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
				////RefreshTokenProvider = new RefreshTokenProvider(),
				//AllowInsecureHttp = true
			};
			app.UseOAuthAuthorizationServer(option);
			app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
		}
	}
}