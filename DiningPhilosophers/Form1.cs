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
        private List<Philosopher> philosophers;
        private List<Label> labels;
        private bool cont;
        private List<CheckBox> Forks;
        private Random r;
        public Form1()
        {
            InitializeComponent();
            cont = true;
            //forks are used to prevent access by multiple threads
            forks = new List<Object>();
            labels = new List<Label>();
            Forks = new List<CheckBox>();
            Forks.Add(this.Fork1);
            Forks.Add(Fork2);
            Forks.Add(Fork3);
            Forks.Add(Fork4);
            Forks.Add(Fork5);
            labels.Add(phil1);
            labels.Add(phil2);
            labels.Add(phil3);
            labels.Add(phil4);
            labels.Add(phil5);
            for (int i = 0; i < NUM_PHIL; i++)
                forks.Add(new Object());
            philosophers = new List<Philosopher>();
            for (int i =0; i< NUM_PHIL; i++)//
                    philosophers.Add(new Philosopher(i, NUM_PHIL));
            r = new Random();//create random number generator
            var bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler(delegate(object o, DoWorkEventArgs args) { Eat(); });
            bw.RunWorkerAsync();
        }
        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e )
        {
            
        }
        public void Eat()
        {
            Parallel.ForEach(philosophers, phil  =>//runs each philiosopher in his own thread
                    {
                        while(cont)//continue until user ends the program
                        {
                            var thisLabel = labels.ElementAt(phil.seat);
                            var leftFork = Forks.ElementAt(phil.leftFork);
                            var rightFork = Forks.ElementAt(phil.rightFork);
                            thisLabel.Invoke((MethodInvoker)(() => thisLabel.Text  = "Thinking..."));
                            var nums = new Queue<int>();
                            lock(r)//get 2 random numbers for time to wait
                            {
                                nums.Enqueue(r.Next(0, 10000));
                                nums.Enqueue(r.Next(1000, 10000));
                            }
                            if (nums.Count() == 2)//if unable to get random numbers skip this code
                            {
                                System.Threading.Thread.Sleep(nums.Dequeue());//Think from 0 to 10 seconds
                                thisLabel.Invoke((MethodInvoker)(() => thisLabel.Text = "Hungry"));
                                System.Threading.Thread.Sleep(1000);//sleep for a second so you can see what is going on
                                lock(forks.ElementAt(phil.leftFork))
                                {
                                    
                                    leftFork.Invoke((MethodInvoker)(() =>leftFork.Text = String.Format("Fork {0}: Picked up by Philosopher {1}", phil.leftFork + 1, phil.seat +1 )));
                                    thisLabel.Invoke((MethodInvoker)(() => thisLabel.Text = String.Format("Grabs fork {0}",  phil.leftFork + 1)));
                                    leftFork.Invoke((MethodInvoker)(() =>leftFork.Checked = true));
                                    System.Threading.Thread.Sleep(1000);//sleep for a second so you can see what is going on
                                    lock(forks.ElementAt(phil.rightFork))
                                    {
                                        rightFork.Invoke((MethodInvoker)(() =>rightFork.Text = String.Format("Fork {0}: Picked up by Philosopher {1}", phil.rightFork + 1, phil.seat+ 1)));
                                        rightFork.Invoke((MethodInvoker)(() =>rightFork.Checked = true));
                                        thisLabel.Invoke((MethodInvoker)(() => thisLabel.Text = String.Format("Grabs fork {0}", phil.rightFork+1)));
                                        //MessageBox.Show("Philosopher {0} is eating\n" , phil.seat.ToString());
                                        System.Threading.Thread.Sleep(1000);//sleep for a second so you can see what is going on
                                        thisLabel.Invoke((MethodInvoker)(() => thisLabel.Text = " Eating"));
                                        System.Diagnostics.Debug.Write("Philosopher {0} is eating\n" , phil.seat.ToString());
                                        System.Threading.Thread.Sleep(nums.Dequeue()); //Eat for up to 10 sec
                                        thisLabel.Invoke((MethodInvoker)(() => thisLabel.Text = "Full"));
                                        rightFork.Invoke((MethodInvoker)(() =>rightFork.Text = String.Format("Fork {0}: Put down by Philosopher {1}", phil.rightFork + 1, phil.seat+ 1)));
                                        rightFork.Invoke((MethodInvoker)(() =>rightFork.Checked = false));
                                        System.Threading.Thread.Sleep(1000);//sleep for a second so you can see what is going on

                                        
                                    }
                                    leftFork.Invoke((MethodInvoker)(() =>leftFork.Text = String.Format("Fork {0}: Put down by Philosopher {1}", phil.leftFork + 1, phil.seat +1 )));
                                    thisLabel.Invoke((MethodInvoker)(() => thisLabel.Text = String.Format("Puts down fork {0}",  phil.leftFork + 1)));
                                    leftFork.Invoke((MethodInvoker)(() =>leftFork.Checked = false));
                                    System.Threading.Thread.Sleep(1000);//sleep for a second so you can see what is going on
                                }
                            }
                        }
                    });
        }
    

        private void Philosoper3_Click(object sender, EventArgs e)
        {

        }

        private void Fork1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            cont = true;
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            cont = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                    leftFork = (seat + 1) % num_phil;
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








