/**
 * Class name:      JsonLeaf
 * Author:          Felipe Lopes Leite
 * Purpose:         Implement the interface IComposite to create a json object to represent a leaf node.
 */

using DocumentBuilderLibrary.Interfaces;

namespace DocumentBuilderLibrary.Concrete_Json
{
    public class JsonLeaf : IComposite
    {
        private string _tagName;
        private string _content;
        
        public JsonLeaf(string tagName, string content)
        {
            _tagName = tagName;
            _content = content;
        } // end JsonLeaf ctor

        /// <summary>
        /// Empty method. Leaves does not have children.
        /// </summary>
        /// <param name="child"></param>
        public void AddChild(IComposite child)
        {
            // * Empty function
        } // end AddChild method

        /// <summary>
        /// Create a string witht he tag name and the text content of the leaf.
        /// </summary>
        /// <param name="depth"></param>
        /// <returns>String representing the tag name and its content.</returns>
        public string Print(int depth)
        {
            string result = "";
            for (int index = 0; index < depth; index++)
                result += "    ";
            result += $"\"{_tagName}\" : \"{_content}\"\n";
            return result;
        } // end Print Method
    } // end class
} // end namespace