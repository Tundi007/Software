﻿using Media.Application.Common;
using Media.Infrastructure.MediaRepository.Mongo;
using Media.Infrastructure.MediaRepository.Mongo.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace Media.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            //services.AddScoped<IJWTChecker, JWTChecker>();
            services.AddScoped<IMongoService, MongoService>();
            services.AddScoped<IMediaRepository, MediaRepository.MediaRepository>();
            return services;
        }
    }
}