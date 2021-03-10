using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        private Button[] buttons;
        private int player;
        public TicTacToe()
        {
            InitializeComponent();
            player = 1;
            label1.Text = "Текущий ход: игрок 1 (X)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (player)
            {
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "X");
                    player = 0;
                    label1.Text = "Текущий ход: игрок 2 (O)";
                    break;

                case 0:
                    sender.GetType().GetProperty("Text").SetValue(sender, "O");
                    player = 1;
                    label1.Text = "Текущий ход: игрок 1 (X)";
                    break;
            }
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            checkWin();
            //MessageBox.Show(sender.GetType().GetProperty("Name").GetValue(sender).ToString());

        }
        private void checkWin()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                if (button1.Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                if (button4.Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (button7.Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (button1.Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (button2.Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (button3.Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                if (button1.Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                if (button3.Text != "")
                    MessageBox.Show("Вы победили!");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process.Start(Application.ExecutablePath);
            Close();
        }
    }
}

