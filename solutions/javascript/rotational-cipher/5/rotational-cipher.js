//
// This is only a SKELETON file for the 'Rotational Cipher' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const rotate = (str, k) => {
  let result = "";

  for (let i = 0; i < str.length; i++) {
    const charCode = str.charCodeAt(i);
    let rotatedCharCode = charCode; //if the char isnt a letter it remains the same
    
    if (charCode >= 65 && charCode <= 90)//Uppercase letters
      rotatedCharCode = checkRotation(charCode, k, 65);
      
    else if (charCode >= 97 && charCode <= 122) //Lowercase letters
      rotatedCharCode = checkRotation(charCode, k, 97);
      
    result += String.fromCharCode(rotatedCharCode);
  }
  return result;
};

export function checkRotation(charCode, k, lowBoundarie) {
  return charCode - lowBoundarie + k > 25 ? charCode - 26 + k : charCode + k;
}
