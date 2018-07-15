// Get the twilio-csharp library from twilio.com/docs/libraries/csharp
using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace YourNewConsoleApp
{
    class Example
    {
        static void Main(string[] args)
        {
            // Find your Account Sid and Auth Token at twilio.com/console and add them below
            const string accountSid = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            const string authToken = "xxxxxxxxxxxxxxxxxxxxxxxxxxx";
            TwilioClient.Init(accountSid, authToken);

            Console.WriteLine("\nGet ready to send a text! ");

            // Read the number you want to send a text to
            Console.WriteLine("\nEnter your reciepient.. ");
            var rec = Console.ReadLine();

            // Reads the message you want to send 
            Console.WriteLine("\nEnter your message.. ");
            var text = Console.ReadLine();

            var to = new PhoneNumber(rec);
            var message = MessageResource.Create(
                to,
                from: new PhoneNumber("[PHONE NUMBER]"), // Add your registred Twilio number here
                body: text);

            Console.WriteLine(message.Sid);
            Console.Write("\nSuccess! Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}