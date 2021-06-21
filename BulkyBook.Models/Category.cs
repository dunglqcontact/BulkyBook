﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BulkyBook.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Category Name")]
        [Required]
        [MaxLength]
        public string Name { get; set; }
    }
}