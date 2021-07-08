using System;
using System.Linq;

public class Program {

	public int MinimumWaitingTime(int[] queries) {
		Array.Sort(queries);
		var result = 0;
		var timeForLastQuery = 0;
		for (var i = 1; i < queries.Length; i++) {
			timeForLastQuery = queries.ToList().GetRange(0,i).Sum();
			result += timeForLastQuery;
		}
		return result;
	}
}

// https://www.algoexpert.io/questions/Minimum%20Waiting%20Time
