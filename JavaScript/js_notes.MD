# JavaScript

## [JSDoc](https://jsdoc.app/)
JSDoc is used to help programmers have a better understanding of the code. As JS is a loosely typed language the JSDoc can be used to help indicate the expected type(s) being passed into a function, or the type returned.

## Arrays
Arrays in JS are of type 'object'.  

They can store multiple different types within an array. For example, you can have it like the following:  
`var multiTypeArray = [0, 1, "two", function () { return 3; }, {value1: 4, value2: 5}, [6, 7]];`  

There are multiple ways to add values to an array. If you have an array like `var array = [];` you can add values the following ways:  
1. Assign a value to a specified index i.e. `array[0] = 1;`  
    If your array has a length of one and you try to add a value at the index position five (`array[5] = 10;`), this will not cause an error with the code. The value will be successfully inserted at that index and all the values in the unspecified indexes will have no values in them. They will be empty, for example it would look like **[ 1, , , , 10 ]**
2. Push the value which will insert a value in the next incremented index position: `array.push(3);`  
    The array will then look like **[ 1, , , , 10, 3 ]**

## Learning Material
[JavaScript Koans](https://github.com/mrdavidlaing/javascript-koans) - Useful hands on introductory tasks.