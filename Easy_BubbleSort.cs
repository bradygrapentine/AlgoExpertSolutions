using System;
using System.Linq;

public class Program {
	public static int[] BubbleSort(int[] array) {
		
		var swaps = false;
		var loopLengthMinusOne = array.Length-1;
		// ------------------------------------------//
		for (var i = 0; i < loopLengthMinusOne; i++) 
		{
		  var current = array[i];
			if (current > array[i+1]) 
			{
				array[i] = array[i+1];
				array[i+1] = current;
			  swaps = true;
		  }
			if (i == (loopLengthMinusOne-1) && swaps) 
			{
				i = -1;
				loopLengthMinusOne -= 1;
				swaps = false;
			}
		}
		// ---------- //
	  return array;
		
  }
}

// https://www.algoexpert.io/questions/Bubble%20Sort
