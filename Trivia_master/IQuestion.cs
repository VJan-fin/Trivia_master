using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia_master
{
    public interface IQuestion<T, U>
    {
         List<T> getQuestion();
         List<U> getAnswer();
         void setQuestion();
         void setAnswer();
       
    }
}
