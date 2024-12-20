﻿using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using Silmoon.AspNetCore.Services;

namespace Silmoon.AspNetCore.FullTemplate.Services
{
    public class SilmoonConfigureServiceImpl : SilmoonConfigureService
    {
        public string MongoDBConnectionString { get; private set; }
        public SilmoonConfigureServiceImpl(IOptions<SilmoonConfigureServiceOption> options) : base(options)
        {
            MongoDBConnectionString = ConfigJson["mongodb"].Value<string>();
        }
    }
}
