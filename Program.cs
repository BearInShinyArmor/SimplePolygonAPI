using System;

namespace SimplePolygonAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            IApiHelper helper = new OpenStreetMapApiHelper();
            Polygon polygon = helper.GetPolygon(Console.ReadLine()).GetAwaiter().GetResult();
            FileWriter fileWriter = new FileWriter(args[0]==null?"report.txt": args[0]);
            fileWriter.WriteToFile(polygon, args[1] == null?0: int.Parse(args[1]));
        }
    }
}
