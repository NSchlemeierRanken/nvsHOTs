using System.Drawing.Printing;
using static System.Reflection.Metadata.BlobBuilder;

namespace FinalProject
{
    public partial class FrmMain : Form
    {
        private List<Book> books;
        private List<Book> displayedBooks;
        private int currentPage = 0;
        private int pageSize = 5;
        private int totalPageCount = 0;

        public FrmMain()
        {
            InitializeComponent();
            displayedBooks = new List<Book>();
            InitializeBooks();
            InitializeDataGridView();
            PopulateDataGridView();
            UpdatePagingButtons();
        }

        private void InitializeBooks()
        {
            books = new List<Book>
        {
            new Book("9780007158461", "Green Eggs and Ham", "Dr.Seuss", 2003, "https://3.bp.blogspot.com/-iT2EWRFGsjk/TepjslBM9bI/AAAAAAAAEjo/cQFhQgOkaE0/s1600/20110602183342084_0001.jpg")
            {   
                Reviews = new List<Review>
                {
                    new Review("Alice", "Loved the playful rhymes!", 5),
                    new Review("Bob", "Great for kids!", 4),
                    new Review("Charlie", "A timeless classic.", 5)
                }
            },
            new Book("9780394900780", "Horton Hears A Who!", "Dr.Seuss", 1962, "https://www.books4school.com/images/product/9780008240028.jpg")
            {
                Reviews = new List<Review>
                {
                    new Review("Dave", "Really touching story!", 5),
                    new Review("Eve", "My children adore this book.", 5),
                    new Review("Frank", "Illustrations are wonderful.", 4)
                }
            },
            new Book("9780394900384", "Fox in Socks", "Dr.Seuss", 1965, "https://images-na.ssl-images-amazon.com/images/I/51l8epW9ZjL.SX316.jpg")
            {
                Reviews = new List<Review>
                {
                    new Review("Grace", "Tongue twisters were so fun!", 5),
                    new Review("Henry", "Challenging but enjoyable read.", 4),
                    new Review("Isaac", "Kids had a blast!", 4)
                }
            },
            new Book("9781580495837", "Adventures of Huckleberry Finn", "Mark Twain", 2004, "https://welcometothewriterslife.com/wp-content/uploads/2018/07/The-Adventures-of-Huckleberry-Finn-702x1024.jpg")
            {
                Reviews = new List<Review>
                {
                    new Review("Jack", "A critical piece of American literature.", 5),
                    new Review("Kathy", "Intriguing narrative and depth.", 5),
                    new Review("Leo", "Complex characters, important themes.", 4)
                }
            },
            new Book("9781503215672", "The Adventures of Tom Sawyer", "Mark Twain", 2020, "https://freshcomics.s3.amazonaws.com/issue_covers/DEC181773.jpg")
            {
                Reviews = new List<Review>
                {
                    new Review("Molly", "A joy to revisit my childhood.", 5),
                    new Review("Nate", "Classic story of adventure and youth.", 4),
                    new Review("Olivia", "Twain's humor is unmatched.", 5)
                }   
            },
            new Book("9780486497273", "Life on the Mississippi", "Mark Twain", 2012, "https://pictures.abebooks.com/BOOKPILOT/md/md30405320991.jpg")
            {
                Reviews = new List<Review>
                {
                    new Review("Pete", "Fantastic insight into America's past.", 5),
                    new Review("Quinn", "Twain's wit shines through.", 4),
                    new Review("Rachel", "A bit lengthy, but worth the read.", 4)
                }
            },
            new Book("9780140367492", "The Prince and the Pauper", "Mark Twain", 1996, "https://i.thenile.io/r1000/9780140367492.jpg?r=5ee2401aa20c8")
            {
                Reviews = new List<Review>
                {
                    new Review("Steve", "Great story on social class and justice.", 5),
                    new Review("Tina", "Engaging and poignant.", 5),
                    new Review("Uma", "Beautifully written with powerful messages.", 5)
                }
            },
            new Book("9783829053884", "A Tramp Abroad", "Mark Twain", 2000, "https://pictures.abebooks.com/isbn/9783829053884-us.jpg")
            {
                Reviews = new List<Review>
                {
                    new Review("Victor", "Laugh out loud funny and brilliantly observant.", 4),
                    new Review("Wendy", "Twain's travelogues are a joy.", 5),
                    new Review("Xander", "A delightful read from start to finish.", 5)
                }
            },
            new Book("9780451532206", "The Mysterious Stranger and Other Stories", "Mark Twain", 2012, "https://cdn2.penguin.com.au/covers/original/9780451532206.jpg")
            {
                Reviews = new List<Review>
                {
                    new Review("Yolanda", "Provocative and deeply philosophical.", 5),
                    new Review("Zach", "Twain explores the darker sides of society.", 4),
                    new Review("Amy", "Captivating tales with strong moral questions.", 4)
                }
            },
            new Book("9780486427041", "Roughing It", "Mark Twain", 1965, "https://i.thriftbooks.com/api/imagehandler/m/ED640211D229F082535C11D84EEC1A5429D24407.jpeg")
            {
                Reviews = new List<Review>
                {
                    new Review("Bill", "A hilarious and wild adventure.", 5),
                    new Review("Cathy", "Twain's humor and sharp wit never fail.", 5),
                    new Review("Don", "An essential read for Twain enthusiasts.", 5)
                }
            },
            new Book("9780141301068", "Matilda", "Roald Dahl", 1988, "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1388793265i/39988.jpg")
            {
                Reviews = 
                {
                    new Review("Eva", "Inspiring story for children and adults alike.", 5),
                    new Review("Frank", "Dahl's creativity is magical.", 5),
                    new Review("Gina", "Empowering and whimsically dark.", 4)
                }
            },
            new Book("9780141311371", "The BFG", "Roald Dahl", 1982, "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1327872673i/6319.jpg")
                {
                Reviews = 
                {
                    new Review("Hannah", "An enchanting and heartwarming story that captures the imagination.", 5),
                    new Review("Ian", "A giant of a tale with a huge heart!", 5),
                    new Review("Julie", "Dahl captures the wonder of childhood perfectly.", 4)
                }
            },
            new Book("9780375814242", "James and the Giant Peach", "Roald Dahl", 1961, "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1320412586i/6689.jpg")
            {
                Reviews = 
                {
                    new Review("Kevin", "A wild, adventurous ride with a heartwarming narrative.", 5),
                    new Review("Lori", "Creative and thrilling, a perfect read for any child.", 5),
                    new Review("Mike", "Never a dull moment with Dahl's vivid imagination!", 4)
                }
            },
            new Book("9780590032490", "The Witches", "Roald Dahl", 1981, "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1351707720i/6327.jpg")
            {
                Reviews = 
                {
                    new Review("Nina", "Deliciously terrifying and fun for young readers.", 5),
                    new Review("Omar", "Dahl's storytelling at its finest—spooky and hilarious.", 5),
                    new Review("Patty", "A spooky story that teaches bravery and cleverness.", 4)
                }
            },
            new Book("9780141318301", "The Twits", "Roald Dahl", 2004, "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1406090629i/31456.jpg")
            {
                Reviews = 
                {
                    new Review("Quincy", "Mischievously entertaining with a good moral.", 4),
                    new Review("Rachel", "Hilarious and gross in equal measure. Classic Dahl!", 5),
                    new Review("Sam", "A tale of two terrible people and the mischief they cause.", 5)
                }
            },
            new Book("9780375822070", "Fantastic Mr. Fox", "Roald Dahl", 1970, "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1390097292i/6693.jpg")
            {
                Reviews = 
                {
                    new Review("Tina", "A clever, quick, and delightful read.", 5),
                    new Review("Ursula", "Dahl's wit shines through in this cunning tale.", 5),
                    new Review("Victor", "Short and sweet, a perfect story for bedtime.", 4)
                }
            },
            new Book("9780224064903", "George's Marvellous Medicine", "Roald Dahl", 2003, "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1348265460i/74532.jpg")
            {
                Reviews = 
                {
                    new Review("Wendy", "Inventive and funny with just a hint of madness.", 5),
                    new Review("Xavier", "Wildly imaginative and definitely one of Dahl's best.", 5),
                    new Review("Yasmin", "A fantastic story that mixes humor with a bit of dark fantasy.", 4)
                }
            },
            new Book("9780375814259", "Danny the Champion of the World", "Roald Dahl", 2002, "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1437500743i/6690.jpg")
            {
                Reviews = 
                {
                    new Review("Zach", "Heartwarming and thrilling! A tale of father-son adventure.", 5),
                    new Review("Amy", "A beautiful narrative that captures the essence of heroism and family.", 5),
                    new Review("Bill", "Dahl proves again why he is a master storyteller.", 4)
                }
            },
            new Book("9780224064927", "Esio Trot", "Roald Dahl", 1990, "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1348269116i/194755.jpg")
            {
                Reviews = 
                {
                    new Review("Cathy", "A sweet, quirky love story hidden within a comical little tale.", 5),
                    new Review("Don", "Short and heartwarming—a lesser known gem by Dahl.", 5),
                    new Review("Eva", "Funny and charming, with a touch of whimsy.", 4)
                }
            },
            new Book("9780141311296", "The Magic Finger", "Roald Dahl", 1966, "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1434928966i/6670.jpg")
            {
                Reviews = 
                {
                    new Review("Frank", "Provocative and engaging—a moral story told with wit.", 5),
                    new Review("Gina", "A delightful read that sparks imagination in all ages.", 5),
                    new Review("Hannah", "Simple yet powerful, with a strong message on empathy.", 5)
                }
            },
            new Book("9780140568196", "The Giraffe and the Pelly and Me", "Roald Dahl", 1985, "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1165604309i/6694.jpg")
            {
                Reviews = 
                {
                    new Review("Ian", "A fun, fantastical story with charming characters.", 5),
                    new Review("Julie", "Creative and cheerful—a story that sings with joy.", 5),
                    new Review("Kevin", "Perfect for young readers with a love for adventure and animals.", 4)
                }
            },
            new Book("9780679729891", "Tales of the Unexpected", "Roald Dahl", 1990, "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1403167344i/394689.jpg")
            {
                Reviews = 
                {
                    new Review("Lori", "A collection of twisted tales that intrigue and entertain.", 5),
                    new Review("Mike", "Darkly humorous and brilliantly unpredictable.", 5),
                    new Review("Nina", "Each story is a masterpiece of suspense and surprise.", 5)
                }
            },
            new Book("9780140018325", "Kiss Kiss", "Roald Dahl", 1987, "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1642048419i/44521.jpg")
            {
                Reviews = 
                {
                    new Review("Omar", "A stunning collection of Dahl's short stories, each with a unique twist.", 5),
                    new Review("Patty", "Engaging, dark, and thoroughly enjoyable.", 5),
                    new Review("Quincy", "Brilliant narratives that keep you at the edge of your seat.", 4)
                }
            }
        };
    }

