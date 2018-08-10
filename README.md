# TwilioMessegingDemo
UTF-8 messages with Twilio

# Running 
- Clone the repository and open `TwilioSMSUTF-8.sln` with [Visual Studio](https://visualstudio.microsoft.com/).
- Install the Twilio package for C# by following [these instructions](https://www.twilio.com/docs/libraries/csharp-dotnet).
- In `TwilioSMSUTF-8/Program.cs`, add your Account Sid and Auth Token, get [these here](twilio.com/console).
- Add your Twilio phone number too, you get this [here](https://www.twilio.com/console/phone-numbers/incoming).
- Save everything and run it by pressing the green play button in Visual Studio :sparkles:

# Working
The repo let's us send Non-latin characters and Emoji using C# 
- *Non-latin characters* - C# has a special escape sequence character that allows us to place UTF-8 formatted characters in strings - this is `\uxxxx`. To send a specific character we need to look up its escape sequence [here](https://www.rapidtables.com/code/text/unicode-characters.html) and place it in our code as desired. This is not just for Emoji as C# has [FAQ's](https://blogs.msdn.microsoft.com/csharpfaq/2004/03/12/what-character-escape-sequences-are-available/) for more escape sequences you might find useful in your projects.
- *Emoji* - For Emoji I took two approaches. I used the Unicode escape sequence built into C# as well as a [C# Emoji project]( https://github.com/catcher-in-the-try/Full-Emoji-List) I found on GitHub that lets us place Emoji into our text using methods as I implemented in the code. I used both ways here and you are free to pick the one which suits you best. 

# Happy Programmable Texting :envelope:
