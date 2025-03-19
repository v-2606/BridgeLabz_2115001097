function generateBirthMonths(count) {
    let birthMonthMap = {};

    for (let i = 1; i <= count; i++) {
        let month = Math.floor(Math.random() * 12) + 1; 

        if (!birthMonthMap[month]) {
            birthMonthMap[month] = [];
        }
        birthMonthMap[month].push(`Person ${i}`);
    }

    return birthMonthMap;
}

let birthMonthGroups = generateBirthMonths(50);


console.log(" Individuals grouped by birth month:");
for (let month in birthMonthGroups) {
    console.log(`Month ${month}: ${birthMonthGroups[month].join(", ")}`);
}
