function binarySearch(array, target) {
	let result = -1
	let searching = true
	let start = 0
	let end = array.length - 1
	let midpoint = Math.floor((array.length - 1) / 2)

	while(searching) {
		
    // ---------------------------------------------- // 
		
		if (array[midpoint] === target) {
			searching = false
			result = midpoint
		}
		else if (array[end] === target) {
			searching = false
			result = end
		}
		else if (array[start] === target) {
			searching = false
			result = start
		}
		
		// ---------------------------------------------- // 
		
		start = (array[midpoint] < target) ? midpoint: start
		end = (array[midpoint] > target) ? midpoint: end
		midpoint = Math.floor((start + end) / 2)
		
		// ---------------------------------------------- // 
		
		if (start + 1 === end) {
			searching = false
		}
		
		// ---------------------------------------------- // 
		
	}
	return result
}

// https://www.algoexpert.io/questions/Binary%20Search

