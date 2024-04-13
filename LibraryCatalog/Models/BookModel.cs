using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog.Models
{
    public class BookModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Series { get; set; }
        public string Genre { get; set; }
        public string Format { get; set; }
        public string Duration { get; set; }
        public string Rating { get; set; }
        public string Language { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public string Keywords { get; set; }=string.Empty;

        public string TextField =>Name==Constants.NoBooks? Name : $"\"{Name}\", ({Author})";
        public string TextFieldByAuthor => Name == Constants.NoBooks ? Name : $"\t{Author} -> \"{Name}\"";
        public string TextFieldBySeries => Name == Constants.NoBooks ? Name : $"{Series} ---> \"{Name}\",({Author})";
        public string TextFieldByGenre => Name == Constants.NoBooks ? Name : $"{Genre} ---> \"{Name}\",({Author})";

    }
}
