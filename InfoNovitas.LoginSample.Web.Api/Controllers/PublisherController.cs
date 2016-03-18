using InfoNovitas.LoginSample.Web.Api.Models.Publishers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using InfoNovitas.LoginSample.Services;

namespace InfoNovitas.LoginSample.Web.Api.Controllers
{
    [Authorize]
    public class PublisherController : ApiController
    {
        private IPublisherService _publisherService;
        private static List<PublisherViewModel> _publishers;

        public PublisherController(IPublisherService publisherService)
        {
            _publisherService = publisherService;
            _publishers = new List<PublisherViewModel>();
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            //var user = _userService.GetUserInfo(loggedUserId);
            var publishers = _publisherService.GetAllPublishers();
            foreach (var publisher in publishers)
            {
                var newPublisher = new PublisherViewModel()
                {
                    Id = publisher.Id,
                    Address = publisher.Address,
                    LogoId = publisher.LogoId,
                    Name = publisher.Name,
                    WebPage = publisher.WebPage
                };
                _publishers.Add(newPublisher);
            }

            return Ok(_publishers);
        }
    }
}