        private void InitializeDataGridView()
        {
            dataGridViewBooks.Columns.Add("ISBN", "ISBN");
            dataGridViewBooks.Columns.Add("Title", "Title");
            dataGridViewBooks.Columns.Add("Author", "Author");
            dataGridViewBooks.Columns.Add("Year", "Year");

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Details",
                Name = "Details",  // Ensure this name is set correctly
                Text = "View Details",
                UseColumnTextForButtonValue = true
            };
            dataGridViewBooks.Columns.Add(btnColumn);
        }

        private void PopulateDataGridView()
        {
            if (books != null && books.Any())
            {
                comboBoxAuthor.DataSource = books.Select(b => b.Author).Distinct().ToList();
                comboBoxAuthor.SelectedIndex = -1; // No selection by default
                UpdateDataGridView(books); // Show all books initially
            }
        }

        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var detailsColumn = dataGridViewBooks.Columns["Details"];
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewBooks.Rows.Count && e.ColumnIndex == detailsColumn.Index)
            {
                int bookIndex = (currentPage * pageSize) + e.RowIndex;
                if (bookIndex < displayedBooks.Count)
                {
                    var selectedBook = displayedBooks[bookIndex];
                    FrmDetails detailsForm = new FrmDetails(selectedBook);
                    detailsForm.ShowDialog();
                }
            }
        }

        private void comboBoxAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAuthor.SelectedItem != null)
            {
                string selectedAuthor = comboBoxAuthor.SelectedItem.ToString();
                var filteredBooks = books.Where(b => b.Author == selectedAuthor).ToList();
                UpdateDataGridView(filteredBooks);  // Update grid with filtered books
            }
        }

        private void UpdateDataGridView(List<Book> filteredBooks)
        {
            displayedBooks = filteredBooks ?? new List<Book>();
            CalculateTotalPages(displayedBooks.Count);
            DisplayPage(0); // Start from the first page
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter search text.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var searchResults = books.Where(b => b.ISBN.ToLower().Contains(searchText) || b.Title.ToLower().Contains(searchText)).ToList();
            if (searchResults.Count == 0)
            {
                MessageBox.Show("No books found matching the search criteria.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            UpdateDataGridView(searchResults);  // Update grid with search results
        }

        private void DisplayPage(int page)
        {
            if (displayedBooks == null || !displayedBooks.Any())
            {
                MessageBox.Show("No books available to display.");
                return;
            }

            int skip = page * pageSize;
            var pageData = displayedBooks.Skip(skip).Take(pageSize).ToList();

            dataGridViewBooks.Rows.Clear();
            foreach (var book in pageData)
            {
                dataGridViewBooks.Rows.Add(book.ISBN, book.Title, book.Author, book.Year);
            }

            lblPageInfo.Text = $"Page {currentPage + 1} of {totalPageCount}";
            UpdatePagingButtons();
        }

        private void CalculateTotalPages(int itemCount)
        {
            totalPageCount = (int)Math.Ceiling(itemCount / (double)pageSize);
            UpdatePagingButtons();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPageCount - 1)
            {
                currentPage++;
                DisplayPage(currentPage);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                DisplayPage(currentPage);
            }
        }

        private void UpdatePagingButtons()
        {
            // Enable or disable the 'Previous' button
            btnPrevious.Enabled = currentPage > 0;

            // Enable or disable the 'Next' button
            btnNext.Enabled = currentPage < totalPageCount - 1;

            //Hide or show paging buttons based on the count of displayedBooks
            btnPrevious.Visible = btnNext.Visible = (totalPageCount > 1);
        }
    }

    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string ImageUrl { get; set; }
        public List<Review> Reviews { get; set; } = new List<Review>();

        public Book(string isbn, string title, string author, int year, string imageUrl)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Year = year;
            ImageUrl = imageUrl;
        }
    }

    public class Review
    {
        public string Username { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }

        public Review(string username, string comment, int rating)
        {
            Username = username;
            Comment = comment;
            Rating = rating;
        }
    }
}
