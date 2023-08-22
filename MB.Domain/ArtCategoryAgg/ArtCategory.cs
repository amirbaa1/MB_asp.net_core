using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.ArtCategoryAgg
{
    public class ArtCategory
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreateDate { get; private set; }
        
        public ArtCategory(string title) 
        {
            Title = title;
            IsDeleted = false;
            CreateDate = DateTime.Now;
        }
    }
}
