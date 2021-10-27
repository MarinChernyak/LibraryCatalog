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
                    ID = Guid.NewGuid(),
                    Author = "Струггацкие A.Б. ",
                    Name = "Улитка на склоне",
                    Format = "FB2",
                    Language = "Русский",
                    Genre = "Фантастика",
                    Rating = "10.0",
                    Image = "Ulitka.jpg",
                    Description = "Книга о Кандиде, попавшем в лес"
                });
                Data.Add(new BookModel()
                {
                    ID = Guid.NewGuid(),
                    Author = "Лем Станислав",
                    Name = "Солярис",
                    Format = "FB2",
                    Language = "Русский",
                    Genre = "Фантастика",
                    Rating = "9.9",
                    Image = "Solaris.jpg",
                    Description = "Книга о Крисе Кельвине, попавшем на Солярис"
                });
            }
        }

        protected override void CreateSerializer()
        {
            _serializer = new BooksSerializer();
        }
    }
}
