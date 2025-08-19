//
// This is only a SKELETON file for the 'Raindrops' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const convert = (number) => {
  if(number % 3 != 0 && number % 5 != 0 && number % 7 != 0)
    return ""+number;

  let result = "";
  result += number % 3 == 0 ? "Pling" : "";
  result += number % 5 == 0 ? "Plang" : "";
  result += number % 7 == 0 ? "Plong" : "";
  return result;
}
