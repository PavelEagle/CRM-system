using System;
using AutoMapper;

namespace WbaApp.Repositories.Infrastructure
{
    public class MappingConfiguration
    {
        private static readonly Lazy<MapperConfiguration> SingleMapperConfiguration =
            new Lazy<MapperConfiguration>(new MapperConfiguration(
                cfg => cfg.AddProfile(new MappingProfile())));

        public static MapperConfiguration GetMapperConfiguration() => SingleMapperConfiguration.Value; 
        
    }
}