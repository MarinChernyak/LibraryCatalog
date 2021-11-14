using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog.Models.Factories
{
    public class ShowKindFactory
    {
        public List<BookModel> Data { get; protected set; }
        public ShowKindFactory(int selection)
        {
            UpdateData(selection);
        }
        protected void UpdateData(int selection)
        {
            BooksFactory fact = new BooksFactory();
            switch(selection)
            {
                case 0:
                    Data = fact.Data;
                    break;
                case 1:
                    Data = fact.Data.Where(x => x.Format.Contains("TXT") || x.Format.Contains("FB2") || x.Format.Contains("PDF")).ToList();
                    break;
                case 2:
                    Data = fact.Data.Where(x => x.Format.Contains("MP3") || x.Format.Contains("MP4") || x.Format.Contains("M4B")).ToList();
                    break;
            }; 
        }
    }
}
