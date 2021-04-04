﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaexposed.models
{
    public class TreeNode
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public TreeNode Parent { get; set; }
        public List<TreeNode> Children { get; set; }

        public TreeNode(string name, string title, TreeNode parent)
        {
            Name = name;
            Title = title;
            Parent = parent;
            Children = null;
        }

        public TreeNode(string name, string title, TreeNode parent, List<TreeNode> children)
        {
            Name = name;
            Title = title;
            Parent = parent;
            Children = children;
        }
    }
}
