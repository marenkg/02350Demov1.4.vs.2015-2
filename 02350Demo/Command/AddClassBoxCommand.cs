using _02350Demo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02350Demo.ViewModel;

namespace _02350Demo.Command
{
    // Undo/Redo command for adding a Shape.
    public class AddClassBoxCommand : IUndoRedoCommand
    {
        // Regions can be used to make code foldable (minus/plus sign to the left).
        #region Fields


        private ObservableCollection<ClassBoxViewModel> classBoxes;
        // The 'shape' field holds a new shape, that is added to the 'shapes' collection, 
        //  and if undone, it is removed from the collection.
        private ClassBoxViewModel classBox;

        #endregion

        #region Constructor

        // For changing the current state of the diagram.
        public AddClassBoxCommand(ObservableCollection<ClassBoxViewModel> classBoxes, ClassBoxViewModel classBox) 
        { 
            this.classBoxes = classBoxes;
            this.classBox = classBox;
        }

        #endregion

        #region Methods

        // For doing and redoing the command.
        public void Execute()
        {
            classBoxes.Add(classBox);
        }

        // For undoing the command.
        public void UnExecute()
        {
            classBoxes.Remove(classBox);
        }

        #endregion
    }
}
