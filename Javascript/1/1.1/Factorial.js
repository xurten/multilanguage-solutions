function calculateFactorial(n){
    var initFactorialValue = 1;
    for(var index = 1;index<=n; index++)
    {
        initFactorialValue*=index;
    }
    return initFactorialValue;
}

console.log(calculateFactorial(5));