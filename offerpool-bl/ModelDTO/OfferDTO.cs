using System;

namespace offerpool_bl.ModelDTO
{
    public class OfferDTO
    {
        public int offer_id {get; set;}
        public string offer_header {get; set;}
        public string offer_contact {get; set;}
        public DateTime offer_date_limit {get;set;}
    }
   
}