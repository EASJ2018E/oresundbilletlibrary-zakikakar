using System;
using System.Collections.Generic;
using System.Text;
using BilletLibrary;

namespace OeresundsbroenBilletLibrary
{
    public class ØresundMC : MC
    {
        public override decimal Pris() //Ved kald af metoden Pris() returneres decimal 125
        {
            if (AnvendtBrobizz)
            {
                return 73;
            }

            return 210;
        }

        public override string Køretøj()//Ved kald af metoden Køretøj() returneres string "MC"
        {
            return "Øresund MC";
        }
    }
}
