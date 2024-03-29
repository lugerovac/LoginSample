﻿using Autofac;
using InfoNovitas.LoginSample.Repositories;
using InfoNovitas.LoginSample.Repositories.Users;
using InfoNovitas.LoginSample.Services;
using InfoNovitas.LoginSample.Services.Impl;

namespace InfoNovitas.LoginSample.Web.Api
{
    public class LoginSampleModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserRepository>().As<IUserRepository>();

            builder.RegisterType<UserService>().As<IUserService>();
        }
    }
}