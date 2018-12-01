﻿// This file has been autogenerated from a class added in the UI designer.

using System;
using LiteDbExplorer.Mac.Models;

namespace LiteDbExplorer.Mac
{
    public class ElementNodeEventArgs : EventArgs
    {
        public ElementNodeEventArgs(DbNavigationNodeType nodeType, string instanceId)
        {
            NodeType = nodeType;
            InstanceId = instanceId;
        }

        public string InstanceId { get; }

        public DbNavigationNodeType NodeType { get; }
    }
}
