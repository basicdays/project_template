using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using BuildHealth2013.WebUI.App_Start.BootStrap;
using StructureMap;

namespace BuildHealth2013.WebUI.Infrastructure.AutoMapper
{
    public class AutoMapperTask : IBootstrapTask
    {
        public AutoMapperTask(IEnumerable<Profile> profiles, IContainer serviceContainer)
        {
            _autoMapperProfiles = profiles;
            _container = serviceContainer;
        }

        private readonly IEnumerable<Profile> _autoMapperProfiles;
        private readonly IContainer _container;

        public void Bootstrap()
        {
            Mapper.Configuration.ConstructServicesUsing(_container.GetInstance);

            foreach (var profile in _autoMapperProfiles)
            {
                Mapper.AddProfile(profile);
            }

            Mapper.AllowNullDestinationValues = true;
        }

        public int Order
        {
            get { return 1; }
        }
    }
}