function powerOfTwoTable(n) {
    console.log(`Powers of 2 up to 2^${n} (max 256):`);

    for (let i = 0; i <= n; i++) {
        let result = Math.pow(2, i);
        if (result > 256) break; 
        console.log(`2^${i} = ${result}`);
    }
}


const num = parseInt(process.argv[2]);

powerOfTwoTable(num);
