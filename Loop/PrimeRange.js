function isPrime(num) {
    if (num <= 1) {
        return false;
    }
    for (let i = 2; i <= Math.sqrt(num); i++) {
        if (num % i === 0) {
            return false;
        }
    }
    return true;
}

function primeInRange(start, end) {
    console.log(`Prime numbers between ${start} and ${end} are:`);
    for (let i = start; i <= end; i++) {
        if (isPrime(i)) {
            console.log(i);
        }
    }
}


const start = parseInt(process.argv[2]);
const end = parseInt(process.argv[3]);

primeInRange(start, end);
