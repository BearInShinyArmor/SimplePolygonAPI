using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace SimplePolygonAPI
{
    internal class OpenStreetMapApiHelper:IApiHelper
    {
        static HttpClient client;
        public OpenStreetMapApiHelper()
        {
            client = new HttpClient();
        }

        public async Task<Polygon> GetPolygon(string query)
        {
            client.BaseAddress = new Uri("https://nominatim.openstreetmap.org/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", "geocode search");
            var response =  client.GetStreamAsync("search?q="+ query + "&format=json&polygon_geojson=1");
            List<OpenStreetMapGeojson> OSMgeojsons = await JsonSerializer.DeserializeAsync<List<OpenStreetMapGeojson>>(await response);
            Polygon polygon =new Polygon {coordinates= OSMgeojsons[0].geojson.coordinates[0].ToString().Trim('[', ']').Split("],[") };

            return polygon;
        }
    }
}