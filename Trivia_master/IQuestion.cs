using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia_master
{
    /// <summary>
    /// An interface class which asserts a certain
    /// behaviour for all the different types of questions
    /// </summary>
    /// <typeparam name="T">Question type</typeparam>
    /// <typeparam name="U">Answer type</typeparam>
    public interface IQuestion<T, U>
    {
        List<T> getQuestion();
        List<U> getCorrectAnswer();
        List<U> getAnswers();
        void setQuestion(List<T> q);
        void setAnswer(List<U> a);
        void setCorrectAnswer(List<U> a);
    }
}
