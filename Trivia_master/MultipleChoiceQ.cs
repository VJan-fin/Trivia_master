using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia_master
{
    /// <summary>
    /// A class for the easy game which consists of a list
    /// of only one question and a list of four possible 
    /// answers of which only one is correct
    /// </summary>
    /// <typeparam name="T">Question type</typeparam>
    /// <typeparam name="U">Answer type</typeparam>
    public class MultipleChoiceQ<T, U> : IQuestion<T, U>
    {
        public int MultipleChoiceQID { get; set; }
        public List<T> Question { get; set; }
        public List<U> Answers { get; set; }
        public List<U> CorrectAnswers { get; set; }

        public MultipleChoiceQ()
        {
            this.Question = new List<T>();
            this.Answers = new List<U>();
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

        public List<U> getAnswers()
        {
            return this.Answers;
        }

        public void setQuestion(List<T> q)
        {
            foreach (var item in q)
            {
                this.Question.Add(item);
            }
        }

        public void setAnswer(List<U> a)
        {
            foreach (var item in a)
            {
                this.Answers.Add(item);
            }
        }

        public void setCorrectAnswer(List<U> a)
        {
            foreach (var item in a)
            {
                this.CorrectAnswers.Add(item);
            }
        }
    }
}
