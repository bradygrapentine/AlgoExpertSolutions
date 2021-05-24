using System;
using System.Linq;
using System.Collections;

public class Program {
	public int NonConstructibleChange(int[] coins) {
		Array.Sort(coins);
		int currentChange = 0;
		foreach (var coin in coins) {
			if (coin > currentChange + 1) {
				return currentChange + 1;
			}
			currentChange += coin;
		}
		return currentChange + 1;
	}
}


//   Loop through sorted coins and increment the maximum value 
//   that can be created.

//   The minimum amount of change that can't be created is either:
//      1) the first missing natural number (one less than the 
//         total after the first number greater than one is added 
//         to the currentChange total) --> will never be able to 
//         create because the coins are sorted
//  or, 2) one greater than the greatest value
//  or, 3) 1 if the list is empty
