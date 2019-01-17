using System.Collections.Generic;

namespace QuestionGenerator
{
    /// <summary>
    /// A dumb but simple way to store the questions, feel free to add more
    /// </summary>
    internal static class QuestionsLibrary
    {
        internal static List<Question> JuniorNetDevQuestions
        {
            get
            {
                return new List<Question>
                {
                    new Question
                    {
                        Number = 1,
                        Category = Category.Industry,
                        Content = "What is **IaaS**, **Paas**, **SaaS**?",
                        Point = 2
                    },
                    new Question
                    {
                        Number = 2,
                        Category = Category.Industry,
                        Content = "Name any popular back-end & front-end framework that you're familiar with.",
                        Point = 2
                    },
                    new Question
                    {
                        Number = 3,
                        Category = Category.Industry,
                        Content = "Name any popular IDE that you're familiar with.",
                        Point = 2
                    },
                    new Question
                    {
                        Number = 4,
                        Category = Category.Industry,
                        Content = "Name any popular version control system that you're familiar with.",
                        Point = 2
                    },
                    new Question
                    {
                        Number = 5,
                        Category = Category.Industry,
                        Content = "Name any popular data storage technology that you're familiar with.",
                        Point = 1
                    },
                    new Question
                    {
                        Number = 6,
                        Category = Category.Industry,
                        Content = "What's the difference between REST WS and SOAP WS?",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 7,
                        Category = Category.Industry,
                        Content = "What's the difference between a MVC application and a SPA?",
                        Point = 4
                    },
                    new Question
                    {
                        Number = 8,
                        Category = Category.Industry,
                        Content = "Can you explain Model, Controller and View in MVC?",
                        Point = 4
                    },
                    new Question
                    {
                        Number = 9,
                        Category = Category.Industry,
                        Content = "What is the use of ViewModel in MVC?",
                        Point = 3
                    },
                    new Question
                    {
                        Number = 10,
                        Category = Category.Industry,
                        Content = "What is Attribute Routing in MVC?",
                        Point = 4
                    },
                    new Question
                    {
                        Number = 11,
                        Category = Category.Industry,
                        Content = "Explain Sections in ASP.NET?",
                        Point = 3
                    },
                    new Question
                    {
                        Number = 12,
                        Category = Category.Industry,
                        Content = "Can a view be shared across multiple controllers?",
                        Point = 2
                    },
                    new Question
                    {
                        Number = 1,
                        Category = Category.Programming,
                        Content = "What's the difference between `static` and `const` keywords in C#?",
                        Point = 4
                    },
                    new Question
                    {
                        Number = 2,
                        Category = Category.Programming,
                        Content = "What is **CLI** and **CLR**?",
                        Point = 3
                    },
                    new Question
                    {
                        Number = 3,
                        Category = Category.Programming,
                        Content = " What's the difference between a **Transient** type and a **Singleton** type in Dependency Injection?",
                        Point = 2
                    },
                    new Question
                    {
                        Number = 4,
                        Category = Category.Programming,
                        Content = "What is a `Class` and what is a `Struct` in C#?",
                        Point = 4
                    },
                    new Question
                    {
                        Number = 5,
                        Category = Category.Programming,
                        Content = "When does the garbage collection get triggered in C#?",
                        Point = 2
                    },
                    new Question
                    {
                        Number = 6,
                        Category = Category.Programming,
                        Content = "What is managed and unmanaged resources in C#?",
                        Point = 2
                    },
                    new Question
                    {
                        Number = 7,
                        Category = Category.Programming,
                        Content = "How do you clean up unmanaged resources in C#?",
                        Point = 2
                    },
                    new Question
                    {
                        Number = 8,
                        Category = Category.Programming,
                        Content = "What is a **Value** type and what is a **Reference** type in C#?",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 9,
                        Category = Category.Programming,
                        Content = "Tell the difference between `public`, `protected`, `internal`, `private` classes in C#. Bonus Point: `private protected`.",
                        Point = 4
                    },
                    new Question
                    {
                        Number = 10,
                        Category = Category.Programming,
                        Content = "What are the return types of an Async method in C#? Bonus Point: `ValueTask<TResult>` in C# 7.0",
                        Point = 3
                    },
                    new Question
                    {
                        Number = 11,
                        Category = Category.Programming,
                        Content = "What's the difference between Unit Test and Functional Test?",
                        Point = 2
                    },
                    new Question
                    {
                        Number = 12,
                        Category = Category.Programming,
                        Content = "What is `virtual` in C#?",
                        Point = 3
                    },
                    new Question
                    {
                        Number = 13,
                        Category = Category.Programming,
                        Content = "What's the difference between `constant` and `readonly` in C#?",
                        Point = 2
                    },
                    new Question
                    {
                        Number = 14,
                        Category = Category.Programming,
                        Content = "What are **extension methods** in C#?",
                        Point = 2
                    },
                    new Question
                    {
                        Number = 15,
                        Category = Category.Programming,
                        Content = "What is Serialization in C#?",
                        Point = 3
                    },
                    new Question
                    {
                        Number = 16,
                        Category = Category.Programming,
                        Content = "How many clustered indexes can be created on single table?",
                        Point = 1
                    },
                    new Question
                    {
                        Number = 17,
                        Category = Category.Programming,
                        Content = "What is the difference between Cluster and Non-Cluster Index?",
                        Point = 1
                    },
                    new Question
                    {
                        Number = 18,
                        Category = Category.Programming,
                        Content = "What is a View in SQL?",
                        Point = 1
                    },
                    new Question
                    {
                        Number = 19,
                        Category = Category.Programming,
                        Content = "What is a trigger in SQL?",
                        Point = 2
                    },
                    new Question
                    {
                        Number = 20,
                        Category = Category.Programming,
                        Content = "What is the difference between DELETE and TRUNCATE command in SQL?",
                        Point = 3
                    },
                    new Question
                    {
                        Number = 21,
                        Category = Category.Programming,
                        Content = "How to select unique records from a table in SQL?",
                        Point = 2
                    },
                    new Question
                    {
                        Number = 22,
                        Category = Category.Programming,
                        Content = "What are the types of join and explain each?",
                        Point = 3
                    },
                    new Question
                    {
                        Number = 1,
                        Category = Category.Algo,
                        Content = "Explain Bubble Sort algo and its complexity.",
                        Point = 4
                    },
                    new Question
                    {
                        Number = 2,
                        Category = Category.Algo,
                        Content = "Explain Quick Sort algo and its complexity.",
                        Point = 4
                    },
                    new Question
                    {
                        Number = 3,
                        Category = Category.Algo,
                        Content = "Explain Merge Sort algo and its complexity.",
                        Point = 4
                    },
                    new Question
                    {
                        Number = 4,
                        Category = Category.Algo,
                        Content = "Describe Breadth First Search and its complexity.",
                        Point = 4
                    },
                    new Question
                    {
                        Number = 5,
                        Category = Category.Algo,
                        Content = "Describe Depth First Search and its complexity.",
                        Point = 4
                    },
                    new Question
                    {
                        Number = 6,
                        Category = Category.Algo,
                        Content = @"Describe what this function does:
public static void Main()
{
    string str = Console.ReadLine();
    char[] str1 = str.ToCharArray();
    for (int j = 0; j < str1.Length / 2; j++)
    {
        char temp;
        temp = str1[j];
        str1[j] = str1[str1.Length - j - 1];
        str1[str1.Length - j - 1] = temp;
    }
    for (int i = 0; i < str1.Length; i++)
        Console.Write(str1[i]);
    Console.ReadLine();
}",
                        Point = 4
                    },
                    new Question
                    {
                        Number = 1,
                        Category = Category.DataStructure,
                        Content = "Describe what is a Hash Table.",
                        Point = 3
                    },
                    new Question
                    {
                        Number = 2,
                        Category = Category.DataStructure,
                        Content = "Describe what is a Stack.",
                        Point = 3
                    },
                    new Question
                    {
                        Number = 3,
                        Category = Category.DataStructure,
                        Content = "Describe What is a Queue.",
                        Point = 3
                    },
                    new Question
                    {
                        Number = 4,
                        Category = Category.DataStructure,
                        Content = "Describe What is a Binary Tree.",
                        Point = 3
                    }
                };
            }
        }

