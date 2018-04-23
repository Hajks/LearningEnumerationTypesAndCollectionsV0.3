using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningEnumerationTypesAndCollectionsV0._3
{

    public partial class Form1 : Form
    {
        public string x = "";
        Card[] cards =
        {
            new Card(Suits.Spades, Values.Ace),
            new Card(Suits.Spades, Values.Two),
            new Card(Suits.Spades, Values.Three),
            new Card(Suits.Spades, Values.Four),
            new Card(Suits.Spades, Values.Five),
            new Card(Suits.Spades, Values.Six),
            new Card(Suits.Spades, Values.Seven),
            new Card(Suits.Spades, Values.Eight),
            new Card(Suits.Spades, Values.Nine),
            new Card(Suits.Spades, Values.Ten),
            new Card(Suits.Spades, Values.Jack),
            new Card(Suits.Spades, Values.Queen),
            new Card(Suits.Spades, Values.King),

            new Card(Suits.Clubs, Values.Ace),
            new Card(Suits.Clubs, Values.Two),
            new Card(Suits.Clubs, Values.Three),
            new Card(Suits.Clubs, Values.Four),
            new Card(Suits.Clubs, Values.Five),
            new Card(Suits.Clubs, Values.Six),
            new Card(Suits.Clubs, Values.Seven),
            new Card(Suits.Clubs, Values.Eight),
            new Card(Suits.Clubs, Values.Nine),
            new Card(Suits.Clubs, Values.Ten),
            new Card(Suits.Clubs, Values.Jack),
            new Card(Suits.Clubs, Values.Queen),
            new Card(Suits.Clubs, Values.King),

            new Card(Suits.Diamonds, Values.Ace),
            new Card(Suits.Diamonds, Values.Two),
            new Card(Suits.Diamonds, Values.Three),
            new Card(Suits.Diamonds, Values.Four),
            new Card(Suits.Diamonds, Values.Five),
            new Card(Suits.Diamonds, Values.Six),
            new Card(Suits.Diamonds, Values.Seven),
            new Card(Suits.Diamonds, Values.Eight),
            new Card(Suits.Diamonds, Values.Nine),
            new Card(Suits.Diamonds, Values.Ten),
            new Card(Suits.Diamonds, Values.Jack),
            new Card(Suits.Diamonds, Values.Queen),
            new Card(Suits.Diamonds, Values.King),

            new Card(Suits.Hearts, Values.Ace),
            new Card(Suits.Hearts, Values.Two),
            new Card(Suits.Hearts, Values.Three),
            new Card(Suits.Hearts, Values.Four),
            new Card(Suits.Hearts, Values.Five),
            new Card(Suits.Hearts, Values.Six),
            new Card(Suits.Hearts, Values.Seven),
            new Card(Suits.Hearts, Values.Eight),
            new Card(Suits.Hearts, Values.Nine),
            new Card(Suits.Hearts, Values.Ten),
            new Card(Suits.Hearts, Values.Jack),
            new Card(Suits.Hearts, Values.Queen),
            new Card(Suits.Hearts, Values.King),
 
    };
        public Form1()
        {
            InitializeComponent();
            }

        private void button1_Click(object sender, EventArgs e)
        {
         
            for (int i = 0; i < cards.Length; i++)
            {
                x += cards[i].Name + "\r\n";
                var strings = new List<string>() { "King of Spades", "King of Clubs", "King of Diamonds", "King of Hearts" }; //well this app should be in console, so i had to change few things. "var" is new to me. Just wanted to sort my messagebox.
                if (strings.Contains(cards[i].Name))
                    x += "\r\n";
                

            }
            MessageBox.Show(x);
        }
    }
}
