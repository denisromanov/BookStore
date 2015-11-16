using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookDB.Entities;
using Newtonsoft.Json;

namespace Book.API.Models
{
    public class BookModel
    {
        //[JsonIgnore]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("price")]
        public decimal? Price { get; set; }

        [JsonProperty("Date")]
        public DateTime PublishYear { get; set; }

        [JsonIgnore]
        public int GenreID { get; set; }
    }
}