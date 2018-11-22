using System;
using System.Diagnostics;
using System.Globalization;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace textio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find your Account Sid and Auth Token at https://twilio.com/console and add them below
            const string accountSid = "<Your Twilio Account SID>";
            const string authToken = "<Your Twilio Auth Token>";
            TwilioClient.Init(accountSid, authToken);

            // Add the number you want to send a text to here
            string rec = "<Your recipient's phone number>";

            //Add your Twilio phone number here
            string phone = "<Your Twilio Phone Number>";

            // The message you want to send comes here
            // Console.InputEncoding = Encoding.GetEncoding(65001);
            Console.WriteLine("Enter your message:"); // Prompt
            string text = Console.In.ReadLine();
            text = DecodeEncodedNonAsciiCharacters(text);

            var to = new PhoneNumber(rec);
            // Putting everything together and sending the text
            var message = MessageResource.Create(
            to,
            from: new PhoneNumber(phone), body: text);

            Console.WriteLine("\nYou just sent a text with Twilio *Mic Drop* ");
            Console.WriteLine(message.Sid);
            Console.Write("\nSuccess! Press any key to exit...");
            Console.ReadKey(true);
        }

        private static string DecodeEncodedNonAsciiCharacters(string value)
        {
            return System.Text.RegularExpressions.Regex.Replace(
                value,
                @"\\u(?<Value>[a-zA-Z0-9]{4})",
                m => {
                    return ((char)int.Parse(m.Groups["Value"].Value, NumberStyles.HexNumber)).ToString();
                });
        }
    }
}
