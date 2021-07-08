using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using api_video_juegos.Models;

namespace api_video_juegos.Controllers
{
    public class apiJuegosController : ApiController
    {
        video_juegos_bd bd = new video_juegos_bd();
        public IEnumerable<juego> Get()
        {
            return bd.juegos;
        }
    }
}
