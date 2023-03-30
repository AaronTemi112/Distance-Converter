using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject.App04
{
    public class post
    {
        public List<String> comments;

        public int likes;

        public String Username { get; set; }

        public int PostId { get; }
        public static int Increase = 0;

        public DateTime Timestamp { get; set; }

        private readonly List<MessagePost> messages;
        private readonly List<PhotoPost> photos;


        public Post()
        {
            Increase++;
            PostId = Increase - 1;
            Timestamp = DateTime.Now;

            likes = 0;
            comments = new List<String>();

            messages = new List<MessagePost>();
            photos = new List<PhotoPost>();
        }


        public string InputName()
        {
            Console.Write(" Enter your name > ");
            string name = Console.ReadLine();
            return name;
        }
        private void PostImage()
        {
            ConsoleHelper.OutputTitle("Posting an Image/Photo");

            string author = InputName();

            Console.Write(" Please enter your image filename > ");
            string filename = Console.ReadLine();

            Console.Write(" Please enter your image caption > ");
            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(author, filename, caption);
            photos.Add(post);
            post.Display();
        }

        private void PostMessage()
        {
            ConsoleHelper.OutputTitle("Posting a Message");

            string author = InputName();

            Console.Write(" Please enter your message > ");
            string text = Console.ReadLine();

            MessagePost post = new MessagePost(author, text);
            
            messages.Add(post);
            post.Display();
        }

        private void RemovePost()
        {
            Display();
            Console.Write("Enter the ID of the post you want to remove: ");
            int id = Convert.ToInt32(Console.ReadLine());
            int idValid = 0;
            foreach (PhotoPost postPhoto in photos)
            {
                if (id == postPhoto.PostId)
                {
                    photos.Remove(postPhoto);
                    idValid++;
                    ConsoleHelper.OutputTitle("Removed a post");
                }
            }
            foreach (MessagePost postMessage in messages)
            {
                if (id == postMessage.PostId)
                {
                    messages.Remove(postMessage);
                    idValid++;
                    ConsoleHelper.OutputTitle("Removed a post");
                }
            }
            if (idValid == 0)
            {
                ConsoleHelper.OutputTitle(" Invalid ID");
            }
        }

        public void Author()
        {
            // prompt user to enter name of author
            // chech for each item in photos if this author exists
            // same for each item in messages
            // if so, display that post post.display() /// postMessage.display() or postPhoto.display()
            // dont forget at the end, if nothing is displayed, (not invalid) just author doesnt exist
        }



        ///<summary>
        /// Record one more 'Like' indication from a user.
        ///</summary>
        public void Like()
        {
            Display();
            Console.Write(" Enter post ID you want to like > ");
            int id = Convert.ToInt32(Console.ReadLine());
            int idValid = 0;
            foreach (PhotoPost postPhoto in photos)
            {
                if (id == postPhoto.PostId)
                {
                    postPhoto.likes++;
                    idValid++;
                    ConsoleHelper.OutputTitle($"Added a like to post ID: {id}");
                }
            }
            foreach (MessagePost postMessage in messages)
            {
                if (id == postMessage.PostId)
                {
                    postMessage.likes++;
                    idValid++;
                    ConsoleHelper.OutputTitle($"Added a like to post ID: {id}");
                }

            }
            if (idValid == 0)
            {
                ConsoleHelper.OutputTitle(" Invalid ID");
            }
        }


        ///<summary>
        /// Record that a user has withdrawn his/her 'Like' vote.
        ///</summary>
        public void Unlike()
        {
            Display();
            Console.Write(" Enter post ID you want to Unlike > ");
            int id = Convert.ToInt32(Console.ReadLine());
            int idValid = 0;
            foreach (PhotoPost postPhoto in photos)
            {
                if (id == postPhoto.PostId)
                {
                    if (likes > 0)
                    {
                        postPhoto.likes--;
                        idValid++;
                        ConsoleHelper.OutputTitle($"Removed a like to post ID: {id}");
                    }
                    else 
                    { 
                        Console.WriteLine(); 
                        Console.WriteLine(" Cannot remove a like from a post with 0 likes... "); 
                        Console.WriteLine(); 
                    }
                }
            }
            foreach (MessagePost postMessage in messages)
            {
                if (id == postMessage.PostId)
                {
                    if (likes > 0)
                    {
                        postMessage.likes--;
                        idValid++;
                        ConsoleHelper.OutputTitle($"Removed a like to post ID: {id}");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Cannot remove a like from a post with 0 likes... ");
                        Console.WriteLine();
                    }
                }

            }
            if (idValid == 0)
            {
                ConsoleHelper.OutputTitle(" Invalid ID");
            }
        }


        ///<summary>
        /// Add a comment to this post.
        ///</summary>
        /// <param name="text">
        /// The new comment to add.
        /// </param>
        public void AddComment()
        {
            Display();
            Console.Write(" Enter post ID you want to add a comment to > ");
            int id = Convert.ToInt32(Console.ReadLine());
            int idValid = 0;
            Console.Write(" Enter comment > ");
            string userComment = Console.ReadLine();
            foreach (PhotoPost postPhoto in photos)
            {
                if (id == postPhoto.PostId)
                {
                    postPhoto.comments.Add(userComment);
                    idValid++;
                    ConsoleHelper.OutputTitle($" Added a comment to post ID: {id}");
                }
            }
            foreach (MessagePost postMessage in messages)
            {
                if (id == postMessage.PostId)
                {
                    postMessage.comments.Add(userComment);
                    idValid++;
                    ConsoleHelper.OutputTitle($" Added a comment to post ID: {id}");
                }

            }
            if (idValid == 0)
            {
                ConsoleHelper.OutputTitle(" Invalid ID");
            }
        }


        public void DisplayMenu()
        {
            bool quit = false;

            string[] choices = new string[] { "Add message", "Add photo", "Display all", "Like a post", "Unlike a post", "Add comment", "Remove a post", "Quit" };

            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);
                switch (choice)
                {
                    case 1: PostMessage(); Console.WriteLine(); break;
                    case 2: PostImage(); Console.WriteLine(); break;
                    case 3: Display(); break;
                    case 4: Like(); break;
                    case 5: Unlike(); break;
                    case 6: AddComment(); break;
                    case 7: RemovePost(); break;
                    case 8: quit = true; break;

                }
            } while (!quit);
        }

        public virtual void Display()
        {
            // display all text posts
            foreach (MessagePost message in messages)
            {
                message.Display();
                Console.WriteLine();   // empty line between posts
            }

            // display all photos
            foreach (PhotoPost photo in photos)
            {
                photo.Display();
                Console.WriteLine();   // empty line between posts
            }
        }



        public String FormatElapsedTime(DateTime time)
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - time;

            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;

            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }


    }
}
