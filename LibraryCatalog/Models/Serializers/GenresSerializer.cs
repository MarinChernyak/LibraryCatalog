using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace LibraryCatalog.Models.Serializers
{
    public class GenresSerializer : XMLSerializerBase<List<string>>
    {


        protected override void UpdateFile()
        {
            _filename = $"{_filename}Genres.xml";
        }
    }
}
