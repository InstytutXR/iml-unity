using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;
using System;
using InteractML;


    /// <summary>
    /// Offers a collection of functions to serialize/deserialize IML data from disk
    /// </summary>
    public static class NodeID
    { 
        public static string CheckNodeID(string id, Node node)
        {
            if (id == null)
            {
                id = Guid.NewGuid().ToString();
            }
            else
            {
                var match = node.graph.nodes.Find(n => {
                    if (n == node) return false;
                    Node skillNode = n;
                    IMLNode imlNode = n as IMLNode;
                    return imlNode != null && imlNode.id == id;
                });

                if (match != null)
                {
                    id = Guid.NewGuid().ToString();
                }
            }
            return id;
        }
    }

