public int Rob(int[] nums) {
    if (nums == null || nums.Length == 0) 
        return 0;
    else if (nums.Length == 1) 
        return nums[0];

    for (int i = 2; i < nums.Length; i++)
    {
        if (i == 2) 
            nums[i] = nums[i] + nums[i - 2];
        else
            nums[i] = Math.Max(nums[i] + nums[i - 2], nums[i] + nums[i - 3]);
    }

    return Math.Max(nums[nums.Length - 1], nums[nums.Length - 2]);
}
