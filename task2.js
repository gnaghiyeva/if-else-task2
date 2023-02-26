let t=6;
let result=1;

if(t>0 && t<=3){
    result=t*1;
}
else if(t==4 || t==5){
    result=3+((t-3)*0.8);
}
// console.log(result);
else if(t>5 && t<=8){
    result = (4.6 + ((t-5)*0.50));
}

else {
    result = (6.1 + ((t-8)*0.25 ));
}

console.log(result);


