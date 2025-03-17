function isPalindrome(num) {
    const str = num.toString();
    const reversedStr = str.split('').reverse().join('');
    return str === reversedStr;
}

function checkTwoPalindromes(num1, num2) {
    if (isPalindrome(num1) && isPalindrome(num2)) {
        console.log(`${num1} and ${num2} both are palindromes.`);
    } else if (isPalindrome(num1)) {
        console.log(`${num1} is a palindrome, but ${num2} is not.`);
    } else if (isPalindrome(num2)) {
        console.log(`${num2} is a palindrome, but ${num1} is not.`);
    } else {
        console.log(`Neither ${num1} nor ${num2} is a palindrome.`);
    }
}


checkTwoPalindromes(121, 12321); 
checkTwoPalindromes(121, 123); 
checkTwoPalindromes(123, 456);   
