using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Trivia_master
{
    public abstract class Game<T,U>
    {
        public State<T, U> state { get; set; }
        public List<Category<T,U>> Category { get; set; }
        public Form basicForm; // soodvetna klasa za forma
        public PictureQ<Image, string> pictureQ;

        public abstract void createState();
    }
}
