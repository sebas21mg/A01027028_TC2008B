function newReversedArray(nums) {
  let newNums = [];
  nums.forEach(n => newNums.unshift(n));
  return newNums;
}

function reverseArray(nums) {

  for (let i = 0; i < nums.length; i++) {
    nums.splice(nums.length - i, 0, nums[0]);
    nums.shift();
  }

}

let nums = [15, 34, 8, 24, 1];
console.log("Array original: " + nums);

let newNums = newReversedArray(nums);
console.log("Nuevo array: " + newNums);

reverseArray(nums);
console.log("Mismo array invertido: " + nums);