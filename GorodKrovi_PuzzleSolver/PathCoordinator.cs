using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorodKrovi_PuzzleSolver
{
    public class PathCoordinator
    {
        List<AirflowNode> nodes = new List<AirflowNode>();
        AirflowNode[] path = new AirflowNode[6];
        AirflowNode endPoint;

        const String armory = "Armory";
        const String departmentStore = "Department Store";
        const String dragonCommand = "Dragon Command";
        const String supplyDepot = "Supply Depot";
        const String infirmary = "Infirmary";
        const String tankFactory = "Tank Factory";

        public PathCoordinator()
        {
            InitializeAirflowNodes();
        }

        public void InitializePuzzle(AirflowNode startNode, AirflowNode endNode)
        {
            path[0] = startNode;
            endPoint = endNode;
        }

        public void InitializeAirflowNodes()
        {
            nodes.Clear();

            AirflowNode armoryNode = new AirflowNode(armory, new string[3] { supplyDepot, tankFactory, departmentStore });
            AirflowNode deptStoreNode = new AirflowNode(departmentStore, new string[3] { armory, infirmary, dragonCommand });
            AirflowNode dragonCommandNode = new AirflowNode(dragonCommand, new string[3] { supplyDepot, departmentStore, infirmary });
            AirflowNode supplyDepotNode = new AirflowNode(supplyDepot, new string[3] { dragonCommand, armory, tankFactory });
            AirflowNode infirmaryNode = new AirflowNode(infirmary, new string[3] { departmentStore, tankFactory, dragonCommand });
            AirflowNode tankFactoryNode = new AirflowNode(tankFactory, new string[3] { infirmary, supplyDepot, armory });

            nodes.Add(armoryNode);
            nodes.Add(deptStoreNode);
            nodes.Add(dragonCommandNode);
            nodes.Add(supplyDepotNode);
            nodes.Add(infirmaryNode);
            nodes.Add(tankFactoryNode);
        }

        public AirflowNode GetNextNode(AirflowNode currentNode)
        {
            String nextNodeName = currentNode.GetNextNodeName();
            AirflowNode foundNode = Array.Find<AirflowNode>(path, s => s != null && s.Name.Equals(nextNodeName));

            if((nextNodeName.Equals(endPoint.Name) && path.Count<AirflowNode>() < 5)
                || foundNode != null)
            {
                nextNodeName = currentNode.GetNextNodeName();
            }

            AirflowNode nextNode = null;

            foreach(AirflowNode node in nodes)
            {
                if(node.Name.Equals(nextNodeName))
                {
                    nextNode = node;
                    break;
                }
            }

            return nextNode;
        }

        public AirflowNode[] CalculatePath()
        {
            bool solved = false;
            int currentIndex = 1;

            while(!solved)
            {
                AirflowNode nextNode = GetNextNode(path[currentIndex - 1]);
                if(nextNode != null)
                {
                    path[currentIndex] = nextNode;
                    currentIndex++;
                }

                if(path[5] != null && path[5].Name.Equals(endPoint.Name))
                {
                    solved = true;
                }
            }

            return path;
        }

        public List<AirflowNode> GetAirflowNodes()
        {
            return nodes;
        }

        public override string ToString()
        {
            String output = string.Empty;
            foreach(AirflowNode node in nodes)
            {
                output += node.ToString();
                output += Environment.NewLine;
            }

            return output;
        }
    }
}
