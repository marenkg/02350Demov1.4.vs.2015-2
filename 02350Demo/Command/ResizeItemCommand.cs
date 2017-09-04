using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02350Demo.Model;

namespace _02350Demo.Command
{
    class ResizeItemCommand : IUndoRedoCommand
    {
        // Classboxes can only be resized horizontally, hence only left and right controls - Vertical resize in controlled with content of box
        private ClassBox classBox;
        private double offsetLeft;
        private double offsetRight;

        public ResizeItemCommand(ClassBox _classBox, double _offsetLeft, double _offsetRight)
        {
            classBox = _classBox;
            offsetLeft = _offsetLeft;
            offsetRight = _offsetRight;

        }

        public void Execute()
        {
            if (offsetLeft != 0.0)
            {
                //classBox.CanvasCenterX += - offsetLeft / 2;
                //classBox.Width += offsetLeft;
            }
            else
            {
                //classBox.CanvasCenterX += offsetRight / 2;
                //classBox.Width += offsetRight;
            }
        }

        public void UnExecute()
        {
            throw new NotImplementedException();
        }
    }
}
