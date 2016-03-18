﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InfoNovitas.LoginSample.Web.Api.Models.Publishers
{
    public class PublisherViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string WebPage { get; set; }
        public string LogoId { get; set; }
    }
}