﻿using System;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace Our.Umbraco.HeadRest.Web.Mapping
{
    public class HeadRestMappingContext : HeadRestPreMappingContext
    {
        public Type ViewModelType { get; internal set; }

        internal HeadRestMappingContext()
        { }
    }

    public class HeadRestPreMappingContext
    {
        public IPublishedContent Content { get; internal set; }
        public Type ContentType { get; internal set; }

        public HttpRequestBase Request { get; internal set; }
        public HttpContextBase HttpContext { get; internal set; }
        public UmbracoContext UmbracoContext { get; internal set; }

        internal HeadRestPreMappingContext()
        { }
    }
}
