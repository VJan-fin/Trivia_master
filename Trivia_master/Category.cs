using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia_master
{
    public abstract class Category<T,U>
    {
        private int Curr { get; set; }
        public virtual List<IQuestion<T, U>> questions { get; set; }

        private void Shuffle()
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

        public Category()
        {
            questions = new List<IQuestion<T, U>>();
            Curr = 0;
        }

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

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
