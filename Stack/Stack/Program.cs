using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Pages myPage = new Pages();

            myPage.Facebook("First page was Photos");
            myPage.Facebook("Second page was Timeline");
            myPage.Facebook("Third page was Story");


            
            
            myPage.undoFacebook();
            myPage.printredoFacebook();



        }
    }
}
public class Pages
{
    private Stack<string> facebookStack = new Stack<string>();
    private Stack<string> undoFacebookStack = new Stack<string>();


    public void Facebook(string myFirstPage)
    {
        facebookStack.Push(myFirstPage);

        foreach (var item in facebookStack)
        {
            Console.WriteLine("The page I visited are the following:"
                          + item);
        }
    }

    public void undoFacebook()
    {
        string lastPage = facebookStack.Pop();
        undoFacebookStack.Push(lastPage);
    }
    public void printredoFacebook()
    {
        foreach(var item in undoFacebookStack)
        {
            Console.WriteLine("The page I visited are the following:"
                          + item);
        }

    }
}
