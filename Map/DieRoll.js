function rollDice() {
    return Math.floor(Math.random() * 6) + 1; // Generate number between 1-6
}

function rollUntilLimit(limit) {
    let diceResults = { 1: 0, 2: 0, 3: 0, 4: 0, 5: 0, 6: 0 };

    while (true) {
        let roll = rollDice();
        diceResults[roll]++; // Increment the count for the rolled number

        // Stop if any number reaches the limit
        if (diceResults[roll] === limit) {
            break;
        }
    }

    return diceResults;
}

function findMinMax(results) {
    let maxNum = null, minNum = null;
    let maxCount = 0, minCount = Infinity;

    for (let num in results) {
        if (results[num] > maxCount) {
            maxCount = results[num];
            maxNum = num;
        }
        if (results[num] < minCount) {
            minCount = results[num];
            minNum = num;
        }
    }

    return { maxNum, maxCount, minNum, minCount };
}


let diceResults = rollUntilLimit(10);
console.log("Dice Roll Results:", diceResults);

// Finding max and min occurrence
let { maxNum, maxCount, minNum, minCount } = findMinMax(diceResults);
console.log(`Number with max rolls: ${maxNum} (${maxCount} times)`);
console.log(`Number with min rolls: ${minNum} (${minCount} times)`);
