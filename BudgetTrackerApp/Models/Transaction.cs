using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetTrackerApp.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        //Catergory ID will go here as a foreign key
        [Range(1, int.MaxValue, ErrorMessage = "Please select a value from the drop down.")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Amount needs to be greater than 0.")]
        public int  Amount { get; set; }

        [Column(TypeName = "nvarchar(75)")]
        public string? Note { get; set; } = "";

        public DateTime Date { get; set; } = DateTime.Now;

        [NotMapped]
        public string? CategoryTitleWithIcon { 
            get 
            {
                return Category == null ? "" : Category.Icon + " " + Category.Title;
            } 
        }

        [NotMapped]
        public string? FormattedAmount
        {
            get
            {
                return ((Category == null || Category.Type=="Expense" )? "- " : "+ ") + Amount.ToString("C0");
            }
        }
    }
}
