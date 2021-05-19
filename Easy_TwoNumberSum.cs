// Original Answers

using System;
using System.Linq;
public class Program {
	public static int[] TwoNumberSum(int[] array, int targetSum) {
		for (var i = 0; i < array.Length; i++) 
		{
			for (var j = i+1; j < array.Length; j++)
			{
				if (array[i] + array[j] == targetSum) 
				{
					return new int[] {array[i],array[j]}; 
				}
			}
		} 
		return new int[0];
	}
}

// Sampple Solutions

// using System.Collections.Generic;
// public class Program {
// 	public static int[] TwoNumberSum(int[] array, int targetSum) {
// 		HashSet<int> nums = new HashSet<int>();
// 		foreach (var num in array) { 
// 			int potentialMatch = targetSum - num;
// 			if (nums.Contains(potentialMatch)) {
// 				return new int[] {potentialMatch, num};
// 			}
// 			else
// 			{
// 			nums.Add(num);	
// 			}
// 		}
// 		return new int[0];
// 	}
// }


// public class Program {
// 	public static int[] TwoNumberSum(int[] array, int targetSum) {
// 		Array.Sort(array);
// 		int start = 0;
// 		int end = array.Length - 1;
// 		while (start < end) {	
// 			int currentSum = array[start] + array[end];
// 			if(currentSum == targetSum) {
// 				return new int[] {array[start], array[end]};
// 			}
// 			else if (currentSum < targetSum) {
// 				start++;
// 			}
// 			else if (currentSum > targetSum){
// 				end--;
// 			}
// 		}
// 		return new int[0];
// 	}
// }

