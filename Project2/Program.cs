/**
 * Class name:      Program
 * Author:          Felipe Lopes Leite
 * Purpose:         Hold the main runner application and execute the program.
 */

using DocumentBuilderLibrary;
using System;

namespace Project2
{
    public class Program
    {
        // Initialize the director - I know that I didn't initialize with the builder. Check SetMode of the director.
        // I found cleaner doing this.
        private static Director tarantino = new Director();
        private static MenuHandler objMenu = new MenuHandler();
        static void Main(string[] args)
        {
            objMenu.DisplayHeader();
            string input = "";

            // Read the input of the user
            while (true)
            {
                Console.Write("> ");
                input = Console.ReadLine();
                string[] data = input.Split(':');
                if (data.Length > 0)
                {
                    switch (data[0].ToLower())
                    {
                        case "help":
                            objMenu.DisplayHelp();
                            break;
                        case "mode":
                            // set the mode and initialize the builder attribute of the director inside of the SetMode method.
                            if (data.Length == 2)
                                tarantino.SetMode(data[1]);
                            else
                                objMenu.InvalidInput();
                            break;
                        case "branch":
                            if (tarantino == null)
                                objMenu.ErrorMessage();
                            else if (data.Length == 2)
                            {
                                //if (!string.IsNullOrEmpty(data[1]))
                                if (data[1] != null)
                                {
                                    tarantino.SetTagName(data[1]);
                                    tarantino.BuildBranch();
                                }
                                else
                                    objMenu.InvalidInput();
                            }
                            else
                                objMenu.InvalidInput();
                            break;
                        case "leaf":
                            if (tarantino == null)
                                objMenu.ErrorMessage();
                            else if(data.Length == 3)
                            {
                                if(!String.IsNullOrEmpty(data[1]))
                                {
                                    tarantino.SetTagName(data[1]);
                                    tarantino.SetContent(data[2]);
                                    tarantino.BuildLeaf();
                                }
                            }
                            else
                                objMenu.InvalidInput();
                            break;
                        case "close":
                            tarantino.CloseBranch();
                            break;
                        case "print":
                            if (tarantino == null)
                                objMenu.ErrorMessage();
                            else
                                tarantino.PrintDoc();
                            break;
                        case "exit":
                            Console.WriteLine("Thank for using the ");
                            Environment.Exit(0);
                            break; // The compile ask for this even when I end the program (DUMB C#)
                        default:
                            objMenu.InvalidInput();
                            break;
                    } // end switch block
                } // end if statement block
            } // end infinite while loop
        } // end main
    } // end class
} // end namespace
