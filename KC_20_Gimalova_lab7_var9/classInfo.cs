using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KC_20_Gimalova_lab7_var9
{
    public class classInfo
    {
        public int ID { get; set; }
        public string Journal { get; set; }
        public string Article { get; set; }
        public string Authors { get; set; }
        public int Year { get; set; }
        public int Volume { get; set; }
        public int Number { get; set; }
        public int FirstPage { get; set; }
        public int EndPage { get; set; }
        public byte[] Picture { get; set; }

        public classInfo() { }

        //конструктор
        public classInfo(string journal, string article, string authors,
            int year, int volume, int number, int firstPage, int endPage, byte[] picture) {
            Journal = journal;
            Article = article;
            Authors = authors;
            Year = year;
            Volume = volume;
            Number = number;
            FirstPage = firstPage;
            EndPage = endPage;
            Picture = picture;

        }

    }
}
