using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollesction)
        {
            serviceCollesction.AddMemoryCache();
            serviceCollesction.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollesction.AddSingleton<ICacheManager, MemoryCacheManager>();
            serviceCollesction.AddSingleton<Stopwatch>();
        }
    }
}
