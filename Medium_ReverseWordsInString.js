function reverseWordsInString(string) {
	let result = []
	const regExp1 = new RegExp('[^ ]+', "g")
	const words = [...string.matchAll(regExp1)]
	const regExp2 = new RegExp('[ ]+', "g")
	const spaces = [...string.matchAll(regExp2)]
	if (words.length === 0 && spaces.length === 1) {
		return `${spaces[0]}`
	}
	for (let i = 0; i < words.length; i++) {
		if (i === words.length-1 && words.length > 1) {
			result.unshift(words[i])
		} else {
			result.unshift(spaces[i], words[i])
		}
	}
	return result.join('')
}

// https://www.algoexpert.io/questions/Reverse%20Words%20In%20String
