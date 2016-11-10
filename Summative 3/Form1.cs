/// created by : (M)Addie
/// date       : November 7, 2016
/// description: A basic text adventure game engine
/// 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summative_3
{

    public partial class Form1 : Form
    {
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\chord.wav");

        Random randGen = new Random();

        int scene = 1;  // tracks what part of the game the user is at
        

        public Form1()
        {
            InitializeComponent();

            //TODO display initial message and options
            outputLabel.Text = "You accidentally ran over Santa so now you have to deliver all these presents in one night! Do you take on this challenge? ";
            redLabel.Text = "Yes";
            greenLabel.Text = "No";
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            startSoundPlayer.Play();

            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 1)
                {
                    scene = 2;
                }
                else if (scene == 2)
                {
                    scene = 5;
                }
                else if (scene == 4)
                {
                    scene = 6;
                }
                else if (scene == 6)
                {
                    scene = 9;
                }
                else if (scene == 8)
                {
                    scene = 10;
                }
                else if (scene == 3)
                {
                    scene = 1;
                }
                else if (scene == 5)
                {
                    scene = 1;
                }
                else if (scene == 7)
                {
                    scene = 1;
                }
                else if (scene == 9)
                {
                    scene = 1;
                }
                else if (scene == 10)
                {
                    scene = 1;
                }
                else if (scene == 11)
                {
                    scene = 1;
                }

            }
            else if (e.KeyCode == Keys.B)  //green button press
            {
                if (scene == 1)
                {
                    scene = 2;
                }
                else if (scene == 2)
                {
                    int chance = randGen.Next(1, 101);

                    if (chance < 80)
                    {
                        scene = 4;
                    }

                    else if (chance > 80)
                    {
                        scene = 5;
                    }
                }
                else if (scene == 4)
                {
                    scene = 7;
                }
                else if (scene == 6)
                {
                    scene = 8;
                }
                else if (scene == 8)
                {
                    scene = 11;
                }
                else if (scene == 3)
                {
                    this.Close();
                }
                else if (scene == 5)
                {
                    this.Close();
                }
                else if (scene == 7)
                {
                    this.Close();
                }
                else if (scene == 9)
                {
                    this.Close();
                }
                else if (scene == 10)
                {
                    this.Close();
                }
                else if (scene == 11)
                {
                    this.Close();
                }



            }

            switch (scene)
            {
                case 1:  //start scene  
                    break;
                case 2:
                    outputLabel.Text = "The elves are slacking off and wont build the toys and you only have 23 hours left till christmas eve!!!Do you threaten them or ask them nicely?";
                    redLabel.Text = "Threaten them";
                    greenLabel.Text = "Ask them nicely";
                    break;
                case 3:
                    outputLabel.Text = "You get kicked out of Santa's workshop. You're stranded alone in the North Pole. You die.";
                    redLabel.Text = "Restart";
                    greenLabel.Text = "Close Game";
                    break;
                case 4:
                    outputLabel.Text = "The elves grudgingly do their job, but... oh no! Prancer dies! Do you go ahead with it and make Rudolph take Prancer's place or get a baby reindeer to do so?";
                    redLabel.Text = "Baby Reindeer";
                    greenLabel.Text = "Rudolph";
                    break;
                case 5:
                    outputLabel.Text = "You're on the naughty list now :) Guess you were always meant to be a loser ";
                    redLabel.Text = "Restart";
                    greenLabel.Text = "Close Game";
                    break;
                case 6:
                    outputLabel.Text = "The baby reindeer practices and is surprisingly amazing at it. However, all the presents still aren't ready!!! Do you give the rest of the kids coal or give the rest of the kids money ?";
                    redLabel.Text = "Coal";
                    greenLabel.Text = "Money";
                    break;
                case 7:
                    outputLabel.Text = "Rudolph crashes and breaks his leg! Now Christmas is ruined thanks to you! You really do ruin everything you touch...";
                    redLabel.Text = "Restart";
                    greenLabel.Text = "Close Game";
                    break;
                case 8:
                    outputLabel.Text = "The elves admire your kindness, so they decide to speed up and get it done! Just one more task. Do you start delivering presents from the East or the West?";
                    redLabel.Text = "East";
                    greenLabel.Text = "West";
                    break;
                case 9:
                    outputLabel.Text = "Wow can't believe you're Satan. ";
                    redLabel.Text = "Restart";
                    greenLabel.Text = "Close Game";
                    break;
                case 10:
                    outputLabel.Text = "Great Job! You won the game and you have a good understanding of how time zones work! You're not stupid!";
                    redLabel.Text = "Restart";
                    greenLabel.Text = "Close Game";
                    break;
                case 11:
                    outputLabel.Text = "Yikes, why are you like this?";
                    redLabel.Text = "Restart";
                    greenLabel.Text = "Close Game";
                    break; 
                default:
                    break;
            }
        }

    }
}
           