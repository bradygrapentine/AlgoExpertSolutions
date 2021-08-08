using System;
using System.Collections.Generic;
using System.Linq;

public class Program {
	public static List<int[]> ThreeNumberSum(int[] array, int targetSum) {
		var result = new List<int[]>();
		Array.Sort(array);
		for (var i = 0; i < array.Length; i++) {
			var left = i+1;
			var right = array.Length-1;
			while (right > left && right > i) {
				if ((array[i] + array[right] + array[left]) == targetSum) {
					var addition = new int[] {array[i], array[left], array[right]};
					result.Add(addition);
					right--;
					left++;
				} else if ((array[i] + array[right] + array[left]) > targetSum) {
					right--;
				} else if ((array[i] + array[right] + array[left]) < targetSum) {
					left++;
				}
			}
		}
		return result;
	}
}

// https://www.algoexpert.io/questions/Three%20Number%20Sum
