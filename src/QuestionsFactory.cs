using System;
using System.Collections.Generic;
using System.Linq;

namespace QuestionGenerator
{
    internal static class QuestionsFactory
    {
        internal static List<Question> GetQuestions(Title title, int nbOfCategories, int nbOfQuestions, int points)
        {
            // Add more job titles
            if (title == Title.JuniorNetDev)
            {
                return GenerateQuestions(QuestionsLibrary.JuniorNetDevQuestions, nbOfCategories, nbOfQuestions, points);
            }
            else if (title == Title.SeniorFrontDev)
            {
                return GenerateQuestions(QuestionsLibrary.SeniorFrontDevQuestions, nbOfCategories, nbOfQuestions, points);
            }
            else
            {
                return null;
            }
        }

        private static List<Question> GenerateQuestions(List<Question> dic, int nbOfCategories, int nbOfQuestions, int points)
        {
            int nbQ = 0, total = 0;
            var questions = new List<Question>();
            var rnd = new Random();

            while (dic.Select(x => x.Category).Distinct().Count() > nbOfCategories)
            {
                var category = (Category)rnd.Next(0, Enum.GetNames(typeof(Category)).Length - 1);
                dic.RemoveAll(x => x.Category == category);
            }

            var catArray = dic.GroupBy(x => x.Category).Select(l => l.ToList()).ToArray();

            for (int i = 0; i < nbOfCategories;)
            {
                if (catArray[i].Count > 0)
                {
                    if (nbQ == nbOfQuestions - 1)
                    {
                        var last = dic.Where(x => x.Point == (points - total)).FirstOrDefault();
                        if (last != null)
                        {
                            questions.Add(last);
                            break;
                        }
                    }

                    var index = rnd.Next(0, catArray[i].Count - 1);
                    questions.Add(catArray[i][index]);
                    total += catArray[i][index].Point;
                    catArray[i].RemoveAt(index);
                    nbQ++;

                    i = (i == nbOfCategories - 1) ? 0 : i + 1;
                }
                else
                {
                    if (HasQuestion(catArray, nbOfCategories))
                        i = (i == nbOfCategories - 1) ? 0 : i + 1;
                    else
                        break;
                }

                if ((total >= points) || (nbQ >= nbOfQuestions))
                    break;
            }

            return questions;
        }

        private static bool HasQuestion(List<Question>[] array, int nbOfCategories)
        {
            var result = false;
            for (int i = 0; i < nbOfCategories; i++)
            {
                if (array[i].Count > 0)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }
    }
}
