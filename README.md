<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Library System Management - C# Project</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
        }
        .container {
            max-width: 1000px;
            margin: 20px auto;
            padding: 20px;
            background-color: #fff;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        h1, h2, h3 {
            color: #333;
        }
        img {
            max-width: 100%;
            height: auto;
            display: block;
            margin: 10px 0;
        }
        code {
            background-color: #f4f4f4;
            padding: 2px 5px;
            border-radius: 3px;
        }
        .menu {
            background-color: #007BFF;
            color: white;
            padding: 10px;
            text-align: center;
        }
        .menu a {
            color: white;
            margin: 0 10px;
            text-decoration: none;
        }
        pre {
            background-color: #f4f4f4;
            padding: 10px;
            border-left: 4px solid #007BFF;
            overflow-x: auto;
        }
        .btn {
            padding: 10px 15px;
            background-color: #007BFF;
            color: white;
            border: none;
            border-radius: 3px;
            cursor: pointer;
        }
    </style>
</head>
<body>

    <div class="container">
        <h1>Library System Management - C# Project</h1>

        <h2>Overview</h2>
        <p>This project is a <strong>Library System</strong> developed in <strong>C#</strong>, featuring both a <strong>CLI (Command Line Interface)</strong> and a <strong>GUI (Graphical User Interface)</strong>. The system allows users to manage books, members, transactions, and more through two interactive interfaces.</p>
        
        <h2>Features</h2>
        
        <h3>CLI Part</h3>
        <p>The CLI part provides a simple and efficient way to interact with the library system. Users can manage members, borrow/return books, and view the system's functionality.</p>
        <img src="path-to-your-image/cli.png" alt="CLI Menu">
        
        <ul>
            <li>Add new members</li>
            <li>View list of members</li>
            <li>Borrow and return books</li>
            <li>Exit the system</li>
        </ul>
        
        <h3>GUI Part</h3>
        <p>The GUI part offers a more user-friendly, visual way to manage the library. It includes functionalities like adding, removing, and viewing books, managing transactions, and navigating through a dashboard.</p>
        <img src="path-to-your-image/Addbookk.png" alt="GUI Dashboard">
        
        <ul>
            <li><strong>Dashboard</strong>: An overview of the library's status</li>
            <li><strong>Add Book</strong>: Add new books to the library</li>
            <li><strong>Remove Book</strong>: Remove books from the library</li>
            <li><strong>View Book</strong>: Check details of available books</li>
            <li><strong>Transactions</strong>: Manage borrowing and returning of books</li>
        </ul>
        
        <h2>Technologies Used</h2>
        <ul>
            <li><strong>C#</strong>: Programming language used for both CLI and GUI.</li>
            <li><strong>Windows Forms</strong>: For creating the graphical user interface.</li>
            <li><strong>Visual Studio</strong>: IDE for development.</li>
        </ul>
        
        <h2>How to Run</h2>
        <ol>
            <li>Clone the repository:</li>
            <pre><code>git clone https://github.com/your-username/library-system.git</code></pre>
            <li>Open the project in <strong>Visual Studio</strong>.</li>
            <li>Build and run the solution.</li>
            <li>Choose either the CLI or GUI interface based on your preference.</li>
        </ol>
        
        <h2>Screenshots</h2>
        <h3>Login Error</h3>
        <img src="path-to-your-image/login_error.png" alt="Login Error">
        
        <h3>CLI Menu</h3>
        <img src="path-to-your-image/cli.png" alt="CLI Menu">
        
        <h3>GUI Dashboard</h3>
        <img src="path-to-your-image/Addbookk.png" alt="GUI Dashboard">
        
        <h2>Future Enhancements</h2>
        <ul>
            <li>Implement a <strong>search</strong> functionality for both books and members.</li>
            <li>Add <strong>email notifications</strong> for due dates.</li>
            <li>Integrate with a <strong>database</strong> for persistent data storage.</li>
        </ul>
    </div>

</body>
</html>
