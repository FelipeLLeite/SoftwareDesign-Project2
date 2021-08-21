/**
 * Class Name:      JsonBuilder
 * Author:          Felipe Lopes Leite
 * Purpose:         Implement the builder interface to be able to create a object of a Json document.
 */

using System.Collections.Generic;
using DocumentBuilderLibrary.Interfaces;

namespace DocumentBuilderLibrary.Concrete_Json
{
    public class JsonBuilder : IBuilder
    {
        private JsonBranch _root;
        private Stack<JsonBranch> _lastCompositeStack;

        public JsonBuilder()
        {
            _root = new JsonBranch();
            _lastCompositeStack = new Stack<JsonBranch>();
            _lastCompositeStack.Push(_root);
        } // end JsonBuilder ctor

        /// <summary>
        /// Create and add the new branch into *this* container.
        /// </summary>
        /// <param name="name">
        /// A string to represent the name of the tag of the branch.
        /// </param>
        /// <returns>Void</returns>
        public void BuildBranch(string name)
        {
            JsonBranch element = new JsonBranch(name);
            _lastCompositeStack.Peek().AddChild(element);
            _lastCompositeStack.Push(element);
        } // end builderbranch method

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
            _lastCompositeStack.Peek().AddChild(new JsonLeaf(name, content));
        }

        /// <summary>
        /// Close the lasted node in the stack container. Ignore the root branch.
        /// </summary>
        public void CloseBranch()
        {
            if (!_lastCompositeStack.Peek().Equals(_root))
                _lastCompositeStack.Pop();
        } // end CloseBranch method

        /// <summary>
        /// Return the object that represent the root node of the Json document.
        /// </summary>
        /// <returns>The root object.</returns>
        public IComposite GetDocument()
        {
            return _root;
        } // end GetDocument
    } // end class
} // end namespace
