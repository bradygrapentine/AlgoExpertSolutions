function smallestDifference(arrayOne, arrayTwo) {
	let sortedOne = arrayOne.sort((a,b) => a-b);
	let sortedTwo = arrayTwo.sort((a,b) => a-b);
	let o = 0;
	let t = 0;
	let result = [sortedOne[o], sortedTwo[t]];
	let currentDiff = Math.abs(sortedOne[o] - sortedTwo[t]);
	
	while (o < sortedOne.length && t < sortedTwo.length) {
		if (Math.abs(sortedOne[o] - sortedTwo[t]) < currentDiff) {
			currentDiff = Math.abs(sortedOne[o] - sortedTwo[t]);
		  result = [sortedOne[o], sortedTwo[t]];
		}
		if (currentDiff === 0) {
			return result;
		} else if (sortedOne[o] < sortedTwo[t]) {
			o++;
		} else {
			t++;
		}
	}
  return result
}

// https://www.algoexpert.io/questions/Smallest%20Difference
