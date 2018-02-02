using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
 public partial class Form1: Form {
  int box = 1;
  int number = 0;
  List numbers = new List();
  List cards = new List();
  bool stack = false;
  bool snap;
  DateTime p1sTime;
  DateTime p2sTime;
  bool restack;
  double p2seconds;
  double p1seconds;
  bool keypressedp1 = false;
  bool keypressedp2 = false;

  public Form1() {
   InitializeComponent();

   lbldetailsp1.Text = "Player 1 \nsnap with \n1 key";
   lbldetailsp2.Text = "Player 2 \nsnap with \n0 key ";

   picbox1.Image = Properties.Resources.back;
   picbox2.Image = Properties.Resources.back;
  }

  private void timer2_Tick(object sender, EventArgs e) {
   while (stack == false) {
    //populate lists
    //hearts
    cards.Add(Properties.Resources.ace_of_hearts);
    numbers.Add(1);
    cards.Add(Properties.Resources._2_of_hearts);
    numbers.Add(2);
    cards.Add(Properties.Resources._3_of_hearts);
    numbers.Add(3);
    cards.Add(Properties.Resources._4_of_hearts);
    numbers.Add(4);
    cards.Add(Properties.Resources._5_of_hearts);
    numbers.Add(5);
    cards.Add(Properties.Resources._6_of_hearts);
    numbers.Add(6);
    cards.Add(Properties.Resources._7_of_hearts);
    numbers.Add(7);
    cards.Add(Properties.Resources._8_of_hearts);
    numbers.Add(8);
    cards.Add(Properties.Resources._9_of_hearts);
    numbers.Add(9);
    cards.Add(Properties.Resources._10_of_hearts);
    numbers.Add(10);
    cards.Add(Properties.Resources.jack_of_hearts);
    numbers.Add(11);
    cards.Add(Properties.Resources.queen_of_hearts);
    numbers.Add(12);
    cards.Add(Properties.Resources.king_of_hearts);
    numbers.Add(13);

    //spades
    cards.Add(Properties.Resources.ace_of_spades);
    numbers.Add(1);
    cards.Add(Properties.Resources._2_of_spades);
    numbers.Add(2);
    cards.Add(Properties.Resources._3_of_spades);
    numbers.Add(3);
    cards.Add(Properties.Resources._4_of_spades);
    numbers.Add(4);
    cards.Add(Properties.Resources._5_of_spades);
    numbers.Add(5);
    cards.Add(Properties.Resources._6_of_spades);
    numbers.Add(6);
    cards.Add(Properties.Resources._7_of_spades);
    numbers.Add(7);
    cards.Add(Properties.Resources._8_of_spades);
    numbers.Add(8);
    cards.Add(Properties.Resources._9_of_spades);
    numbers.Add(9);
    cards.Add(Properties.Resources._10_of_spades);
    numbers.Add(10);
    cards.Add(Properties.Resources.jack_of_spades);
    numbers.Add(11);
    cards.Add(Properties.Resources.queen_of_spades);
    numbers.Add(12);
    cards.Add(Properties.Resources.king_of_spades);
    numbers.Add(13);

    //dimonds
    cards.Add(Properties.Resources.ace_of_dimonds);
    numbers.Add(1);
    cards.Add(Properties.Resources._2_of_dimonds);
    numbers.Add(2);
    cards.Add(Properties.Resources._3_of_dimonds);
    numbers.Add(3);
    cards.Add(Properties.Resources._4_of_dimonds);
    numbers.Add(4);
    cards.Add(Properties.Resources._5_of_dimonds);
    numbers.Add(5);
    cards.Add(Properties.Resources._6_of_dimonds);
    numbers.Add(6);
    cards.Add(Properties.Resources._7_of_dimonds);
    numbers.Add(7);
    cards.Add(Properties.Resources._8_of_dimonds);
    numbers.Add(8);
    cards.Add(Properties.Resources._9_of_dimonds);
    numbers.Add(9);
    cards.Add(Properties.Resources._10_of_dimonds);
    numbers.Add(10);
    cards.Add(Properties.Resources.jack_of_dimonds);
    numbers.Add(11);
    cards.Add(Properties.Resources.queen_of_dimonds);
    numbers.Add(12);
    cards.Add(Properties.Resources.king_of_dimonds);
    numbers.Add(13);

    //clubs
    cards.Add(Properties.Resources.ace_of_clubs);
    numbers.Add(1);
    cards.Add(Properties.Resources._2_of_clubs);
    numbers.Add(2);
    cards.Add(Properties.Resources._3_of_clubs);
    numbers.Add(3);
    cards.Add(Properties.Resources._4_of_clubs);
    numbers.Add(4);
    cards.Add(Properties.Resources._5_of_clubs);
    numbers.Add(5);
    cards.Add(Properties.Resources._6_of_clubs);
    numbers.Add(6);
    cards.Add(Properties.Resources._7_of_clubs);
    numbers.Add(7);
    cards.Add(Properties.Resources._8_of_clubs);
    numbers.Add(8);
    cards.Add(Properties.Resources._9_of_clubs);
    numbers.Add(9);
    cards.Add(Properties.Resources._10_of_clubs);
    numbers.Add(10);
    cards.Add(Properties.Resources.jack_of_clubs);
    numbers.Add(11);
    cards.Add(Properties.Resources.queen_of_clubs);
    numbers.Add(12);
    cards.Add(Properties.Resources.king_of_clubs);
    numbers.Add(13);

    //pile has been stacked
    stack = true;
    //if after 30 seconds still hasnt snapped, make it snap
    if (restack == true && box == 1) {
     for (int i = 0; i < numbers.Count; i++) {
      if (numbers[i] == number) {
       picbox1.Image = cards[i];
       snap = true;
       timer1.Start();
       timer3.Start();
       p1sTime = DateTime.Now;
       p2sTime = DateTime.Now;
       box = 0;
       i = cards.Count;
      }

     }
    }
    if (restack == true && box == 2) {
     for (int i = 0; i < numbers.Count; i++) {
      if (numbers[i] == number) {
       picbox2.Image = cards[i];
       snap = true;
       timer1.Start();
       timer3.Start();
       p1sTime = DateTime.Now;
       p2sTime = DateTime.Now;
       box = 0;
       i = cards.Count;
      }
     }
    }
   }

   if (box == 1 && snap == false) {
    //random card generator
    Random r = new Random();
    int randomno = r.Next(0, (cards.Count));
    //set number to match
    int number1 = numbers[randomno];
    //put card in picbox
    picbox1.Image = cards[randomno];
    //remove this card from deck
    numbers.RemoveAt(randomno);
    cards.RemoveAt(randomno);
    //check for match
    if (number1 == number) {
     snap = true;
     timer1.Start();
     timer3.Start();
     p1sTime = DateTime.Now;
     p2sTime = DateTime.Now;
     box = 0;
    } else {
     number = number1;
     if (cards.Count < 22) //if after 30 cards(30 seconds) there still hasnt been a match
     {
      stack = false;
      restack = true;


     }

    }

   } else if (box == 2 && snap == false) {
    //random card generator
    Random r = new Random();
    int randomno = r.Next(0, (cards.Count));
    //set number to match
    int number2 = numbers[randomno];
    //put card in picbox
    picbox2.Image = cards[randomno];
    //remove this card from deck
    numbers.RemoveAt(randomno);
    cards.RemoveAt(randomno);
    //check for match
    if (number2 == number) {
     //lblmessage.Text = "snap";
     snap = true;
     timer1.Start();
     timer3.Start();
     p1sTime = DateTime.Now;
     p2sTime = DateTime.Now;
     box = 0;
    } else {
     //if no match set the new number to be matched and move to the other box
     number = number2;

     if (cards.Count < 22) //if after 30 cards(30 seconds) there still hasnt been a match
     {
      restack = true;
      stack = false;
     }
    }
   }
   //change boxes
   if (box == 1)
    box++;
   else if (box == 2)
    box--;
  }

  private void Form1_KeyPress(object sender, KeyPressEventArgs e) {
   if ((e.KeyChar == '1') && (snap == true) && (keypressedp1 == false)) //player 1
   {
    timer1.Stop();
    DateTime p1eTime = DateTime.Now;
    TimeSpan p1t = p1eTime - p1sTime;
    p1seconds = p1t.TotalSeconds;
    string player1 = p1seconds.ToString();
    lblmessage.Text = "Player 1 reflex = " + player1;
    keypressedp1 = true;

   }
   if ((e.KeyChar == '0') && (snap == true) && (keypressedp2 == false)) //player2
   {
    timer1.Stop();
    DateTime p2eTime = DateTime.Now;
    TimeSpan p2t = p2eTime - p2sTime;
    p2seconds = p2t.TotalSeconds;
    string player2 = p2seconds.ToString();
    lblmessage2.Text = "Player 2 reflex = " + player2;
    keypressedp2 = true;
   }
   if ((p2seconds < p1seconds) && (keypressedp2 == true) && (snap == true))
    lblwinner.Text = "Player 2 is the winner";
   else if ((p1seconds < p2seconds) && (keypressedp1 == true) && (snap == true))
    lblwinner.Text = "Player 1 is the winner";
   else if ((keypressedp1 == false) && (snap == true))
    lblwinner.Text = "Player 2 is the winner";
   else if ((keypressedp2 == false) && (snap == true))
    lblwinner.Text = "Player 1 is the winner";


  }
 }
}
