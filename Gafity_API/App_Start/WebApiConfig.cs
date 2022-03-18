using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Gafity_API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.None;
            json.SerializerSettings.ReferenceLoopHandling
            = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "createUser",
                routeTemplate: "api/create-user",
                defaults: new { controller = "Gafity", action = "createUser" }
            );
            config.Routes.MapHttpRoute(
                name: "updateProfilePic",
                routeTemplate: "api/update-profile-pic",
                defaults: new { controller = "Gafity", action = "updateProfilePic" }
            );
            config.Routes.MapHttpRoute(
                name: "updateVip",
                routeTemplate: "api/update-vip",
                defaults: new { controller = "Gafity", action = "updateVip" }
            );
            config.Routes.MapHttpRoute(
                name: "createPlaylist",
                routeTemplate: "api/create-playlist",
                defaults: new { controller = "Gafity", action = "createPlaylist" }
            );
            config.Routes.MapHttpRoute(
                name: "deletePlaylist",
                routeTemplate: "api/delete-playlist",
                defaults: new { controller = "Gafity", action = "deletePlaylist" }
            );
            config.Routes.MapHttpRoute(
                name: "addSongToPlaylist",
                routeTemplate: "api/add-song-to-playlist",
                defaults: new { controller = "Gafity", action = "addSongToPlaylist" }
            );
            config.Routes.MapHttpRoute(
                name: "deleteSongFromPlaylist",
                routeTemplate: "api/delete-song-from-playlist",
                defaults: new { controller = "Gafity", action = "deleteSongFromPlaylist"}
            );
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
