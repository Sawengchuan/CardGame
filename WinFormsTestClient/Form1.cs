using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardLib;
using PokerEngine;

namespace WinFormsTestClient
{
    public partial class Form1 : Form
    {
        List<Card> cards = new List<Card>();
        List<string> selectedCards = new List<string>();
        RankingEvaluator evaluator = new RankingEvaluator();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lbSelected.Items.Clear();
            selectedCards = new List<string>();
            lblResult.Text = "Result";
            lblSelectedText.Text = "selected";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(lbSuit.SelectedItem?.ToString().Length > 0 && lbRank.SelectedItem?.ToString().Length > 0)
            {
                var selected = lbSuit.SelectedItem?.ToString() + " - " + lbRank.SelectedItem?.ToString();
                lbSelected.Items.Add(selected);

                var selectedString = lbRank.SelectedItem?.ToString() + lbSuit.SelectedItem?.ToString().Substring(0,1).ToLower();
                selectedCards.Add(selectedString);

                UpdateSelectedText();
            }
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            if(selectedCards.Count == 5)
            {
                lblResult.Text = "";

                var cards = ConvertToCard(selectedCards);
                var result = evaluator.Evaluate(cards);

                lblResult.Text = result;
            }
            else
            {
                lblResult.Text = "select 5 cards";
            }
        }

        List<Card> ConvertToCard (List<string> selected)
        {
            List<Card> cards = new List<Card>();

            foreach(var s in selected)
            {
                var suit = s.Substring(s.Length - 1);
                var rank = s.Substring(0, s.Length - 1);

                CardSuit cardSuit = CardSuit.Spade;
                Card card = null;

                if (suit == "h") cardSuit = CardSuit.Heart;
                if (suit == "d") cardSuit = CardSuit.Diamond;
                if (suit == "c") cardSuit = CardSuit.Club;
                if (suit == "s") cardSuit = CardSuit.Spade;

                if (rank == "A") card = new A(cardSuit);
                if (rank == "2") card = new _2(cardSuit);
                if (rank == "3") card = new _3(cardSuit);
                if (rank == "4") card = new _4(cardSuit);
                if (rank == "5") card = new _5(cardSuit);
                if (rank == "6") card = new _6(cardSuit);
                if (rank == "7") card = new _7(cardSuit);
                if (rank == "8") card = new _8(cardSuit);
                if (rank == "9") card = new _9(cardSuit);
                if (rank == "10") card = new _10(cardSuit);
                if (rank == "J") card = new J(cardSuit);
                if (rank == "Q") card = new Q(cardSuit);
                if (rank == "K") card = new K(cardSuit);

                cards.Add(card);
            }

            return cards;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbSelected.SelectedItem != null)
            {
                var itemText = lbSelected.SelectedItem.ToString();

                string suit;
                string rank;

                var arr = itemText.Split("-", StringSplitOptions.None);

                rank = arr[1].Trim();
                suit = arr[0].Trim().ToLower().Substring(0, 1);


                selectedCards.Remove(rank + suit);

                lbSelected.Items.Remove(lbSelected.SelectedItem);

                UpdateSelectedText();

            }
        }

        private void UpdateSelectedText()
        {
            lblSelectedText.Text = "{" + string.Join(",", selectedCards.Select(s => "\"" + s + "\"").ToArray()) + "}";
        }
    }
}
