using System;
using System.Collections.Generic;

namespace _1108_Defanging_An_IP_Address
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution test = new Solution();
            string output = test.DefangIPaddr("255.100.50.0");
            Console.WriteLine(output); 
        }
    }
    public class Solution
    {
        public string DefangIPaddr(string address)
        {
            //First, convert the string to Char Array
            char[] addressChar = address.ToCharArray();
            //Next, create a list while will copy each index from the array
            List<char> addressList = new List<char>();

            // Next, iterate through the array to find each '.'
            for (int i = 0; i < addressChar.Length; i++)
            {
                if (addressChar[i] == '.')
                {
                    //add the required beginning bracket and ending bracket betweeen the .
                    addressList.Add('[');
                    addressList.Add('.');
                    addressList.Add(']');
                }
                else
                {
                    //add what is not a .
                    addressList.Add(addressChar[i]);
                }
            }
            // convert the list back to a string
            var result = string.Join("", addressList.ToArray());
            return result;
        }
    }
}

//Success

//Runtime: 84 ms, faster than 52.85% of C# online submissions for Defanging an IP Address.
//Memory Usage: 23.2 MB, less than 64.77% of C# online submissions for Defanging an IP Address.