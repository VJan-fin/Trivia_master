using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        Game<T, U> game;
        List<Category<T, U>> Category;

        public State()
        {

        }

        public State(Game<T, U> game)
        {
            this.game = game;
        }

        public void createForm()
        {

        }
    }
}
