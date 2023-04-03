// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
IsPalindrome(1001);
 bool IsPalindrome(int x)
{
    if(x<0)
    {
        return false;
    }
    var sNumber=x.ToString();
    var end = sNumber.Length-1;
    var start = 0;
    while(start<sNumber.Length/2)
    {
        if(sNumber[start] == sNumber[end])
        {
            start++;
            end--;
        }
        else
        {
            return false;
        }
    }
    return true;



}