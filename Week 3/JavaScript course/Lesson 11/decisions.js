var count = 3;
if (count == 4) {
    console.log('Count is 4');
} else if (count > 4) {
    console.log('Count is greater than 4');
} else {
    console.log('Count is NOT 4');
}

count = 4;
if (count == 4){
    console.log('same value');
} else if (count === 4) {
    console.log('same value and type');
} else {
    console.log('nothing same');
}

let hero = 'Batman';
switch (hero.toLowerCase()) {
    case 'superman':
        console.log('super strength');
        break;
    case 'batman':
        console.log('fighting skills');    
        break;
    default: 
        console.log('member of JLA');
}


let a = 1, b = '1';
console.log((a === b) ? 'equal' : 'inequal');
console.log((a == b) ? 'equal' : 'inequal');
console.log((a !== b) ? 'inequal' : 'equal');