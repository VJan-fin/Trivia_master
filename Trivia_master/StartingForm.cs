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
    public partial class StartingForm : Form1
    {
        public StartingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Easy easyObj = new Easy();

            //creating a new category
            Category<string, string> cat1 = new Category<string, string>() { CategoryName = "History" };
            //creating a new question
            MultipleChoiceQ<string, string> mc1 = new MultipleChoiceQ<string, string>();
            mc1.Question.Add("In which year did Constantinople fall under Ottoman rule?");
            mc1.CorrectAnswers.Add("1453");
            mc1.Answers.Add("1371");
            mc1.Answers.Add("1204");
            mc1.Answers.Add("1453");
            mc1.Answers.Add("1261");
            cat1.questions.Add(mc1);
            easyObj.Categories.Add(cat1);
            //creating a new question
            MultipleChoiceQ<string, string> mc2 = new MultipleChoiceQ<string, string>();
            mc2.Question.Add("Who was the first president of the USA?");
            mc2.CorrectAnswers.Add("George Washington");
            mc2.Answers.Add("George Washington");
            mc2.Answers.Add("Abraham Lincoln");
            mc2.Answers.Add("John F. Kennedy");
            mc2.Answers.Add("Theodore Roosevelt");
            cat1.questions.Add(mc2);

            //creating a new category
            Category<string, string> cat2 = new Category<string, string>() { CategoryName = "Computer Science" };
            //creating a new question
            MultipleChoiceQ<string, string> mc3 = new MultipleChoiceQ<string, string>();
            mc3.Question.Add("What is the term used for describing the judgmental or commonsense part of problem solving?");
            mc3.CorrectAnswers.Add("Heuristic");
            mc3.Answers.Add("Stochastic");
            mc3.Answers.Add("Deterministic");
            mc3.Answers.Add("Forward-chaining");
            mc3.Answers.Add("Heuristic");
            cat2.questions.Add(mc3);
            easyObj.Categories.Add(cat2);
            //creating a new question
            MultipleChoiceQ<string, string> mc4 = new MultipleChoiceQ<string, string>();
            mc4.Question.Add("Which is considered to be the oldest programming language?");
            mc4.CorrectAnswers.Add("ADA");
            mc4.Answers.Add("COBOL");
            mc4.Answers.Add("ADA");
            mc4.Answers.Add("PASCAL");
            mc4.Answers.Add("FORTRAN");
            cat2.questions.Add(mc4);

            //creating a new category
            Category<string, string> cat3 = new Category<string, string>() { CategoryName = "Literature" };
            //creating a new question
            MultipleChoiceQ<string, string> mc5 = new MultipleChoiceQ<string, string>();
            mc5.Question.Add("\"A horse! a horse! my kingdom for a horse!\" is a quote from which famous Shakespeare's play?");
            mc5.CorrectAnswers.Add("Richard III");
            mc5.Answers.Add("Richard III");
            mc5.Answers.Add("King Henry V");
            mc5.Answers.Add("Hamlet");
            mc5.Answers.Add("Much Ado About Nothing");
            cat3.questions.Add(mc5);
            easyObj.Categories.Add(cat3);
            //creating a new question
            MultipleChoiceQ<string, string> mc6 = new MultipleChoiceQ<string, string>();
            mc6.Question.Add("Which of the followong authors does not belong to the Romantic period?");
            mc6.CorrectAnswers.Add("Leo Tolstoy");
            mc6.Answers.Add("Lord Byron");
            mc6.Answers.Add("Victor Hugo");
            mc6.Answers.Add("Leo Tolstoy");
            mc6.Answers.Add("Alexander Pushkin");
            cat3.questions.Add(mc6);

            easyObj.createState();
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
            AssociationQ<string, string> question = new AssociationQ<string, string>();
            question.Question.Add("A programming language");
            question.Question.Add("John McCarthy");
            question.Question.Add("Artificial intelligence");
            question.Question.Add("Has a lot of dialects");
            question.CorrectAnswers.Add("LISP");
            Category<string, string> category = new Category<string, string>();
            category.CategoryName = "Computer Science";
            category.addQuestion(question);
            Hard hard = new Hard();
            hard.Categories.Add(category);
            hard.createState();

            /*
            AssociationForm a = new AssociationForm();
            a.ShowDialog();*/
        }

        private bool IsClicked = false;
        private Point mousePoint;
        private Point currPoint;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsClicked = true;
                mousePoint = e.Location;
                Cursor = Cursors.SizeAll;
                currPoint = this.Location;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsClicked)
            {
                this.Location = new Point(this.Location.X + (e.Location.X - mousePoint.X), this.Location.Y + (e.Location.Y - mousePoint.Y));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.Location.Y < 0) this.Location = new Point(this.Location.X, 0);
                IsClicked = false;
                Cursor = Cursors.Default;
            }
        }
    }
}
