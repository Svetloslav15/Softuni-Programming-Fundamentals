using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Messages
{
    public class User
    {
        public string Username { get; set; }

        public List<Message> ReceivedMessages { get; set; }
    }

    public class Message
    {
        public string Content { get; set; }

        public User Sender { get; set; }
    }

    public class Messages
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            var userMessage = new Dictionary<string, List<Message>>();

            while (!input.Equals("exit"))
            {
                var dataLine = input.Split(' ');
                if (dataLine.Length < 3)
                {
                    var name = dataLine[1];
                    User newUser = new User();
                    newUser.Username = name;
                    if (!userMessage.ContainsKey(newUser.Username))
                    {
                        userMessage[newUser.Username] = new List<Message>();
                    }

                }
                else
                {
                    var senderUsername = dataLine[0];
                    var recipientUsername = dataLine[2];
                    var content = dataLine[3];

                    Message newMessage = new Message();
                    newMessage.Content = content;
                    if (userMessage.ContainsKey(recipientUsername))
                    {
                        userMessage[senderUsername].Add(newMessage);
                    }

                }

                input = Console.ReadLine();
            }


            var names = Console.ReadLine().Split();
            var firstName = names[0];
            var secondName = names[1];
            var max = Math.Max(userMessage[firstName].Count, userMessage[secondName].Count);

            List<string> final = new List<string>();
            foreach (var item in userMessage[firstName])
            {
                final.Add($"{firstName}: {item.Content}");
            }
            foreach (var item in userMessage[secondName])
            {
                final.Add($"{item.Content} :{secondName}");
            }



        }
    }
}