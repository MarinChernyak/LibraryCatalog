using LibraryCatalog.Models.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog.Models.Factories
{
    public class FormatsFactory : DataFactoryBase<List<string>>
    {
        protected override void ConsiderDefaultData()
        {
            if (Data == null || Data.Count == 0)
            {
                Data = new List<string>
                {
                    "TXT",
                    "PDF",
                    "FB2",
                    "MP3",
                    "MP4",
                    "M4B"
                };
            }
        }

        protected override void CreateSerializer()
        {
            _serializer = new FormatsSerializer();
        }
    }
}
