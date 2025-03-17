function printPowersOfTwo(n) {
    console.log(`Table of powers of 2 up to 2^${n}:`);
    for (let i = 0; i <= n; i++) {
        console.log(`2^${i} = ${Math.pow(2, i)}`);
    }
}


const n = parseInt(process.argv[2]);
printPowersOfTwo(n);
