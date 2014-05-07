using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Trivia_master.Properties;

namespace Trivia_master
{
    public partial class LoadingForm : Form
    {
        Image img0;
        Image img1;
        Image img2;
        Image img3;
        Image img4;
        Image img5;
        Image img6;
        Image img7;
        Image img8;
        Size size { get; set; }

        Category<Image, FormPainter> main { get; set; }
        Easy easyObj;
        Medium medium;
        Hard hard;

        int cap;
        int curr;
        public LoadingForm()
        {
            InitializeComponent();
            timer3.Stop();
            cap = 0;
            curr = 0;
            img0 = Resources._0;
            img1 = Resources._1;
            img2 = Resources._2;
            img3 = Resources._3;
            img4 = Resources._4;
            img5 = Resources._5;
            img6 = Resources._6;
            img7 = Resources._7;
            img8 = Resources._8;
            size = new Size(200, 200);
            DoubleBuffered = true;
            timer2.Stop();
            timer3.Stop();
            timer1.Start();
        }

        private void LoadingForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(img0, new Rectangle(new Point(50, 201), size));
            g.DrawImage(img1, new Rectangle(new Point(141, 174), size));
            g.DrawImage(img2, new Rectangle(new Point(255, 201), size));
            g.DrawImage(img3, new Rectangle(new Point(371, 203), size));
            g.DrawImage(img4, new Rectangle(new Point(450, 222), size));
            g.DrawImage(img5, new Rectangle(new Point(455, 109), size));          
            g.DrawImage(img6, new Rectangle(new Point(362, 110), size));
            g.DrawImage(img7, new Rectangle(new Point(266, 107), size));
            g.DrawImage(img8, new Rectangle(new Point(150, 286), size));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += 0.1;
            cap++;
            if (cap == 9)
            {
                timer1.Stop();
                CreateMain();
                CreateEasy();
                CreateMedium();
                CreateHard();
                timer3.Stop();
                timer2.Start();
            }
               
        }

        private void CreateMain()
        {
            main = new Category<Image, FormPainter>();
            main.CategoryName = "Main";
            HangManQ<Image, FormPainter> q = new HangManQ<Image, FormPainter>();
            q.Question.Add(Resources.Napoleon);
            AlphabetAnswer aa = new AlphabetAnswer("NAPOLEON");
            aa.JokerChance = 0;
            aa.DevilChance = 0;
            aa.AttemtsLocation = new Point(62, 59);
            FormPainter fp = new FormPainter(aa);
            q.CorrectAnswers.Add(fp);
            main.addQuestion(q);


            q = new HangManQ<Image, FormPainter>();
            q.Question.Add(Resources.Despicable_Me);
            aa = new AlphabetAnswer("DESPICABLE ME");
            aa.JokerChance = 0;
            aa.DevilChance = 0;
            aa.AttemtsLocation = new Point(62, 59);
            fp = new FormPainter(aa);
            q.CorrectAnswers.Add(fp);
            main.addQuestion(q);
        }

        private void CreateEasy()
        {
            easyObj = new Easy();

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

            easyObj.MainCategory = main;
        }

