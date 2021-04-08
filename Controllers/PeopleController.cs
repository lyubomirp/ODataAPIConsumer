using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ODataApiConsumer.Controllers
{   
    [Route("[controller]")]
    public class PeopleController : Controller
    {
        private HttpClient client;
        private string endpoint = "TripPinRESTierService/(S(3jgtctz5a2wyzb0gi3pxikvb))/People";
        private const string url = "https://services.odata.org/";

        public IActionResult Index()
        {
            client  = new HttpClient();
            client.BaseAddress = new Uri(url);

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync(endpoint).Result;

            if (response.IsSuccessStatusCode)
            {   
                Root dataObjects = JsonConvert.DeserializeObject<Root>(response.Content.ReadAsStringAsync().Result);
                return Ok(dataObjects.People);
            }
            else
            {
                return StatusCode((int)response.StatusCode, response.Content);
            }

        }

        [HttpPost("ordered")]
        public IActionResult GetOrdered([FromBody]OrderData data)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(url);

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            if(!String.IsNullOrEmpty(data.Direction))
            {
                endpoint += $"?$orderby={data.Property}%20{data.Direction}";
            }

            HttpResponseMessage response = client.GetAsync(endpoint).Result;

            if (response.IsSuccessStatusCode)
            {
                Root dataObjects = JsonConvert.DeserializeObject<Root>(response.Content.ReadAsStringAsync().Result);
                return Ok(dataObjects.People);
            }
            else
            {
                return StatusCode((int)response.StatusCode, response.Content);
            }

        }
    }
}
