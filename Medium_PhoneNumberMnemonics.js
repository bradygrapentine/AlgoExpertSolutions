const mappings = {
	'2':['a','b','c'],
	'3':['d','e','f'],
	'4':['g','h','i'],
	'5':['j','k','l'],
	'6':['m','n','o'],
	'7':['p','q','r', 's'],
	'8':['t','u','v'],
	'9':['w','x','y','z']
}

function replaceNext(phoneNumber, index) {
	let tempNums = [];
	let letters = mappings[phoneNumber[index]];
	let nextIndex;
	let result = [];
	
	for (let j = 0; j < letters.length; j++) {
		phoneNumber[index] = letters[j];
		let newNum = phoneNumber.join(''); 
		nextIndex = newNum.search(new RegExp('[2-9]'));
		tempNums.push(newNum)
	}
	
  if (nextIndex !== -1) {
		for (let i = 0; i < tempNums.length; i++) {
			result.push(...replaceNext(tempNums[i].split(''), nextIndex))
		}
	} else {
		result.push(...tempNums)
	}
	return result
}


function phoneNumberMnemonics(phoneNumber) {
	const regex = new RegExp('[2-9]');
	const firstIndex = phoneNumber.search(regex);
	if (firstIndex === -1) {
		return [phoneNumber];
	}
	return replaceNext(phoneNumber.split(''), firstIndex);
}

// https://www.algoexpert.io/questions/Phone%20Number%20Mnemonics
