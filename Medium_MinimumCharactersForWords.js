function minimumCharactersForWords(words) {
	let chars = {};
	for (let i = 0; i < words.length; i++) {
		let charsForWord = {}
		for (let j = 0; j < words[i].length; j++) {
			if (charsForWord[words[i][j]]) {
				charsForWord[words[i][j]]++
			} else {
				charsForWord[words[i][j]] = 1
			}
		}
		Object.keys(charsForWord).map(key => {
			if (chars[key]) {
				if (charsForWord[key] > chars[key]) {
				  chars[key] = charsForWord[key]	
				}
			} else {
				chars[key] = charsForWord[key]
			}
		})
	}
	
	let result = []
	Object.keys(chars).map(key => {
    for (let i = 0; i < chars[key]; i++) {
			result.push(key)
		}
	})
	
	return result
}

// https://www.algoexpert.io/questions/Minimum%20Characters%20For%20Words
