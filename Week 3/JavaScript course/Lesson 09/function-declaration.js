function sayHello(){
    console.log('Hello!');
}
/*
function sayHello(name){
    console.log('Hello ' + name + '!');
}
*/
//sayHello('Ruben');

//overloaded functions do not work in JavaScript

sayHello(); 
let a = sayHello;
a();

function calculateTax(amount) {
    let result = amount * 0.0825;
    return result;
}

let tax = calculateTax(100);
console.log(tax);