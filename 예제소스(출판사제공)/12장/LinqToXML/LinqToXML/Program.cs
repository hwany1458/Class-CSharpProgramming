using System.Xml.Linq;

namespace LinqToXML
{
    internal class Program
    {
        class Weather
        {
            public string Hour { get; set; }
            public string Day { get; set; }
            public string Wf { get; set; }
            public string Temp { get; set; }
            public string WdKor { get; set; }
            public string WfKor { get; set; }
            public string Tmn { get; set; }
            public string Tmx { get; set; }
        }

        static void Main(string[] args)
        {
            // 코드 12-12: 웹에서 XML 가져오기
            string url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=1150061500";
            XElement xElement = XElement.Load(url);
            // Console.WriteLine(xElement);


            // 코드 12-13: data 태그 추출
            /*var xmlQuery = from item in xElement.Descendants("data")
                           select item;

            foreach (var item in xmlQuery)
            {
                Console.Write(item);
            }*/


            // 코드 12-14: data 태그 내부에서 값 추출
            /* var xmlQuery = from item in xElement.Descendants("data") select item;
            foreach (var item in xmlQuery)
            {
                Console.Write(item.Element("hour").Value + "\t");
                Console.Write(item.Element("day").Value + "\t");
                Console.Write(item.Element("temp").Value + "\t");
                Console.Write(item.Element("wdKor").Value + "\t");
                Console.Write(item.Element("wfKor").Value + "\t");
                Console.Write(item.Element("tmn").Value + "\t");
                Console.Write(item.Element("tmx").Value + "\t");
            } */


            // 코드 12-15: 익명 객체 사용
            /* var xmlQuery = from item in xElement.Descendants("data")
                           select new
                           {
                               Hour = item.Element("hour").Value,
                               Day = item.Element("day").Value,
                               Temp = item.Element("temp").Value,
                               WdKor = item.Element("wdKor").Value,
                               WfKor = item.Element("wfKor").Value,
                               Tmn = item.Element("tmn").Value,
                               Tmx = item.Element("tmx").Value
                           }; */

            // 코드 12-16 클래스 활용
            var xmlQuery = from item in xElement.Descendants("data")
                           select new Weather
                           {
                               Hour = item.Element("hour").Value,
                               Day = item.Element("day").Value,
                               Temp = item.Element("temp").Value,
                               WdKor = item.Element("wdKor").Value,
                               WfKor = item.Element("wfKor").Value,
                               Tmn = item.Element("tmn").Value,
                               Tmx = item.Element("tmx").Value
                           };

            foreach (var item in xmlQuery)
            {
                Console.Write(item.Hour + "\t");
                Console.Write(item.Day + "\t");
                Console.Write(item.Temp + "\t");
                Console.Write(item.WdKor + "\t");
                Console.Write(item.WfKor + "\t");
                Console.Write(item.Tmn + "\t");
                Console.Write(item.Tmx + "\t");
                Console.WriteLine();
            }
        }
    }
}
