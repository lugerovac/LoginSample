using System.Collections.Generic;
using InfoNovitas.LoginSample.Services.Messaging.Views.Publishers;
using AutoMapper;

namespace InfoNovitas.LoginSample.Services.Mapping
{
    public static class PublisherMapper
    {
        public static Publisher MapToView(this Repositories.DatabaseModel.Publisher model)
        {
            return Mapper.Map<Publisher>(model);
        }

        public static List<Publisher> MapToViewList(this List<Repositories.DatabaseModel.Publisher> model)
        {
            return Mapper.Map<List<Publisher>>(model);
        }
    }
}
