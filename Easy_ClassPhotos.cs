using System.Collections.Generic;
using System;
using System.Linq;


public class Program {

	public bool ClassPhotos(List<int> redShirtHeights, List<int> blueShirtHeights) {
		
		var back = new List<int>();
		var front = new List<int>();
		
		var redSorted = redShirtHeights.OrderBy(num => num).ToList();
		var blueSorted = blueShirtHeights.OrderBy(num => num).ToList();
			
		if (redSorted.ElementAt(redShirtHeights.Count()-1) > blueSorted.ElementAt(blueShirtHeights.Count()-1)) {
			back = redSorted;
			front = blueSorted;
		}
		else {
			front = redSorted;
			back = blueSorted;
		}
		
		for (var i = 0; i < back.Count(); i++ ) {
			if (front[i] >= back[i]) {
				return false;
			}
		}
		return true;
	}
}

// https://www.algoexpert.io/questions/Class%20Photos
