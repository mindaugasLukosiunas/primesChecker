using PrimesChecker.CodeBehind;
using System;

namespace PrimesChecker
{
    public partial class PrimesCheckerWebView : System.Web.UI.Page
    {

        //This is the code what happens when "Check if it's prime" button gets clicked
        protected void Button1_Click(object sender, EventArgs e)
        {
            /*Parsing is usually a risky operation, 
             * even if we have a nice ASP.NET in-build form validations for the input to only be a number, 
             * it's still better to catch an exception.
             * Of course exceptions should be handled more precisely, but for demonstration
             will catch a generic Exception.
             */
            try
            {

                double num = double.Parse(number.Text);

                bool isPrime = new PrimesAlgorithm().Primes(num);

                //If the number is prime, get the joke from a jokes api I found on the web
                if (isPrime)
                {
                    var joke = new JokesRequest().GetTheJoke();
                    result.Text = "You entered " + num + ". This is a prime number! Here's a joke for you:";
                    jokeResult.Text = joke;
                    giflabel.Text = "";
                }
                //if the number is not prime, show "no joke" text and a gif.
                else
                {
                    result.Text = "You entered " + num + ". This is not a prime number. Try another one! ";
                    jokeResult.Text = "No joke this time. :(";
                    giflabel.Text = "<img src = '/Recources/giphy.gif'>";
                }

            } catch (Exception)
            {
                //Do something to recover
            }
        }
    }
}