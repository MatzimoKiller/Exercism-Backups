//
// This is only a SKELETON file for the 'Rotational Cipher' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const rotate = (str, k) => {
  let result = "";
  const alphabetMin = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";
  const alphabetMay = alphabetMin.toUpperCase();

  for (let index = 0; index < str.length; index++) {
    let actualChar = str[index];
    let alphabetIndex = alphabetMin.indexOf(actualChar.toLowerCase());
    
    if (alphabetIndex !== -1) {
      let charIsMayus = actualChar >= 'A' && actualChar <= 'Z';
      result += charIsMayus ? alphabetMay[alphabetIndex+k] : alphabetMin[alphabetIndex+k];
    }
    else{
      result += actualChar;
    }
  }
  return result;
};
