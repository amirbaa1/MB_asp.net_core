using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Applications.Contracts.ArtCategory
{
    public class ArtCategoryViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreateDate { get; set; }
        public ArtCategoryViewModel(string title) 
        {
            Title = title;
            IsDelete = false;
            CreateDate = DateTime.Now;
        }
    }
}
