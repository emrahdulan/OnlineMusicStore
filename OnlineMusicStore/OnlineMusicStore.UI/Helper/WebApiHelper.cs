using System;
using System.Net.Http;

namespace OnlineMusicStore.UI.Helper
{
	public class WebApiHelper
	{
		private HttpClient Client { get; set; }
		private string Route { get; set; }

		public WebApiHelper(string uri, string route)
		{
			Client = new HttpClient();
			Client.BaseAddress = new Uri(uri);
			Route = route;

		}

		public HttpResponseMessage GetResponse(string param = "")
		{
			return Client.GetAsync(Route + "/" + param).Result;
		}

		public HttpResponseMessage GetActionResponse(string action, string param = "")
		{
			return Client.GetAsync(Route + "/" + action + "/" + param).Result;
		}

		public HttpResponseMessage PostResponse(Object obj)
		{
			return Client.PostAsJsonAsync(Route, obj).Result;
		}

		public HttpResponseMessage PutResponse(int id, Object obj)
		{
			return Client.PutAsJsonAsync(Route + "/" + id, obj).Result;
		}

		public HttpResponseMessage DeleteResponse(int id)
		{
			return Client.DeleteAsync(Route + "/" + id).Result;
		}
	}
}
