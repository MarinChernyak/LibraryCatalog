using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog.Models.Serializers
{
    internal class KWSerializer : XMLSerializerBase<List<Keyword>>
    {
        protected override void UpdateFile()
        {
            _filename = $"{_filename}Keywords.xml";
        }
    }

}
