using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02350Demo.ViewModel;

namespace _02350Demo.Command
{
    class RemoveEdgeCommand : IUndoRedoCommand
    {

        private ObservableCollection<EdgeViewModel> Edges;
        private EdgeViewModel Edge;
        public RemoveEdgeCommand(EdgeViewModel edge, ObservableCollection<EdgeViewModel> edges)
        {
            this.Edge = edge;
            this.Edges = edges;
        }

        public void Execute()
        {
            // Remove edge from list of edges
            Edges.Remove(Edge);
            // Remove edge from source and sink 
        }

        public void UnExecute()
        {


        }
    }
}