        internal static List<Question> SeniorFrontDevQuestions
        {
            get
            {
                return new List<Question>
                {
                    new Question
                    {
                        Number = 1,
                        Category = Category.Html,
                        Content = "What is doctype? Why do u need it?",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 2,
                        Category = Category.Html,
                        Content = "What is the use of data attribute?",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 3,
                        Category = Category.Html,
                        Content = "How can u highlight text in html?",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 4,
                        Category = Category.Html,
                        Content = @"http request  ```<img src=""mypic.jpg"" style=""visibility: hidden"" alt=""My photo"">``` ```<div style=""display: none;""> <img src=""mypic.jpg"" alt=""My photo""> </div> ```",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 5,
                        Category = Category.Html,
                        Content = "Describe the difference between a `cookie`, `sessionStorage` and `localStorage`.",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 6,
                        Category = Category.Html,
                        Content = "When should you use `section`, `div` or `article`?",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 7,
                        Category = Category.Html,
                        Content = "How do you serve a page with content in multiple languages?",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 8,
                        Category = Category.Html,
                        Content = "Why is it generally a good idea to position CSS `<link>`s between `<head></head>` and JS `<script>`s just before `</body>`? Do you know any exceptions?",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 1,
                        Category = Category.CSS,
                        Content = "Describe Floats and how they work.",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 2,
                        Category = Category.CSS,
                        Content = "How would you approach fixing browser-specific styling issues?",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 3,
                        Category = Category.CSS,
                        Content = "Type of position.",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 4,
                        Category = Category.CSS,
                        Content = "Have you used or implemented media queries or mobile specific layouts/CSS?",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 5,
                        Category = Category.CSS,
                        Content = "What are the advantages/disadvantages of using CSS preprocessors?",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 6,
                        Category = Category.CSS,
                        Content = "What does `{ box-sizing: border-box; }` do? What are its advantages?",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 7,
                        Category = Category.CSS,
                        Content = "What is the CSS display property and can you give a few examples of its use?",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 8,
                        Category = Category.CSS,
                        Content = "CSS framworks ex?",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 9,
                        Category = Category.CSS,
                        Content = "How u can use pseudo classes?",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 1,
                        Category = Category.Javascript,
                        Content = "Explain `Arrow` function.",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 2,
                        Category = Category.Javascript,
                        Content = "Describe `this`.",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 3,
                        Category = Category.Javascript,
                        Content = "What is `IIFE`?",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 4,
                        Category = Category.Javascript,
                        Content = "How many data-types do u know?",
                        Point = 5
                    },
                    new Question
                    {
                        Category = Category.Javascript,
                        Content = "What is a `closure`?",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 6,
                        Category = Category.Javascript,
                        Content = "Explain curring, hoisting.",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 7,
                        Category = Category.Javascript,
                        Content = "Can you give an example for destructuring an object or an array?",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 8,
                        Category = Category.Javascript,
                        Content = "What's the difference between a variable that is: `null`, `undefined` or `undeclared`?",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 9,
                        Category = Category.Javascript,
                        Content = "What's the difference between an `attribute` and a `property`?",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 10,
                        Category = Category.Javascript,
                        Content = "What is the difference between `==` and `===`?",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 11,
                        Category = Category.Javascript,
                        Content = "How would you Merge objects in es6?",
                        Point = 5
                    },
                    new Question
                    {
                        Number = 12,
                        Category = Category.Javascript,
                        Content = "What are the differences between variables created using `let`, `var` or `const`?",
                        Point = 5
                    }
                };
            }
        }
    }
}
