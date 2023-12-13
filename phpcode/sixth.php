<?php
function welcomeMessage(){
    print 'Welcome to Our Page<br>';
}

welcomeMessage();

print '<br>';

function welcomeUser($name){
    print 'Welcome to Our Page, '.$name.'<br>';
}

welcomeUser("John");

print '<br>';

function addTwo($num1, $num2){
    return $num1 + $num2;
}

print addTwo(3,4);

print '<br>';

function subTwo($num1 = 10, $num2 = 6){
    return $num1 - $num2;
}

print subTwo();

print '<br>';

function calcPow($a, $b){
    $powr = $a;
    for($i=0; $i<$b-1, $i++;){
        $powr = $powr * $a;
    }
    return $powr;
}

print calcPow(64, 4);

?>