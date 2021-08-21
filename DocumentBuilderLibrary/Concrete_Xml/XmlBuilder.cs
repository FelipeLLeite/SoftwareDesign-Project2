/**
 * Class Name:      XmlBuilder
 * Author:          Felipe Lopes Leite
 * Purpose:         Implement the builder interface to be able to create a object of a Xml document.
 */

using System.Collections.Generic;
using DocumentBuilderLibrary.Interfaces;

namespace DocumentBuilderLibrary.Concrete_Xml
{
    public class XmlBuilder : IBuilder
    {
        private XmlBranch _root;
        private Stack<XmlBranch> _lastCompositeStack;

        public XmlBuilder()
        {
            _root = new XmlBranch("root");
            _lastCompositeStack = new Stack<XmlBranch>();
            _lastCompositeStack.Push(_root);
        } // end ctor

        /// <summary>
        /// Create and add the new branch into *this* container.
        /// </summary>
        /// <param name="name">
        /// A string to represent the name of the tag of the branch.
        /// </param>
        /// <returns>Void</returns>
        public void BuildBranch(string name)
        {
            XmlBranch element = new XmlBranch(name);
            _lastCompositeStack.Peek().AddChild(element);
            _lastCompositeStack.Push(element);
        } // end BuildBranch method

        /// <summary>
        /// Create a new leaf node and to the last branch saved on *this* container
        /// </summary>
        /// <param name="name">
        /// A string to represent the name of the tag of the leaf node.
        /// </param>
        /// <param name="content">
        /// A string to represent the content of the leaf node.
        /// </param>
        /// <returns>Void</returns>
        public void BuildLeaf(string name, string content)
        {
            _lastCompositeStack.Peek().AddChild(new XmlLeaf(name, content));
        } // end buildLeaf method

        /// <summary>
        /// Close the lasted node in the stack container. Ignore the root branch.
        /// </summary>
        public void CloseBranch()
        {
            if(!_lastCompositeStack.Peek().Equals(_root))
                _lastCompositeStack.Pop();
        } // end closeBranch method

        /// <summary>
        /// Return the object that represent the root node of the Xml document.
        /// </summary>
        /// <returns>The root object.</returns>
        public IComposite GetDocument()
        {
            return _root;
        } // end GetDocument method
    } // end class
} // end namespace