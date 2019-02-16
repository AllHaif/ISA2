let originalCar = {
    make: 'bmw',
    model: '745li',
    year: 2010
};

let newCar = Object.create(originalCar);

newCar.make = 'audi';
console.log(newCar.make);
console.log(Object.getPrototypeOf(newCar));

let prototype = Object.getPrototypeOf(newCar);
console.log(prototype.make);

originalCar.doors = 4;
console.log(newCar.doors);

console.log(originalCar.hasOwnProperty('doors'));
console.log(newCar.hasOwnProperty('doors'));