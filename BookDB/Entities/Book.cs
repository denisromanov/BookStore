using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookDB.Entities
{
    public class Book
    {
        // Id book
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        // Title book
        public string Title { get; set; }

        // Price book
        public decimal? Price { get; set; }

        // Date publish
        public DateTime PublishYear { get; set; }

        public int GenreID { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
