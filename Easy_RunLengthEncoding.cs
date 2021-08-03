using System;
using System.Linq;

public class Program {
	public string RunLengthEncoding(string str) {
		
		var result = "";
		var count = 1;
		if (str.Length == 1) {
			return "1" + str;
		}
		for (var i = 1; i < str.Length; i++) {
			if (str[i] == str[i-1]) {
				count++;
				if (i == (str.Length - 1)){
				  if (count > 9) {
					  var remainder = count % 9;
				    var numOfNines = Convert.ToInt32(Math.Floor(Convert.ToDouble(count/9)));
				    var n = ("9" + str[i-1]);
				    var nineStr = string.Concat(Enumerable.Repeat(n, numOfNines));
				    result += (nineStr + remainder.ToString() + str[i-1]);
				  }
					else {
						result += count.ToString() + str[i-1];
					}
			  }
			}
			else if (count > 9) {
				var remainder = count % 9;
		    var numOfNines = Convert.ToInt32(Math.Floor(Convert.ToDouble(count/9)));
		    var n = ("9" + str[i-1]);
		    var nineStr = string.Concat(Enumerable.Repeat(n, numOfNines));
				result += (nineStr + remainder.ToString() + str[i-1]);
		    count = 1;
				if (i == (str.Length - 1)) {
					result += ("1" + str[i]);
			  }				
			}
			else {
				result += count.ToString() + str[i-1];
				count = 1;
				if (i == (str.Length - 1)) {
					result += ("1" + str[i]);
			  }				
			}
		}
		return result;
	}
}

// https://www.algoexpert.io/questions/Run-Length%20Encoding
