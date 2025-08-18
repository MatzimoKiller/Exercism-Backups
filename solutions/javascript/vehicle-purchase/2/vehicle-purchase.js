// @ts-check

export function needsLicense(kind) {
  return kind === 'car' || kind === 'truck';
}

export function chooseVehicle(option1, option2) {
  let choice = option1 < option2 ? option1 : option2
  return choice + ' is clearly the better choice.';
}

export function calculateResellPrice(originalPrice, age) {
  let multiplier = 0.7
  
  if (age < 3)
    multiplier = 0.8;

  if (age > 10)
    multiplier = 0.5;
  
  return originalPrice * multiplier;
}
