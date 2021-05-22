using System.Collections;
using System.Linq;

public class Program {

	public int[] SortedSquaredArray(int[] array) => array.Select(number => number*number).OrderBy(number => number).ToArray();
}



// using System.Collections.Generic;
// using System.Linq;
// using System;

// public class Program {

// 	public int[] SortedSquaredArray(int[] array) {
// 		// Write your code here.
// 		var result = new int[array.Length];
// 		var last = array.Length - 1;
// 		var first = 0;
// 		for (var i = array.Length-1; i >= 0; i--) {
// 			if (Math.Abs(array[last]) > Math.Abs(array[first])) 
// 			{
// 				result[i] = (array[last]*array[last]);
// 				last--;
// 			}
// 			else
// 			{
// 				result[i] =(array[first]*array[first]);
// 				first++;
// 			}
// 		}
// 		return result;
// 	}
// }

