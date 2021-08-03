using System;
using System.Linq;
using System.Collections.Generic;

public class Program {

	public int FirstNonRepeatingCharacter(string str) {
		Dictionary<char, int> chrDict = new Dictionary<char,int>();
		foreach (var chr in str) 
		{
			if (chrDict.ContainsKey(chr)) {
				chrDict[chr] += 1;
			} 
			else {
				chrDict[chr] = 1;
			}
		}
		for (var i = 0; i < str.Length; i++) 
		{
			if (chrDict[str[i]] == 1) {
				return i;
			}
		}
		return -1;
	}
}

// https://www.algoexpert.io/questions/First%20Non-Repeating%20Character
