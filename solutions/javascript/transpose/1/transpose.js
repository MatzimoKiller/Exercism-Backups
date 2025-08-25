export const transpose = (arr) => { 
  const initialRows = arr.length;
  const initialColumns = maxLength(arr)[0];
  let spikes = findSpikes(arr);
  const transposed = [];
console.log(spikes);
  
  for (let i = 0; i < initialColumns; i++) {
    let newRow = '';
    transposed.push(newRow);
  }
  
  for (let i = 0; i < initialRows; i++) {
    const word = arr[i];

    for (let j = 0; j < spikes[0]; j++) {
      if (word.length < spikes[0]) {
        //console.log('s');
        transposed[j] += (word.charAt(j) || ' ');
      }
      else{
        transposed[j] += (word.charAt(j) || '');
          //      console.log('n');

      }
    }
    if (word.length >= spikes[0]){ 
      spikes.shift();
    }    
  }
  /*
  for (let i = 0; i < initialColumns; i++) {
    let newRow = '';
    for (let j = 0; j < initialRows; j++) {
      newRow += (arr[j].charAt(i) || ' ');
    }
    
    transposed.push(newRow);
  }

  //clean right paddings
  for (let i = initialColumns; i < initialColumns; i++) {
    let newRow = '';
    for (let j = 0; j < initialRows; j++) {
      newRow += (arr[j].charAt(i) || (' ');
    }
    
    transposed.push(newRow);
  }
*/

  
  return transposed;
};

export function maxLength(arr) {
  let result = [];
  let max = -1;
  let index = -1;
  for (let i = 0; i < arr.length; i++) {
    if (max < arr[i].length) {
      max = arr[i].length;
      index = i;
    }
  }

  result.push(max, index);
  return result;
}

export function findSpikes(arr) {
  let result = [];
  let arrCopy = structuredClone(arr);

  while (maxLength(arrCopy)[0] != -1) {
    result.push(maxLength(arrCopy)[0]);
    arrCopy.splice(0, maxLength(arrCopy)[1] + 1);
  }
  return result; 
}


