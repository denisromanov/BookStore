using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Net.Http.Formatting;
using Book.API.Negotiator;
namespace Book.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            /*С телефонами не работаем (на данный момент) */
            //config.Services.Replace(typeof(IContentNegotiator), new MyNegotiator());
            
            // Web API routes
            config.MapHttpAttributeRoutes();

          config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "store/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //Данные о формате клиент передает с помощью заголовка Accept. Различные браузеры отправляют разные заголовки Accept.
            //Например, в IE данный заголовок выглядит следующим образом: Accept: text/html, application/xhtml+xml, */*. Часть */* указывает, 
            //что данные могут быть приняты в любом формате. Поэтому IE получает в формате json - предпочтительном для Web API формате. 
            //Однако в других браузерах этот заголовок может выглядеть другим образом, например, Accept: text/html, application/xhtml+xml, application/xml;q=0.9, 
            //*/*;q=0.8. Здесь уже явно указывается с помощью application/xml, что браузер хочет получать данные в формате xml.
            //Web API имеет встроенную поддержку для следующих форматов: JSON, BSON, XML. Если же в запросе не передается заголовок Accept, то используется формат по умолчанию - json.



            // Отключаю возможность вывода данных пользователю в формате XML
            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}
