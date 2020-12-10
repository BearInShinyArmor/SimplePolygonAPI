using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimplePolygonAPI
{
    internal interface IApiHelper
    {
        Task<Polygon> GetPolygon(string query);
    }
}