using AutoMapper;
using OnlineMusicStore.API.App_Start;
using System.Web.Http;

namespace OnlineMusicStore.API
{
	public class WebApiApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			Mapper.Initialize(m => m.AddProfile<MappingProfile>());

			GlobalConfiguration.Configure(WebApiConfig.Register);

			GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings
				.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
			GlobalConfiguration.Configuration.Formatters
				.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);
		}
	}
}
