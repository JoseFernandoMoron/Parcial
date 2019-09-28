using System;


namespace apiEval.Models
{
    using System.ComponentModel.DataAnnotations;
    public enum TypeTricks
    {
        Jabalina,
        Jenga,
        Jirafa,
    }
    public class Clown
    {
        [Key]
        public int ClownID { get; set; }
        public String Nickname { get; set; }
        [Required]
        public TypeTricks Tricks { get; set; }
        [EmailAddress(ErrorMessage = "")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50)]
        public String Email { get; set; }
        [DataType(DataType.Date)]
        public String Birthdate { get; set; }

    }
}