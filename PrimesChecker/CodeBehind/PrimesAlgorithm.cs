using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrimesChecker.CodeBehind
{
    public class PrimesAlgorithm
    {
        /*This is the function Primes(num) which tells if the number is a prime number.
         It takes a double type instead of an int, since there could be really large prime numbers as the ones used in cryptography.
         But it still has a limit, you can not check the largest known prime with this one.
         There is a special case which needed to be handled first and it is when the num is less than 2: negatives, 0 and 1 are not primes.
         After handling this case the deterministic algorithm was implemented.*/
        public bool Primes(double num)
        {
            if (num < 2)
            {
                return false;
            }

            else
            {
                //Only need to check until the square root of the num           
                for (double i = 2; i <= Math.Sqrt(num); i++)
                {
                    //if the remain of the division result is 0 that means the number has a factor other than 1 and itself, therefore its not a prime.
                    if (num % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}