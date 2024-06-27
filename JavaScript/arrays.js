var arrayOne = [];
var arrayTwo = [0, 1, 2, "hello", undefined, []];

console.log("The length of arrayOne is " + arrayOne.length);
console.log("The length of arrayTwo is " + arrayTwo.length);

console.log("The types contained in arrayOne are: " + printUniqueTypesContainedInArray(arrayOne));
console.log("The types contained in arrayTwo are: " + printUniqueTypesContainedInArray(arrayTwo));

arrayOne[5] = "Why am I inserting a value here"
console.log("After inserting a value in arrayOne it now looks like '" + arrayOne + "'");
console.log("The types contained in arrayOne are: " + printUniqueTypesContainedInArray(arrayOne));

/**
 * @param {Array} array
 * @returns {Array}
 */
function printUniqueTypesContainedInArray(array)
{
    var types = []
    array.forEach(element => {
        var type = typeof(element);
        if(!types.includes(type)){
            types.push(type)
        }
    });

    return types
}