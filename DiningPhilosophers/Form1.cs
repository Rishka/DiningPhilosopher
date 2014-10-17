using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiningPhilosophers
{
    public partial class Form1 : Form
    {
        public const int NUM_PHIL = 5;
        public Form1()
        {
            InitializeComponent();
            forks = new List(NUM_PHIL);
            var philosophers = new List<Philosopher>();
            for (int i =0; i< NUM_PHIL; i++;)
                    philosophers.add(new Philosopher(i, NUM_PHIL));
        }
    }
    public class Philosopher
    {
            private int seat, rightFork, leftFork;
            private bool hasRight { get; set; }
            private bool hasLeft { get; set; }
            public static List forks;
            public Philosopher(int seat, int num_phil)
            {
                    this.seat = seat;
                    rightFork = seatNumber;
                    leftFork = seatNumber % num_phil + 1;
                    hasLeft = false;
                    hasRight = false;
            }
            public bool Dine()
            {
                    if (hasLeft && hasRight)
                            return true;
                    else
                            return false;
            }
           
    }
}








