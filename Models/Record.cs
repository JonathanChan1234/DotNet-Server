using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Record
    {
        public enum Category
        {
            Transportation,
            Entertainment,
            Meal
        }
        public int recordID { get; set; }
        public string recordName { get; set; }
        public string description { get; set; }
        [EnumDataType(typeof(Category))]
        public Category category { get; set; }

        [DataType(DataType.Date)]
        public DateTime addedDate { get; set; }
        public double amount { get; set; }
    }
}