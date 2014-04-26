using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trivia_master
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* MultipleChoiceForm mcf = new MultipleChoiceForm();
            mcf.ShowDialog();*/
            Easy obj = new Easy();
            Category<string, string> cat = new Category<string, string>() { CategoryName = "History"};
            MultipleChoiceQ<string,string> mc = new MultipleChoiceQ<string,string>();
            mc.Question.Add("Who was the first president of the USA?");
            mc.CorrectAnswers.Add("George Washington");
            mc.Answers.Add("1");
            mc.Answers.Add("2");
            mc.Answers.Add("3");
            mc.Answers.Add("4");
            cat.questions.Add(mc);
            obj.Categories.Add(cat);
            //obj.showQ(cat);

            obj.createState();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Medium obj = new Medium();
            obj.Categories.Add(new Category<MediumQuestionPainter, MediumAnswerPainter>() { CategoryName = "Finki" });
            obj.Categories[0].addQuestion(new HangManQ<MediumQuestionPainter, MediumAnswerPainter>());
            AlphabetQuestion que = new AlphabetQuestion("First programming language?");
            List<MediumQuestionPainter> list = new List<MediumQuestionPainter>();
            list.Add(que);
            obj.Categories[0].questions[0].setQuestion(list);
            AlphabetAnswer ans = new AlphabetAnswer("ADA");
            List<MediumAnswerPainter> list1 = new List<MediumAnswerPainter>();
            list1.Add(ans);
            obj.Categories[0].questions[0].setCorrectAnswer(list1);

            //obj.Categories.Add(new Category<MediumQuestionPainter, MediumAnswerPainter>() { CategoryName = "Finki" });
            obj.Categories[0].addQuestion(new HangManQ<MediumQuestionPainter, MediumAnswerPainter>());
            que = new AlphabetQuestion("What is the term used for describing the judgmental or commonsense part of problem solving?");
            list = new List<MediumQuestionPainter>();
            list.Add(que);
            obj.Categories[0].questions[1].setQuestion(list);
            ans = new AlphabetAnswer("HEURISTIC");
            list1 = new List<MediumAnswerPainter>();
            list1.Add(ans);
            obj.Categories[0].questions[1].setCorrectAnswer(list1);
            obj.Categories[0].Shuffle();

            obj.createState();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AssociationForm a = new AssociationForm();
            a.ShowDialog();
        }
    }
}
