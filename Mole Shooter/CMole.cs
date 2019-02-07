using Mole_Shooter.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Mole_Shooter
{
    class CMole : CImageBase
    {
        public CMole()
            : base(Resources.Mole)
        {
            _moleHotSpot.X = Left + 20;
            _moleHotSpot.Y = Top - 1;
            _moleHotSpot.Width = 30;
            _moleHotSpot.Height = 40;
        }

        private Rectangle _moleHotSpot = new Rectangle();

        public void update(int X, int Y)
        {
        Left = X;
        Top = Y;
        _moleHotSpot.X = Left + 20;
        _moleHotSpot.Y = Top - 1;
        }
        public bool Hit(int X, int Y)
        {
        Rectangle c = new Rectangle(X, Y, 1, 1); // Create a cursor rect - quick check for hit

        if (_moleHotSpot.Contains(c))
        {
            return true;
        }
        return false;
        }
    }
}
