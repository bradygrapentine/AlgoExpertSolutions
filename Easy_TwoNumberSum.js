function twoNumberSum(array, targetSum) {
	array = array.sort((a,b) => a-b)
	let right = array.length-1
	let left = 0
	let result = []
	while (left < right) {
		if (array[left] + array[right] === targetSum) {
			result.push(array[left])
			result.push(array[right])
			break
		}
		else if (array[left] + array[right] < targetSum) {
			left++
		}
		else {
			right--
		}
	}
	return result
}

// https://www.algoexpert.io/questions/Two%20Number%20Sum

