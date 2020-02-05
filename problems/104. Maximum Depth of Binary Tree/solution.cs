public int GetLen(TreeNode node)
{
    var result = 0;

    if (node != null)
        result = Math.Max(GetLen(node.left), GetLen(node.right)) + 1;

    return result;
}
