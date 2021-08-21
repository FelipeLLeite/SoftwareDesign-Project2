/**
 * Class name:      Director
 * Author:          Felipe Lopes Leite
 * Purpose:         Implements the interface IDirect.
 *                  Extends from the Abstract Builder to be able to have more flexibility 
 *                  without change the the interface the it implementes
 */

using DocumentBuilderLibrary.Builder;
using DocumentBuilderLibrary.Concrete_Json;
using DocumentBuilderLibrary.Concrete_Xml;
using DocumentBuilderLibrary.Interfaces;
using System;

namespace DocumentBuilderLibrary
{
    public class Director : AbstractBuilder, IDirector
    {
        public Director() : base() { }

        /// <summary>
        /// Create the branch using the builder attribute with the tag name passed to the builder method.
        /// </summary>
        public void BuildBranch()
        {
            if (this.builder != null)
                this.builder.BuildBranch(this.tagName);
            else
                (new MenuHandler()).ErrorMessage();
        } // end BuildBranch method

        /// <summary>
        /// Create the leaf using the builder attribute with the tag name and content text passed to the builder method.
        /// </summary>
        public void BuildLeaf()
        {
            if (this.builder != null)
                this.builder.BuildLeaf(this.tagName, this.content);
            else
                (new MenuHandler()).ErrorMessage();
        } // end BuildLeaf method

        /// <summary>
        /// Close the branch using the builder attribute "CloseBranch" method
        /// </summary>
        public void CloseBranch()
        {
            if (this.builder != null)
                builder.CloseBranch();
            else
                (new MenuHandler()).ErrorMessage();
        } // end CloseBranch method

        /// <summary>
        /// Override method from the Abstract Class.
        /// Set the mode and initialize the builder attribute based on the user input.
        /// </summary>
        /// <param name="mode">String that represent the mode. Mode can only be Xml or Json</param>
        public override void SetMode(string mode)
        {
            if (mode.ToLower().Trim().Equals("xml"))
                builder = new XmlBuilder();
            else if (mode.ToLower().Trim().Equals("json"))
                builder = new JsonBuilder();
            else
                (new MenuHandler()).InvalidInput();
            //Console.WriteLine("Invalid input. For usage, type 'Help'");
        } // end SetMode method

        /// <summary>
        /// Override method from the Abstract Class.
        /// Set the name of the tag. This tag can be for a branch of for a leaf node.
        /// </summary>
        /// <param name="name"></param>
        public override void SetTagName(string name)
        {
            this.tagName = name;
        } // end setName method

        /// <summary>
        /// Override method from the Abstract Class.
        /// Set the content text for a leaf node.
        /// </summary>
        /// <param name="content"></param>
        public override void SetContent(string content)
        {
            this.content = content;
        } // end SetContent method

        /// <summary>
        /// Override method from the Abstract Class.
        /// Display the content of the document by looping through the whole tree structure.
        /// </summary>
        public override void PrintDoc()
        {
            if (this.builder != null)
                Console.WriteLine(builder.GetDocument().Print(0));
            else
                (new MenuHandler()).ErrorMessage();
        } // end Pricdoc method
    } // end class
} // end namespace