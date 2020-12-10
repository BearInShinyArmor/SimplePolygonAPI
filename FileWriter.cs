using System.IO;
using System.Text;

namespace SimplePolygonAPI
{
    internal class FileWriter
    {

        internal readonly string _fileName;

        public FileWriter(string reportFile)
        {

            _fileName = Path.GetFileName(reportFile);
        }



        public void WriteToFile(Polygon data, int numberToSkip)
        {
            var fileWriter = new StreamWriter(_fileName, false);
            int i = 0;
            foreach (var item in data.coordinates)
            {
                if (i % numberToSkip == 0)
                {
                    fileWriter.WriteLine(item.ToString());
                    fileWriter.Flush();
                }
                i++;

            }
            fileWriter.Close();
        }

    }
}