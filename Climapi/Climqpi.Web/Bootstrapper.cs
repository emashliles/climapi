using Nancy;
using Nancy.Bootstrapper;
using Nancy.Responses.Negotiation;
using Nancy.TinyIoc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Climqpi.Web
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override NancyInternalConfiguration InternalConfiguration
        {
            get { return new NancyInternalConfigurationFactory().Build(); }
        }
    }
    public class NancyInternalConfigurationFactory
    {
        public NancyInternalConfiguration Build()
        {
            return NancyInternalConfiguration.WithOverrides(c =>
            {
                // This is optional because of Nancy's serializers autodiscovery and priority
                c.Serializers.Clear();
                c.Serializers.Add(typeof(Nancy.Serialization.JsonNet.JsonNetSerializer));
                c.ResponseProcessors.Clear();
                c.ResponseProcessors.Add(typeof(JsonProcessor));
            });
        }
    }
}