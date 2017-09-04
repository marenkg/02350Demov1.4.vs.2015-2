using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using GalaSoft.MvvmLight;
using _02350Demo.Model;

namespace _02350Demo.ViewModel
{
    class EdgeViewModel : ViewModelBase
    {
        public Edge edge { get; }
    
        public bool isSelected { get; set; }

        public ClassBox Source
        {
            get { return edge.Source; }
            set { edge.Source = value; RaisePropertyChanged(() => Source); }
        }

        public ClassBox Sink
        {
            get { return edge.Source; }
            set { edge.Sink = value; RaisePropertyChanged(() => Sink); }
        }


        public EdgeViewModel()
        {

        }
    }
}
