using System;
using System.Collections.Generic;
using System.Linq;

namespace Just_A_Test
{
    internal class Program
    {
        private static void Main()
        {
            bool done = false;

            Stack<BookCreator> userLoaningStack = new Stack<BookCreator>();
            List<BookCreator> liberyBooks = new List<BookCreator>();
            List<BookCreator> userLoans = new List<BookCreator>();


            BookCreator cooking = new BookCreator("Hentai Cartoons");
            cooking.BookSeize(5000);
            cooking.BookColor("White");
            cooking.BookSubject("Cartoons");
            liberyBooks.Add(cooking);

            BookCreator smiting = new BookCreator("Gun Smiting");
            smiting.BookSeize(20000);
            smiting.BookColor("Gray");
            smiting.BookSubject("Smiting");
            liberyBooks.Add(smiting);

            BookCreator shipBuilding = new BookCreator("Building a War Ship");
            shipBuilding.BookSeize(1500);
            shipBuilding.BookColor("Yellow");
            shipBuilding.BookSubject("Ship Building");
            liberyBooks.Add(shipBuilding);

            do
            {
                int menu = GetIntFromUser(
                    "press 1 to Rent a Book: \r\nPress 2 to see rent Books: \r\nPress 3 to exit: ");
                switch (menu)
                {
                    case 1:
                        int addBook;
                        do
                        {
                            Console.WriteLine("Books in Library");
                            Console.WriteLine();
                            foreach (BookCreator i in liberyBooks)
                            {
                                Console.Write("Book number: " + liberyBooks.IndexOf(i));
                                Console.Write(" | Name: ");
                                Console.Write(i.Name + ": Subject: ");
                                Console.Write(i.Subject + " | Color: ");
                                Console.Write(i.Color + " | Seize: ");
                                Console.Write(i.Seize);
                                Console.WriteLine();
                                Console.WriteLine();
                            }

                            Console.WriteLine("Books In Loan Stack");
                            Console.WriteLine();
                            foreach (BookCreator i in userLoaningStack)
                            {
                                Console.Write(" | Name: ");
                                Console.Write(i.Name + ": Subject: ");
                                Console.Write(i.Subject + " | Color: ");
                                Console.Write(i.Color + " | Seize: ");
                                Console.Write(i.Seize);
                                Console.WriteLine();
                                Console.WriteLine();
                            }

                            addBook = GetIntFromUser("Press 1 to loan a Book: \r\nPress 2 to Quit: ");
                            Console.WriteLine();
                            switch (addBook)
                            {
                                case 1:
                                    int selectBook = GetIntFromUser("What book would you like to loan, write its book number: ");
                                    for (int length = 0; length < liberyBooks.Count; length++)
                                        if (liberyBooks.IndexOf(liberyBooks[length]) == selectBook)
                                        {
                                            userLoaningStack.Push(liberyBooks[selectBook]);
                                            liberyBooks.RemoveAt(selectBook);
                                        }

                                    break;
                                default:
                                    int loaningStackLength;
                                    addBook = 2;
                                    loaningStackLength = userLoaningStack.Count();
                                    for (int length = 0; length < loaningStackLength; length++)
                                    {
                                        Console.WriteLine("rent book: " + userLoaningStack.Peek().Name);
                                        userLoans.Add(userLoaningStack.Peek());
                                        userLoaningStack.Pop();
                                    }

                                    break;
                            }

                            Console.Clear();
                        } while (addBook == 1);

                        break;
                    case 2:
                        Console.WriteLine();
                        foreach (BookCreator i in userLoans) Console.WriteLine(i.Name);

                        Console.ReadKey();
                        break;
                    case 3:
                        done = true;
                        break;
                }

                Console.Clear();
            } while (done == false);

            int GetIntFromUser(string question)
            {
                Console.Write(question);
                int result;
                string input = Console.ReadLine();

                while (!int.TryParse(input, out result))
                {
                    Console.Write("Invalid, try again: ");
                    input = Console.ReadLine();
                }
                return result;
            }
        }
    }
}