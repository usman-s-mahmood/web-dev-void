const myFun = () => {
    let val1 = parseInt(document.getElementById('value1').value),
        val2 = parseInt(document.getElementById('value2').value),
        op = document.getElementById('op').value,
        res = null;
    if (op === '+')
        res = val1+val2;

    else if (op === '-')
        res = val1-val2;

    else if (op === '*')
        res = val1*val2;

    else if (op === '/')
        res = val1/val2;

    else if (op === '%')
        res = val1%val2;

    alert(`Result of ${val1} ${op} ${val2} = ${res}`);
}