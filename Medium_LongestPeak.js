function longestPeak(array) {
	if (array.length >= 3) {
	  let peakLength = 0
		let incCount = 0
	  for (let i = 1; i < array.length; i++) {
			let tempPeakLength = 0
			if (array[i] > array[i-1]) {
				incCount++
				if (array[i] > array[i+1]) {
				  tempPeakLength = incCount + 2
				  incCount = 0
				  for (let h = i+1; h < array.length; h++) {
					  if (array[h] > array[h+1]) {
						  tempPeakLength++
					  } else {
						  i = h
							peakLength = tempPeakLength > peakLength ? tempPeakLength : peakLength
						  break
					  }
				  }
			  }
			} else if (array[i] === array[i-1]) {
				incCount = 0
			}
	  }
		return peakLength
	}
	return 0
}

// https://www.algoexpert.io/questions/Longest%20Peak
