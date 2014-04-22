using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Trivia_master
{
    public abstract class Game<T,U>
    {
        public virtual State<T, U> state { get; set; }
        public virtual List<Category<T,U>> Categories { get; set; }
        public virtual Category<Image,string> MainCategory { get; set; }
        private Random random;

        public Game()
        {
            random = new Random();
        }

        public IQuestion<Image, string> getMainQ()
        {
            return MainCategory.getNextQuestion();
        }

        public List<Category<T, U>> getCategories(int n)
        {
            List<Category<T, U>> result = new List<Category<T, U>>();
            for (int i = 0; i < n; i++)
            {
                result.Add(Categories[random.Next(n)]);
            }
            return result;
        }

        public abstract void createState();
    }
}
