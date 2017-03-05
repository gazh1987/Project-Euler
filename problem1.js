/*
Project Euler Problem 1
Multplies of 3 and 5
Gary Healy
 */

var ma = [3, 5]; //multiples array
var t = 1000; //target 
var m = 1; //multiplier
var s = 0; //sum
var sb = 0; //sum to subtract

s = mlt(ma, m, t, s, 0);
s = mlt(ma, m, t, s, 1);
sb = sub(m, t, sb, lcm(ma[0], ma[1]));
console.log(s - sb); //answer

//Caluclates the sum of multiples ma below t
function mlt(ma, m, t, s, i) {
	while (ma[i] * m < t) {
		s += ma[i] * m;
		m++;
	}		
	return s;
}

//The least common multiple of 3 and 5 is 15. This means all
//multiples of 15 have been counted twice. These duplicate 
//calculations need to be removed. 
function sub(m, t, sa, i){
	while (i * m < t){
		sa += i * m;
		m++;
	}		
	return sa;	
}

//Find the least common multiple
function lcm (x, y){
	return Math.abs((x * y) / gcd(x, y));
}

//Find the Greatest common divisor
function gcd (x, y){
	if (!y){
		return x;
	}
	return gcd(y, x % y);
}
