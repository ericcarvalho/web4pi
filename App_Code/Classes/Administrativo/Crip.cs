using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;


public class Crip
{
    public static string GetSHA256(string text)
    {
        UnicodeEncoding UE = new UnicodeEncoding();
        byte[] hashValue;
        byte[] message = UE.GetBytes(text);

        SHA256Managed hashString = new SHA256Managed();
        string hex = "";

        hashValue = hashString.ComputeHash(message);
        foreach (byte x in hashValue)
        {
            hex += String.Format("{0:x2}", x);
        }
        return hex;
    }


    public Crip()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}