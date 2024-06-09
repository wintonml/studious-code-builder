// Strings - Learning from https://learnjavascript.online/app.html
// They can be represented by using 'single quotes' and "double quotes"
console.log("This is printed using double quotes.")
console.log('This is printed using single quotes.')

/**
 * @param {string} text
 */
function uppercaseTheString(text)
{
    return text.toUpperCase();
}

console.log(uppercaseTheString("can this be made uppercase?"))