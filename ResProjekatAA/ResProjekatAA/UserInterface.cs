﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfejsi;
using FederatedIdentityProjekat;

namespace ResProjekatAA
{
    public class UserInterface : IUserInterface
    {
        IFederatedIdentityInterface ifederated=new FederatedIdentityInterface();

        public void OdaberiSistemZaPrijavu()
        {
           
        }

        public void PrijaviSe()
        {
            do
            {
                string sistrem;

                do
                {
                    Console.WriteLine("Izaberite sistem za prijavu[json ili db]: ");
                    sistrem = Console.ReadLine();
                    sistrem = sistrem.ToLower();
                } while (sistrem != "json" && sistrem != "db");

                Console.WriteLine("Unesite username: ");
                string username = Console.ReadLine();
                Console.WriteLine("Unesite lozinku: ");
                string lozinka = "";
                ConsoleKeyInfo key;

                do
                {
                    key = Console.ReadKey(true);
                    // Backspace Should Not Work
                    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                    {
                        lozinka += key.KeyChar;
                        Console.Write("*");
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.Backspace && lozinka.Length > 0)
                        {
                            lozinka = lozinka.Substring(0, (lozinka.Length - 1));
                            Console.Write("\b \b");
                        }
                        else if (key.Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                    }
                } while (true);



                Console.WriteLine();
                Console.WriteLine("The Password You entered is : " + lozinka);

                bool postoji = ifederated.LogovanjeZahteva(username, lozinka, sistrem);

                if (postoji)
                {
                    Console.WriteLine("Uspesno ste se ulogovali");
                    break;
                }
                else
                {
                    Console.WriteLine("Niste uneli tacne podatke");
                }

            } while (true);

            Console.ReadLine();
        }

        public void PrikaziSistemeZaPrijavu()
        {
            throw new NotImplementedException();
        }
    }
}
