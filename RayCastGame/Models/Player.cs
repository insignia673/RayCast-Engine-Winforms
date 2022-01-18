﻿using RayCastGame.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RayCastGame.Models
{
    public class Player : Entity
    {
        public double DirX { get; set; } = -1;
        public double DirY { get; set; } = 0;
        public double PlaneX { get; set; } = 0;
        public double PlaneY { get; set; } = .66;
        public void Update(double gametime, int[,] map, int turn)
        {
            #region Walk
            if (Input.KEYINPUT[Keys.W])
            {
                if (map[(int)(CoorX + DirX * gametime), (int)CoorY] != 1) CoorX += (float)(DirX * gametime);
                if (map[(int)CoorX, (int)(CoorY + DirY * gametime)] != 1) CoorY += (float)(DirY * gametime);
            }
            if (Input.KEYINPUT[Keys.D])
            {
                if (map[(int)(CoorX - DirY * gametime), (int)CoorY] != 1) CoorX -= (float)(DirY * gametime);
                if (map[(int)CoorX, (int)(CoorY + DirX * gametime)] != 1) CoorY += (float)(DirX * gametime);
            }
            if (Input.KEYINPUT[Keys.S])
            {
                if (map[(int)(CoorX - DirX * gametime), (int)CoorY] != 1) CoorX -= (float)(DirX * gametime);
                if (map[(int)CoorX, (int)(CoorY - DirY * gametime)] != 1) CoorY -= (float)(DirY * gametime);
            }
            if (Input.KEYINPUT[Keys.A])
            {
                if (map[(int)(CoorX + DirY * gametime), (int)CoorY] != 1) CoorX += (float)(DirY * gametime);
                if (map[(int)CoorX, (int)(CoorY - DirX * gametime)] != 1) CoorY -= (float)(DirX * gametime);
            }
            #endregion

            #region Turn
            double oldDirX = DirX;
            DirX = DirX * Math.Cos(gametime * turn) - DirY * Math.Sin(gametime * turn);
            DirY = oldDirX * Math.Sin(gametime * turn) + DirY * Math.Cos(gametime * turn);
            double oldPlaneX = PlaneX;
            PlaneX = PlaneX * Math.Cos(gametime * turn) - PlaneY * Math.Sin(gametime * turn);
            PlaneY = oldPlaneX * Math.Sin(gametime * turn) + PlaneY * Math.Cos(gametime * turn);

            //--- If Done With Keys---//
            //if (Input.KEYINPUT[Keys.Left])
            //{
            //    double oldDirX = DirX;
            //    DirX = DirX * Math.Cos(gametime * 6) - DirY * Math.Sin(gametime * 6);
            //    DirY = oldDirX * Math.Sin(gametime * 6) + DirY * Math.Cos(gametime * 6);
            //    double oldPlaneX = PlaneX;
            //    PlaneX = PlaneX * Math.Cos(gametime * 6) - PlaneY * Math.Sin(gametime * 6);
            //    PlaneY = oldPlaneX * Math.Sin(gametime * 6) + PlaneY * Math.Cos(gametime * 6);
            //}
            //if (Input.KEYINPUT[Keys.Right])
            //{
            //    //both camera direction and camera plane must be rotated
            //    double oldDirX = DirX;
            //    DirX = DirX * Math.Cos(-gametime * 6) - DirY * Math.Sin(-gametime * 6);
            //    DirY = oldDirX * Math.Sin(-gametime * 6) + DirY * Math.Cos(-gametime * 6);
            //    double oldPlaneX = PlaneX;
            //    PlaneX = PlaneX * Math.Cos(-gametime * 6) - PlaneY * Math.Sin(-gametime * 6);
            //    PlaneY = oldPlaneX * Math.Sin(-gametime * 6) + PlaneY * Math.Cos(-gametime * 6);
            //}
            #endregion
        }
    }
}