using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Random;

namespace DiningPhilosophers
{
    public partial class Form1 : Form
    {
        public const int NUM_PHIL = 5;
        public List forks;
        private cont;
        public Form1()
        {
            InitializeComponent();
            forks = new List(NUM_PHIL);
            var philosophers = new List<Philosopher>();
            for (int i =0; i< NUM_PHIL; i++;)
                    philosophers.add(new Philosopher(i, NUM_PHIL));
            Parrallel.foreach (var phil in philosophers) //runs each philiosopher in his own thread
                    {
                            while(cont)//continue until user ends the program
                                    {
                                            System.Threading.Thread.Sleep(Random.Next(0, 10000));//Think from 0 to 10 seconds
                                            lock(forks.get(phil.leftFork))
                                                    {
                                                            lock(forks.get(phil.rightFork))
                                                                    {
                                                                            Console.Writeline("Philosopher {0} is eating" , phil.seat.ToString()})
                                                                    }
                                                    }
                                    }
                    }
        }
    }
    public class Philosopher
    {
            public int seat, rightFork, leftFork;
            private bool hasRight { get; set; }
            private bool hasLeft { get; set; }
            public double timeThinking;
            private string status { get; set; }
            public Philosopher(int seat, int num_phil)
            {
                    this.seat = seat;
                    rightFork = seatNumber;
                    leftFork = seatNumber % num_phil + 1;
                    hasLeft = false;
                    hasRight = false;
                    status = "Thinking"
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








