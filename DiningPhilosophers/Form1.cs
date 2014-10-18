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
        public List<Object> forks;
        private bool cont;
        public Form1()
        {
            InitializeComponent();
            forks = new List<Object>(NUM_PHIL);
            var philosophers = new List<Philosopher>();
            for (int i =0; i< NUM_PHIL; i++)
                    philosophers.Add(new Philosopher(i, NUM_PHIL));
            var r = new Random();
            Parallel.ForEach(philosophers, phil  =>//runs each philiosopher in his own thread
                    {
                            while(cont)//continue until user ends the program
                                    {
                                            var nums = new Queue<int>();
                                            lock(r)
                                            {
                                                    nums.Enqueue(r.Next(0, 10000));
                                                    nums.Enqueue(r.Next(1000, 10000));
                                            }
                                            System.Threading.Thread.Sleep(nums.Dequeue());//Think from 0 to 10 seconds
                                            lock(forks.ElementAt(phil.leftFork))
                                                    {
                                                            lock(forks.ElementAt(phil.rightFork))
                                                                    {
                                                                            System.Diagnostics.Debug.Write("Philosopher {0} is eating\n" , phil.seat.ToString());
                                                                            System.Threading.Thread.Sleep(nums.Dequeue()); //Eat for up to 10 sec
                                                                    }
                                                    }
                                            
                                    }
                    });
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
                    rightFork = seat;
                    leftFork = seat % num_phil + 1;
                    hasLeft = false;
                    hasRight = false;
                    status = "Thinking";
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








