let pattern = /xyz/;
console.log(pattern); // /xyz/
console.log(typeof pattern); // object

let value = 'This is xyz a test.';

console.log(pattern.test(value));
console.log(value.replace(pattern, 'just'));

console.log(value.match(pattern));
var match = value.match(pattern);
console.log(match.index);