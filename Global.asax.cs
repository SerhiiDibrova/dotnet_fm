// Global.asax.cs
using System.Web;
using System.Web.Http;

namespace dotnet_fm
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
