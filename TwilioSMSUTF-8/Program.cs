// Get the twilio-csharp library from twilio.com/docs/libraries/csharp
using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;


namespace textio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find your Account Sid and Auth Token at twilio.com/console and add them below
            const string accountSid = "<Your Twilio Account SID>";
            const string authToken = "<Your Twilio Auth Token>";
            TwilioClient.Init(accountSid, authToken);

            // Add the number you want to send a text to here
            string rec = "<Your reciepients phone number>";

            //Add your Twilio phone number here
            string phone = "<Your Twilio Phone Number>";
            //  The message you want to send comes here
            Console.WriteLine("Enter your message:"); // Prompt
            string text = Console.ReadLine();
            

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
    }
}
