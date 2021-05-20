using System;
using System.Collections.Generic;

public class Program {
	public static bool IsValidSubsequence(List<int> array, List<int> sequence) {
		var result = false;
		for (var i = 0; i < sequence.Count; i++) {
			var seqNum = sequence[i];
			var nextIdx = 0;
			for (var j = i; j < array.Count; j++) {
				if (seqNum == array[j]) {
					result = true;
					var val = array[j];
					array.RemoveAt(j);
					array.Insert(0, val);
					break;
				}
				else {
					if (j == array.Count - 1) {
						return false;
					}
				}
			}
		}
		if (sequence.Count > array.Count) {
			return false;
		}
		return result;
	}


// This code doesn't do what was asked because order matters in this problem,
// but, if we ignore whether the elements of the array and subsequence have 
// the same order, then this code works.

  public static bool IsValidSubsequence2(List<int> array, List<int> sequence) {
	  int seqIdx = 0;
		foreach(var val in array) {
	  // traverses array once to prevent code from checking earlier elements
		  if (seqIdx == sequence.Count) {
			  break;
			  // as soon as every sequence member is accounted for, the loop ends
			  // prevents double counting
		  }
		  if (sequence[seqIdx] == val) {
			  seqIdx++;
			  // increments sequence index if match found
		  }
	  }
		return seqIdx == sequence.Count;
		// if all elements of sequence matched, these should be equal
	}
  
  public static bool IsValidSubsequence3(List<int> array, List<int> sequence) {
		int arrIdx = 0;
		int seqIdx = 0;
		while (arrIdx < array.Count && seqIdx < sequence.Count) {
			if (array[arrIdx] == sequence[seqIdx]) {
				seqIdx++;
				// increment sequence index if located 
			}
			arrIdx++;
			// increment array index regardless
			// prevents code from checking earlier elements of array for matches
			// => whether a match was located or not
		}
		return seqIdx == sequence.Count;
		// if every member of sequence accounted for, these values will be equal
	}
