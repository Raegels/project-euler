// The prime factors of 13195 are 5, 7, 13 and 29.
// What is the largest prime factor of the number 600851475143

long number = 600851475143;

int i = 2;

while (i * i < number)
{
    while (number % i == 0)
    {
        number /= i;
    }
    i++;
    Console.WriteLine(number);
}



