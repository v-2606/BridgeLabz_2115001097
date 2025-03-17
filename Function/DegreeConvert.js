const readline = require('readline-sync');


function celsiusToFahrenheit(celsius) {
    return (celsius * 9 / 5) + 32;
}

function fahrenheitToCelsius(fahrenheit) {
    return (fahrenheit - 32) * 5 / 9;
}


const choice = parseInt(readline.question("Choose Conversion: \n1. Celsius to Fahrenheit \n2. Fahrenheit to Celsius \nEnter your choice: "));

switch (choice) {
    case 1:
        const celsius = parseFloat(readline.question("Enter Temperature in Celsius (0°C to 100°C): "));
        if (celsius >= 0 && celsius <= 100) {
            console.log(`Temperature in Fahrenheit: ${celsiusToFahrenheit(celsius)}°F`);
        } else {
            console.log(" Invalid Input! Enter between 0°C to 100°C.");
        }
        break;

    case 2:
        const fahrenheit = parseFloat(readline.question("Enter Temperature in Fahrenheit (32°F to 212°F): "));
        if (fahrenheit >= 32 && fahrenheit <= 212) {
            console.log(`Temperature in Celsius: ${fahrenheitToCelsius(fahrenheit)}°C`);
        } else {
            console.log(" Invalid Input! Enter between 32°F to 212°F.");
        }
        break;

    default:
        console.log(" Invalid Choice! Please select 1 or 2.");
}
