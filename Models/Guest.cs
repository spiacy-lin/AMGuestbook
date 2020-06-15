using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMGuestbook.Models
{
    public class Guest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CurrentDate { get; set; }
        public string CurrentText { get; set; }
        public string Name { get; set; }
    }
}
