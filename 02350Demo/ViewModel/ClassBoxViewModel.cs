using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using _02350Demo.Model;
using System.Windows.Media;

namespace _02350Demo.ViewModel
{
    public class ClassBoxViewModel : ViewModelBase
    {

        public ClassBoxViewModel(ClassBox classBox)
        {
            this.classBox = classBox;
        }

        public ClassBoxViewModel()
        {
            this.classBox = new ClassBox();
        }
        
        public ICommand SizeChanged { get; }

        public ClassBox classBox { get; }
        public bool IsSelected { get; set; }
        public Brush SelectedColor => IsSelected ? Brushes.Blue : Brushes.LightBlue;

        public List<EdgeViewModel> connectedEdges = new List<EdgeViewModel>();

        public double X
        {
            get { return classBox.X; }
            set
            {
                classBox.X = value;
                RaisePropertyChanged(() => X);
                RaiseConnectionsPointChanged();

            }
        }

        public double Y
        {
            get { return classBox.Y; }
            set
            {
                classBox.Y = value;
                RaisePropertyChanged(() => Y);
                RaiseConnectionsPointChanged();
            }
        }

        public double Height
        {
            get { return classBox.Height; }
            set
            {
                classBox.Height = value;
                RaisePropertyChanged(() => Height);
                RaiseConnectionsPointChanged();
            }
        }

        public double Width
        {
            get { return classBox.Width; }
            set
            {
                classBox.Width = value;
                RaisePropertyChanged(() => Width);
                RaiseConnectionsPointChanged();
            }
        }

        private void RaiseConnectionsPointChanged()
        {
            RaisePropertyChanged(() => North);
            RaisePropertyChanged(() => South);
            RaisePropertyChanged(() => East);
            RaisePropertyChanged(() => West);
        }

        public String ContentClass
        {
            get { return classBox.ContentClass; }
            set
            {
                classBox.ContentClass = value;
                RaisePropertyChanged(() => ContentClass);
            }
        }

        public String ContentFields
        {
            get { return classBox.ContentFields; }
            set
            {
                classBox.ContentFields = value;
                RaisePropertyChanged(() => ContentFields);
            }
        }

        public String ContentMethods
        {
            get { return classBox.ContentMethods; }
            set
            {
                classBox.ContentMethods = value;
                RaisePropertyChanged(() => ContentMethods);
            }
        }

        // Points are calculated in model when X and Y is changed
        public Point North => classBox.North;

        public Point South => classBox.South;
        public Point West => classBox.West;
        public Point East => classBox.East;

    }


}
