using System;
using System.Linq;

public class Program {
	public static int KadanesAlgorithm(int[] array) {
    var currentSum = array[0];
    var maxSum = currentSum;
    for (var i = 1; i < array.Length; i++)
    {
      currentSum = Math.Max(array[i], array[i] + currentSum);
      maxSum = Math.Max(currentSum, maxSum);
    }
    return maxSum;
  }
}

// https://www.algoexpert.io/questions/Kadane's%20Algorithm
