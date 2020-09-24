using dsaexposed.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaexposed
{
    public class ShowTreeChildrenBreadthWise
    {

        public static void Init()
        {
            TreeNode rootNode = new TreeNode("Company", null, null);
            List<TreeNode> rootChild = new List<TreeNode>
            {
                new TreeNode("Haris", "CEO", rootNode),
                new TreeNode("James", "CTO", rootNode),
                new TreeNode("Sahas", "CFO", rootNode)
            };
            rootNode.Children = rootChild;

            CompanyTree companyTree = new CompanyTree(rootNode);

            List<TreeNode> ceoChild = new List<TreeNode>
            {
                new TreeNode("Subash", "Manager", rootNode.Children[0], null),
                new TreeNode("Gita", "Marketing", rootNode.Children[0], null),
            };
            rootNode.Children[0].Children = ceoChild;

            companyTree.ShowAll(rootNode);
        }
    }
}
