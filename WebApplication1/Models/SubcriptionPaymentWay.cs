using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace WebApplication1.Models

{

    public class SubcriptionPaymentWay
    {
        [Required]
        public SubPaymentWay PaymentWay { get; set; }

        [Display(Name ="Please select Payment mode")]
        public string SelectionOption { get; set; }


        public string successMessage { get; set; }
            }
    public enum SubPaymentWay
    {
        book = 1,
        PhyscialProdcut =2,
        MemeberShip = 3,
        UpgradeToMembers =4,
        MemberOrUpgrade =5,
        LearningForSki=6,
        PhyscialorBook=7
    }
}