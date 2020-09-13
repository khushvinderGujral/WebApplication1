using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models

{

    public class SubcriptionPaymentWay
    {
        [Required]
        public SubPaymentWay PaymentWay { get; set; }

        [Display(Name = "Subcription Type")]
        public string SelectionOption { get; set; }


        public string successMessage { get; set; }
    }
    public enum SubPaymentWay
    {
        Book = 1,
        PhyscialProdcut = 2,
        MemeberShip = 3,
        UpgradeToMembers = 4,
        MemberOrUpgrade = 5,
        LearningForSki = 6,
        PhyscialorBook = 7
    }
}