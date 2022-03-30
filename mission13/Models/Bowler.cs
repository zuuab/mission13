using System;
using System.ComponentModel.DataAnnotations;

namespace mission13.Models
{
    public class Bowler
    {
        [Key]
        [Required]
        public int BowlerID { get; set; }
        [Required]
        public string BowlerLastName { get; set; }
        [Required]
        public string BowlerFirstName { get; set; }
        public string BowlerMiddleInit { get; set; }
        [Required]
        public string BowlerAddress { get; set; }
        [Required]
        public string BowlerCity { get; set; }
        [Required]
        [MaxLength(2)]
        public string BowlerState { get; set; }
        [Required]
        public string BowlerZip { get; set; }
        [Required]
        public string BowlerPhoneNumber { get; set; }
        [Required]
        public int TeamID { get; set; }
    }
}
