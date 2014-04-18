using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Trivia_master
{
    public abstract class Game
    {
        public Form basicForm; // soodvetna klasa za forma
        public PictureQ<Image, string> pictureQ;
    }
}
