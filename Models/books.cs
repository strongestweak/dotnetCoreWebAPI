using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    [Table("tblBooks")]
    public class books:BaseEntity
    {
        public string BookName{get;set;}
        public string Author { get; set; }
    }
}