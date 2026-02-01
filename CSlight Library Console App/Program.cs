
    bool isOpen = true;
    string[,] books =
    {
          {"J.K. Rowling", "J.R.R. Tolkien", "George Orwell"},
          {"Frank Herbert", "William Gibson", "Isaac Asimov"},
          {"Aldous Huxley", "Ray Bradbury", "Arthur Conan Doyle"}
     };

    while (isOpen)
    {
        Console.SetCursorPosition(0, 20);
        Console.WriteLine("\nFull list of authors: \n");
        for (int i = 0; i < books.GetLength(0); i++)
        {
            for (int j = 0; j < books.GetLength(1); j++)
            {
                Console.Write(books[i, j] + " | ");
            }
            Console.WriteLine();
        }
        Console.SetCursorPosition(0, 0);
        Console.WriteLine("Libary");
        Console.WriteLine("\n1 - find out the author's name by the book index.\n " +
                          "\n2 - find a book by author.\n " +
                          "\n3 - Exit\n");
        Console.Write("\nselect a menu item: ");

        switch (Convert.ToInt32(Console.ReadLine()))
        {
            case 1:
                int line, column;
                Console.Write("Enter shelf number: ");
                line = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write("Enter column number: ");
                column = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("This is the author: " + books[line, column]);
                break;

            case 2:
                string author;
                bool authorIsFound = false;
                Console.Write("Enter the author: ");
                author = Console.ReadLine();
                for (int i = 0; i < books.GetLength(0); i++)
                {
                    for (int j = 0; j < books.GetLength(1); j++)
                    {
                        if (author.ToLower() == books[i, j].ToLower())
                        {
                            Console.Write($"Author {books[i, j]} located at shelf {i + 1} place {j + 1}");
                            authorIsFound = true;
                        }
                    }
                }
                if (authorIsFound == false)
                {
                    Console.WriteLine("there is no such author.");
                }
                break;

            case 3:
                isOpen = false;
                break;

            default:
                Console.WriteLine("Unknown comand");
                break;
        }
        if (isOpen)
        {
            Console.WriteLine("\n Press any key to continue...\n");
        }

        Console.ReadKey();
        Console.Clear();
    }

