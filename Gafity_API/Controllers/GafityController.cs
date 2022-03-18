using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyApp.Controllers
{
    public class GafityController : ApiController
    {
        GafityEntities gafityEntities = new GafityEntities();
        public IHttpActionResult createUser(user_gafity u)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                gafityEntities.user_gafity.Add(u);
                gafityEntities.SaveChanges();
            }
            catch (Exception)
            {
                return BadRequest(ModelState);
            }
            return Ok();
        }
        public IHttpActionResult updateProfilePic(String url, String userEmail)
        {
            using (var context = new GafityEntities())
            {
                var user = context.user_gafity.SingleOrDefault(x => x.email.Equals(userEmail));
                user.url_user_pic = url;
                context.SaveChanges();
                return Ok();
            }
        }
        public IHttpActionResult createPlaylist(playlist pl)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                gafityEntities.playlists.Add(pl);
                gafityEntities.SaveChanges();
            }
            catch (Exception)
            {
                return BadRequest(ModelState);
            }
            return Ok();
        }
        public IHttpActionResult deletePlaylist(playlist pl)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                gafityEntities.playlists.Remove(pl);
                gafityEntities.SaveChanges();
            }
            catch (Exception)
            {
                return BadRequest(ModelState);
            }
            return Ok();
        }
        public IHttpActionResult addSongToPlaylist(int playlistId, int songId)
        {
            using (var context = new GafityEntities())
            {
                playlist_manager playlist_Manager = new playlist_manager();
                playlist_Manager.id_playlist = playlistId;
                playlist_Manager.id_song = songId;
                context.playlist_manager.Add(playlist_Manager);
                context.SaveChanges();
                return Ok();
            }
        }
        public IHttpActionResult deleteSongFromlist(int playlistId, int songId)
        {
            using (var context = new GafityEntities())
            {
                playlist_manager playlist_Manager = new playlist_manager();
                playlist_Manager.id_playlist = playlistId;
                playlist_Manager.id_song = songId;
                context.playlist_manager.Remove(playlist_Manager);
                context.SaveChanges();
                return Ok();
            }
        }
        public IHttpActionResult updateVip(String userEmail)
        {
            using (var context = new GafityEntities())
            {
                var user = context.user_gafity.SingleOrDefault(x => x.email.Equals(userEmail));
                user.isVip = "yes";
                user.expried_date = DateTime.Now.AddMonths(1);
                context.SaveChanges();
                return Ok();
            }
        }
    }
}
