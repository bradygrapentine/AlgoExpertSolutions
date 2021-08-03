public class Program {
	public static int[] InsertionSort(int[] array) {
		var end = 1;
		while (end < array.Length) {
			for (var current = end; current > 0; current--) {
				var currentDuplicate = array[current];
				if (array[current] < array[current-1]){
					array[current] = array[current-1];
					array[current-1] = currentDuplicate;
				}
			}
			end++;
		}
		return array;
	}
}

// https://www.algoexpert.io/questions/Insertion%20Sort
