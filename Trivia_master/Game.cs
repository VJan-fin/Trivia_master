using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Trivia_master
{
    /// <summary>
    /// A class which is used to implement the entire logic of
    /// the different types of games. It also includes references
    /// to the categories which hold the suitable questions
    /// </summary>
    /// <typeparam name="T">Question type</typeparam>
    /// <typeparam name="U">Answer type</typeparam>
    public abstract class Game<T,U>
    {
        public int GameID { get; set; }
        public virtual State<T, U> state { get; set; }
        public virtual List<Category<T,U>> Categories { get; set; }
        public virtual Category<Image,string> MainCategory { get; set; }
        private Random random;

        public Game()
        {
            random = new Random();
        }

        /// <summary>
        /// Choose one question which will be used for the base game.
        /// </summary>
        /// <returns></returns>
        public IQuestion<Image, string> getMainQ()
        {
            return MainCategory.getNextQuestion();
        }

        /// <summary>
        /// Returns references to n categories, where n is
        /// passed as an argument to the method
        /// </summary>
        /// <param name="n">Number of categories which should be returned</param>
        /// <returns></returns>
        public List<Category<T, U>> getCategories(int n)
        {
            List<Category<T, U>> result = new List<Category<T, U>>();
            for (int i = 0; i < n; i++)
            {
                result.Add(Categories[random.Next(n)]);
            }
            return result;
        }

        /// <summary>
        /// Creation of the starting state of the game
        /// </summary>
        public abstract void createState();
    }
}
