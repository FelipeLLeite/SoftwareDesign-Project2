/**
 * Class Name:      Abstractbuilder
 * Author:          Felipe Lopes Leite
 * Purpose:         This class will give more flexibility to the children classes without any changes in the interfaces.
 */

using DocumentBuilderLibrary.Interfaces;

namespace DocumentBuilderLibrary.Builder
{
    public abstract class AbstractBuilder
    {
        // Gives access to any IBuilder that the user create
        protected IBuilder builder;
        // Placehold for the tag name of a branch and leaf
        protected string tagName { get; set; }
        // Placehold for the content enter by the user
        protected string content { get; set; }

        // Additional methods
        public abstract void SetMode(string mode);
        public abstract void SetTagName(string name);
        public abstract void SetContent(string content);
        public abstract void PrintDoc();
    }
}
