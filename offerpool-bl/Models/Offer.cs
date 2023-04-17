using System;
using System.ComponentModel.DataAnnotations;

namespace offerpool_bl.Models
{
    public class Offer
    {

        [Key]
        public int offer_id {get; set;}
        [Required]
        public string offer_header {get; set;}
        public string offer_contact {get; set;}
        public DateTime offer_date_limit {get;set;}

    }


}