/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
 
public List<string> BinaryTreePaths(TreeNode root) {
    var paths = new List<string>();

    if (root == null)
        return paths;

    dfs(root, "", paths);

    return paths;
}

public void dfs(TreeNode root, string path, List<string> paths) {
    path += root.val.ToString();
    
    if (root.left == null && root.right == null)
    {
        paths.Add(path);
        return;
    }
    
    if (root.left != null)
        dfs(root.left, path + "->", paths);
    
    if (root.right != null)
        dfs(root.right, path + "->", paths);
}
