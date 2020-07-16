using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

namespace InteractML
{
    public class IMLNode : Node
    {
        [HideInInspector]
        public IMLNodeTooltips tooltips;
        [HideInInspector]
        public string id;
        // Use this for initialization
        protected override void Init()
        {
            base.Init();
            id = NodeID.CheckNodeID(id, this);

        }

        // Return the correct value of an output port when requested
        public override object GetValue(NodePort port)
        {
            return null; // Replace this
        }
    }
}
