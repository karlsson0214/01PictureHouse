﻿namespace PictureShapes
{
    class Picture
    {
        private Square wall;
        public Picture()
        {
            DrawImage();
        }
        public void DrawImage()
        {
            wall = new Square();
            wall.MakeVisible();
            wall.ChangeColor("red");
            wall.ChangeSize(200);
            wall.MoveHorizontal(70);
            wall.MoveVertical(20);

            // Write your code here

        }
    }
}
