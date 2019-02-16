let a, b, c, d, e;
let others;

let names = ['david', 'eddie', 'ruben', 'bob', 'rob'];
/* [a, b, c, e, d] = names;

console.log(a);
console.log(b);
console.log(c);
console.log(d);
console.log(e); */

/* [a, b, ...others] = names;
console.log(a);
console.log(b);
console.log(others); */

let year, model;
 ({year, model} = {
    make: 'bmw',
    model: '745li',
    year: 2010,
    value: 5000
 });

 console.log(year);
 console.log(model);