// Get the twilio-csharp library from twilio.com/docs/libraries/csharp
using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using J3QQ4; // Let's us access Emoji without using escape characters


namespace YourNewConsoleApp
{
    class Example
    {
        static void Main(string[] args)
        {
            // Find your Account Sid and Auth Token at twilio.com/console and add them below
            const string accountSid = "<Your Twilio Account SID>";
            const string authToken = "<Your Twilio Auth Token>";
            TwilioClient.Init(accountSid, authToken);

            // Add the number you want to send a text to here
            var rec = "<Your reciepients phone number";

            // Add the message you want to send here
            // It's important to note the escape characters being used as well as the way we add a Blush Emoji ( More info in the docs ) 
            string text = "\"The \u00C6olean Harp\", by Samuel Taylor Coleridge is one of my favourite books! \u03C8" + Emoji.Blush + "\n \u4EF0 is \u26C4 in Japanese ( jk. \u270B)";

            var to = new PhoneNumber(rec);

            // Putting everything together and sending the text
            var message = MessageResource.Create(
                to,
                from: new PhoneNumber("<Your Twilio Phone Number>"), // Add your registred Twilio number here
                body: text);

            Console.WriteLine("\nYou just sent a text with Twilio *Mic Drop* ");
            Console.WriteLine(message.Sid);
            Console.Write("\nSuccess! Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}