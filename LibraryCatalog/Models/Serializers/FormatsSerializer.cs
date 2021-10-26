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

    public class FormatsSerializer : XMLSerializerBase<List<string>>
    {
        public FormatsSerializer()
        {
        }
        public FormatsSerializer(object data)
            :base(data)
        {

        }


        protected override void UpdateFile()
        {
            _filename = $"{_filename}Formats.xml";
        }
    }
}
