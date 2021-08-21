/**
 * Interface name:  IComposite
 * Author:          Felipe Lopes Leite
 * Purpose:         Representation of what a Composite concrete class should do.
 *                  Needs implemention. The implementaiuon need to have attributes 
 *                  to be able to represent a branch node or a leaf node.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentBuilderLibrary.Interfaces
{
    public interface IComposite
    {
        void AddChild(IComposite child);
        string Print(int depth);
    } // end interface
} // end namespace
