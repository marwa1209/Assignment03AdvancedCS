using Assignment03AdvancedCS.part01;

namespace Assignment03AdvancedCS
{
    internal class Program
    {
        #region Part02
        static bool Exists<T>(List<T> list, Predicate<T> predicate)
        {
            foreach (T item in list)
            {
                if (predicate(item))
                {
                    return true;
                }
            }
            return false;
        }

        static T find<T>(List<T> list, Predicate<T> predicate)
        {
            foreach (T item in list)
            {
                if (predicate(item))
                {
                    return item;
                }
            }
            return default(T);
        }

        static List<T> FindAll<T>(List<T> list, Predicate<T> predicate)
        {
            List<T> result = new List<T>();
            foreach (T item in list)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        static int FindIndex<T>(List<T> list, Predicate<T> predicate)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (predicate(list[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        static T FindLast<T>(List<T> list, Predicate<T> predicate)
        {
            T result = default(T);
            foreach (T item in list)
            {
                if (predicate(item))
                {
                    result = item;
                }
            }
            return result;
        }

        static int FindLastIndex<T>(List<T> list, Predicate<T> predicate)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (predicate(list[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        static void ForEach<T>(List<T> list, Action<T> action)
        {
            foreach (T item in list)
            {
                action(item);
            }
        }

        static bool TrueForAll<T>(List<T> list, Predicate<T> predicate)
        {
            foreach (T item in list)
            {
                if (!predicate(item))
                {
                    return false;
                }
            }
            return true;
        } 
        #endregion
        static void Main(string[] args)
        {
            #region Part01
            List<Book> books = new List<Book>()
            {
                new Book("1", "C#", new[] {"Omar", "Ahmed", "Ali"}, DateTime.Now, 50),
                new Book("2", "OOP", new[] {"Mohamed"}, DateTime.Now, 30),
                new Book("3", "SQL", new[] {"Hamada", "Aya"}, DateTime.Now, 40)
            };


            BookDelegate title = BookFunctions.GetTitle;
            BookDelegate price = BookFunctions.GetPrice;
            BookDelegate authors = BookFunctions.GetAuthors;

            LibraryEngine.ProcessBooks(books, title);
            LibraryEngine.ProcessBooks(books, price);
            LibraryEngine.ProcessBooks(books, authors);


            Func<Book, string> func = BookFunctions.GetTitle;

            LibraryEngine.ProcessBooksv2(books, func);

            LibraryEngine.ProcessBooks(books, delegate (Book b) { return b.ISBN; });
            LibraryEngine.ProcessBooksv2(books, delegate (Book b) { return b.ISBN; });

            LibraryEngine.ProcessBooks(books, b => $"Publication Date: {b.PublicationDate}");
            LibraryEngine.ProcessBooksv2(books, b => $"Publication Date: {b.PublicationDate}");
            #endregion
        }
    }
}
