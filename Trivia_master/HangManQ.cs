using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia_master
{
    /// <summary>
    /// A class for the medium game which consists of a
    /// list of only one question and a list of only one
    /// answer which is the correct one and should be
    /// guessed by the player
    /// </summary>
    /// <typeparam name="T">Question type</typeparam>
    /// <typeparam name="U">Answer type</typeparam>
    public class HangManQ<T, U> : IQuestion<T, U>
    {
        public int HangManQID { get; set; }
        public List<T> Question { get; set; }
        public List<U> CorrectAnswers { get; set; }

        public HangManQ()
        {
            this.Question = new List<T>();
            this.CorrectAnswers = new List<U>();
        }

        public List<T> getQuestion()
        {
            return this.Question;
        }

        public List<U> getCorrectAnswer()
        {
            return this.CorrectAnswers;
        }

        public void setQuestion(List<T> q)
        {
            foreach (var item in q)
            {
                this.Question.Add(item);
            }
        }

        public void setCorrectAnswer(List<U> a)
        {
            foreach (var item in a)
            {
                this.CorrectAnswers.Add(item);
            }
        }

        /// <summary>
        /// Not implemented
        /// </summary>
        /// <returns></returns>
        public List<U> getAnswers()
        {
            return new List<U>();
        }

        /// <summary>
        /// Not implemented
        /// </summary>
        /// <param name="a"></param>
        public void setAnswer(List<U> a)
        {
        }
    }
}
