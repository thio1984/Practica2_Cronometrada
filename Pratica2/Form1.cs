using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratica2
{
    public partial class Form1 : Form
    {
        // Create a Random object to generate random numbers.
        Random randomizer = new Random();
        // These ints will store the numbers
        // for the addition problem.
        int addend1;
        int addend2;

        // These ints will store the numbers
        // for the subtraction problem.
        int minuend;
        int subtrahend;

        // These ints will store the numbers for the multiplication problem.
        int multiplicand;
        int multiplier;

        // These ints will store the numbers for the division problem.
        int dividend;
        int divisor;


        // This int will keep track of the time left.
        int timeLeft;


        public Form1()
        {
            InitializeComponent();
        }

      

        /// <summary>
        /// Start the quiz by filling in all of the problems
        /// and starting the timer.
        /// </summary>
        public void StartTheQuiz()
        {
            // Fill in the addition problem.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            plusleftlabel.Text = addend1.ToString();
            plusrigthlabel.Text = addend2.ToString();
            suma.Value = 0;

            // Fill in the subtraction problem.
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusleftlabel.Text = minuend.ToString();
            minusrigthlabel.Text = subtrahend.ToString();
            diferencia.Value = 0;

            // Fill in the multiplication problem.
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesleftlabel.Text = multiplicand.ToString();
            timesrigthlabel.Text = multiplier.ToString();
            producto.Value = 0;

            // Fill in the division problem.
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            divideleftlabel.Text = dividend.ToString();
            dividerigthlabel.Text = divisor.ToString();
            cociente.Value = 0;

            // Start the timer.
            timeLeft = 30;
            timelabel.Text = "30 seconds";
            timer1.Start();
        }
        /// <summary>
        /// Check the answer to see if the user got everything right.
        /// </summary>
        /// <returns>True if the answer's correct, false otherwise.</returns>
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == suma.Value)
        && (minuend - subtrahend == diferencia.Value)
        && (multiplicand * multiplier == producto.Value)
        && (dividend / divisor == cociente.Value))
                return true;
            else
                return false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.StartTheQuiz();
            this.startButton.Enabled = false;



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // If the user got the answer right, stop the timer 
                // and show a MessageBox.
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // Decrease the time left by one second and display 
                // the new time left by updating the Time Left label.
                timeLeft--;
                timelabel.Text = timeLeft + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timelabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry");
                suma.Value = addend1 + addend2;
                diferencia.Value = minuend - subtrahend;
                producto.Value = multiplicand * multiplier;
                cociente.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

      
    }
}
