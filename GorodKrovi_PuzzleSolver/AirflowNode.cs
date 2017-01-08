using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorodKrovi_PuzzleSolver
{
    public class AirflowNode
    {
        string locationName;
        public int currentIndex = 0;
        string[] connections;

        public AirflowNode()
        { }

        public AirflowNode(string location, string[] connectionList)
        {
            locationName = location;
            connections = connectionList;
        }

        public String Name
        {
            get
            {
                return locationName;
            }
        }

        public String GetNextNodeName()
        {
            if (currentIndex > 2)
            {
                currentIndex = 0;
                return null;
            }

            String nextNode = connections[currentIndex];
            currentIndex++;

            return nextNode;
        }

        public override string ToString()
        {
            string output = "Location: " + locationName;
            return output;
        }
    }
}
