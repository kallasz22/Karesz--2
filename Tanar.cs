using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace Karesz
{
    public partial class Form1 : Form
    {
        string betöltendő_pálya = "palya70.txt";

        void TANÁR_ROBOTJAI()
        {
            new Robot("Karesz", 0, 0, 0, 0, 0, 1, 1, 2);

            Robot anti1 = new Robot("anti1", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1000, 9, 15, 2);
            anti1.Feladat = delegate ()
            {
                for (int i = 0; i < 1000; i++)
                {
                    for (int j = 0; j < 15; j++)
                    {
                        anti1.Várj();
                    }
                    anti1.Lőjj();
                }
            };

            Robot anti2 = new Robot("anti2", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1000, 31, 21, 1);
            anti2.Feladat = delegate ()
            {
                for (int i = 0; i < 1000; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        anti2.Várj();
                    }
                    anti2.Lőjj();
                }
            };

            Robot anti3 = new Robot("anti3", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1000, 9, 9, 1);
            anti3.Feladat = delegate ()
            {
                for (int i = 0; i < 1000; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        anti3.Várj();
                    }
                    anti3.Lőjj();
                }
            };

            Robot anti4 = new Robot("anti3", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1000, 35, 25, 2);
            anti4.Feladat = delegate ()
            {
                for (int i = 0; i < 1000; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        anti4.Várj();
                    }
                    anti4.Lőjj();
                }
            };
        }
    }
}