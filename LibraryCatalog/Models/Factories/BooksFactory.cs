using LibraryCatalog.Models.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog.Models.Factories
{
    public class BooksFactory : DataFactoryBase<List<BookModel>>
    {
        public BooksFactory()
        {

        }
        public BooksFactory(List<BookModel> model)
            :base(model)
        {

        }

        protected override void ConsiderDefaultData()
        {
            if (Data == null || Data.Count == 0)
            {
                Data = new List<BookModel>();
                Data.Add(new BookModel()
                {
                    ID ="0001",
                    Name = Constants.NoBooks,
                });
            }
        }

        protected override void CreateSerializer()
        {
            _serializer = new BooksSerializer();
        }
    }
}
