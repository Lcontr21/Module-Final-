using System;
using Module.Models;
using System.Collections.Generic;
using System.Linq;

namespace Module
{
    class Program
    {

        static void Main()
        {


            string response = "";
            List<User> myUser = new List<User>();
            List<Comments> myComments = new List<Comments>();

            while (response != "5")
            {
                Console.WriteLine("1. Create a User");
                Console.WriteLine("2. Create a Comment");
                Console.WriteLine("3. Option 1");
                Console.WriteLine("4. Option 2");
                Console.WriteLine("5. Look for a User");
                Console.WriteLine("6. Look for a Comment");
                Console.WriteLine("7. Exit");


                Console.WriteLine("");
                Console.WriteLine("Please select an option");

                response = Console.ReadLine();

                switch (response)
                {
                    
                    case "1":
                        User newUser = new User();
                        newUser.username1 = "Leonardo Contreras";
                        newUser.username2 = "McKain";
                        newUser.username3 = "Frank";
                        myUser.Add(newUser);

                        Console.WriteLine("The User you created is:");


                        break;

                    case "2":
                        Comments newComment = new Comments();
                        newComment.positive = "This picture is pretty, I like the vibrant colors";
                        newComment.negative = "I hate how you took the pictuer its all blurry";
                        newComment.crucial = "It seems that you don't have a steady hand, try to buy a stand to take pictures more clearly";
                        myComments.Add(newComment);

                        Console.WriteLine("The comment you created is:");

                        break;

                    case "3":
                        Console.WriteLine("These is the list of users created:");

                        foreach (var insideuser in myUser)
                        {
                            Console.WriteLine("The name of the user1 is:" + insideuser.username1);
                            Console.WriteLine("The name of the user2 is:" + insideuser.username2);
                            Console.WriteLine("The name of the user3 is:" + insideuser.username3);

                        }
                        break;

                    case "4":

                        Console.WriteLine("These is the list of comments created:");

                        foreach (var insidecomment in myComments)
                        {
                            Console.WriteLine("Comment1 says: " + insidecomment.positive);
                            Console.WriteLine("Comment2 says: " + insidecomment.negative);
                            Console.WriteLine("Comment3 says: " + insidecomment.crucial);
                        }
                        break;

                    case "5":

                        foreach (var insidecomment in myComments)
                        {
                            myUser.Where(user => user.username1 == "Leonardo Contreras").ToList();
                            myUser.Where(user => user.username2 == "McKain").ToList();
                            myUser.Where(user => user.username3 == "Frank").ToList();
                            Console.WriteLine("Please type in a Username");
                            if (myUser.Count > 0)
                            {
                                Console.WriteLine("Users found, here are the Users");
                                string format = "Here are the Users: " +
                                                "Username1 {0}, Username2{1}, Username3{2}";
                                foreach(var user in myUser)
                                {
                                    Console.WriteLine(format, user.username1, user.username2, user.username3);
                                }
                            }
                            else
                            {
                                Console.WriteLine("No users found");
                            }
                        }
                        break;

                    case "6":

                        foreach (var insidecomment in myComments)
                        {
                            myComments.Where(user => user.positive == "This picture is pretty, I like the vibrant colors").ToList();
                            myComments.Where(user => user.negative == "I hate how you took the pictuer its all blurr").ToList();
                            myComments.Where(user => user.crucial == "It seems that you don't have a steady hand, try to buy a stand to take pictures more clearly").ToList();
                            Console.WriteLine("Please type in text");
                            if (myUser.Count > 0)
                            {
                                Console.WriteLine("Comments found, here are all comments");
                                string format = "Here are all the comments: " +
                                                "positive {0}, negative{1}, crucial{2}";
                                foreach (var comment in myComments)
                                {
                                    Console.WriteLine(format, comment.positive, comment.negative, comment.crucial);
                                }
                            }
                            else
                            {
                                throw new UserNotFound("No comments found");
                            }
                           
                        }
                        break;
                       
                }
            }
        }             
    }
}
public class UserNotFound : Exception
{
    public UserNotFound(string errorMessage): base(errorMessage)
    {

    }
}
                    
