using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.EntityLayer.Concrete
{
    public class News
    {
        public int NewsID { get; set; }
        public string NameSurname { get; set;}
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string ProfileImage { get; set; }
    }
}
