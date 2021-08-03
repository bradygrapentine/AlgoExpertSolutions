using System;
using System.Linq;
using System.Collections.Generic;

public class Program {

	public int TandemBicycle(int[] redShirtSpeeds, int[] blueShirtSpeeds, bool fastest) {
		var count = 0;
		var sum = 0;
		if (fastest) {
			var blueSortedMax = blueShirtSpeeds.OrderBy(num => num).ToList();
		    var redSortedDescendingMax = redShirtSpeeds.OrderByDescending(num => num).ToList();
			while (count < redShirtSpeeds.Length) {
				sum += Math.Max(blueSortedMax[count], redSortedDescendingMax[count]);
				count++;
			}
			return sum;
		}
		else {
			var blueSortedMin = blueShirtSpeeds.OrderBy(num => num).ToList();
		    var redSortedMin = redShirtSpeeds.OrderBy(num => num).ToList();
			while (count < redShirtSpeeds.Length) {
				sum += Math.Max(blueSortedMin[count], redSortedMin[count]);
				count++;
			}
			return sum;
		}
	}
}

// https://www.algoexpert.io/questions/Tandem%20Bicycle
