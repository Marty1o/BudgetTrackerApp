﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetTrackerApp.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage ="This is required.")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "This is required.")]
        public string Icon { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string Type { get; set; } = "Expense";

        [NotMapped]
        public string? TitleWithIcon {
            get
            {
                return this.Icon + " " + this.Title;
            }
        }
    }
}
