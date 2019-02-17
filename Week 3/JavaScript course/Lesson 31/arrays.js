let names = [ 'david', 'eddie', 'alex', 'michael' ];
let others = [ 'sammy', 'gary', 'wolfgang', 'mark'  ]

let lost = [ 4, 8, 15, 16, 23, 42 ];
let fibonacci = [ 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 ];

var combine = lost.concat(fibonacci);

console.log(fibonacci.join('~'));

console.log(lost.shift());

lost.unshift(1, 2, 3, 4);

console.log(names.reverse());
console.log(names.sort());

console.log(others.indexOf('mark'));

console.log(combine.lastIndexOf(1));

var filtered = combine.filter((x) => { if (x <= 15) return x; }  );

names.forEach((name) => console.log(`howdy ${name}`)  );

console.log(filtered.every((num) => num < 10 ));
console.log(filtered.every((num) => num < 16 ));

console.log(fibonacci.some((num) => num > 50 ));
console.log(fibonacci.some((num) => num > 100 ));