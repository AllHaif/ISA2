let myString = new String('howdy');
console.log(myString); // [String: 'howdy']
console.log(myString.toString()); // howdy
console.log(typeof myString); // object

let myPrimitive = 'THIS IS CRAZY';
console.log(typeof myPrimitive); // string
myPrimitive = myPrimitive.toLowerCase();
console.log(typeof myPrimitive); // string

let myNumber = new Number(7);
console.log(typeof myNumber); //object
myPrimitive = myNumber.valueOf();
console.log(typeof myPrimitive); //number