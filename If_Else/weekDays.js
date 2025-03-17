function getWeekday(num) {
    const days = [
        "Sunday", "Monday", "Tuesday", 
        "Wednesday", "Thursday", "Friday", "Saturday"
    ];

    if (num >= 0 && num <= 6) {
        console.log(days[num]);
    } else {
        console.log("Invalid input. Please enter a number between 0 and 6.");
    }
}

const input = process.argv[2]; 
getWeekday(input);
