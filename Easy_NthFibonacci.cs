using System;
using System.Collections.Generic;
using System.Linq;

public class Program {
	public static int GetNthFib(int n) {
		if (n == 1) {
			return 0;
		}
		else if (n == 2) {
			return 1;
		}
		else {
			var secondLast = 0;
			var last = 1;
			var lastLast = 1;
			for ( var i = 1; i < n-1; i++ ) {
				lastLast = last;
				last = secondLast + last;
				secondLast = lastLast;
			}
			return last;
		}
	}
}

// https://www.algoexpert.io/questions/Nth%20Fibonacci
