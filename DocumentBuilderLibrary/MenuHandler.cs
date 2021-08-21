/**
 * Class name:      MenuHandler
 * Author:          Felipe Lopes Leite
 * Purpose:         Helper class to store and display the program header, usage menu, error messages, and thank you message.
 */

using System;

namespace DocumentBuilderLibrary
{
    public class MenuHandler
    {
        // String arrays to store the string message for the menus.
        private string[] _menuOptions = { "help", "mode:<JSON|XML>", "branch:<tagName>", "leaf:<tagName>:<content>", "close", "print", "exit" };
        private string[] _menuDescription = {
            "-Prints Usage (this page).",
            "-Sets mode to JSON or XML. Must be set before creating or closing.",
            "-Creates a new branch, assigning it the passed tagName.",
            "-Creates a new leaf, assigning the passed tagName and content.",
            "-Closes the current branch, as long as it is not root.",
            "-Prints the doc in its current state to the console.",
            "-Exits the application."
        };

        /// <summary>
        /// Display into the sceen the header of the program with the usage menu.
        /// </summary>
        public void DisplayHeader()
        {
            System.Console.WriteLine("Document Builder Console Client");
            this.DisplayHelp();
        } // end DisplayHeader method

        /// <summary>
        /// Display into the screen the usage menu.
        /// </summary>
        public void DisplayHelp()
        {
            Console.WriteLine($"{Environment.NewLine}Usage:");
            for (int idx = 0; idx < _menuOptions.Length; idx++)
            {
                Console.Write($"{new string(' ', 3)}{_menuOptions[idx],-23}");
                Console.WriteLine(_menuDescription[idx]);
            } // end for loop
            Console.WriteLine(Environment.NewLine);
        } // end DisplayHelp method

        /// <summary>
        /// Display the error message in case the mode is not initialized.
        /// </summary>
        public void ErrorMessage()
        {
            Console.WriteLine("Error. Mode has not been set. For usage, type 'Help'");
        }

        /// <summary>
        /// Display the error message in case of invalid input.
        /// </summary>
        public void InvalidInput()
        {
            Console.WriteLine("Invalid input. For usage, type 'Help'");
        }
    } // end class
} // end namespace