using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasic
{
    class Program : bas
    {
        static void Main(string[] args)
        {
            // Init

            ScreenTitle("MORSE v1");
            Screen(ConsoleColor.DarkBlue, ConsoleColor.White);
            Cls();

            string MORSE = ".... ___ ._.. ._ __ .. ... ._ __ .. __. ___ ... .__. ._. ___ __. ._. ._ __ ._ _.. ___ ._. . ... __..__ . ... .._ _. ._ _... .._ . _. ._ _. ___ _ .. _._. .. ._ _ . _. . ._. .._ _. __. ._. .._ .__. ___ __ .._ ._.. _ .. ._.. .. _. __. .._ ._ ._.. ._._._ . ... .__. . ._. ___ __._ .._ . .__. .._ . _.. ._ _. _._. ___ __ .__. ._ ._. _ .. ._. ... .._ ... .. _.. .. ___ __ ._ ... _. ._ _ ._ ._.. . ... .__. ._ ._. ._ ._ .__. ._. . _. _.. . ._. ._ .._ _. __ ._ ....";

            string[] ABC = new string[43]; string[] CODES = new string[43];
            int counter = 0;
            ABC[counter] = ","; CODES[counter] = "— — · · — —"; counter++;
            ABC[counter] = "."; CODES[counter] = "· — · — · —"; counter++;
            ABC[counter] = "\""; CODES[counter] = " · — · · — · 		"; counter++;
            ABC[counter] = "/"; CODES[counter] = "— · · — · "; counter++;
            ABC[counter] = "?"; CODES[counter] = " 	· · — — · ·"; counter++;
            ABC[counter] = "0"; CODES[counter] = "— — — — —    "; counter++;
            ABC[counter] = "Ñ"; CODES[counter] = "— — · — —    "; counter++;
            ABC[counter] = "1"; CODES[counter] = "· — — — —    "; counter++;
            ABC[counter] = "3"; CODES[counter] = "· · · — —    "; counter++;
            ABC[counter] = "2"; CODES[counter] = "· · — — —    "; counter++;
            ABC[counter] = "4"; CODES[counter] = "· · · · —     "; counter++;
            ABC[counter] = "5"; CODES[counter] = "· · · · ·     "; counter++;
            ABC[counter] = "6"; CODES[counter] = " — · · · ·    "; counter++;
            ABC[counter] = "7"; CODES[counter] = " — — · · ·   "; counter++;
            ABC[counter] = "C"; CODES[counter] = "— · — ·      "; counter++;
            ABC[counter] = "L"; CODES[counter] = " · — · · 	   "; counter++;
            ABC[counter] = "B"; CODES[counter] = "— · · ·      "; counter++;
            ABC[counter] = "H"; CODES[counter] = " · · · · 	   "; counter++;
            ABC[counter] = "8"; CODES[counter] = " — — — · ·   "; counter++;
            ABC[counter] = "V"; CODES[counter] = " · · · — 		"; counter++;
            ABC[counter] = "9"; CODES[counter] = " — — — — ·    "; counter++;
            ABC[counter] = "J"; CODES[counter] = " · — — — 		"; counter++;
            ABC[counter] = "X"; CODES[counter] = " — · · — 		"; counter++;
            ABC[counter] = "Y"; CODES[counter] = " — · — — 		"; counter++;
            ABC[counter] = "Z"; CODES[counter] = " — — · · 		"; counter++;
            ABC[counter] = "F"; CODES[counter] = " · · — · 		"; counter++;
            ABC[counter] = "Q"; CODES[counter] = "— — · — 		"; counter++;
            ABC[counter] = "P"; CODES[counter] = "· — — · 	    "; counter++;
            ABC[counter] = "CH"; CODES[counter] = "— — — —     "; counter++;
            ABC[counter] = "W"; CODES[counter] = " · — — 		"; counter++;
            ABC[counter] = "S"; CODES[counter] = " · · · 		"; counter++;
            ABC[counter] = "D"; CODES[counter] = "— · · 		"; counter++;
            ABC[counter] = "R"; CODES[counter] = "· — · 		"; counter++;
            ABC[counter] = "K"; CODES[counter] = " — · — 		"; counter++;
            ABC[counter] = "U"; CODES[counter] = "· · — 		"; counter++;
            ABC[counter] = "O"; CODES[counter] = "— — — 		"; counter++;
            ABC[counter] = "G"; CODES[counter] = " — — · 		"; counter++;
            // 2
            ABC[counter] = "A"; CODES[counter] = "· —          "; counter++;
            ABC[counter] = "M"; CODES[counter] = " — — 		"; counter++;
            ABC[counter] = "I"; CODES[counter] = " · · 		"; counter++;
            ABC[counter] = "N"; CODES[counter] = "— · 		"; counter++;
            // 1
            ABC[counter] = "T"; CODES[counter] = "—   "; counter++;
            ABC[counter] = "E"; CODES[counter] = "· 		"; counter++;

            // CLEAN Dirty CODES
            int TMPCOUNTER = CODES.Length - 1;
            for (int X = 0; X <= TMPCOUNTER; X++)
            {
                // Replace black spaces
                CODES[X] = CODES[X].Replace(" ", "");
                CODES[X] = CODES[X].Replace("\t", "") + " ";
                CODES[X] = CODES[X].Trim() + " ";
            }

            Locate(1, 20);
            ForeColor(12);
            Print("The Morse Translator by Carlos Chang FB @sistemaswebchang");


            // Tranlate
            MORSE = Replace(MORSE, "_", "—");
            MORSE = Replace(MORSE, ".", "·");
            MORSE = MORSE + " ";
            for (int X = 0; X <= TMPCOUNTER; X++)
            {
                MORSE = Replace(MORSE, CODES[X], ABC[X]);
            }


            ForeColor(7);

            for (int X = 0; X < TMPCOUNTER; X++)
            {
                // Print morse screen
                Locate(X, 1);
                Print(ABC[X] + " " + CODES[X]);
            }

            BackColor(4);
            Locate(5, 0);
            Print(new string(Chr(187), 120));
            Locate(7, 0);
            Print(new string(' ', 120));
            Locate(8, 0);
            Print(new string(Chr(187), 120));

            Locate(6, 0);
            Print(MORSE);

            Wait();

            // END

        }
    }
}
