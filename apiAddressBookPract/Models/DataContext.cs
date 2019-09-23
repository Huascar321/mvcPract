

namespace apiAddressBookPract.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext 
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<apiAddressBookPract.Models.Book> Books { get; set; }
    }
}