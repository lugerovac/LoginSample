using InfoNovitas.LoginSample.Web.Api.Models.Publishers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InfoNovitas.LoginSample.Web.Api.Controllers
{
    [Authorize]
    public class PublisherController : ApiController
    {
        private static List<PublisherViewModel> _publishers;
        public PublisherController()
        {
            _publishers = new List<PublisherViewModel>();

            _publishers.Add(new PublisherViewModel()
            {
                Id = 1,
                Name = "Školska knjiga",
                Description = "Školska knjiga",
                Url = "http://www.sk.hr"
            });

            _publishers.Add(new PublisherViewModel()
            {
                Id = 2,
                Name = "Mozaik",
                Description = "Mozaik",
                Url = "http://www.mozaik.hr"
            });
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_publishers);
        }
    }
}
