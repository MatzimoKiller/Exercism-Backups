//
// This is only a SKELETON file for the 'Gigasecond' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const gigasecond = (date) => {
  const gsDate = new Date();
  const oneGigaSecondInMs = 1000000000 * 1000
  gsDate.setTime(date.getTime() + oneGigaSecondInMs);

  return gsDate;
};
