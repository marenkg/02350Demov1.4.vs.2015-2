using _02350Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02350Demo.ViewModel;

namespace _02350Demo.Command
{
    // Undo/Redo command for moving a Shape.
    public class MoveShapeCommand : IUndoRedoCommand
    {
        // Regions can be used to make code foldable (minus/plus sign to the left).
        #region Fields

        // The 'shape' field holds an existing shape, 
        //  and the reference points to the same object, 
        //  as one of the objects in the MainViewModels 'Shapes' ObservableCollection.
        // This shape is moved by changing its coordinates (X and Y), 
        //  and if undone the coordinates are changed back to the original coordinates.
        private ClassBoxViewModel classBox;

        // The 'offsetX' field holds the offset (difference) between the original and final X coordinate.
        private double offsetX;
        // The 'offsetY' field holds the offset (difference) between the original and final Y coordinate.
        private double offsetY;

        #endregion

        #region Constructor

        // For changing the current state of the diagram.
        public MoveShapeCommand(ClassBoxViewModel _classBox, double _offsetX, double _offsetY) 
        {
          
            classBox = _classBox;
            offsetX = _offsetX;
            offsetY = _offsetY;
        }

        #endregion

        #region Methods

        // For doing and redoing the command.
        public void Execute()
        {
            // Updates position first to make sure edges goes to the new position
            classBox.X += offsetX;
            classBox.Y += offsetY;

            // Updates position for eges
            foreach (var edge in classBox.connectedEdges)
            {
                edge.positionChanged();
            }
        }

        // For undoing the command.
        public void UnExecute()
        {
            classBox.X -= offsetX;
            classBox.Y -= offsetY;
        }

        #endregion
    }
}
