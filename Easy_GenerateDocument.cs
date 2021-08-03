using System;
using System.Collections.Generic;
using System.Linq;

public class Program {

	public bool GenerateDocument(string characters, string document) {
		var splitCharacters = characters.ToCharArray().ToList();
		var splitDocument = document.ToCharArray().ToList();
		foreach (var character in splitDocument) {
			if (!(splitCharacters.Contains(character))) {
				return false;
			}
			splitCharacters.Remove(character);
		}
		return true;
	}
}

// https://www.algoexpert.io/questions/Generate%20Document
