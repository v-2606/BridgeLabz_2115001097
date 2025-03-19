function findSecondLargestAndSmallest(arr) {
    let largest = -Infinity, secondLargest = -Infinity;
    let smallest = Infinity, secondSmallest = Infinity;

    for (let num of arr) {
 
        if (num > largest) {
            secondLargest = largest;
            largest = num;
        } else if (num > secondLargest && num !== largest) {
            secondLargest = num;
        }

      
        if (num < smallest) {
            secondSmallest = smallest;
            smallest = num;
        } else if (num < secondSmallest && num !== smallest) {
            secondSmallest = num;
        }
    }

    return { secondLargest, secondSmallest };
}


let numbers = Array.from({ length: 10 }, () => Math.floor(Math.random() * 900) + 100);

console.log("Generated Numbers:", numbers);

const { secondLargest, secondSmallest } = findSecondLargestAndSmallest(numbers);
console.log("Without Sorting - Second Largest:", secondLargest);
console.log("Without Sorting - Second Smallest:", secondSmallest);


numbers.sort((a, b) => a - b);
console.log("Sorted Numbers:", numbers);


let sortedSecondSmallest = numbers[1];
let sortedSecondLargest = numbers[numbers.length - 2];

console.log("With Sorting - Second Largest:", sortedSecondLargest);
console.log("With Sorting - Second Smallest:", sortedSecondSmallest);
