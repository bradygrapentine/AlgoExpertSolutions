function isMonotonic(arr) {
	if (arr.length > 2) {
	  let last = 0
		let current = 1
		let next = 2
	  const inc = arr[last] <= arr[current] && arr[current] <= arr[next]
	  const dec = arr[last] >= arr[current] && arr[current] >= arr[next]
		if (inc) {
		  while (arr[current] <= arr[next]) {
				if (next === arr.length-1) {
					return true
				}
				current++
				next++
		  }
	  } else if (dec) {
		  while (arr[current] >= arr[next]) {
				if (next === arr.length-1) {
					return true
				}
				current++
				next++
		  }
	  }
		return false
	}
	return true
}

// https://www.algoexpert.io/questions/Monotonic%20Array
