using _02350Demo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02350Demo.Command
{
    // Undo/Redo command for adding a Line.
    public class AddEdgeCommand : IUndoRedoCommand
    {
        // Regions can be used to make code foldable (minus/plus sign to the left).
        #region Fields

        // The 'lines' field holds the current collection of lines, 
        //  and the reference points to the same collection as the one the MainViewModel point to, 
        //  therefore when this collection is changed in a object of this class, 
        //  it also changes the collection that the MainViewModel uses.
        // For a description of an ObservableCollection see the MainViewModel class.
        private ObservableCollection<Edge> lines;
        // The 'line' field holds a new line, that is added to the 'lines' collection, 
        //  and if undone, it is removed from the collection.
        private Edge _edge;

        #endregion

        #region Constructor

        // For changing the current state of the diagram.
        public AddEdgeCommand(ObservableCollection<Edge> _lines, Edge edge) 
        { 
            lines = _lines;
            _edge = edge;
        }

        #endregion

        #region Methods

        // For doing and redoing the command.
        public void Execute()
        {
            lines.Add(_edge);
        }

        // For undoing the command.
        public void UnExecute()
        {
            lines.Remove(_edge);
        }

        #endregion
    }
}
