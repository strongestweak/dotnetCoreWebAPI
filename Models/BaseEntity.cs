using System;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class BaseEntity
    {
        private DateTime currentDate;
        public BaseEntity() => currentDate = DateTime.Now;
        [Key]
        public int Id{get;set;}
        public DateTime CreatedAt{get=> currentDate; set=>currentDate=value;}

        public Nullable<DateTime> UpdatedAt{get;set;}
    }
}