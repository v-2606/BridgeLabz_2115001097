const readline = require('readline-sync');

function isPrime(num) {
    if (num <= 1) return false;
    for (let i = 2; i <= Math.sqrt(num); i++) {
        if (num % i === 0) {
            return false;
        }
    }
    return true;
}


function getPalindrome(num) {
    const str = num.toString();
    const reversedStr = str.split('').reverse().join('');
    return parseInt(reversedStr);
}


function checkPrimeAndPalindrome(num) {
    if (isPrime(num)) {
        const palindrome = getPalindrome(num);
        if (isPrime(palindrome)) {
            console.log(`${num} is prime and its palindrome ${palindrome} is also prime.`);
        } else {
            console.log(`${num} is prime but its palindrome ${palindrome} is not prime.`);
        }
    } else {
        console.log(`${num} is not a prime number.`);
    }
}


const number = parseInt(readline.question("Enter a number: "));
checkPrimeAndPalindrome(number);
