using System.Collections.Generic;

namespace BehaviorTree
{
    public enum ExecutionState { running, success, failure }
    public abstract class Node
    {
        public Node parent;
        public List<Node> children;

        protected ExecutionState state;

        /// <summary>
        /// The current Execution state of the node
        /// </summary>


        /// <summary>
        /// The method that runs every frame and evaluates the  current execution state
        /// 
        /// </summary>
        public abstract ExecutionState Evaluate();

    }
}
