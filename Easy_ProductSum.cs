using System;
using System.Collections.Generic;
using System.Linq;

public class Program {
	public static int ProductSum(List<object> array, int mult = 1) {
		var result = 0;
		foreach (var current in array) {
			if (current.GetType().Equals(typeof(int))) {
				result += Convert.ToInt32(current);
			}
			else {
				result += Convert.ToInt32(ProductSum(current as List<object>, mult + 1));
			}
		}
		return result * mult;
	}
}

// https://www.algoexpert.io/questions/Product%20Sum
