
var andreacs = [3,8,7,25,26,2,13];
var b = 0;
for(var i=0;i<andreacs.length;i++)
{
if(andreacs[i]!=0)
{
if((andreacs[i] % 2) == 0){
console.log("es par el numero: ",andreacs[i]);
}else{
if((andreacs[i] % 2) == 1){
console.log("es impar el numero: ",andreacs[i]);
}
}
}
}

for(var i=0;i<andreacs.length;i++)
{
if(andreacs[i]!=0)
{
for(var j=1; j<=andreacs[i]; j++){
if((andreacs[i] % j) == 0){
b++;
}
}
if(b==2){
console.log(" es primo el numero: ",andreacs[i]);
b=0;
}else{
//console.log("no es  primo ", andreacs[i]);
b=0;
}
}
}

