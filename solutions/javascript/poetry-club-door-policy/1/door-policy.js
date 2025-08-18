// @ts-check

export function frontDoorResponse(line) {
  return line[0];
}

function capitalizeWord(word){
  let firstLetter = word[0].toUpperCase();
  let restOfTheWord = word.slice(1, word.length).toLowerCase();
  
  word = firstLetter + restOfTheWord;
  return word;
}


export function frontDoorPassword(word) {
  return capitalizeWord(word);
}

export function backDoorResponse(line) {
  line = line.trim()
  return line[line.length - 1];
}

export function backDoorPassword(word) {
  return capitalizeWord(word) + ', please' ;
}
