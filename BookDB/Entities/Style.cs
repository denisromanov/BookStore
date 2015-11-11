using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookDB.Entities
{
    public class Style
    {
        // Id style
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        // Name style
        public string NameStyle { get; set; }

        // List genre
        public virtual ICollection<Genre> Genres { get; set; }
    }
}
