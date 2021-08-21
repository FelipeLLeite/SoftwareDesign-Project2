/**
 * Class name:      JsonBranch
 * Author:          Felipe Lopes Leite
 * Purpose:         Implement the interface IComposite to create a json object to represent a branch node.
 */
using System.Collections.Generic;
using DocumentBuilderLibrary.Interfaces;

namespace DocumentBuilderLibrary.Concrete_Json
{
    public class JsonBranch : IComposite
    {
        private string _tagName;
        private List<IComposite> _children;
        public JsonBranch(string tagName = null)
        {
            _tagName = tagName;
            _children = new List<IComposite>();
        } // end JsonComposite ctor


        /// <summary>
        /// Add a child node to its container. The child node can be another branch or a leaf.
        /// </summary>
        /// <param name="child">
        /// An object of the interface implementation of IComposite interface to represent the child node.
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
            string ident = "";
            for (int index = 0; index < depth; index++)
                ident += "    ";
            if (_tagName != null)
                result += $"{ident}\"{_tagName}\" :\n";
            result += $"{ident}{"{"}\n";

            foreach (var child in _children)
                result += child.Print(depth + 1);
            result += ident;
            result += "}\n";
            return result;
        } // end Print method
    } // end class_tagname
} // end namespace