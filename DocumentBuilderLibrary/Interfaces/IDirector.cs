/**
 * Interface name:  IDirector
 * Author:          Felipe Lopes Leite
 * Purpose:         Representation of what a Director Concrete class should do.
 *                  Needs implemention.
 *                  Its implemention will need to have ways to work with inputs.
 */

namespace DocumentBuilderLibrary.Interfaces
{
    public interface IDirector
    {
        void BuildBranch();
        void BuildLeaf();
        void CloseBranch();
    } // end interface
} // end namespace
