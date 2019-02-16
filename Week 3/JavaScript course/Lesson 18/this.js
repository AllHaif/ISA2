/* var car = {
    make: "bmw",
    model: "745li",
    year: 2010,
    getPrice: function () {
      return 5000;
    },
    printDescription: function() {
      console.log(this.make + ' ' + this.model);
    }
  }

car.printDescription();

function first() {
    return this;
}

console.log(first() === global);

function second() {
    'use strict';

    return this;
}

console.log(second() === global);
console.log(second() === undefined); */

let myObject = { value: 'My Object' };
global.value = 'Global object';

function third(name) {
    return this.value + name;
}

//console.log(third());

/* Both call and apply allow you to explicitly set
what you want to represent 'this'.  The difference
is in how additional arguments to the function
are sent. */

console.log(third.call(myObject, 'bob'));
console.log(third.apply(myObject, ['bob']));

