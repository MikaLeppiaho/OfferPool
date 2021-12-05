using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using offerpool_bl.Data;

namespace offerpool_bl.Models
{
    public class Offer
    {

        [Key]
        public int offer_id {get; set;}
        [Required]
        public string offer_header {get; set;}
        public string offer_contact {get; set;}

    }


}