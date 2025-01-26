using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static C__FUGAS.Block7;

namespace C__FUGAS
{
    class Block7
    {
        //task 1
        /*
        public class person
        {
            public string Name {get; private set;}
            public int Age {get; private set;}
            public person(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public virtual void ShowInfo()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}");
            }
        }
        public class Student : person
        {
            public List<int> grades {get; private set;}
            public Student(string name, int age)
                : base(name, age)
            {
                grades = new List<int>();
            }
            public void AddGrade(int grade)
            {
                grades.Add(grade);
                Console.WriteLine($"Mark {grade} added for student {Name}.");
            }
            public double CalculateAvGrade()
            {
                if (grades.Count == 0)
                    return 0;

                int sum = 0;
                foreach (int grade in grades)
                {
                    sum += grade;
                }
                return (double)sum / grades.Count;
            }
            public override void ShowInfo()
            {
                base.ShowInfo();
                if (grades.Count > 0)
                {
                    Console.WriteLine($"Average mark is: {CalculateAvGrade():F2}");
                }
                else
                {
                    Console.WriteLine("Error 404. No mark founds.");
                }
            }
        }
        public class Teacher : person
        {
            public string Subject { get; private set; }
            public Teacher(string name, int age, string subject)
                : base(name, age)
            {
                Subject = subject;
            }
            public override void ShowInfo()
            {
                base.ShowInfo();
                Console.WriteLine($"Topic/Item: {Subject}");
            }
        }
        public class Group
        {
            public Teacher Teacher { get; private set; }
            public List<Student> Students { get; private set; }
            public Group(Teacher teacher)
            {
                Teacher = teacher;
                Students = new List<Student>();
            }
            public void AddStudent(Student student)
            {
                Students.Add(student);
                Console.WriteLine($"Student {student.Name} was added in group.");
            }
            public void ShowGroupInfo()
            {
                Console.WriteLine("Info about group:");
                Teacher.ShowInfo();
                Console.WriteLine("List with students:");
                foreach (var student in Students)
                {
                    student.ShowInfo();
                }
            }
        }
        class Program
        {
            static void Main()
            {
                Teacher teacher = new Teacher("Efimchyk", 50, "math");
                Student student1 = new Student("Denys", 16);
                Student student2 = new Student("Yura", 16);
                Group group = new Group(teacher);
                group.AddStudent(student1);
                group.AddStudent(student2);
                student1.AddGrade(52);
                student1.AddGrade(993);
                student2.AddGrade(228);
                student2.AddGrade(337);
                group.ShowGroupInfo();
                Console.ReadLine();
            }
        }
        */
        //task 2
        /*
        public class book
        {
            public string bookTitle { get; private set; }
            public string bookAuthor { get; private set; }
            public book(string title, string author)
            {
                bookTitle = title;
                bookAuthor = author;
            }
            public void ShowInfo()
            {
                Console.WriteLine($"Title: {bookTitle}, Author: {bookAuthor}");
            }
        }
        public class Library
        {
            private List<book> books;
            public Library()
            {
                books = new List<book>();
            }
            public void AddBook(book book)
            {
                books.Add(book);
                Console.WriteLine($"Book '{book.bookTitle}' was added in library");
            }
            public book FindBookByTitle(string title)
            {
                foreach (var book in books)
                {
                    if (book.bookTitle.Equals(title, StringComparison.OrdinalIgnoreCase))
                    {
                        return book;
                    }
                }
                return null;
            }
            public void ShowAllBooks()
            {
                Console.WriteLine("Book list in library:");
                foreach (var book in books)
                {
                    book.ShowInfo();
                }
            }
        }
        class Program
        {
            static void Main()
            {
                Library library = new Library();
                library.AddBook(new book("How to understand woman", "Author"));//Я хз який там автор. P.S. Така книга реально існує, але в ній є лиш один рядок, а саме цитую "Ніяк.". І всі остальні 200 сторінок пусті.
                library.AddBook(new book("1984", "george orwell")); // Що що, а це насправді цікава книга
                library.AddBook(new book("Atomic Habits", "James Clear")); //Цю книгу я прочитав разів зі 6, а то і більше, рекомендую її до прочитання
                library.ShowAllBooks();
                while (true)
                {
                    Console.WriteLine("\nEnter book name to search or write 'exit' to exit:");
                    string input = Console.ReadLine();
                    if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Exiting program.");
                        Console.ReadLine();
                        break;
                    }
                    book foundBook = library.FindBookByTitle(input);
                    if (foundBook != null)
                    {
                        Console.WriteLine("Founded book:");
                        foundBook.ShowInfo();
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error 404 not found, book was not found, try again.");
                    }
                }
            }
        }
        */
        //task 3
        /*
        public class Video
        {
            public string Title { get; private set; }
            public string Author { get; private set; }
            public TimeSpan Duration { get; private set; }
            public Video(string title, string author, TimeSpan duration)
            {
                Title = title;
                Author = author;
                Duration = duration;
            }
            public void ShowInfo()
            {
                Console.WriteLine($"Title: {Title}, Author: {Author}, Duration: {Duration}");
            }
        }
        public class Playlist
        {
            private List<Video> videos;
            public Playlist()
            {
                videos = new List<Video>();
            }
            public void AddVideo(Video video)
            {
                videos.Add(video);
                Console.WriteLine($"Video '{video.Title}' added to the playlist.");
            }
            public void RemoveVideo(string title)
            {
                Video videoToRemove = videos.Find(v => v.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
                if (videoToRemove != null)
                {
                    videos.Remove(videoToRemove);
                    Console.WriteLine($"Video '{title}' removed from the playlist.");
                }
                else
                {
                    Console.WriteLine($"Video '{title}' not found.");
                }
            }
            public void ShowAllVideos()
            {
                Console.WriteLine("List of videos in the player:");
                foreach (var video in videos)
                {
                    video.ShowInfo();
                }
            }
            public bool HasVideos()
            {
                return videos.Count > 0;
            }
        }
        class Program
        {
            static void Main()
            {
                Playlist playlist = new Playlist();
                bool hasAddedFirstVideo = false;
                while (true)
                {
                    Console.WriteLine("\nEnter command: 'add' to add video, 'delete' for deleting, and 'exit' to exit:");
                    string command = Console.ReadLine();
                    if (command == "add")
                    {
                        Console.Write("Enter the name of the video: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter the author of the video: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter the video duration (h:min:sec): ");
                        TimeSpan duration;
                        if (TimeSpan.TryParse(Console.ReadLine(), out duration))
                        {
                            Video newVideo = new Video(title, author, duration);
                            playlist.AddVideo(newVideo);
                            hasAddedFirstVideo = true;
                        }
                        else
                        {
                            Console.WriteLine("The duration format is incorrect. Please try again.");
                        }
                    }
                    else if (command == "delete" && hasAddedFirstVideo)
                    {
                        Console.Write("Enter the name of the video to delete: ");
                        string title = Console.ReadLine();
                        playlist.RemoveVideo(title);
                    }
                    else if (command == "exit")
                    {
                        Console.WriteLine("Exiting program.");
                        Console.ReadLine();
                        break;
                    }
                    else if (!hasAddedFirstVideo && command == "delete")
                    {
                        Console.WriteLine("The list is empty, add a video first.");
                    }
                    else
                    {
                        Console.WriteLine("Unknown command, try again.");
                    }
                    if (hasAddedFirstVideo)
                    {
                        Console.WriteLine("\nCurrent video list:");
                        playlist.ShowAllVideos();
                    }
                }
            }
        }
        */
        //task 4
        /*
        public class Message
        {
            public int Index { get; private set; }
            public int? ParentIndex { get; private set; }
            public string Text { get; private set; }
            public string Author { get; private set; }
            public DateTime SentTime { get; private set; }
            public Message(int index, string text, string author, DateTime sentTime, int? parentIndex = null)
            {
                Index = index;
                Text = text;
                Author = author;
                SentTime = sentTime;
                ParentIndex = parentIndex;
            }
            public void ShowInfo()
            {
                Console.WriteLine($"Index: {Index}, Author: {Author}, Time: {SentTime}, Text: {Text}");
                if (ParentIndex != null)
                {
                    Console.WriteLine($"Reply to a message with an index: {ParentIndex}");
                }
            }
        }
        public class Chat
        {
            private List<Message> messages;
            public Chat()
            {
                messages = new List<Message>();
            }
            public void AddMessage(Message message)
            {
                messages.Add(message);
                Console.WriteLine("Message added.");
            }
            public void SearchByAuthor(string author)
            {
                var foundMessages = messages.Where(m => m.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
                if (foundMessages.Any())
                {
                    Console.WriteLine($"\nMessage from the author {author}:");
                    foreach (var message in foundMessages)
                    {
                        message.ShowInfo();
                    }
                }
                else
                {
                    Console.WriteLine($"Messages from the author {author} not found.");
                }
            }
            public void SortByTime()
            {
                var sortedMessages = messages.OrderBy(m => m.SentTime).ToList();
                Console.WriteLine("\nMessages sorted by time:");
                foreach (var message in sortedMessages)
                {
                    message.ShowInfo();
                }
            }
            public void ShowReplies(int index)
            {
                var replies = messages.Where(m => m.ParentIndex == index).ToList();
                if (replies.Any())
                {
                    Console.WriteLine($"\nReply to messages with an index {index}:");
                    foreach (var reply in replies)
                    {
                        reply.ShowInfo();
                    }
                }
                else
                {
                    Console.WriteLine($"Replying to messages with an index {index} not found.");
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Chat chat = new Chat();
                int messageIndex = 1;

                while (true)
                {
                    Console.WriteLine("\nSelect an action: 'add' to add a message, 'search' to search by author, 'sort' to sort by time, 'replies' to view replies, 'exit' to exit:");
                    string command = Console.ReadLine();

                    if (command == "add")
                    {
                        Console.Write("Enter the message text: ");
                        string text = Console.ReadLine();

                        Console.Write("Enter the author of the message: ");
                        string author = Console.ReadLine();

                        Console.Write("Is this a reply to another message? (yes/no): ");
                        string isReply = Console.ReadLine();

                        int? parentIndex = null;
                        if (isReply.ToLower() == "yes")
                        {
                            Console.Write("Enter the index of the message to which this is a reply: ");
                            parentIndex = int.Parse(Console.ReadLine());
                        }

                        Message newMessage = new Message(messageIndex, text, author, DateTime.Now, parentIndex);
                        chat.AddMessage(newMessage);
                        messageIndex++;
                    }
                    else if (command == "search")
                    {
                        Console.Write("Enter the author to search: ");
                        string author = Console.ReadLine();
                        chat.SearchByAuthor(author);
                    }
                    else if (command == "sort")
                    {
                        chat.SortByTime();
                    }
                    else if (command == "replies")
                    {
                        Console.Write("Enter the message index to view replies: ");
                        int index = int.Parse(Console.ReadLine());
                        chat.ShowReplies(index);
                    }
                    else if (command == "exit")
                    {
                        Console.WriteLine("Exit the program.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Unknown command, try again.");
                    }
                }
            }
        }
        */
        //task 5
        /*
        public class Page
        {
            public string Title { get; private set; }
            public List<Page> Links { get; private set; }
            public Page(string title)
            {
                Title = title;
                Links = new List<Page>();
            }
            public void AddLink(Page page)
            {
                Links.Add(page);
            }
            public void RemoveLink(Page page)
            {
                Links.Remove(page);
            }
            public void ShowLinks()
            {
                Console.WriteLine($"Page: {Title}");
                Console.WriteLine("Pages available for navigation:");
                foreach (var link in Links)
                {
                    Console.WriteLine($"- {link.Title}");
                }
            }
        }
        public class Website
        {
            private List<Page> pages;
            public Website()
            {
                pages = new List<Page>();
            }
            public void AddPage(string title)
            {
                Page newPage = new Page(title);
                pages.Add(newPage);
                Console.WriteLine($"Page \"{title}\" added.");
            }
            public void RemovePage(string title)
            {
                Page pageToRemove = pages.Find(p => p.Title == title);
                if (pageToRemove != null)
                {
                    pages.Remove(pageToRemove);
                    Console.WriteLine($"Page \"{title}\" deleted.");
                }
                else
                {
                    Console.WriteLine($"Error 404 page \"{title}\" not found.");
                }
            }
            public void AddLink(string fromTitle, string toTitle)
            {
                Page fromPage = pages.Find(p => p.Title == fromTitle);
                Page toPage = pages.Find(p => p.Title == toTitle);

                if (fromPage != null && toPage != null)
                {
                    fromPage.AddLink(toPage);
                    Console.WriteLine($"Link from the page \"{fromTitle}\" to page \"{toTitle}\" added.");
                }
                else
                {
                    Console.WriteLine($"Error 404 one of the pages was not found.");
                }
            }
            public void RemoveLink(string fromTitle, string toTitle)
            {
                Page fromPage = pages.Find(p => p.Title == fromTitle);
                Page toPage = pages.Find(p => p.Title == toTitle);

                if (fromPage != null && toPage != null)
                {
                    fromPage.RemoveLink(toPage);
                    Console.WriteLine($"Link from the page \"{fromTitle}\" to page \"{toTitle}\" deleted.");
                }
                else
                {
                    Console.WriteLine($"Error 404 one of the pages was not found.");
                }
            }
            public void ShowSiteMap()
            {
                Console.WriteLine("Site map:");
                foreach (var page in pages)
                {
                    page.ShowLinks();
                    Console.WriteLine();
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Website site = new Website();
                while (true)
                {
                    Console.WriteLine("\nSelect an action: 'add page' to add a page, 'delete page' to delete a page, 'add link' to add a link, 'delete link' to delete a link, 'show' to show the sitemap, 'exit' to exit:");
                    string command = Console.ReadLine();

                    if (command == "add page")
                    {
                        Console.Write("Enter the name of the page: ");
                        string title = Console.ReadLine();
                        site.AddPage(title);
                    }
                    else if (command == "delete page")
                    {
                        Console.Write("Enter the name of the page to delete: ");
                        string title = Console.ReadLine();
                        site.RemovePage(title);
                    }
                    else if (command == "add link")
                    {
                        Console.Write("Enter the name of the page to link from: ");
                        string fromTitle = Console.ReadLine();

                        Console.Write("Enter the name of the page to link from: ");
                        string toTitle = Console.ReadLine();

                        site.AddLink(fromTitle, toTitle);
                    }
                    else if (command == "delete link")
                    {
                        Console.Write("Enter the name of the page from which the link will be removed: ");
                        string fromTitle = Console.ReadLine();

                        Console.Write("Enter the name of the linked page: ");
                        string toTitle = Console.ReadLine();

                        site.RemoveLink(fromTitle, toTitle);
                    }
                    else if (command == "show")
                    {
                        site.ShowSiteMap();
                    }
                    else if (command == "exit")
                    {
                        Console.WriteLine("Exit the program.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error 404 unknown command, try again.");
                    }
                }
            }
        }
        */
    }
}