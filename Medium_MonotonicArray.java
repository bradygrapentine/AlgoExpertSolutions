import java.util.*;

class Program {
  public static boolean isMonotonic(int[] arr) {
		if (arr.length > 2) {
	  int last = 0;
		int current = 1;
		int next = 2;
	  boolean inc = arr[last] <= arr[current] && arr[current] <= arr[next];
	  boolean dec = arr[last] >= arr[current] && arr[current] >= arr[next];
		if (inc) {
		  while (arr[current] <= arr[next]) {
				if (next == arr.length-1) {
					return true;
				}
				current++;
				next++;
		  }
	  } else if (dec) {
		  while (arr[current] >= arr[next]) {
				if (next == arr.length-1) {
					return true;
				}
				current++;
				next++;
		  }
	  }
		return false;
	}
	return true;
  }
}

// https://www.algoexpert.io/questions/Monotonic%20Array
