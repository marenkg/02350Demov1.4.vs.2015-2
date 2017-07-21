﻿using _02350Demo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02350Demo.Command
{
    // Undo/Redo command for adding a Shape.
    public class AddShapeCommand : IUndoRedoCommand
    {
        // Regions can be used to make code foldable (minus/plus sign to the left).
        #region Fields

        // The 'shapes' field holds the current collection of shapes, 
        //  and the reference points to the same collection as the one the MainViewModel point to, 
        //  therefore when this collection is changed in a object of this class, 
        //  it also changes the collection that the MainViewModel uses.
        // For a description of an ObservableCollection see the MainViewModel class.
        private ObservableCollection<ClassBox> shapes;
        // The 'shape' field holds a new shape, that is added to the 'shapes' collection, 
        //  and if undone, it is removed from the collection.
        private ClassBox shape;

        #endregion

        #region Constructor

        // For changing the current state of the diagram.
        public AddShapeCommand(ObservableCollection<ClassBox> _shapes, ClassBox _shape) 
        { 
            shapes = _shapes;
            shape = _shape;
        }

        #endregion

        #region Methods

        // For doing and redoing the command.
        public void Execute()
        {
            shapes.Add(shape);
        }

        // For undoing the command.
        public void UnExecute()
        {
            shapes.Remove(shape);
        }

        #endregion
    }
}
