using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using ZetPDF.Drawing;
using ZetPDF.Pdf;

namespace QuestionGenerator
{
    public class Program
    {
        // Default configuration
        private static readonly int _questions = 30;
        private static readonly int _minPoints = 40;
        private static readonly int _maxPoints = 100;
        private static readonly int _maxCategoriesFront = 3;
        private static readonly int _maxCategoriesBack = 4;

        static void Main(string[] args)
        {
            var config = SetUpQuestions();

            var y = int.TryParse(Console.ReadLine(), out int yes);
            while (!y || yes < 1 || yes > 2)
            {
                Console.WriteLine(Environment.NewLine + $"Enter a valid number!" + Environment.NewLine);
                y = int.TryParse(Console.ReadLine(), out yes);
            }
            while (yes != 1)
            {
                config = SetUpQuestions();
                y = int.TryParse(Console.ReadLine(), out yes);
                while (!y || yes < 1 || yes > 2)
                {
                    Console.WriteLine(Environment.NewLine + $"Enter a valid number!" + Environment.NewLine);
                    y = int.TryParse(Console.ReadLine(), out yes);
                }
            }

            var results = QuestionsFactory.GetQuestions((Title)Enum.Parse(typeof(Title), (config[0] - 1).ToString()), config[1], config[2], config[3]);
            Console.WriteLine(Environment.NewLine + "*************Generated Questions*************" + Environment.NewLine);
            int totalPoints = 0, i = 1;
            foreach (var result in results)
            {
                Console.WriteLine(i + $". [{result.Category.ToString()}-{result.Number}]({result.Point}p) : {result.Content}" + Environment.NewLine);
                totalPoints += result.Point;
                i++;
            }

            Console.WriteLine($"Total points : {totalPoints}" + Environment.NewLine);
            if (totalPoints != config[3])
                Console.WriteLine($"Impossible to get {config[3]} points from the library!" + Environment.NewLine);
            if (results.Count != config[2])
                Console.WriteLine($"Impossible to get {config[2]} questions from the library!" + Environment.NewLine);

            Console.WriteLine("Do you want to export the questions to PDF file?" + Environment.NewLine);
            Console.WriteLine("1. Yes" + Environment.NewLine);
            Console.WriteLine("2. No" + Environment.NewLine);
            var p = int.TryParse(Console.ReadLine(), out int pdf);
            while (!p || pdf < 1 || pdf >= 3)
            {
                Console.WriteLine(Environment.NewLine + $"Enter a valid number!" + Environment.NewLine);
                p = int.TryParse(Console.ReadLine(), out pdf);
            }

            if (pdf == 1)
            {
                Console.WriteLine(Environment.NewLine + "Give a file name that you like to the PDF document:" + Environment.NewLine);
                var fileName = Console.ReadLine();

                while (string.IsNullOrEmpty(fileName))
                {
                    Console.WriteLine("Give a file name that you like to the PDF document:" + Environment.NewLine);
                }

                GeneratePDF(results, ((Title)Enum.Parse(typeof(Title), (config[0] - 1).ToString())).ToString(), fileName);
            }

            Console.ReadLine();
        }

