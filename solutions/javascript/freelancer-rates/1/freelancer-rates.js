// @ts-check

export function dayRate(ratePerHour) {
  return ratePerHour * 8;
}

export function daysInBudget(budget, ratePerHour) {
  return Math.floor(budget / dayRate(ratePerHour));
}

export function priceWithMonthlyDiscount(ratePerHour, numDays, discount) {
  var months = Math.floor(numDays / 22);
  var remainingDays = numDays % 22;
  var monthsRate = months * 22 * (1-discount);

  return Math.ceil((remainingDays + monthsRate) * dayRate(ratePerHour));
}
