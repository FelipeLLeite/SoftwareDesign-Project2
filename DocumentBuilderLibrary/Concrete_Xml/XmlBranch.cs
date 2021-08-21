/**
 * Class name:      XmlBranch
 * Author:          Felipe Lopes Leite
 * Purpose:         Implement the interface IComposite to create a xml object to represent a branch node.
 */

using System.Collections.Generic;
using DocumentBuilderLibrary.Interfaces;

namespace DocumentBuilderLibrary.Concrete_Xml
{
    public class XmlBranch : IComposite
    {
        private string _tagName;
        private List<IComposite> _children;
        public XmlBranch(string tagName)
        {
            _tagName = tagName;
            _children = new List<IComposite>();
        } // end XmlComposite ctor

        /// <summary>
        /// Add a child node to its container. The child node can be another branch or a leaf.
        /// </summary>
        /// <param name="child">
        /// An object of the interface implemetion of IComposite interface to represent the child node.
        /// </param>
        /// <returns>Void</returns>
        public void AddChild(IComposite child)
        {
            _children.Add(child);
        } // end AddChild method

        /// <summary>
        /// Print the node with its tag name and its contents (children nodes)
        /// </summary>
        /// <param name="depth">
        /// An integer to represent the indentation of the result string
        /// </param>
        /// <returns>A string to represent </returns>
        public string Print(int depth)
        {
            string result = "";
            for(int index = 0; index < depth; index++)
                result += "    ";
            result += $"<{_tagName}>\n";

            foreach(var child in _children)
                result += child.Print(depth + 1);

            for(int index = 0; index < depth; index++)
                result += "    ";

            result += $"</{_tagName}>\n";

            return result;
        } // end Print method
    } // end class
} // end namespace