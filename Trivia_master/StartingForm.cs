﻿using System;
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
    public partial class StartingForm : Form1
    {
        Category<Image, FormPainter> main { get; set; }
        public StartingForm()
        {
            InitializeComponent();
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

            easyObj.MainCategory = main;

            easyObj.createState();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Medium medium = new Medium();

            
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

            medium.createState();
        }
        public override void CloseForm()
        {
            CloseForm cs = new CloseForm();
            if (cs.ShowDialog() == DialogResult.Yes)
            {
                Close();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Hard hard = new Hard();
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
            AssociationQ<string, FormPainter> questionCS5 = new AssociationQ<string,FormPainter >();
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
            Category<string, FormPainter> geography = new Category<string, FormPainter>();
            geography.CategoryName = "Geography";
            AssociationQ<string, FormPainter> questionG1 = new AssociationQ<string, FormPainter>();
            questionG1.Question.Add("One of the biggest cities in the world");
            questionG1.Question.Add("Has a population of 14 milion");
            questionG1.Question.Add("Turkey");
            questionG1.Question.Add("Transcontinental city");
            fp = new FormPainter(new AlphabetAnswer("Istanbul"));
            fp.AddComponent(new AnsweredPicturePainter()); 
            fp.AddComponent(new TimerPainter());
            questionG1.CorrectAnswers.Add(fp);
            geography.addQuestion(questionG1);
            AssociationQ<string, FormPainter> questionG2 = new AssociationQ<string, FormPainter>();
            questionG2.Question.Add("Planet");
            questionG2.Question.Add("Closest to the sun");
            questionG2.Question.Add("Named after one of the Roman gods");
            questionG2.Question.Add("Smaller than Earth");
            fp = new FormPainter(new AlphabetAnswer("Mercury"));
            fp.AddComponent(new AnsweredPicturePainter()); 
            fp.AddComponent(new TimerPainter());
            questionG2.CorrectAnswers.Add(fp);
            geography.addQuestion(questionG2);
            AssociationQ<string, FormPainter> questionG3 = new AssociationQ<string, FormPainter>();
            questionG3.Question.Add("River");
            questionG3.Question.Add("Africa");
            questionG3.Question.Add("Floods every year");
            questionG3.Question.Add("flows through 10 distinct countries");
            fp = new FormPainter(new AlphabetAnswer("NILE"));
            fp.AddComponent(new AnsweredPicturePainter()); 
            fp.AddComponent(new TimerPainter());
            questionG3.CorrectAnswers.Add(fp);
            geography.addQuestion(questionG3);
            AssociationQ<string, FormPainter> questionG4 = new AssociationQ<string, FormPainter>();
            questionG4.Question.Add("Country");
            questionG4.Question.Add("Population of 32 000");
            questionG4.Question.Add("Casinos");
            questionG4.Question.Add("Has no airports");
             fp = new FormPainter(new AlphabetAnswer("MONACO"));
            fp.AddComponent(new AnsweredPicturePainter()); 
            fp.AddComponent(new TimerPainter());
            questionG4.CorrectAnswers.Add(fp);
            geography.addQuestion(questionG4);
            hard.Categories.Add(geography);

            Category<string, FormPainter> movies = new Category<string, FormPainter>();
            movies.CategoryName = "Movies";
            AssociationQ<string, FormPainter> questionM1 = new AssociationQ<string, FormPainter>();
            questionM1.Question.Add("Gondor");
            questionM1.Question.Add("Battle of the Pelennor fields");
            questionM1.Question.Add("City of the kings");
            questionM1.Question.Add("Aragorn");
            fp = new FormPainter(new AlphabetAnswer("Minas Tirith"));
            fp.AddComponent(new AnsweredPicturePainter());
            fp.AddComponent(new TimerPainter());
            questionM1.CorrectAnswers.Add(fp);
            movies.addQuestion(questionM1);

            AssociationQ<string, FormPainter> questionM2 = new AssociationQ<string, FormPainter>();
            questionM2.Question.Add("Unforgivable Curse");
            questionM2.Question.Add("Harry Potter");
            questionM2.Question.Add("Cedric Diggory");
            questionM2.Question.Add("A flash of green light");
            fp = new FormPainter(new AlphabetAnswer("Avada Kedavra"));
            fp.AddComponent(new AnsweredPicturePainter());
            fp.AddComponent(new TimerPainter());
            questionM2.CorrectAnswers.Add(fp);
            movies.addQuestion(questionM2);

            AssociationQ<string, FormPainter> questionM3 = new AssociationQ<string, FormPainter>();
            questionM3.Question.Add("007");
            questionM3.Question.Add("Daniel Craig");
            questionM3.Question.Add("2012");
            questionM3.Question.Add("ADELE");
            fp = new FormPainter(new AlphabetAnswer("Skyfall"));
            fp.AddComponent(new AnsweredPicturePainter());
            fp.AddComponent(new TimerPainter());
            questionM3.CorrectAnswers.Add(fp);
            movies.addQuestion(questionM3);

            AssociationQ<string, FormPainter> questionM4 = new AssociationQ<string, FormPainter>();
            questionM4.Question.Add("Clark Kent");
            questionM4.Question.Add("Krypton");
            questionM4.Question.Add("Lois Lane");
            questionM4.Question.Add("Lex Luthor");
            fp = new FormPainter(new AlphabetAnswer("Superman"));
            fp.AddComponent(new AnsweredPicturePainter());
            fp.AddComponent(new TimerPainter());
            questionM4.CorrectAnswers.Add(fp);
            movies.addQuestion(questionM4);


            AssociationQ<string, FormPainter> questionM5 = new AssociationQ<string, FormPainter>();
            questionM5.Question.Add("Magicians");
            questionM5.Question.Add("\"Man's reach exceeds his imagination\"");
            questionM5.Question.Add("Nikola Tesla");
            questionM5.Question.Add("Christian Bale");
            fp = new FormPainter(new AlphabetAnswer("The prestige"));
            fp.AddComponent(new AnsweredPicturePainter());
            fp.AddComponent(new TimerPainter());
            questionM5.CorrectAnswers.Add(fp);
            movies.addQuestion(questionM5);
            
            hard.Categories.Add(movies);
            hard.MainCategory = main;


            hard.createState();
            
           
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
