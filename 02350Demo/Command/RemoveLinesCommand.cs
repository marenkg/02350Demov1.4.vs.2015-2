﻿using _02350Demo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02350Demo.ViewModel;

namespace _02350Demo.Command
{
    // Undo/Redo command for removing Lines.
    public class RemoveLinesCommand : IUndoRedoCommand
    {
        // Regions can be used to make code foldable (minus/plus sign to the left).
        #region Fields

        // The 'lines' field holds the current collection of lines, 
        //  and the reference points to the same collection as the one the MainViewModel point to, 
        //  therefore when this collection is changed in a object of this class, 
        //  it also changes the collection that the MainViewModel uses.
        // For a description of an ObservableCollection see the MainViewModel class.
        private ObservableCollection<EdgeViewModel> lines;

        // The 'linesToRemove' field holds a collection of existing lines, that are removed from the 'lines' collection, 
        //  and if undone, they are added to the collection.
        private List<EdgeViewModel> linesToRemove;

        #endregion

        #region Constructor

        // For changing the current state of the diagram 
        //  (or at least the relevant parts).
        public RemoveLinesCommand(ObservableCollection<EdgeViewModel> _lines, List<EdgeViewModel> _linesToRemove) 
        {
            lines = _lines;
            linesToRemove = _linesToRemove;
        }

        #endregion

        #region Methods

        // For doing and redoing the command.
        public void Execute()
        {
            // This is a lambda expression, that iterates the 'linesToRemove' collection, 
            //  and for each one removes it from the 'lines' collection.
            // Java:
            //  foreach (Line line in linesToRemove)
            //  { 
            //    lines.Remove(line);
            //  }
            linesToRemove.ForEach(x => lines.Remove(x));
        }

        // For undoing the command.
        public void UnExecute()
        {
            // This is a lambda expression, that iterates the 'linesToRemove' collection, 
            //  and for each one adds it to the 'lines' collection.
            // Java:
            //  foreach (Line line in linesToRemove)
            //  { 
            //    lines.Add(line);
            //  }
            linesToRemove.ForEach(x => lines.Add(x));
        }

        #endregion
    }
}
