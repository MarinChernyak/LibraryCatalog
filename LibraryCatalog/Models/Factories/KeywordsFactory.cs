using LibraryCatalog.Models.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog.Models.Factories
{
    public class KeywordsFactory : DataFactoryBase<List<string>>
    {
        public KeywordsFactory()
        {

        }
        public KeywordsFactory(List<string> model)
            : base(model)
        {

        }

        protected override void ConsiderDefaultData()
        {
            if (Data == null || Data.Count == 0)
            {
                Data = new List<string>();
            }
        }

        protected override void CreateSerializer()
        {
            _serializer = new KWSerializer();
        }
        public bool IsKWordExisting(string key)
        {
            bool bExist = false;
            if(Data.Any(x => x==key))
            {
                bExist = true;
            }

            return bExist;
        }
    }
}
