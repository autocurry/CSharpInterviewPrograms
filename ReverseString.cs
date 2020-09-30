using NUnit.Framework;
using System;
using System.Text;

[TestFixture]
public class ReverseString{

    const string stringtoReverse = "brazil";
    const string expected = "lizarb";

    [Test]
    public void reversalWithArrayReverse(){
        
        char[] arrayreverse = stringtoReverse.ToCharArray();
        Array.Reverse(arrayreverse);
        var reversedString = new string(arrayreverse);
        Console.WriteLine("After reversal "+reversedString);
        Assert.AreEqual(expected,reversedString);
    }

    [Test]
    public void reversalUsingStringBuilder(){
        var counter = stringtoReverse.Length;
        StringBuilder temp = new StringBuilder();
        for(int i = counter-1;i>=0;i--){
            temp.Append(stringtoReverse[i]);
        }

        Assert.AreEqual(expected,temp.ToString());

    }
}
