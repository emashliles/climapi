using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using Climapi;
using Nancy.ModelBinding;

namespace Climqpi.Web
{
    public class TipsModule : NancyModule
    {
        public TipsModule()
        {
            Get["/tips"] = parameters =>
            {
                var request = this.Bind<TipsRequest>();
                return _Get(request);
            };
        }

        public TipsResponse _Get(TipsRequest request)
        {
            //DO NOT LEAVE IN PROD
            var tipsRepo = new TipsRepository();

            
            
            

            return new TipsResponse()
            {
                TipResponse = tipsRepo.GetRandomTip()
            };
        }
    }
}