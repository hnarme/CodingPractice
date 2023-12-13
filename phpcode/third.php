<?php


$arr = [1,2,3,4];
print_r($arr);

// Array Function
$even = array(0,2,4,6);
print '<br>';
print_r($even);

print '<br>';
print 'The second element in even is '.$even[1].'<br>';

// Associative Array Function
$age = [
    "Radee" => 24,
    "Adib" => 23,
    "Anjum" => 32
];

print_r($age);

// Multidimensional array
$coordinates = [
    [12,34],
    [34,48],
    [56,78]
];

print '<br>';
print_r($coordinates);

print '<br>';
print $coordinates[2][0].'<br>'.$coordinates[0][0].'<br>';

// Boolean
$a = 5;
$b = 3;
if ($a > $b)
{
    print $a.' is greater than '.$b;
} else{
    print $b.' is greater than or equal to '.$a;
}

print '<br>';

if ($a > $b)
{
    print $a.' is greater than '.$b;
} 
elseif ($a < $b)
{
    print $b.' is greater than '.$a;
} 
else 
{
    print $a.' is equal to '.$b;
}

?>