        private void CreateMedium()
        {
            medium = new Medium();

            medium.Categories.Add(new Category<MediumQuestionPainter, MediumAnswerPainter>() { CategoryName = "Computer Science" });
            medium.Categories[0].addQuestion(new HangManQ<MediumQuestionPainter, MediumAnswerPainter>());
            AlphabetQuestion question = new AlphabetQuestion("First programming language?");
            List<MediumQuestionPainter> listQuestions = new List<MediumQuestionPainter>();
            listQuestions.Add(question);
            medium.Categories[0].questions[0].setQuestion(listQuestions);
            AlphabetAnswer alphabetAnswer = new AlphabetAnswer("ADA");
            alphabetAnswer.DevilChance = 5;
            alphabetAnswer.JokerChance = 5;
            FormPainter answer = new FormPainter(alphabetAnswer);
            answer.AddComponent(new TimerPainter());
            answer.AddComponent(new AnsweredPicturePainter());
            List<MediumAnswerPainter> listAnswers = new List<MediumAnswerPainter>();
            listAnswers.Add(answer);
            medium.Categories[0].questions[0].setCorrectAnswer(listAnswers);

            //obj.Categories.Add(new Category<MediumQuestionPainter, MediumAnswerPainter>() { CategoryName = "Finki" });
            medium.Categories[0].addQuestion(new HangManQ<MediumQuestionPainter, MediumAnswerPainter>());
            question = new AlphabetQuestion("What is the term used for describing the judgmental or commonsense part of problem solving?");
            listQuestions = new List<MediumQuestionPainter>();
            listQuestions.Add(question);
            medium.Categories[0].questions[1].setQuestion(listQuestions);
            alphabetAnswer = new AlphabetAnswer("HEURISTIC");
            alphabetAnswer.DevilChance = 5;
            alphabetAnswer.JokerChance = 5;
            answer = new FormPainter(alphabetAnswer);
            answer.AddComponent(new TimerPainter());
            answer.AddComponent(new AnsweredPicturePainter());
            listAnswers = new List<MediumAnswerPainter>();
            listAnswers.Add(answer);
            medium.Categories[0].questions[1].setCorrectAnswer(listAnswers);

            /*medium.Categories[0].addQuestion(new HangManQ<MediumQuestionPainter, MediumAnswerPainter>());
            question = new AlphabetQuestion("Home");
            listQuestions = new List<MediumQuestionPainter>();
            listQuestions.Add(question);
            medium.Categories[0].questions[2].setQuestion(listQuestions);
            answer = new FormPainter(new AlphabetJoker());
            listAnswers = new List<MediumAnswerPainter>();
            listAnswers.Add(answer);
            medium.Categories[0].questions[2].setCorrectAnswer(listAnswers);*/
            //medium.Categories[0].Shuffle();

            medium.Categories.Add(new Category<MediumQuestionPainter, MediumAnswerPainter>() { CategoryName = "History" });
            medium.Categories[1].addQuestion(new HangManQ<MediumQuestionPainter, MediumAnswerPainter>());
            question = new AlphabetQuestion("Son of Philip 2 Macedonian was called?");
            listQuestions = new List<MediumQuestionPainter>();
            listQuestions.Add(question);
            medium.Categories[1].questions[0].setQuestion(listQuestions);
            alphabetAnswer = new AlphabetAnswer("THE GREAT");
            alphabetAnswer.DevilChance = 5;
            alphabetAnswer.JokerChance = 5;
            answer = new FormPainter(alphabetAnswer);
            answer.AddComponent(new TimerPainter());
            answer.AddComponent(new AnsweredPicturePainter());
            listAnswers = new List<MediumAnswerPainter>();
            listAnswers.Add(answer);
            medium.Categories[1].questions[0].setCorrectAnswer(listAnswers);

            medium.MainCategory = main;
        }

