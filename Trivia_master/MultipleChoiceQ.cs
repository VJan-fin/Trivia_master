using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia_master
{
    public class MultipleChoiceQ<T, U> : IQuestion<T, U>
    {

        public List<T> getQuestion()
        {
            throw new NotImplementedException();
        }

        public List<U> getAnswer()
        {
            throw new NotImplementedException();
        }

        public void setQuestion()
        {
            throw new NotImplementedException();
        }

        public void setAnswer()
        {
            throw new NotImplementedException();
        }
    }
}
