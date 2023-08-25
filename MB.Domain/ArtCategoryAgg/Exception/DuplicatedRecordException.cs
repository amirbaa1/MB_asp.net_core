using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.ArtCategoryAgg.Exception
{
    public class DuplicatedRecordException : System.Exception
    {
        public DuplicatedRecordException() { }

        public DuplicatedRecordException(string message) : base(message) { }
    }
    
}
