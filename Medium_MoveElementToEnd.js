function moveElementToEnd(array, toMove) {
	let newArr = array.filter(t => t !== toMove)
	let count = array.length - newArr.length
	newArr.push(...Array(count).fill(toMove))
	return newArr
}

// function moveElementToEnd(array, toMove) {
//   let start = 0
// 	let end = array.length-1
// 	while (start < end) {
// 		if (array[start] === toMove && array[end] !== toMove) {
// 			let temp = array[start]
// 			array[start] = array[end]
// 			array[end] = temp
// 			start++
// 		  end--
// 		} else if (array[start] !== toMove) {
// 			start++
// 		} else if (array[end] === toMove) {
// 			end--
// 		}
// 	}
// 	return array
// }

// https://www.algoexpert.io/questions/Move%20Element%20To%20End
