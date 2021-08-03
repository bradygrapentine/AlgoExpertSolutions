using System;

public class Program {
	public static bool IsPalindrome(string str) {
		var frontIdx = 0;
		var backIdx = str.Length - 1;
		while ((frontIdx - backIdx) < (str.Length - 1)) {
			if (str[frontIdx] != str[backIdx]) {
				return false;
			}
			backIdx--;
			frontIdx++;
		}
		return true;
	}
}

// https://www.algoexpert.io/questions/Palindrome%20Check
