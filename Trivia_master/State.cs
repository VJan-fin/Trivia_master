using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Trivia_master
{
    /// <summary>
    /// The class holds the instance of the game being 
    /// played and its current state
    /// </summary>
    /// <typeparam name="T">Question type</typeparam>
    /// <typeparam name="U">Answer type</typeparam>
    public class State<T, U>
    {
        public IQuestion<Image, FormPainter> Question { get; set; }
        Game<T, U> game;
        public List<Category<T, U>> Category;

        public State()
        {
        }

        public State(Game<T, U> game)
        {
            this.game = game;
            Category = game.getCategories(9);
            Question = game.MainCategory.getNextQuestion();
            createForm();
        }

        public void createForm()
        {
            MainForm<T, U> mf = new MainForm<T, U>(this);
            mf.ShowDialog();
        }

        public bool ShowQ(Category<T, U> cat)
        {
            return game.showQ(cat);
        }
    }
}
