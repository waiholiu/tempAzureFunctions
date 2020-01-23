using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using RestSharp;

namespace tempAzureFunctions
{
    public interface  IMyService
    {
        string MyMethod();

    }

    public class MyService : IMyService
    {
        public string MyMethod()
        {
            // using (var client = new HttpClient())
            // {
            //     client.BaseAddress = new Uri("https://www.google.com");
            //     var result = client.GetAsync("").Result;
            //     string resultContent =  result.Content.ReadAsStringAsync().Result;
            //     Console.WriteLine(resultContent);
            // }

            var client = new RestClient("https://identitysso.betfair.com.au/api/login");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("content-length", "51");
            request.AddHeader("accept-encoding", "gzip, deflate");
            request.AddHeader("cookie", "wsid=501e3d61-2489-11ea-9e9b-fa163e65b0a1; vid=501e3d62-2489-11ea-9e9b-fa163e65b0a1");
            request.AddHeader("Host", "identitysso.betfair.com.au");
            request.AddHeader("Postman-Token", "c13bb420-b75a-4e61-ac38-052e6ed5b662,e22ad715-4856-4fae-a748-5341c7623a21");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("User-Agent", "PostmanRuntime/7.15.0");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("X-Application", "jacksmith");
            request.AddHeader("Accept", "application/json");
            request.AddParameter("undefined", "username=jack.smith%40gmail.com&password=jacksmith1", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            
            return "hello";
        }

    }
}
