public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // PLAN:
        // 1. Create a new array of doubles whose size is 'length'. This array will hold the answer.
        // 2. Use a for loop with an index 'i' that starts at 0 and runs while i < length.
        // 3. Each position in the array holds one multiple of 'number'. Position 0 holds the 1st
        //    multiple (number * 1), position 1 holds the 2nd multiple (number * 2), and so on.
        //    So on every pass of the loop, store number * (i + 1) at position i.
        // 4. When the loop finishes, every position has been filled. Return the array.
        //
        // Example check: MultiplesOf(7, 5) -> i=0: 7*1=7, i=1: 7*2=14, i=2: 7*3=21,
        //                i=3: 7*4=28, i=4: 7*5=35 -> {7, 14, 21, 28, 35}

        var multiples = new double[length];
        for (var i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }
 
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // PLAN (list slicing approach):
        // Rotating right by 'amount' means the LAST 'amount' items move to the FRONT of the list,
        // and everything else stays in the same order after them.
        // 1. Find where the "tail" starts: startOfTail = data.Count - amount.
        // 2. Make a copy of the tail using GetRange(startOfTail, amount). This is a new list, so it
        //    is not affected when we change the original list.
        // 3. Remove the tail from the original list using RemoveRange(startOfTail, amount).
        //    Now 'data' only holds the items that were not rotated.
        // 4. Put the copied tail back at the front of the list using InsertRange(0, tail).
        //    The existing items get pushed to the right, behind the tail.
        // 5. Nothing to return, because the original 'data' list was modified directly.
        //
        // Example check: data = {1,2,3,4,5,6,7,8,9}, amount = 3
        //   startOfTail = 9 - 3 = 6, tail = {7,8,9}, after removing -> {1,2,3,4,5,6},
        //   after inserting tail at index 0 -> {7,8,9,1,2,3,4,5,6}
        // Edge case: if amount == data.Count, the tail is the whole list. We remove everything and
        //   put it right back, so the list is unchanged, which is correct for a full rotation.
 
        var startOfTail = data.Count - amount;
        var tail = data.GetRange(startOfTail, amount);
        data.RemoveRange(startOfTail, amount);
        data.InsertRange(0, tail);
    }
}