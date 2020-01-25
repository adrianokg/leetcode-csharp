public int[] TwoSum(int[] nums, int target) {
    var result = new int[2];

    if (nums.Length > 0 || target > 0)
    {
        var size = nums.Length;

        for(var i = 0; i < size; i++)
        {
            for(var j = i + 1; j < size; j++)
            {
                var selected = nums[i];
                var next = nums[j];

                if(selected + next == target)
                {
                    result[0] = i;
                    result[1] = j;

                    return result;
                }
            }
        }
    }

    return result;
}
