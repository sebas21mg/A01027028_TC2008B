function newReversedArray(array) {
  let newNums = [];
  array.forEach(n => newNums.unshift(n));
  return newNums;
}

function reverseArray(array) {

  for (let i = 0; i < array.length; i++) {
    array.splice(array.length - i, 0, array[0]);
    array.shift();
  }

}

document.querySelector("#ejercicio1").addEventListener("click", () => {
  let nums = [15, 34, 8, 24, 1];
  alert("Array original: " + nums);

  let newNums = newReversedArray(nums);
  alert("Nuevo array: " + newNums);

  reverseArray(nums);
  alert("Mismo array invertido: " + nums);
});

function quitaDuplicados(array) {
  return array.filter((item, i) => array.indexOf(item) === i);
}

let numsRepetidos = [9, 3, 3, 3, 9, 1, 3, 1, 0, 1, 1, 0, 0];
let numsNoRepetidos = quitaDuplicados(numsRepetidos);
console.log("Array con números repetidos: " + numsRepetidos);
console.log("Arary con números sin repetir: " + numsNoRepetidos);
