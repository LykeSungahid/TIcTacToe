using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TicTacToe
{
    public partial class MainPage : ContentPage
    {
        
        int currentState = 1;

        List<int> x = new List<int>();
        List<int> o = new List<int>();



        public MainPage()
        {
            InitializeComponent();

        }

        void OnSelectBox(object sender, EventArgs e)
        {


            int num;
            
               
            
            if ( currentState == 1)
            {
                Button button = (Button)sender;
                string pressed = button.Text;
                button.Text = "X";
                button.IsEnabled = false;
                currentState = 2;
                this.OText.Text = "O Player Turn";
                this.XText.Text = "X Player Wait";
                int.TryParse( button.ClassId, out num);
                x.Add(num);
                if (x.Count >= 3)
                {
                    checkGame();
                }


            }
            else
            {
                
                Button button = (Button)sender;
                string pressed = button.Text;
                button.Text = "0";
                button.IsEnabled = false;
                currentState = 1;
                this.OText.Text = "O Player Wait";
                this.XText.Text = "X Player Turn";
                int.TryParse(button.ClassId, out num);
                o.Add(num);
                if (o.Count >= 3)
                {
                    checkGame();
                }
            }
        
        }

        void checkGame()
        {
            if ((x.Contains(1) && x.Contains(2) && x.Contains(3)) ||
                (x.Contains(4) && x.Contains(5) && x.Contains(6)) ||
                (x.Contains(7) && x.Contains(8) && x.Contains(9)) ||
                (x.Contains(1) && x.Contains(4) && x.Contains(7)) ||
                (x.Contains(2) && x.Contains(5) && x.Contains(8)) ||
                (x.Contains(3) && x.Contains(6) && x.Contains(9)) ||
                (x.Contains(1) && x.Contains(5) && x.Contains(9)) ||
                (x.Contains(3) && x.Contains(5) && x.Contains(7)))
            {
                this.XText.Text = "X Player Wins";
                this.OText.Text = "O Player Loses";
            }
            else if ((o.Contains(1) && o.Contains(2) && o.Contains(3)) ||
                (o.Contains(4) && o.Contains(5) && o.Contains(6)) ||
                (o.Contains(7) && o.Contains(8) && o.Contains(9)) ||
                (o.Contains(1) && o.Contains(4) && o.Contains(7)) ||
                (o.Contains(2) && o.Contains(5) && o.Contains(8)) ||
                (o.Contains(3) && o.Contains(6) && o.Contains(9)) ||
                (o.Contains(1) && o.Contains(5) && o.Contains(9)) ||
                (o.Contains(3) && o.Contains(5) && o.Contains(7)))
            {
                this.XText.Text = "X Player Loses";
                this.OText.Text = "O Player Wins";
            }

        }



        void OnClear(object sender, EventArgs e)
        {
            currentState = 1;
            int ctr;

            for(ctr = 0;ctr<10;ctr++)
            {
                

            }

            x.Clear();
            o.Clear();
        }
    }


}
;