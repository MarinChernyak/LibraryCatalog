using LibraryCatalog.Models.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog.Models.Factories
{
    public class GenresFactory : DataFactoryBase<List<string>>
    {
        protected override void ConsiderDefaultData()
        {
            if (Data == null || Data.Count == 0)
            {
                Data = new List<string>();
                Data.Add("Novel");
                Data.Add("Romance");
            }
        }

        protected override void CreateSerializer()
        {
            _serializer = new GenresSerializer();
        }
    }
}
