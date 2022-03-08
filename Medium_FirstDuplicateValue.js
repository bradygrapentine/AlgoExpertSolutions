function firstDuplicateValue(array) {
	let numbers = {};
	for (let i = 0; i < array.length; i++) {
		if (numbers[array[i]]) {
			return array[i];
		} else {
			numbers[array[i]] = true;
		}
	}
	return -1;
}
