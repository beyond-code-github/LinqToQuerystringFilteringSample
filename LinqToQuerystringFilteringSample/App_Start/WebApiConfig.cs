namespace LinqToQuerystringFilteringSample
{
    using System.Web.Http;

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var xmlFormatter = config.Formatters.XmlFormatter;
            config.Formatters.Remove(xmlFormatter);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.EnableSystemDiagnosticsTracing();
        }
    }
}
