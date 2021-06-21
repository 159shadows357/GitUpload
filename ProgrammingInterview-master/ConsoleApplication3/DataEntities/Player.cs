using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Player
    {
        public string PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? EntryDate { get; set; }
        public Boolean IsActive { get; set; }
        public Club Club { get; set; }
    }
}
