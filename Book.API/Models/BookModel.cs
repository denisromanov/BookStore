using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookDB.Entities;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Book.API.Models
{
    public class BookModel
    {
        //[JsonIgnore]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter please title the book")]
        [JsonProperty("title")]
        public string Title { get; set; }

        [Range(1, 2000, ErrorMessage = "Enter please price the book")]
        [Required(ErrorMessage = "Укажите год издания книги")]
        [JsonProperty("price")]
        public decimal? Price { get; set; }

        [Range(1980, 2015, ErrorMessage = "Год должен быть в промежутке от 1980 до 2015")]
        [Required(ErrorMessage = "Укажите год издания книги")]
        [JsonProperty("Date")]
        public DateTime PublishYear { get; set; }

        [JsonIgnore]
        public int GenreID { get; set; }

        [JsonProperty("GenreName")]
        public string GenreName { get; set; }
    }
}