using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight;
using _02350Demo.Model;

namespace _02350Demo.ViewModel
{
    public class ClassBoxViewModel : ViewModelBase
    {
        public ClassBox classBox { get; }
        public bool isSelected { get; set; }

        public double X {
            get { return classBox.X; }
            set { classBox.X = value; RaisePropertyChanged(() => X);}
        }
        public double Y
        {
            get { return classBox.Y; }
            set { classBox.Y = value; RaisePropertyChanged(() => Y); }
        }
        public double Height
        {
            get { return classBox.Height; }
            set { classBox.Height = value; RaisePropertyChanged(() => Height); }
        }
        public double Width
        {
            get { return classBox.Width; }
            set { classBox.Width = value; RaisePropertyChanged(() => Width); }
        }

        public String ContentClass
        {
            get { return classBox.ContentClass; }
            set { classBox.ContentClass = value; RaisePropertyChanged(() => ContentClass); }
        }

        public String ContentFields
        {
            get { return classBox.ContentFields; }
            set { classBox.ContentFields = value; RaisePropertyChanged(() => ContentFields); }
        }

        public String ContentMethods
        {
            get { return classBox.ContentMethods; }
            set { classBox.ContentMethods = value; RaisePropertyChanged(() => ContentMethods); }
        }

        // Points are calculated in model when X and Y is changed
        public Point North => classBox.North;
        public Point South => classBox.South;
        public Point West => classBox.West;
        public Point East => classBox.East;

        public ClassBoxViewModel(ClassBox classBox)
        {
            this.classBox = classBox;
        }

        public ClassBoxViewModel()
        {
            this.classBox = new ClassBox();
        }
     }
}
