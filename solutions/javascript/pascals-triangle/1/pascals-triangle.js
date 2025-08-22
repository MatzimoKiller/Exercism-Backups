//
// This is only a SKELETON file for the 'Pascals Triangle' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const rows = (n) => {
  let triangle = [];

  for (let i = 0; i < n; i++) {
    if (i === 0){
      triangle.push([1]);
    }
    else{
      let row = [];
      for (let j = 0; j <= i; j++) {
        row.push((triangle[i-1][j] || 0) + (triangle[i-1][j-1] || 0 ));
      }
      triangle.push(row);
    }
  }

  return triangle;
};
