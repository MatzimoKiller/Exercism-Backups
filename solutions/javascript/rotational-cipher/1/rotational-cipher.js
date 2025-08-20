//
// This is only a SKELETON file for the 'Rotational Cipher' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const rotate = (str, k) => {
  let result = "";
  const alphabetMin = "abcdefghijklmnopqrstuvwxyz";
  const alphabetMay = alphabetMin.toUpperCase();

  for (let index = 0; index < str.length; index++) {
    let actualChar = str[index];
    let alphabetIndex = alphabetMin.indexOf(actualChar.toLowerCase())
    if (alphabetIndex !== -1) {
      let rotation = alphabetIndex + k >= 26 ? alphabetIndex + k - 26 : alphabetIndex + k;
      result += actualChar >= 'A' && actualChar <= 'Z' ? alphabetMay[rotation] : alphabetMin[rotation]
    }
    else{
      result += actualChar;
    }
  }
  return result;
};
