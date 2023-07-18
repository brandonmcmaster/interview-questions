using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class InterviewGame
    {

        private Dictionary<string, string> questionsAndAnswers = new Dictionary<string, string>()
        {
            {"What is git? Why do we use it?",
                "Git is a distributed version control system that tracks changes to source code, enabling multiple developers to work on a project simultaneously. We use Git for its capabilities in version control, collaboration, branching and merging, and its integration with platforms like GitHub." },
           
            {"What is a variable? Can you give an example of an integer expression? A boolean expression?",
                "A variable is a symbolic name for a value that can change. In programming, it's used to store data.\r\n\r\nAn example of an integer expression is 3 + 4 * 2, which equals 11.\r\n\r\nA boolean expression could be 10 > 9, which evaluates to True." },
            
            {"What controls whether the “if” or the “else” portion of an if-else should execute?" ,
                "The \"if\" or \"else\" portion of an if-else statement executes based on the result of the condition in the \"if\" statement. If the condition is true, the \"if\" block executes; if the condition is false, the \"else\" block executes."},
            
            {"Why should the code for each if or else be enclosed in a scope “{ }”?",
                "The {} braces define a block of code or a scope. They ensure that multiple statements under an if or else execute together. If you omit {}, only the immediate next line is considered part of the if or else, which could lead to logic errors." },
            
            {"What programming problem does a loop solve? Why would we use a loop?\r\n",
                "A loop solves the problem of repeating tasks in code. We use a loop to perform an operation multiple times without writing the same code repeatedly. This makes our code more efficient, easier to read, and simpler to maintain." },
            
            {"How do we display information on the console? How do we take in information from the user in a console program?",
                "In C#, you use `Console.WriteLine()` to display information on the console. For example, `Console.WriteLine(\"Hello, World!\");`.\r\n\r\nTo take in information from the user, you use `Console.ReadLine()`. For example, `string userInput = Console.ReadLine();`." },
            
            {" What is an object? What is a class?",
                "In C#, an object is an instance of a class. It's a data structure that contains data and methods.\r\n\r\nA class is a blueprint for creating objects. It defines the data and behavior that the created objects can have." },
            
            {"How is an array like a List(C#) / ArrayList(Java)? How are they different?\r\n",
                "Arrays and Lists in C# (or ArrayLists in Java) both store multiple values. They can be accessed using indices.\r\n\r\nHowever, arrays have a fixed size once defined, while Lists (ArrayLists) are dynamic and can grow or shrink at runtime. Also, Lists provide more built-in methods such as `Add()`, `Remove()`, etc. compared to arrays." },
            
            {"Tell me about a Dictionary(C#) / HashMap(Java)." ,
                "A Dictionary in C# (or HashMap in Java) is a collection of key-value pairs. Keys are unique, while values may not be.\r\n\r\nUnlike arrays or Lists, data in a Dictionary or HashMap is accessed via keys, not numeric indices. This allows for efficient retrieval of values when the key is known." },
            
            {"What is encapsulation? Why is it important?\r\n",
                "Encapsulation is a principle of object-oriented programming where the data (variables) and methods operating on that data are bundled together in a class.\r\n\r\nIt's important because it hides the internal state of one object from others. This enhances security, prevents data corruption, and makes code easier to maintain and understand." },
            
            {"What is Inheritance? Why, as a programmer, would you choose to use Inheritance?",
                "Inheritance is a concept in object-oriented programming where a class can inherit properties and methods from another class.\r\n\r\nYou'd use inheritance to promote code reusability and create a logical, hierarchical structure for your classes. It helps in making code easier to manage, understand, and extend." },
           
            {"What is polymorphism? How is polymorphism like inheritance? How is it different?",
                "Polymorphism, a concept in object-oriented programming, allows one interface to represent different underlying forms. In C#, this could mean methods with the same name behaving differently based on their data types or number of parameters.\r\n\r\nPolymorphism is similar to inheritance in that they both promote flexibility and extensibility in code. However, while inheritance allows classes to inherit properties and methods from a parent class, polymorphism allows methods to perform different actions based on the object they're acting upon." },
            
            {"What is an interface, and why would you use one?", "An interface in C# defines a contract for classes. It outlines specific methods or properties a class must implement.\r\n\r\nYou use interfaces to enforce certain behaviors across different classes. This enables loose coupling, making your code more modular, adaptable, and testable." },
            
            {"How are abstract classes and interfaces alike? How are they different?\r\n",
                "Abstract classes and interfaces in C# are alike in that they both define contracts for other classes to implement.\r\n\r\nHowever, they differ in several ways. An abstract class can provide some method implementation, while interfaces can't. A class can implement multiple interfaces, but it can only inherit from one abstract (or any other) class. Abstract classes can also have constructors and fields, which interfaces cannot have." },
            
            {"What is Unit Testing? What tools are used to do automated Unit Testing?\r\n",
                "Unit testing involves testing individual components (or \"units\") of software to verify that they behave as intended.\r\n\r\nFor automated unit testing in a .NET environment, NUnit and MSTest are commonly used. These frameworks allow developers to write tests, automate execution, and report results. Xunit is another popular choice for .NET Core." },
            
            {"What are the three principles of Object Oriented Programming?  Give an example for each.", "The three principles of Object Oriented Programming are Encapsulation, Inheritance, and Polymorphism.\r\n\r\n1. **Encapsulation**: Data and methods are wrapped together in a class. For example, a `Person` class could encapsulate properties like `Name` and `Age`, and methods like `Speak()`.\r\n\r\n2. **Inheritance**: A class can inherit properties and methods from a parent class. For instance, a `Student` class could inherit from the `Person` class, thereby gaining its properties and methods.\r\n\r\n3. **Polymorphism**: A method can behave differently based on the object. For example, a `Shape` class might have a `Draw()` method. This method would behave differently if called on objects of the `Circle` or `Rectangle` class, assuming they inherit from `Shape`." },
            
            {"When catching Exceptions, should the code catch a specific exception type (like \"Subscript out of bounds\")  or the general \"Exception\" type? Why?\r\n", "It's generally best to catch specific exceptions. This allows you to handle different exception types in a tailored manner. Catching the general \"Exception\" type should be a last resort, as it can make debugging harder by masking other unexpected or unknown errors." },
            
            {"When writing files, what does it mean to append? What does it mean to not append?",
                "Appending to a file means adding new data at the end of the file's existing content.\r\n\r\nNot appending, often referred to as \"overwriting\", means replacing the file's existing content with the new data. If the file doesn't exist, it's created in both cases." },

            {"For an application that has a console user interface, reads and writes information to a file, and provides the ability to do CRUD (Create, Read, Update, and Delete) functions on the data in memory while executing, how might you organize and structure the classes and methods in your code?",
                "You might structure your classes as follows:\r\n\r\n1. `DataModel` class: Represents the data you're working with, encapsulates properties relevant to the data.\r\n\r\n2. `FileHandler` class: Handles all file operations, with methods such as `ReadFromFile`, `WriteToFile`, and `AppendToFile`.\r\n\r\n3. `CrudOperations` class: Handles the in-memory CRUD operations. Methods could include `CreateData`, `ReadData`, `UpdateData`, and `DeleteData`.\r\n\r\n4. `UserInterface` class: Manages interactions with the user via console. Has methods like `DisplayMenu`, `GetUserInput`, and `DisplayData`.\r\n\r\nEach class has its own responsibilities, promoting separation of concerns and making the code more maintainable. The `Program` class would coordinate these classes to perform the required tasks." },

            {"What is pair programming? What are the basic rules? What are its advantages and disadvantages?",
                "Pair programming involves two programmers working together at one workstation. One, the \"driver\", writes code while the other, the \"navigator\", reviews each line of code as it's typed in.\r\n\r\nBasic rules include:\r\n1. Switch roles regularly.\r\n2. Both partners must understand the code.\r\n3. Constant communication is key.\r\n\r\nAdvantages include:\r\n1. Improved code quality due to instant review.\r\n2. Knowledge sharing and improved team collaboration.\r\n3. Faster problem solving.\r\n\r\nDisadvantages include:\r\n1. It may be less efficient for simpler tasks.\r\n2. Conflicts may arise from differences in coding style or approach.\r\n3. It requires good communication skills and patience." },

            {"What is an RDBMS?  Can you name some commercial and open-source RDBMS's?",
                "An RDBMS, or Relational Database Management System, is software for creating and managing databases based on the relational model.\r\n\r\nCommercial RDBMSs include Oracle Database, Microsoft SQL Server, and IBM DB2.\r\n\r\nOpen-source RDBMSs include MySQL, PostgreSQL, and SQLite." },

            {"The major elements of a SQL SELECT are written in a certain order. What's that Order? (Hint: The first two are SELECT and FROM.)",
                "The order of major elements in a SQL SELECT statement is as follows:\r\n\r\n1. SELECT\r\n2. FROM\r\n3. WHERE\r\n4. GROUP BY\r\n5. HAVING\r\n6. ORDER BY\r\n\r\nEach clause is optional except for SELECT and FROM." },

            {"What are the special considerations for GROUP BY in SQL queries? \r\n",
                "In SQL, GROUP BY is used to group rows with the same values in specified columns into aggregated data.\r\n\r\nSpecial considerations include:\r\n\r\n1. GROUP BY clause can group by one or more columns.\r\n2. Columns in the SELECT statement that are not aggregated should be included in the GROUP BY clause.\r\n3. It's often used with aggregate functions (COUNT, MAX, MIN, SUM, AVG) to perform calculations on each group.\r\n4. WHERE clause is applied before GROUP BY. HAVING is applied after and is used to filter the groups." },

            {"What are the two forms of the INSERT statement in SQL? Which is preferred? Why?",
                "The two forms of the INSERT statement in SQL are:\r\n\r\n1. INSERT INTO table_name VALUES (value1, value2, ...);\r\n2. INSERT INTO table_name (column1, column2, ...) VALUES (value1, value2, ...);\r\n\r\nThe second form is generally preferred. It allows for clarity by specifying column names and enables insertion into specific columns, even if you don't have values for all columns." },

            {"Why would a developer want to develop and maintain a SQL script for a database under development or being changed?",
                "A developer would maintain a SQL script for a few reasons:\r\n\r\n1. Reproducibility: Scripts can recreate the database schema or data whenever needed, useful for testing or deploying to new environments.\r\n2. Version Control: Scripts allow tracking of changes over time, and enable reverting to a previous state if necessary.\r\n3. Collaboration: Scripts make it easier for team members to understand database structure and apply consistent changes.\r\n4. Automation: Database creation or modification can be automated using scripts, reducing manual errors." },

            {"What is a DAO, and what OOP principal does in most clearly express?",
                "A DAO, or Data Access Object, is a design pattern that provides an abstract interface for accessing data from different sources like databases or APIs.\r\n\r\nDAO most clearly expresses the principle of encapsulation in OOP. It hides the complexity of data access operations from the rest of the application, providing a simpler interface to interact with data sources." },

            {"Why is it important to use parameter substitution rather than string concatenation when building SQL strings inside of code? Extra credit: Who is Little Bobby Tables?",
                "Using parameter substitution rather than string concatenation prevents SQL Injection attacks, which occur when malicious SQL code is inserted into a query. Parameter substitution ensures input is treated as literal data rather than executable code.\r\n\r\nExtra credit: \"Little Bobby Tables\" is a character from the \"xkcd\" comic strip, used to humorously illustrate the dangers of SQL Injection. His real name in the strip is \"Robert'); DROP TABLE Students;--\", which, if inserted into a database query without proper precautions, would delete the \"Students\" table." },

            {"What software vulnerability is totally under the control of the programmer (even a junior developer)?",
                "\"Hardcoding sensitive information\" is a software vulnerability fully under the control of the programmer, even a junior developer. This includes embedding passwords, encryption keys, or API keys directly into the source code. This practice is a security risk and is easily avoidable by using secure methods of configuration management and environment variables." },

            {"What are some examples of Integration Testing?\r\n",
                "Integration testing involves testing how different components of a system work together. Examples include:\r\n\r\n1. Testing a client-server communication: Checking if the client and server components interact correctly.\r\n2. Testing database integration: Verifying the application's interaction with the database.\r\n3. Testing web services: Checking how your application interacts with external services.\r\n4. Testing UI with backend: Ensuring the user interface works correctly with the backend logic.\r\n5. Testing API endpoints: Making sure different APIs interact as expected when used in combination." },

            {"Why would you want to use SQL to select the specific information you need inside your program? Why not just select all the information from a table and hold it in a collection inside your program?",
                "Using SQL to select specific information is more efficient for two main reasons:\r\n\r\n1. Network Efficiency: It reduces the amount of data sent over the network, speeding up data transfer times.\r\n2. Memory Efficiency: It minimizes memory usage in your application by only holding necessary data.\r\n\r\nSelecting all data can lead to performance issues, especially with large datasets. It also increases the risk of exposing sensitive information." },

            {"What does the first forward slash (\"/\") in a URL represent? What does the question mark {\"?\") in a URL represent?",
                "In a URL, the first forward slash (\"/\") after the domain name is used to separate the domain from the path to a specific resource or page within the website.\r\n\r\nThe question mark (\"?\") in a URL is used to start the query string, which typically includes parameters to be sent to a server-side script. It separates the path from the parameters." },

            {"In HTTP, how are the GET and POST verbs alike? How are they different?",
                "GET and POST are HTTP methods used to request data from a server.\n\nSimilarities:\n1. They can both send requests to the server.\n2. They're both used in the HTTP request/response process.\n\nDifferences:\n1. GET appends data to the URL (in the query string), while POST sends data in the body of the HTTP request.\n2. GET is idempotent (repeated requests have the same effect as a single one), while POST is not.\n3. GET requests can be cached and bookmarked, POST requests cannot.\n4. GET has length restrictions, while POST does not."},

            {"Assume four blocks of code: 1) Controller and 2) Model/DAOs for a server and 3) User Interface, and 4) API Service for a client. Describe the flow of a REST request and response. Describe the role/responsibility of each block of code.",
                "Here's the flow of a REST request and response:\n\n1. **User Interface (Client)**: The user interacts with the UI, which triggers a REST request to the server (for example, to get data).\n\n2. **API Service (Client)**: The API Service processes this request, formats it correctly (often as an HTTP request), and sends it to the server.\n\n3. **Controller (Server)**: The server's controller receives the request. It determines what the client is asking for, and directs the request to the appropriate model or DAO for processing.\n\n4. **Model/DAOs (Server)**: The Model or DAO interacts with the server's database or data source to carry out the request. It retrieves or manipulates the data as needed.\n\n5. The data or result is sent back to the Controller, which then formats it into a suitable HTTP response.\n\n6. This response is sent back to the API Service on the client side.\n\n7. **API Service (Client)**: The API Service on the client receives this response. It processes the data as necessary (like converting from JSON to JavaScript objects) and sends it to the UI.\n\n8. **User Interface (Client)**: The UI receives this data and uses it to update the interface, completing the request/response cycle.\n\nEach block of code has its own responsibilities, separating concerns and making the system more maintainable."},

            {"How can we test that our client-server application is following the rules and protocols of REST?",
                "To test if a client-server application follows REST principles, you can:\n\n1. Use tools like Postman or curl to send requests to your server and examine the responses. Verify that they use standard HTTP methods (GET, POST, PUT, DELETE), have meaningful status codes, and return data in a stateless manner.\n\n2. Ensure resources are identified by URLs and that the application adheres to a logical, consistent URL structure.\n\n3. Check that the responses are in a standard format like JSON or XML.\n\n4. Ensure the application is stateless, i.e., server responses are independent of previous requests.\n\n5. Test for idempotency, meaning multiple identical requests have the same effect as a single one.\n\n6. Use automated testing frameworks to continuously test these aspects.\n\nThese measures will help confirm that your application is abiding by REST conventions."},

            {"What is a JWT? How is it generated, and how is it used?\n",
                "JWT stands for JSON Web Token. It's a compact, URL-safe means of representing claims to be transferred between two parties. It's used for authentication and secure information exchange.\n\nA JWT is generated by:\n1. Creating a header with token type and the hashing algorithm.\n2. Creating a payload with the claims (like user details or permissions).\n3. Encoding the header and payload as JSON and then Base64Url encoding.\n4. Concatenating these with a dot separator and signing this string using the specified algorithm and a secret key.\n\nIn use, when a user logs in, the server generates a JWT and sends it back. For subsequent requests, the user's client attaches this JWT, often in the Authorization header. The server can then validate the token and verify the user's identity and permissions. This allows for stateless, sessionless authentication." },

            {"Describe MVC in the context of a Web Service running on a server.",
                "MVC stands for Model-View-Controller, a design pattern often used in web services:\n\n1. **Model**: This represents the data and the rules that govern access to and updates of this data. In a web service, models interact with the database, handling create, read, update, and delete (CRUD) operations.\n\n2. **View**: In the context of a web service, the view is the format and structure of the output sent to the client. This could be JSON, XML, or HTML depending on the service. It's how the data from the model is presented.\n\n3. **Controller**: This is the intermediary between the Model and the View. It receives client requests, interacts with the Model to get or manipulate data, and then formats this data with the View to send as a response.\n\nIn MVC, each component has a distinct responsibility, making the web service easier to maintain, test, and scale."},

            {"Why do HTTP POST and PUT use a request body? Why not just put information in the path or query string of the URL? ",
                "HTTP POST and PUT use a request body primarily for two reasons:\n\n1. Data Security: Sensitive information is safer in the request body than in the URL, as URLs can be logged or cached.\n2. Data Size: HTTP methods that use the request body can send much larger amounts of data than those using a URL. URLs have length limitations.\n\nUsing the request body also allows sending of complex data types, like nested JSON, which wouldn't be feasible in a URL. Thus, for operations that involve sending large or sensitive data, methods with request bodies are preferred."},

            {"What should HTTP status codes in the 200's indicate? The 400's? The 500's? What specific HTTP status codes do you know, and what should they mean?",
                "HTTP status codes indicate the result of the HTTP request:\n\n1. **200s**: These are successful response codes. For example:\n    - 200 OK: The request has succeeded.\n    - 201 Created: The request has been fulfilled and resulted in a new resource being created.\n    - 204 No Content: The server successfully processed the request and is not returning any content.\n\n2. **400s**: These are client error response codes. For example:\n    - 400 Bad Request: The server could not understand the request due to invalid syntax.\n    - 401 Unauthorized: The request requires user authentication.\n    - 404 Not Found: The server has not found anything matching the Request-URI.\n\n3. **500s**: These are server error response codes. For example:\n    - 500 Internal Server Error: The server encountered an unexpected condition which prevented it from fulfilling the request.\n    - 503 Service Unavailable: The server is currently unable to handle the request due to a temporary overloading or maintenance.\n\nThese codes help clients understand the server's response to their requests."},

            {"In JavaScript, should you use \"let\" or \"var\" to create variables? Why?",
                "In modern JavaScript, it's recommended to use \"let\" or \"const\" over \"var\" to declare variables. This is because:\n\n\"let\" and \"const\" have block scope, meaning they only exist within the block they're defined in. \"var\" has function scope, which can lead to unexpected behavior.\n\"let\" allows you to declare variables that can be reassigned, while \"const\" allows you to declare variables that are constant, or unchangeable.\n\"var\" is still valid JavaScript, but its usage can lead to confusion, especially for those coming from other languages where block scoping is standard." },

            {"In a world of HTML, CSS, and JavaScript, what role do each provide in the browser?",
                "In a web environment, HTML, CSS, and JavaScript each have distinct roles:\n\n1. **HTML (HyperText Markup Language)**: This is the structure of the webpage. It creates and organizes content in the form of text, images, links, and more.\n\n2. **CSS (Cascading Style Sheets)**: This is the design of the webpage. It determines how the HTML elements are displayed, including colors, layouts, fonts, and animations.\n\n3. **JavaScript**: This is the behavior of the webpage. It provides interactivity, allowing elements on the page to respond to user actions like clicks, input, and form submission.\n\nTogether, they create dynamic, interactive webpages. HTML provides the base content, CSS makes it visually appealing, and JavaScript adds user interaction."},

            {"What are some common selectors used with HTML and CSS and how are they specified in CSS?",
                "Tag or Element selector: Applies style to all elements of a specified type. It's simply the name of the HTML tag. For example, \"p { color: blue; }\" applies to all paragraph tags.\n\n2. Class selector: Applies style to all elements with the specified class. It's denoted by a period (.) followed by the class name. For example, \".myClass { font-size: 20px; }\" applies to all elements with class \"myClass\".\n\n3. ID selector: Applies style to the element with the specified ID. It's denoted by a hash (#) followed by the ID. For example, \"#myID { background-color: yellow; }\" applies to the element with ID \"myID\".\n\nNote: An ID should be unique within a page, while classes can be applied to multiple elements."},

            {"In CSS, what does it mean when multiple selectors are used together with spaces between them?  (div li)  With no space between them?  (div.hidden) With commas between them?  (div, li) With > between them (div > li) ",
                "1. \"div li\": This is a descendant selector. It selects all \"li\" elements inside a \"div\".\n2. \"div.hidden\": This is a class selector for a specific element. It selects \"div\" elements with the class \"hidden\".\n3. \"div, li\": This is a group selector. It selects all \"div\" elements and all \"li\" elements.\n4. \"div > li\": This is a child selector. It selects all \"li\" elements that are direct children of a \"div\"."},

            {"In general, what part of a web page layout should be controlled by CSS Grid? What part should be controlled by CSS Flex?",
                "\nCSS Grid is generally used for defining two-dimensional layouts, handling both columns and rows. It's ideal for larger scale layouts like whole pages or significant page sections.\n\nCSS Flexbox is typically used for one-dimensional layouts, dealing with either a column or a row at a time. It's useful for smaller-scale layouts within a page, like aligning items in a header, footer, or controlling the layout of specific components."},

            {" In JavaScript, this symbol ( => ) is referred to by what name? What JavaScript keyword does it replace? Bonus: What are some other names the symbol is called?",
                "The \"=>\" symbol in JavaScript is called an \"arrow function\". It replaces the \"function\" keyword when defining a function.\n\nBonus: Some people might also refer to it as \"fat arrow\", in contrast to a thin arrow \"->\" used in some other programming languages. The terms \"lambda\", \"anonymous function\", or \"closure\" might be used in certain contexts to refer to functions defined with the arrow syntax, but these terms have broader meanings beyond just \"=>\"."},

            {"How is the \"event-driven\" style of program execution different from the \"sequential\" style of execution we utilized in simple console programs during the first few weeks of the program?",
                "Sequential execution runs code line by line from top to bottom. It's straightforward but doesn't handle user interaction or simultaneous tasks well. \n\nEvent-driven execution responds to user actions or system events (like clicks or key presses). It's less predictable because code execution depends on the events and their order. This style is more suited for interactive applications, like websites or desktop applications, where user input needs to be processed at unknown times."}
        };

        private Random random = new Random();

        public string GetRandomQuestion()
        {
            List<string> keys = new List<string>(questionsAndAnswers.Keys);
            return keys[random.Next(keys.Count)];
        }

        public string GetAnswer(string question)
        {
            return questionsAndAnswers[question];
        }
        
    }
}
