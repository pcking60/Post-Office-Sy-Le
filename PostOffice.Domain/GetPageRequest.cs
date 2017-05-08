using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice.Domain
{
    public class GetPageRequest
    {
        public string Keyword { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }
        public IEnumerable<RequestFilter> Filters { get; set; }
        public string SortedField { get; set; }
        public string IsDescSort { get; set; }

        public class RequestFilter
        {
            public string FieldName { get; set; }
            public object UpperBound { get; set; }
            public object LowerBound { get; set; }
            public object Exact { get; set; }
        }
    }
}
