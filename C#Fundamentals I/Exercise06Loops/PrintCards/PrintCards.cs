using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintCards
{
    class PrintCards
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 13+1; i++)
            {
                string name = "";
                switch (i)
                {
                    case 1:
                        name = "Ace";
                        break;
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        name = string.Format("{0}",i);
                        break;
                    case 11:
                        name = "Jack";
                        break;
                    case 12:
                        name = "Queen";
                        break;
                    case 13:
                        name = "King";
                        break;
                    default:
                        name = "No such card";
                        break;
                }//switch
                name += " of ";
                for (int suite = 0; suite < 4; suite++)
                {
                    string card = name;
                    switch (suite)
                    {
                        case 0:
                            card += "hearts";
                                break;
                        case 1:
                            card +="spades";
                            break;
                        case 2:
                            card +="diamonds";
                            break;
                        case 3:
                            card +="clubs";
                            break;
                        default:
                            card +="no such suite";
                            break;
                    }//switch
                    Console.WriteLine(card);
                    card = "";
                }//suite for
                Console.WriteLine("");
            }//number for

        }

    }
}
