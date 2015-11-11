using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookDB.Entities
{
    public class Genre
    {
        // Id book
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        // Name genre
        public string NameGenre { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        public int StyleID { get; set; }
        public virtual Style Style { get; set; }
    }
}
