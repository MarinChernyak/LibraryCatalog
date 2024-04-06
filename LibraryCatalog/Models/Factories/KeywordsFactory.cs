using LibraryCatalog.Models.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog.Models.Factories
{
    public class KeywordsFactory : DataFactoryBase<List<Keyword>>
    {
        public KeywordsFactory()
        {

        }
        public KeywordsFactory(List<Keyword> model)
            : base(model)
        {

        }

        protected override void ConsiderDefaultData()
        {
            if (Data == null || Data.Count == 0)
            {
                Data = new List<Keyword>
                {
                    new Keyword()
                    {
                        Id = 0,
                        KWDescription = "Root"

                    }
                };
            }
        }

        protected override void CreateSerializer()
        {
            _serializer = new KWSerializer();
        }
    }
}
