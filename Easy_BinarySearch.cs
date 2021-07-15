using System;

public class Program {
	public static int BinarySearch(int[] array, int target) {
		var result = -1;
	        var searching = true;
	        var start = 0;
	        var end = array.Length - 1;
	        var midpoint = Convert.ToInt32((array.Length - 1) / 2);

	        while(searching) {
		
                // ---------------------------------------------- // 
			if (array[midpoint] == target) {
				searching = false;
			        result = midpoint;
			}
			else if (array[end] == target) {
				searching = false;
			        result = end;
		        }
		        else if (array[start] == target) {
			        searching = false;
			        result = start;
		        }
		
		// ---------------------------------------------- // 
		
		        start = (array[midpoint] < target) ? midpoint : start;
		        end = (array[midpoint] > target) ? midpoint : end;
		        midpoint = Convert.ToInt32((start + end) / 2);
		
		// ---------------------------------------------- // 
		
		        if (start + 1 == end) {
				searching = false;
		        }
		
		// ---------------------------------------------- // 
		
	        }
	        return result;
	}
}

// https://www.algoexpert.io/questions/Binary%20Search
