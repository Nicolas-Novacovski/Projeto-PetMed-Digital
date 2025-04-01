﻿using System.ComponentModel.DataAnnotations;

namespace PetMed_Digital.Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; } 
        
        public string DonoCachorro { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
