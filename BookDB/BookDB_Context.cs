using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookDB.Abstract;
using BookDB.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace BookDB
{
    public class BookDB_Context: DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Style> Styles { get; set; }

        public BookDB_Context() : base("BookDB_Context")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        //protected override void OnMappingCreation()
        //{
        
        //} 
    }
}
