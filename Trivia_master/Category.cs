using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia_master
{
    public abstract class Category<T,U>
    {
        //public int Curr { get; set; }
        public List<IQuestion<T,U>> questions;
        public string CategoryName { get; set; } 
        public Random rnd;

        public Category()
        {
            questions = new List<IQuestion<T, U>>();
            rnd = new Random();
        }

        public IQuestion<T, U> getNextQuestion() 
        {
            return null;
        }

        public void addQuestion(IQuestion<T, U> question)
        { 
        }
    }
}
