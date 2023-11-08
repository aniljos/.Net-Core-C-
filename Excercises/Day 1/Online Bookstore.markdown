**Online Bookstore System**

**Objective:**

Design and implement a console application for an online bookstore
system. The system should include classes representing different types
of books and provide functionality for customers to browse, purchase,
and manage their orders. Utilize concepts of constructors, overloaded
constructors, classes, inheritance, and polymorphism to create a
well-organized and extensible system.

**Class Hierarchy Design Instructions:**

1.  **Base Class - Book:**

-   Properties: Title, Author, Price

-   Constructors:

    -   A parameter less constructor to set default values.

    -   An overloaded constructor to initialize properties.

-   Methods: GetDetails()

2.  **Derived Classes - FictionBook and NonFictionBook**

-   Additional Properties: Genre (for FictionBook), Topic (for
    NonFictionBook)

-   Constructors: Overloaded constructors to initialize properties,
    calling the base class constructors.

-   Methods: Implement the GetDetails() method to display book details
    including specific properties

3.  **Class - Order:**

-   Properties: CustomerName, OrderedBooks (a list of Book objects),
    TotalPrice

-   Constructors:

    -   An overloaded constructor to set customer name and initialize
        the list.

-   Methods: CalculateTotalPrice(), DisplayOrderDetails()

4.  **Class - Bookstore:**

-   Properties: Inventory (a list of available books)

-   Method: GetInventory(): Fetches(returns) the available books in the
    inventory.

**Requirements:**

1.  Students should design the class hierarchy as described above,
    utilizing abstract classes, inheritance, and polymorphism
    appropriately.

2.  Implement a simple console menu allowing users to:

    a.  Browse available books (display book details)

    b.  Add books to the shopping cart

    c.  Apply discounts to selected books

    d.  View the order details, including the discounted total price

3.  Use virtual and override keywords where necessary to achieve
    polymorphic behaviour.

4.  Implement input validation to handle invalid inputs gracefully.

5.  Provide comments explaining the purpose and usage of each class and
    method.

**Example Output:**

**Welcome to the Online Bookstore!**

**Enter Your Name (Customer Name):**

*(Menu to be displayed till the user exits)*

**1. Browse Books**

**2. Add Books to Cart**

**3. Apply Discounts**

**4. View Order**

**5. Exit**

**Enter your choice: 1**

**Available Books:**

**1. Fiction - \"The Great Gatsby\" by F. Scott Fitzgerald - \$15.99**

**2. Non-Fiction - \"Sapiens: A Brief History of Humankind\" by Yuval
Noah Harari - \$19.99**

**Enter your choice: 2**

**Enter the book number to add to your cart: 1**

**Book added to cart: \"The Great Gatsby\"**

**Enter your choice: 3**

**Enter discount percentage (5% to 20%): 10**

**Discount Applied: 10%**

**Enter your choice: 4**

**Order Summary:**

**Customer Name: John Doe**

**Ordered Books:**

1.  **\"The Great Gatsby\" - \$14.39**

2.  **"Sapiens: A Brief History of Humankind\" by Yuval Noah Harari -
    \$19.99"**

**Total Price: \$34.38**

**Discount Applied: 10%**

**Discounted Total Price: \$30.94**

**Enter your choice: 5**

**Exiting Online Bookstore. Thank you,** *{Customer name}* **for
shopping with us!**

**Instructions:**

1.  **Create a project in Visual Studio 2022 for the assignment.**

2.  **To change the color of the console use**

    a.  Console.BackgroundColor = ConsoleColor.Blue;

    b.  Console.ForegroundColor = ConsoleColor.White;

3.  **Use the List class to create the Inventory**

    a.  Creating a list: List\<Book\> books = new List\<Book\>();

    b.  Adding to the list: books.Add(new Book("Name of book", "Author",
        "Price"))

    c.  The inventory can the populated with some books at
        initialization of the BookStore class.

Submission:

Once completed mail the project to <anil.jos@gmail.com> along with the
other project.
