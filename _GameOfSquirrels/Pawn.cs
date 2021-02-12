﻿using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _GameOfSquirrels
{
    public class Pawn : IPawn
    {
        private int _locationX;
        public int LastRoll { get; set; }
        public bool GoingUp { get; set; }
        public bool GoingRight { get; set; }

        public int LocationX
        {
            get { return _locationX; }
            set { _locationX = value; }
        }

        private int _locationY;

        public int LocationY
        {
            get { return _locationY; }
            set { _locationY = value; }
        }

        private Ellipse _ellipse;

        public Ellipse Ellipse
        {
            get { return _ellipse; }
            set { _ellipse = value; }
        }

        public Pawn(int locationX, int locationY)
        {
            LocationX = locationX;
            LocationY = locationY;

            Ellipse = new Ellipse() { Fill = Brushes.DarkRed, Height = 20, Width = 20, };
        }

        public void Move()
        {
            Dice dice = new Dice();
            int roll = dice.RollDice(1, 7);
            LastRoll = roll;
            LocationX += roll;
            Grid.SetColumn(Ellipse, LocationX);
        }

        public void Move(int x)
        {
            LocationX += x;
            Grid.SetColumn(Ellipse, LocationX);
            Grid.SetRow(Ellipse, LocationY);
        }
    }
}