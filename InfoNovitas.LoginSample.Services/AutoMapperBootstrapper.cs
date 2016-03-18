﻿using AutoMapper;
using InfoNovitas.LoginSample.Services.Messaging.Views.Publishers;
using InfoNovitas.LoginSample.Services.Messaging.Views.Users;
using Model = InfoNovitas.LoginSample.Repositories.DatabaseModel;

namespace InfoNovitas.LoginSample.Services
{
    public class AutoMapperBootstrapper
    {
        public static void CreateMap()
        {
           Mapper.CreateMap<UserInfo, Model.UserInfo>();
           Mapper.CreateMap<Model.UserInfo, UserInfo>();

            Mapper.CreateMap<Publisher, Model.Publisher>();
            Mapper.CreateMap<Model.Publisher, Publisher>();

            Mapper.AssertConfigurationIsValid();
        }
    }
}
