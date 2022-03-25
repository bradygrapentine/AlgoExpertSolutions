function hasSingleCycle(array) {
	let jumps = 0
	let i = 0
	let visited = {}
	while (jumps <= array.length) {
		if (!visited[i]) {
		  visited[i] = 1
			i = (array[i] + i) % array.length < 0 ? 
				  (array.length + ((array[i] + i) % array.length)) : 
			    (array[i] + i) % array.length;
			jumps++
		} else if (i === 0 && jumps == array.length) {
			  return true
		} else {
			return false
		}
	}
}

 // https://www.algoexpert.io/questions/Single%20Cycle%20Check
