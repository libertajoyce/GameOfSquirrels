﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace _GameOfSquirrels
{
    internal class FireTile : Tile
    {
        public FireTile(int locationX, int locationY)
            : base(locationX, locationY)
        {
            TileBorder = new Border();
            TileBorder.Background = Brushes.Firebrick;
        }

        public override int GetInteraction()
        {
            MessageBox.Show("Fire! Move back to the start!");
            return 0;
        }
    }
}