/**
 * Interface name:  IBuilder
 * Author:          Felipe Lopes Leite
 * Purpose:         Representation of what a Builder Concrete class should do.
 *                  Needs implemention.
 */

namespace DocumentBuilderLibrary.Interfaces
{
    public interface IBuilder
    {
        void BuildBranch(string name);
        void BuildLeaf(string name, string content);
        void CloseBranch();
        IComposite GetDocument();
    } // end interface
} // end namespace
