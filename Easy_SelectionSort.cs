using System;
using System.Collections.Generic;
using System.Linq;

public class Program {
	public static int[] SelectionSort(int[] array) {
		var result = new List<int>();
		var arrayAsList = array.ToList();
		var least = 0;
		while (result.Count() < array.Length) {
			for (var i = 0; i < arrayAsList.Count(); i++) {
			  if (arrayAsList[i] <= arrayAsList[least]) {
				  least = i;
			  }
				// Console.WriteLine("Current: " + arrayAsList[i] + ", Index: " + i + ", Least: " + arrayAsList[least] + ", Least Index: " + least);
		  }
			// Console.WriteLine("Least: " + arrayAsList[least]);
			result.Add(arrayAsList[least]);
			arrayAsList.RemoveAt(least);
			// Console.WriteLine("Count: " + arrayAsList.Count());
			least = 0;
		}
	  return result.ToArray();
	}
}

// https://www.algoexpert.io/questions/Selection%20Sort