        private void CreateHard()
        {
            hard = new Hard();
            FormPainter fp;
            Category<string, FormPainter> cs = new Category<string, FormPainter>();
            cs.CategoryName = "Computer Science";
            AssociationQ<string, FormPainter> question = new AssociationQ<string, FormPainter>();
            question.Question.Add("A programming language");
            question.Question.Add("John McCarthy");
            question.Question.Add("Artificial intelligence");
            question.Question.Add("Has a lot of dialects");
            fp = new FormPainter(new AlphabetAnswer("LISP"));
            fp.AddComponent(new TimerPainter());
            fp.AddComponent(new AnsweredPicturePainter());
            question.CorrectAnswers.Add(fp);
            cs.addQuestion(question);


            AssociationQ<string, FormPainter> questionCS2 = new AssociationQ<string, FormPainter>();
            questionCS2.Question.Add("Algorithm");
            questionCS2.Question.Add("Artificial Intelligence");
            questionCS2.Question.Add("Tic Tac Toe");
            questionCS2.Question.Add("Tree traversal");
            fp = new FormPainter(new AlphabetAnswer("Minimax"));
            fp.AddComponent(new TimerPainter());
            fp.AddComponent(new AnsweredPicturePainter());
            questionCS2.CorrectAnswers.Add(fp);
            cs.addQuestion(questionCS2);

            AssociationQ<string, FormPainter> questionCS3 = new AssociationQ<string, FormPainter>();
            questionCS3.Question.Add("Famous computer virus");
            questionCS3.Question.Add("Infected 50 million computers");
            questionCS3.Question.Add("2000");
            questionCS3.Question.Add("E-mail");
            fp = new FormPainter(new AlphabetAnswer("ILOVEYOU"));
            fp.AddComponent(new TimerPainter());
            fp.AddComponent(new AnsweredPicturePainter());
            questionCS3.CorrectAnswers.Add(fp);
            cs.addQuestion(questionCS3);
            AssociationQ<string, FormPainter> questionCS4 = new AssociationQ<string, FormPainter>();
            questionCS4.Question.Add("A programming paradigm");
            questionCS4.Question.Add("Java");
            questionCS4.Question.Add("C#");
            questionCS4.Question.Add("Acronym");
            fp = new FormPainter(new AlphabetAnswer("OOP"));
            fp.AddComponent(new TimerPainter());
            fp.AddComponent(new AnsweredPicturePainter());
            questionCS4.CorrectAnswers.Add(fp);
            cs.addQuestion(questionCS4);
            AssociationQ<string, FormPainter> questionCS5 = new AssociationQ<string, FormPainter>();
            questionCS5.Question.Add("Router");
            questionCS5.Question.Add("Switch");
            questionCS5.Question.Add("Hub");
            questionCS5.Question.Add("Ethernet");

            fp = new FormPainter(new AlphabetAnswer("Network"));
            fp.AddComponent(new TimerPainter());
            fp.AddComponent(new AnsweredPicturePainter());
            questionCS5.CorrectAnswers.Add(fp);
            cs.addQuestion(questionCS5);

            hard.Categories.Add(cs);
            /*    Category<string, FormPainter> geography = new Category<string, FormPainter>();
                geography.CategoryName = "Geography";
                AssociationQ<string, FormPainter> questionG1 = new AssociationQ<string, FormPainter>();
                questionG1.Question.Add("One of the biggest cities in the world");
                questionG1.Question.Add("Has a population of 14 milion");
                questionG1.Question.Add("Turkey");
                questionG1.Question.Add("Transcontinental city");
                fp = new FormPainter(new AlphabetAnswer("Istanbul"));
                fp.AddComponent(new TimerPainter());
                questionG1.CorrectAnswers.Add(new AlphabetAnswer("Istanbul");
                geography.addQuestion(questionG1);
                AssociationQ<string, FormPainter> questionG2 = new AssociationQ<string, FormPainter>();
                questionG2.Question.Add("Planet");
                questionG2.Question.Add("Closest to the sun");
                questionG2.Question.Add("Named after one of the Roman gods");
                questionG2.Question.Add("Smaller than Earth");
                questionG2.CorrectAnswers.Add(new FormPainter("Mercury"));
                geography.addQuestion(questionG2);
                AssociationQ<string, FormPainter> questionG3 = new AssociationQ<string, FormPainter>();
                questionG3.Question.Add("River");
                questionG3.Question.Add("Africa");
                questionG3.Question.Add("Floods every year");
                questionG3.Question.Add("flows through 10 distinct countries");
                questionG3.CorrectAnswers.Add(new AlphabetAnswer("NILE"));
                geography.addQuestion(questionG3);
                hard.Categories.Add(geography);
          
              */


            hard.MainCategory = main;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            curr++;
            if (curr == 5)
            {
                timer2.Stop();
                timer3.Start();
            }
            Invalidate(true);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Opacity -= 0.1;
            if (Opacity == 0)
            {
                timer3.Stop();
                StartingForm st = new StartingForm(easyObj, medium, hard);
                st.Show();
                Close();
                
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Opacity = 1;
        }
    }
}
