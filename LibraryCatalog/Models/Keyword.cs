using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog.Models
{
    public  class Keyword
    {
        public string KWDescription { get; set; }
        public int Id { get; set; }
        public int? RefId { get; set; }
    }
}
