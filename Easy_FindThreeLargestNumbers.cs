using System;
using System.Linq;
using System.Collections.Generic;

public class Program {
	public static int[] FindThreeLargestNumbers(int[] array) {
		return array.OrderBy(num => num)
			          .ToList()
			          .GetRange((array.Count()-3),3)
			          .ToArray();
	}
}


using System;
using System.Linq;
using System.Collections.Generic;

public class Program {
	public static int[] FindThreeLargestNumbers(int[] array) {
		var result = new List<int>();
		var sortedArrayAsStack = new Stack<int>(array.OrderBy(num => num).ToArray());
		result.Add(sortedArrayAsStack.Pop());
		result.Add(sortedArrayAsStack.Pop());
		result.Add(sortedArrayAsStack.Pop());
		return result.OrderBy(num => num).ToArray();
	}
}

// https://www.algoexpert.io/questions/Find%20Three%20Largest%20Numbers
