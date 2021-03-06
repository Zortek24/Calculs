/**
 * Application "Calculs" v01 (b5 a218)
 * author : Emds
 * date : 24/05/2020
 */
using System;

namespace Calculs
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1 = 0, val2 = 0; // mémorisation de nombres aléatoires
            int solution = 0; // calcul de la solution
            int reponse = 0; // saisie de la réponse de l'utilisateur
            int choix; // saisie du choix de l'utilsiateur

            // boucle sur le menu
            choix = 1;
            while (choix != 0)
            {
                // affiche le menu et saisi le choix
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Multiplication ................. 2");
                Console.WriteLine("Quitter ........................ 0");
                Console.Write("Choix :                          ");
                bool correct = false;
                while (!correct)
                {
                    try
                    {

                        choix = int.Parse(Console.ReadLine());
                        correct = true;
                    }
                    catch
                    {
                        Console.WriteLine("Erreur de saisie : saisissez une nombre entier");
                    }
                }
                Console.Clear();
                // traitement des choix
                if (choix != 0)
                {
                    if (choix == 1)
                    {
                        // choix de l'addition
                        val1 = rand.Next(1, 10);
                        val2 = rand.Next(1, 10);
                        // saisie de la réponse
                        Console.Write(val1 + " + " + val2 + " = ");
                        correct = false;
                        while (!correct)
                        {
                            try
                            {
                                reponse = int.Parse(Console.ReadLine());
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("Erreur de saisie : saisissez une nombre entier");
                            }
                        }
                        // comparaison avec la bonne réponse
                        solution = val1 + val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                        }
                    }
                    if (choix == 2)
                    {
                        // choix de la multiplication
                        val1 = rand.Next(1, 10);
                        val2 = rand.Next(1, 10);
                        // saisie de la réponse
                        Console.Write(val1 + " x " + val2 + " = ");
                        correct = false;
                        while (!correct)
                        {
                            try
                            {
                                reponse = int.Parse(Console.ReadLine());
                                // comparaison avec la bonne réponse
                                solution = val1 * val2;
                                if (reponse == solution)
                                {
                                    Console.WriteLine("Bravo !");
                                    correct = true;
                                }
                                else
                                {
                                    Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                                }
                            }

                            catch
                            {
                                Console.WriteLine("Erreur de saisie : saisissez une nombre entier");
                            }
                        }

                    }
                    
                        }
                    }
                       
                    }
                }
            }
        
    

