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
        List<PuzzlePainter> Puzzle;

        Category<Image, FormPainter> main { get; set; }
        Easy easyObj;
        Medium medium;
        Hard hard;
        Point FormLocation;
        Random r;
        int min;
        int PuzzleSize;

        int cap;
        int curr;
        public LoadingForm()
        {
            InitializeComponent();
            r = new Random();
            if (Width > Height)
            {
                FormLocation = new Point(Width / 2 - Height / 2, 0);
            }
            else FormLocation = new Point(0, Height / 2 - Width / 2);
            cap = 0;
            curr = 0;
            label1.Visible = false;
            min = Math.Min(Width, Height);
            PuzzleSize = (int)(min * 0.3125);
            this.Puzzle = new List<PuzzlePainter>();
            PuzzlePainter.Size = new Size(PuzzleSize, PuzzleSize);
            label1.Font = new Font("Microsoft Sans Serif", min*(float)(8.0 / 640));
            label1.Location = new Point(FormLocation.X + (int)(min * (210.0 / 640)), FormLocation.Y + (int)(min * (470.0 / 640)));
            this.Puzzle.Add(new PuzzlePainter(Resources._0, this.genPoint(), new Point(FormLocation.X + (int)(min * (23.0 / 640)), FormLocation.Y + (int)(min * (201.0 / 640)))));
            this.Puzzle.Add(new PuzzlePainter(Resources._1, this.genPoint(), new Point(FormLocation.X + (int)(min * (114.0 / 640)), FormLocation.Y + (int)(min * (174.0 / 640)))));
            this.Puzzle.Add(new PuzzlePainter(Resources._2, this.genPoint(), new Point(FormLocation.X + (int)(min * (228.0 / 640)), FormLocation.Y + (int)(min * (201.0 / 640)))));
            this.Puzzle.Add(new PuzzlePainter(Resources._3, this.genPoint(), new Point(FormLocation.X + (int)(min * (344.0 /640)), FormLocation.Y + (int)(min * (203.0 / 640)))));
            this.Puzzle.Add(new PuzzlePainter(Resources._4, this.genPoint(), new Point(FormLocation.X + (int)(min * (423.0 / 640)), FormLocation.Y + (int)(min * (222.0 / 640)))));
            this.Puzzle.Add(new PuzzlePainter(Resources._5, this.genPoint(), new Point(FormLocation.X + (int)(min * (428.0 / 640)), FormLocation.Y + (int)(min * (109.0 / 640)))));
            this.Puzzle.Add(new PuzzlePainter(Resources._6, this.genPoint(), new Point(FormLocation.X + (int)(min * (335.0 / 640)), FormLocation.Y + (int)(min * (110.0 / 640)))));
            this.Puzzle.Add(new PuzzlePainter(Resources._7, this.genPoint(), new Point(FormLocation.X + (int)(min * (239.0 / 640)), FormLocation.Y + (int)(min * (107.0 / 640)))));
            this.Puzzle.Add(new PuzzlePainter(Resources._8, this.genPoint(), new Point(FormLocation.X + (int)(min * (123.0 / 640)), FormLocation.Y + (int)(min * (286.0 / 640)))));
            
            DoubleBuffered = true;
            timer1.Start();
            timer4.Start();
        }

        /// <summary>
        /// Generates a random starting point for puzzle parts
        /// </summary>
        /// <returns></returns>
        private Point genPoint()
        {
            int x = r.Next(this.Width - PuzzleSize);
            int y = r.Next(this.Height - PuzzleSize);
            Point tmp = new Point(x, y);
            return tmp;
        }

        private void LoadingForm_Paint(object sender, PaintEventArgs e)
        {
            foreach (var item in this.Puzzle)
            {
                item.draw(e.Graphics);
            }
        }

        /// <summary>
        /// Controls the movement of the Puzzle pieces
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer4_Tick_1(object sender, EventArgs e)
        {
            foreach (var item in this.Puzzle)
            {
                item.move();
            }
            if (Puzzle[0].Step == 0)
            {
                timer4.Stop();
                Invalidate();
                timer2.Start();
            }
            Invalidate(true);
        }

        /// <summary>
        /// Controls the appearance effect of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += 0.1;
            cap++;
            if (cap == 10)
            {
                timer1.Stop();
            }
               
        }

        /// <summary>
        /// Creates main objects, and defines the time of loading window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (curr == 0)
            {
                timer2.Stop();
                CreateMain();
                CreateEasy();
                CreateMedium();
                CreateHard();
                label1.Visible = true;
            }
            curr++;
            if (curr == 5)
            {
                timer2.Stop();
                timer3.Start();
            }
            Invalidate(true);
            if (curr == 1)
                timer2.Start();
        }

        /// <summary>
        /// Transparent disappearing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Creates questions for main form
        /// </summary>
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

            q = new HangManQ<Image, FormPainter>();
            q.Question.Add(Resources.Elizabeth_Taylor);
            aa = new AlphabetAnswer("Elizabeth Taylor");
            aa.JokerChance = 0;
            aa.DevilChance = 0;
            aa.AttemtsLocation = new Point(62, 59);
            fp = new FormPainter(aa);
            q.CorrectAnswers.Add(fp);
            main.addQuestion(q);

            q = new HangManQ<Image, FormPainter>();
            q.Question.Add(Resources.The_Godfather);
            aa = new AlphabetAnswer("The Godfather");
            aa.JokerChance = 0;
            aa.DevilChance = 0;
            aa.AttemtsLocation = new Point(62, 59);
            fp = new FormPainter(aa);
            q.CorrectAnswers.Add(fp);
            main.addQuestion(q);

            q = new HangManQ<Image, FormPainter>();
            q.Question.Add(Resources.Starry_Night);
            aa = new AlphabetAnswer("Starry Night");
            aa.JokerChance = 0;
            aa.DevilChance = 0;
            aa.AttemtsLocation = new Point(62, 59);
            fp = new FormPainter(aa);
            q.CorrectAnswers.Add(fp);
            main.addQuestion(q);

            q = new HangManQ<Image, FormPainter>();
            q.Question.Add(Resources.Sting);
            aa = new AlphabetAnswer("Sting");
            aa.JokerChance = 0;
            aa.DevilChance = 0;
            aa.AttemtsLocation = new Point(62, 59);
            fp = new FormPainter(aa);
            q.CorrectAnswers.Add(fp);
            main.addQuestion(q);

            q = new HangManQ<Image, FormPainter>();
            q.Question.Add(Resources.Maserati);
            aa = new AlphabetAnswer("Maserati");
            aa.JokerChance = 0;
            aa.DevilChance = 0;
            aa.AttemtsLocation = new Point(62, 59);
            fp = new FormPainter(aa);
            q.CorrectAnswers.Add(fp);
            main.addQuestion(q);

            q = new HangManQ<Image, FormPainter>();
            q.Question.Add(Resources.Georgia);
            aa = new AlphabetAnswer("Georgia");
            aa.JokerChance = 0;
            aa.DevilChance = 0;
            aa.AttemtsLocation = new Point(62, 59);
            fp = new FormPainter(aa);
            q.CorrectAnswers.Add(fp);
            main.addQuestion(q);

            q = new HangManQ<Image, FormPainter>();
            q.Question.Add(Resources.France);
            aa = new AlphabetAnswer("France");
            aa.JokerChance = 0;
            aa.DevilChance = 0;
            aa.AttemtsLocation = new Point(62, 59);
            fp = new FormPainter(aa);
            q.CorrectAnswers.Add(fp);
            main.addQuestion(q);

            q = new HangManQ<Image, FormPainter>();
            q.Question.Add(Resources.Jessica_Alba);
            aa = new AlphabetAnswer("Jessica Alba");
            aa.JokerChance = 0;
            aa.DevilChance = 0;
            aa.AttemtsLocation = new Point(62, 59);
            fp = new FormPainter(aa);
            q.CorrectAnswers.Add(fp);
            main.addQuestion(q);

            main.Shuffle();
        }

        /// <summary>
        /// Creates questions for easy form
        /// </summary>
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

        /// <summary>
        /// Creates questions for medium form
        /// </summary>
        private void CreateMedium()
        {
            medium = new Medium();

            //COMPUTER SCIENCE
            FormPainter formpainter;
            Category<MediumQuestionPainter, MediumAnswerPainter> category = new Category<MediumQuestionPainter, MediumAnswerPainter>();
            category.CategoryName = "Computer Science";
            HangManQ<MediumQuestionPainter, MediumAnswerPainter> question = new HangManQ<MediumQuestionPainter, MediumAnswerPainter>();
            question.Question.Add(new AlphabetQuestion("First programming language?"));
            formpainter = new FormPainter(new AlphabetAnswer("ADA"));
            formpainter.AddComponent(new TimerPainter());
            formpainter.AddComponent(new AnsweredPicturePainter());
            question.CorrectAnswers.Add(formpainter);
            category.addQuestion(question);

            question = new HangManQ<MediumQuestionPainter, MediumAnswerPainter>();
            question.Question.Add(new AlphabetQuestion("What is the term used for describing the judgmental or commonsense part of problem solving?"));
            formpainter = new FormPainter(new AlphabetAnswer("HEURISTIC"));
            formpainter.AddComponent(new TimerPainter());
            formpainter.AddComponent(new AnsweredPicturePainter());
            question.CorrectAnswers.Add(formpainter);
            category.addQuestion(question);

            question = new HangManQ<MediumQuestionPainter, MediumAnswerPainter>();
            question.Question.Add(new AlphabetQuestion("If you need to sort a very large list of integers (billions), what efficient sorting algorithm would be your best bet?"));
            formpainter = new FormPainter(new AlphabetAnswer("QUICKSORT"));
            formpainter.AddComponent(new TimerPainter());
            formpainter.AddComponent(new AnsweredPicturePainter());
            question.CorrectAnswers.Add(formpainter);
            category.addQuestion(question);

            question = new HangManQ<MediumQuestionPainter, MediumAnswerPainter>();
            question.Question.Add(new AlphabetQuestion("Name the famous computer scientist who worked to break Nazi codes at Bletchley Park during WWII."));
            formpainter = new FormPainter(new AlphabetAnswer("ALAN TURING"));
            formpainter.AddComponent(new TimerPainter());
            formpainter.AddComponent(new AnsweredPicturePainter());
            question.CorrectAnswers.Add(formpainter);
            category.addQuestion(question);

            question = new HangManQ<MediumQuestionPainter, MediumAnswerPainter>();
            question.Question.Add(new AlphabetQuestion("Which company is the largest manufacturer of network equipment?"));
            formpainter = new FormPainter(new AlphabetAnswer("CISCO"));
            formpainter.AddComponent(new TimerPainter());
            formpainter.AddComponent(new AnsweredPicturePainter());
            question.CorrectAnswers.Add(formpainter);
            category.addQuestion(question);

            question = new HangManQ<MediumQuestionPainter, MediumAnswerPainter>();
            question.Question.Add(new AlphabetQuestion("What does the computer acronym PnP stand for?"));
            formpainter = new FormPainter(new AlphabetAnswer("PLUG AND PLAY"));
            formpainter.AddComponent(new TimerPainter());
            formpainter.AddComponent(new AnsweredPicturePainter());
            question.CorrectAnswers.Add(formpainter);
            category.addQuestion(question);

            question = new HangManQ<MediumQuestionPainter, MediumAnswerPainter>();
            question.Question.Add(new AlphabetQuestion("What does the “W” stand for on a WAP phone?"));
            formpainter = new FormPainter(new AlphabetAnswer("WIRELESS"));
            formpainter.AddComponent(new TimerPainter());
            formpainter.AddComponent(new AnsweredPicturePainter());
            question.CorrectAnswers.Add(formpainter);
            category.addQuestion(question);

            question = new HangManQ<MediumQuestionPainter, MediumAnswerPainter>();
            question.Question.Add(new AlphabetQuestion("Which chess-playing computer developed by IBM defeated the world champion Garry Kasparov in 1997?"));
            formpainter = new FormPainter(new AlphabetAnswer("DEEP BLUE"));
            formpainter.AddComponent(new TimerPainter());
            formpainter.AddComponent(new AnsweredPicturePainter());
            question.CorrectAnswers.Add(formpainter);
            category.addQuestion(question);

            question = new HangManQ<MediumQuestionPainter, MediumAnswerPainter>();
            question.Question.Add(new AlphabetQuestion("Nibble is?"));
            formpainter = new FormPainter(new AlphabetAnswer("HALF BYTE"));
            formpainter.AddComponent(new TimerPainter());
            formpainter.AddComponent(new AnsweredPicturePainter());
            question.CorrectAnswers.Add(formpainter);
            category.addQuestion(question);

            question = new HangManQ<MediumQuestionPainter, MediumAnswerPainter>();
            question.Question.Add(new AlphabetQuestion("Where is the main arithmetical-logical unit located?"));
            formpainter = new FormPainter(new AlphabetAnswer("PROCESSING UNIT"));
            formpainter.AddComponent(new TimerPainter());
            formpainter.AddComponent(new AnsweredPicturePainter());
            question.CorrectAnswers.Add(formpainter);
            category.addQuestion(question);

            question = new HangManQ<MediumQuestionPainter, MediumAnswerPainter>();
            question.Question.Add(new AlphabetQuestion("What does the abbreviation WWW stand for?"));
            formpainter = new FormPainter(new AlphabetAnswer("WORLD WIDE WEB"));
            formpainter.AddComponent(new TimerPainter());
            formpainter.AddComponent(new AnsweredPicturePainter());
            question.CorrectAnswers.Add(formpainter);
            category.addQuestion(question);

            category.Shuffle();
            medium.Categories.Add(category);

            //HISTORY
            category = new Category<MediumQuestionPainter, MediumAnswerPainter>();
            category.CategoryName = "History";
            
            question = new HangManQ<MediumQuestionPainter, MediumAnswerPainter>();
            question.Question.Add(new AlphabetQuestion("Son of Philip 2 Macedonian was called?"));
            formpainter = new FormPainter(new AlphabetAnswer("THE GREAT"));
            formpainter.AddComponent(new TimerPainter());
            formpainter.AddComponent(new AnsweredPicturePainter());
            question.CorrectAnswers.Add(formpainter);
            category.addQuestion(question);

            question = new HangManQ<MediumQuestionPainter, MediumAnswerPainter>();
            question.Question.Add(new AlphabetQuestion("Which of these countries represented the easternmost extent of the Macedonian empire of Alexander the Great? Was it Persia, India, or China?"));
            formpainter = new FormPainter(new AlphabetAnswer("INDIA"));
            formpainter.AddComponent(new TimerPainter());
            formpainter.AddComponent(new AnsweredPicturePainter());
            question.CorrectAnswers.Add(formpainter);
            category.addQuestion(question);

            category.Shuffle();
            medium.Categories.Add(category);

            //HISTORY
            category = new Category<MediumQuestionPainter, MediumAnswerPainter>();
            category.CategoryName = "Geography";

            question = new HangManQ<MediumQuestionPainter, MediumAnswerPainter>();
            question.Question.Add(new AlphabetQuestion("Which is the capital of Kenya?"));
            formpainter = new FormPainter(new AlphabetAnswer("NAIROBY"));
            formpainter.AddComponent(new TimerPainter());
            formpainter.AddComponent(new AnsweredPicturePainter());
            question.CorrectAnswers.Add(formpainter);
            category.addQuestion(question);

            question = new HangManQ<MediumQuestionPainter, MediumAnswerPainter>();
            question.Question.Add(new AlphabetQuestion("Which is the third most populated country in the world?"));
            formpainter = new FormPainter(new AlphabetAnswer("USA"));
            formpainter.AddComponent(new TimerPainter());
            formpainter.AddComponent(new AnsweredPicturePainter());
            question.CorrectAnswers.Add(formpainter);
            category.addQuestion(question);

            category.Shuffle();
            medium.Categories.Add(category);

            medium.MainCategory = main;
        }

        /// <summary>
        /// Creates questions for hard form
        /// </summary>
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
        }
    }
}