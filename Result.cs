using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextComparator.Controllers.ForList
{
    public class Result
    {
        public int RowId { get; set; }
        public string RowTextOr { get; set; }
        public string RowTextCh { get; set; }
        public int WordId { get; set; }
        public string WordOr { get; set; }
        public string WordCh { get; set; }
    }
}
