

namespace mvcPract.Models
{
    using System.ComponentModel.DataAnnotations;
    public enum TypeContact
    {
        telephone,
        email,
        facebook,
        twitter,
        instagram,
        dblink
    }
    public class Book
    {
        [Key]
        public int bookID { get; set; }
        [Required] //Significa que te volvera a pedir datos hasta que pongas algo
        public string name { get; set; }
        [Required] 
        public TypeContact Type { get; set; }
        [Required]
        public string contact { get; set; }
    }
}