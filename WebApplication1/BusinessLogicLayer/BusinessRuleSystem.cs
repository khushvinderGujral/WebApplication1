using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.BusinessLogicLayer
{
    public class BusinessRuleSystem
    {
        public static bool PaymentProcessingSystem (SubPaymentWay PaymentFor)
        {
            bool resultactiontoProcess = false;
            try
            {
                switch (PaymentFor)
                {
                    case SubPaymentWay.book:
                        // call function for create a duplicate packing slip for the royalty department :-
                        resultactiontoProcess = true;
                        break;
                    case SubPaymentWay.PhyscialProdcut:
                        // call function for generate a packing slip for shipping :-
                        resultactiontoProcess = true;
                        break;
                    case SubPaymentWay.PhyscialorBook:
                        // call function for generate a commission payment to the agent :-
                        resultactiontoProcess = true;
                        break;

                    case SubPaymentWay.UpgradeToMembers:
                        // call function for apply the upgrade :-
                        resultactiontoProcess = true; break;
                    case SubPaymentWay.LearningForSki:
                        // call function for add a free “First Aid” video to the packing slip (the result of a court    decision in 1997):-
                        resultactiontoProcess = true; break;
                    case SubPaymentWay.MemberOrUpgrade:
                        // call function for e-mail the owner and inform them of the activation/upgrade :-
                        resultactiontoProcess = true; break;
                    case SubPaymentWay.MemeberShip:
                        // call function activate that membership :-
                        resultactiontoProcess = true; break;
                    default:
                        resultactiontoProcess = false; break;
                }
            }
            catch (Exception)
            {

            }
            return resultactiontoProcess;
        }
    }
}