using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    abstract public class Figure
    {
        public int x;
        public int y;
        public int w;
        public int h;
        abstract public void Draw();
        abstract public void MoveTo(int x, int y);

    }

}
