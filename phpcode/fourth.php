<?php

// For Loop
$b = [2,4,6,8,10];

for($i=0; $i<5; $i++)
{
    $j=$i+1;
    print 'The '.$j.' number element is '.$b[$i].'<br>';
}

print '<br>';

// While Loops
$i = 0; 
$flag = true;
while($flag)
{
    if($b[$i] == 8){$index = $i;$flag = false;}$i++;
}

print '8 is at index '.$index.'<br>';

print '<br>';

$i = 0;
while(true)
{if($b[$i] == 4)
    {
        $index = $i;break;
    } $i++;
}

print '8 is at index '.$index.'<br>';

print '<br>';

// Do While Loop
$i = 0;
do
{
    $j = $i + 1;
    print 'The '.$j.' number element is '.$b[$i].'<br>';
    $i++;
} 
while($i<5);

$i=5;
do
{
    print $i.'<br>';
    $i++;
} 
while($i<5);

// For Each Loop
$colours = ["red","yellow","blue"];
$i=1;
foreach($colours as $colour)
{
    print 'Number '.$i.' Colour is: '.$colour.'<br>';
    $i++;
}

print '<br>';

// Challenge 1
$value = 4;
$temp = 4;
for($i=0;$i<2;$i++)
{
    $value = $value * $temp;
}
print '4 to the power of 3 is '.$value.'<br>';

print '<br>';

//Challenge 2
$fact = 6;
for($i=$fact-1;$i>0;$i--)
{
    $fact = $fact * $i;
}

print 'The factorial of 6 is '.$fact.'<br>';
?>