/// created by : Mann Patel 
/// date       : December
/// description: A Fun Adventure Game

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CampingAdventure
{
    public partial class campingAdventure : Form
    {
        // tracks what part of the game the user is at
        int scene = 0;

        // random number generator
        Random randGen = new Random();

        // sound players
        SoundPlayer Bear = new SoundPlayer(Properties.Resources.Bear_Sound);
        SoundPlayer campFire = new SoundPlayer(Properties.Resources.Campfire);
        SoundPlayer Death = new SoundPlayer(Properties.Resources.Death_sound);

        public campingAdventure()
        {
            InitializeComponent();

            outputLabel.Text = "Welcome! To the start of your amazing Adventure!"; //display initial message and options
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0)
                {
                    
                }
                else if (scene == 1)
                {
                   
                }
                else if (scene == 2)
                {

                }
                else if (scene == 3)
                {
                    scene = 0;
                }
                else if (scene == 4)
                {
                    
                }
                else if (scene == 5)
                {
                    scene = 7;
                }
                else if (scene == 6)
                {
                    scene = 22;
                }
                else if (scene == 7)
                {
                    int water = randGen.Next(1,101);

                    if (water < 50)
                    {
                        scene = 8;
                    }
                    else
                    {
                        scene = 9;
                    }
                    
                }
                else if (scene == 8)
                {
                    scene = 22;
                }
                else if (scene == 9)
                {

                }
                else if (scene == 10)
                {
                    scene = 11;
                }
                else if (scene == 11)
                {

                }
                else if (scene == 12)
                {
                    scene = 13;
                }
                else if (scene == 13)
                {

                }
                else if (scene == 14)
                {

                }
                else if (scene == 15)
                {

                }
                else if (scene == 16)
                {
                    scene = 17;
                }
                else if (scene == 17)
                {
                        scene = 18;
                }
                else if (scene == 18)
                {
                    
                }
                else if (scene == 19)
                {

                }
                else if (scene == 20)
                {

                }
                else if (scene == 21)
                {

                }
                else if (scene == 22)
                {
                    scene = 0;
                }
                else if (scene == 23)
                {

                }
            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    
                }
                else if (scene == 2)
                {
                    scene = 3; 
                }
                else if (scene == 3)
                {
                    scene = 10;
                }
                else if (scene == 4)
                {
                    scene = 5;
                }
                else if (scene == 5)
                {
                    scene = 6;
                }
                else if (scene == 6)
                {
                    scene = 22;
                }
                else if (scene == 7)
                {
                    scene = 9;
                }
                else if (scene == 8)
                {

                }
                else if (scene == 9)
                {

                }
                else if (scene == 10)
                {
                    scene = 12;
                }
                else if (scene == 11)
                {

                }
                else if (scene == 12)
                {
                    scene = 15;
                }
                else if (scene == 13)
                {

                }
                else if (scene == 14)
                {
                    scene = 22;
                }
                else if (scene == 15)
                {

                }
                else if (scene == 16)
                {
                    scene = 0;
                }
                else if (scene == 17)
                {
                    scene = 0;
                }
                else if (scene == 18)
                {
                    int run = randGen.Next(1, 101);

                    if (run < 70)
                    {
                        scene = 20;
                    }
                    else
                    {
                        scene = 22;
                    }
                }
                else if (scene == 19)
                {
                    scene = 23;
                }
                else if (scene == 20)
                {
                    scene = 0;
                }
                else if (scene == 21)
                {

                }
                else if (scene == 22)
                {
                    scene = 23;
                }
                else if (scene == 23)
                {

                }

            }
            else if (e.KeyCode == Keys.N)   // yellow button press
            {
                if (scene == 0)
                {
                    scene = 16;
                }
                else if (scene == 1)
                {
                    scene = 2;
                }
                else if (scene == 2)
                {
                    int value = randGen.Next(1,101);

                    if (value > 60)
                    {
                        scene = 4;
                    }
                    else
                    {
                        scene = 3;
                    }
                    
                }
                else if (scene == 3)
                {

                }
                else if (scene == 4)
                {

                }
                else if (scene == 5)
                {

                }
                else if (scene == 6)
                {
                    scene = 14;
                }
                else if (scene == 7)
                {

                }
                else if (scene == 8)
                {

                }
                else if (scene == 9)
                {
                    scene = 22;
                }
                else if (scene == 10)
                {

                }
                else if (scene == 11)
                {
                    scene = 22;
                }
                else if (scene == 12)
                {

                }
                else if (scene == 13)
                {
                    scene = 22;
                }
                else if (scene == 14)
                {

                }
                else if (scene == 15)
                {
                    scene = 22;
                }
                else if (scene == 16)
                {

                }
                else if (scene == 17)
                {

                }
                else if (scene == 18)
                {
                    int away = randGen.Next(1,11);

                    if (away < 3)
                    {
                        scene = 19;
                    }
                    else
                    {
                        scene = 21;
                    }
                    
                }
                else if (scene == 19)
                {

                }
                else if (scene == 20)
                {

                }
                else if (scene == 21)
                {
                    scene = 22;
                }
                else if (scene == 22)
                {

                }
                else if (scene == 23)
                {

                }
            }

                /// Display text and game options to screen based on the current scene
                switch (scene)
            {
                case 0:
                    outputLabel.Text = "You are in the middle of a forest. camping with your friends \n\nWhat is your next move?";
                    redLabel.Text = "Stay at camp";
                    blueLabel.Text = "Explore";
                    yellowLabel.Text = "Share Stories";
                    campFire.Play();
                    break;
                case 1:
                    campFire.Stop();
                    outputLabel.Text = "You want to explore \n\nYour friends agree. \n\nYou start your exploration of the vast forest!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "Continue";
                    break;
                case 2:
                    outputLabel.Text = "one of your friends spots a wild fox \n\nTame it?";
                    redLabel.Text = "";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "Yes";
                    break;
                case 3:
                    outputLabel.Text = "It's unfortunate that you didn't tame the majestic fox \n\nDo you want to go back to camp?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    break;
                case 4:
                    outputLabel.Text = "You've successfully tamed the fox! \n\nHe is now your pet";
                    redLabel.Text = "";
                    blueLabel.Text = "Continue";
                    yellowLabel.Text = "";
                    break;
                case 5:
                    outputLabel.Text = "You continue on your adventure in the vast forest, your friend asks if you have water in your water bottle \n\n you check and see you don't have any, but you spot a river near you \n\n Do you want to go to river for water? ";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    break;
                case 6:
                    outputLabel.Text = "You decide you don't want to waste your time to get water \n\nYou continue in the forest until you suddenly encounter a deadly Grizzly Bear \n\n What do you do?";
                    redLabel.Text = "Play Dead";
                    blueLabel.Text = "Run";
                    yellowLabel.Text = "Curl up and lay flat";
                    break;
                case 7:
                    outputLabel.Text = "You decide to go to the river to get water \n\nDo you drink the water?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    break;
                case 8:
                    outputLabel.Text = "You Died :( \n\n The water had Cholera";
                    redLabel.Text = "Continue";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 9:
                    outputLabel.Text = "\n\nYou drink the water and are back to your journey \n\nYou decide you've explored enough and go back to camp";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "Continue";
                    break;
                case 10:
                    outputLabel.Text = "You continue your journey in the forest \nyou spot something shiny \nyou go to investigate the shiny object to find out that it is a loaded gun \n\nyour friend being the idiot that he is takes the gun out of your hand" +
                        " and starts pointing at all of your friends and pretends to shoot you all, \nhe is not aware that the gun is loaded and goes to fire the gun, the bullet hits one of your friends \n\n what do you do?";
                    redLabel.Text = "run away";
                    blueLabel.Text = "call ambulance";
                    yellowLabel.Text = "";
                    break;
                case 11:
                    outputLabel.Text = "you decide to run away \n\nyou arrive back at camp and decide to go back \n\na week later your friends dead body is found along with the murder weapon " +
                        "\n\nThrough forensic evidence your friends fingerprint came up on the murder weapon, he was taken in for questioning and you got taken in juvie for 6 monthes";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "continue";
                    break;
                case 12:
                    outputLabel.Text = "as the good friend you are, you call the ambulance \n\nthe ambulance arrives and your friend is taken to the hospital " +
                        "\n\nyou go to check on your friend a day later to find out that he has somewhat recovered\n\ndo you speak of what happened?";
                    redLabel.Text = "no";
                    blueLabel.Text = "yes";
                    yellowLabel.Text = "";
                    break;
                case 13:
                    outputLabel.Text = "you and your friend agree to never speak of this incident again";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "continue";
                    break;
                case 14:
                    outputLabel.Text = "You've survived the bear encounter and run back to the safety of your camp";
                    redLabel.Text = "";
                    blueLabel.Text = "Continue";
                    yellowLabel.Text = "";
                    break;
                case 15:
                    outputLabel.Text = "you decide to talk to your friend about what happened " +
                        "\n\nyou come to the conclusion of forgiving your friend for pulling the trigger as he didn't know the gun was loaded";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "Continue";
                    break;
                case 16:
                    campFire.Stop();
                    outputLabel.Text = "Your friends tell you a story about an abandoned house near where your camping \n\nDo you want to check it out?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    break;
                case 17:
                    outputLabel.Text = "You and your friends decide to check out the abandoned house \n\n\nWhen you arrive you see a strange figure within \n\nContinue?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    break;
                case 18:
                    outputLabel.Text = "You and your friends decide to be brave and walk through the front door \n\n\nAs soon as you open the front door you see the figure right in front of you" +
                        "\n\nRun away?";
                    redLabel.Text = "";
                    blueLabel.Text = "Yes";
                    yellowLabel.Text = "No";
                    break;
                case 19:
                    outputLabel.Text = "You and your friends successfully escaped the strange figure \n\n\nYou decide to explore the house and you find amazing treasure within!";
                    redLabel.Text = "";
                    blueLabel.Text = "Continue";
                    yellowLabel.Text = "";
                    break;
                case 20:
                    outputLabel.Text = "You and your friends decide not to be brave and run away";
                    redLabel.Text = "";
                    blueLabel.Text = "Continue";
                    yellowLabel.Text = "";
                    break;
                case 21:
                    outputLabel.Text = "You didn't survive the fight between the strange figure";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "Continue";
                    break;
                case 22:
                    Death.Play();
                    outputLabel.Text = "Game Over \n\n Play Again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    break;
                case 23:
                    outputLabel.Text = "\n\n\n\n\n\n\n\n          Thank you for Playing!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                default:
                    break;
            }
        }

      
        

        }
    }
    
    


