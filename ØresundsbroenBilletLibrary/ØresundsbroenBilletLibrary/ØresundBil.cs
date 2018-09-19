using System;
using BilletLibrary;

namespace OeresundsbroenBilletLibrary
{
    public class ØresundBil : Bil
    {
        public override decimal Pris() //Ved kald af metoden Pris() returneres decimal 410
        {
            if (AnvendtBrobizz)
            {
                return 161;
            }

            return 410;

            //if (AnvendtBrobizz) //Tjekker om brobizz er anvendt, hvis true så giver den rabat på 5%
            //{
            //    return 240 * Rabat;
            //}


        }

        public override string Køretøj() //Ved kald af metoden Køretøj() returneres string "Øresund Bil"
        {
            return "Øresund Bil";
        }
    }
}