        private static int[] SetUpQuestions()
        {
            Console.WriteLine(Environment.NewLine + "*****Welcome to the Interview Questions Generator*****" + Environment.NewLine);
            Console.WriteLine("Enter the number of the job title" + Environment.NewLine);
            Console.WriteLine($"1.{Title.JuniorNetDev.ToString()}" + Environment.NewLine);
            Console.WriteLine($"2.{Title.SeniorFrontDev.ToString()}" + Environment.NewLine);

            var t = int.TryParse(Console.ReadLine(), out int title);
            while (!t || title < 1 || title >= 3)
            {
                Console.WriteLine(Environment.NewLine + $"Enter a valid number!" + Environment.NewLine);
                t = int.TryParse(Console.ReadLine(), out title);
            }

            Console.WriteLine(Environment.NewLine + "Enter the number of categories" + Environment.NewLine);
            var c = int.TryParse(Console.ReadLine(), out int categories);
            var nbOfC = title == (int)Title.JuniorNetDev + 1 ? _maxCategoriesBack : _maxCategoriesFront;
            while (!c || categories < 1 || categories > nbOfC)
            {
                Console.WriteLine(Environment.NewLine + $"Enter a valid number between 1 and {nbOfC}" + Environment.NewLine);
                c = int.TryParse(Console.ReadLine(), out categories);
            }

            Console.WriteLine(Environment.NewLine + "Enter the number of questions you need" + Environment.NewLine);
            var q = int.TryParse(Console.ReadLine(), out int questions);
            while (!q || questions < 1 || questions > _questions)
            {
                Console.WriteLine(Environment.NewLine + $"Enter a valid number between 1 and {_questions}" + Environment.NewLine);
                q = int.TryParse(Console.ReadLine(), out questions);
            }

            Console.WriteLine(Environment.NewLine + "Enter the total points of your questions" + Environment.NewLine);
            var p = int.TryParse(Console.ReadLine(), out int points);
            while (!p || points < _minPoints || points > _maxPoints)
            {
                Console.WriteLine(Environment.NewLine + $"Enter a valid number between {_minPoints} and {_maxPoints}" + Environment.NewLine);
                p = int.TryParse(Console.ReadLine(), out points);
            }

            Console.WriteLine(Environment.NewLine + $"You're about to generate questions for the summary below" + Environment.NewLine);
            Console.WriteLine("***********************************************");
            Console.WriteLine($"Job Title : { (title == 1 ? Title.JuniorNetDev.ToString() : Title.SeniorFrontDev.ToString()) }");
            Console.WriteLine($"Number of Question Categories : {categories}");
            Console.WriteLine($"Number of Questions : {questions}");
            Console.WriteLine($"Total Points of Questions : {points}");
            Console.WriteLine("***********************************************" + Environment.NewLine);

            Console.WriteLine("Do you confirm?" + Environment.NewLine);
            Console.WriteLine("1. Yes, Generate!" + Environment.NewLine);
            Console.WriteLine("2. No, I want to start over." + Environment.NewLine);

            return new int[] { title, categories, questions, points };
        }

        private static void GeneratePDF(List<Question> questions, string jobTitle, string fileName)
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = $"Technical Interview Questions - {jobTitle}";

            // Create an empty page
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            XPdfFontOptions options = new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Always);

            // Create a font
            XFont TitleFont = new XFont("Calibri", 20, XFontStyle.Bold);
            XFont SubTitleFont = new XFont("Calibri", 15, XFontStyle.Underline);
            XFont ContentFont = new XFont("Calibri", 13, XFontStyle.Regular);

            int totalPoints = questions.Select(x => x.Point).Sum();
            int i = 1, y = 50;
            gfx.DrawString($"Technical Interview Questions - {jobTitle}", TitleFont, XBrushes.Black,
                new PointF(5, y));
            y += 30;
            gfx.DrawString($"Created at : {DateTime.Now}", SubTitleFont, XBrushes.Black, new PointF(5, y));
            y += 20;
            gfx.DrawString($"Total points : {totalPoints}", SubTitleFont, XBrushes.Black, new PointF(5, y));
            y += 30;
            foreach (var question in questions)
            {
                if (y >= 750)
                {
                    PdfPage newPage = document.AddPage();
                    gfx = XGraphics.FromPdfPage(newPage);
                    y = 50;
                }

                gfx.DrawString(i + $". [{question.Category.ToString()}-{question.Number}]({question.Point}p) : {question.Content}", 
                    ContentFont, 
                    XBrushes.Black,
                    new PointF(5, y));

                i++;
                y += 100;
            }

            // Save the document...
            var file = fileName + ".pdf";
            try
            {
                document.Save(file);
                // ...and start a viewer.
                Process.Start(file);

                Console.WriteLine(Environment.NewLine + $"The {file} is successfully generated at {Path.GetFullPath(file)}" + Environment.NewLine);
            }
            catch (Exception)
            {
                Console.WriteLine(Environment.NewLine + $"The {file} couldn't be saved, try another file name:" + Environment.NewLine);
                fileName = Console.ReadLine();

                while (string.IsNullOrEmpty(fileName))
                {
                    Console.WriteLine("Give a file name that you like to the PDF document:" + Environment.NewLine);
                }
                GeneratePDF(questions, jobTitle, fileName);
            }
        }
    }
}
