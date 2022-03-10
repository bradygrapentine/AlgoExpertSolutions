function moveElementToEnd(array, toMove) {
	let newArr = array.filter(t => t !== toMove)
	let count = array.length - newArr.length
	newArr.push(...Array(count).fill(toMove))
	return newArr
}

// https://www.algoexpert.io/questions/Move%20Element%20To%20End
