using System.Collections.Generic;
using InfoNovitas.LoginSample.Services.Messaging.Views.Publishers;

namespace InfoNovitas.LoginSample.Services
{
    public interface IPublisherService
    {
        Publisher GetPublisher(int publisherId);
        List<Publisher> GetAllPublishers();
    }
}
