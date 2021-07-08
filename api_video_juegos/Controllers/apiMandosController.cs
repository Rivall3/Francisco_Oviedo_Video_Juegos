using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using api_video_juegos.Models;

namespace api_video_juegos.Controllers

    
    
{
    public class apiMandosController : ApiController
    {
        //generar el objeto del contexto de la bd
        video_juegos_bd bd = new video_juegos_bd();

        public IEnumerable<mando> Get()
        {
            return bd.mandos;
        }
    }
}
