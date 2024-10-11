Dog[] dog = new Dog[2];

dog[0] = new Dog();
dog[1] = new Dog();

foreach (Dog dogs in dog)
{
    dogs.MakeNoise();
}