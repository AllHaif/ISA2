function one() {
    return 'one';
}

function two() {
    return function () {
        console.log('two');
    }
}

function three() {
    return function() {
        return 'three';
    }
}

console.log(three()); //returns a function
console.log(three()()); //returns a value