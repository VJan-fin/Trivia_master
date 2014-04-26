using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia_master
{
    /// <summary>
    /// This class should be used as a base class for
    /// all the category classes which are needed for
    /// the game
    /// </summary>
    /// <typeparam name="T">Question type</typeparam>
    /// <typeparam name="U">Answer type</typeparam>
    public class Category<T,U>
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        private int Curr { get; set; }
        /// <summary>
        /// Contains the complete set of questions from the suitable
        /// category
        /// </summary>
        public virtual List<IQuestion<T, U>> questions { get; set; }

        public Category()
        {
            questions = new List<IQuestion<T, U>>();
            Curr = 0;
            Shuffle();
        }

        /// <summary>
        /// A method for creating a random permutation
        /// of all the questions from the object's category
        /// </summary>
        public void Shuffle()
        {
            Random rng = new Random();
            int n = questions.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                IQuestion<T, U> value = questions[k];
                questions[k] = questions[n];
                questions[n] = value;
            }
        }

        /// <summary>
        /// Gives back one question from the object's category
        /// </summary>
        /// <returns></returns>
        public IQuestion<T, U> getNextQuestion() 
        {
            if (Curr == questions.Count)
            {
                Curr = 0;
                Shuffle();
            }
            return questions[Curr++];
        }

        public void addQuestion(IQuestion<T, U> question)
        {
            questions.Add(question);
        }

        /// <summary>
        /// The method is overridden so that it returns 
        /// the name of the category
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.CategoryName;
        }
    }
}
