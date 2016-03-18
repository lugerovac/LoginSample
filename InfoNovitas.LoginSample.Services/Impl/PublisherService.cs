using InfoNovitas.LoginSample.Repositories;
using InfoNovitas.LoginSample.Services.Mapping;
using InfoNovitas.LoginSample.Services.Messaging.Views.Publishers;
using System;
using System.Collections.Generic;

namespace InfoNovitas.LoginSample.Services.Impl
{
    public class PublisherService:IPublisherService
    {
        private IPublisherRepository _repository;

        public PublisherService(IPublisherRepository repository)
        {
            _repository = repository;
        }

        public List<Publisher> GetAllPublishers()
        {
            try
            {
                return _repository.FindAll().MapToViewList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Publisher GetPublisher(int publisherId)
        {
            try
            {
                return _repository.FindBy(publisherId).MapToView();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
