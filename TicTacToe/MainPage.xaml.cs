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
                button.BackgroundColor = Color.Green;
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
                button.BackgroundColor = Color.Orange;
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
                this.b1.IsEnabled = false;
                this.b2.IsEnabled = false;
                this.b3.IsEnabled = false;
                this.b4.IsEnabled = false;
                this.b5.IsEnabled = false;
                this.b6.IsEnabled = false;
                this.b7.IsEnabled = false;
                this.b8.IsEnabled = false;
                this.b9.IsEnabled = false;
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
                this.b1.IsEnabled = false;
                this.b2.IsEnabled = false;
                this.b3.IsEnabled = false;
                this.b4.IsEnabled = false;
                this.b5.IsEnabled = false;
                this.b6.IsEnabled = false;
                this.b7.IsEnabled = false;
                this.b8.IsEnabled = false;
                this.b9.IsEnabled = false;
            }

        }



        void OnClear(object sender, EventArgs e)
        {
            this.b1.IsEnabled = true;
            this.b2.IsEnabled = true;
            this.b3.IsEnabled = true;
            this.b4.IsEnabled = true;
            this.b5.IsEnabled = true;
            this.b6.IsEnabled = true;
            this.b7.IsEnabled = true;
            this.b8.IsEnabled = true;
            this.b9.IsEnabled = true;

            this.b1.Text = "-";
            this.b2.Text = "-";
            this.b3.Text = "-";
            this.b4.Text = "-";
            this.b5.Text = "-";
            this.b6.Text = "-";
            this.b7.Text = "-";
            this.b8.Text = "-";  
            this.b9.Text = "-";

            this.b1.BackgroundColor = Color.Gray;
            this.b2.BackgroundColor = Color.Gray;
            this.b3.BackgroundColor = Color.Gray;
            this.b4.BackgroundColor = Color.Gray;
            this.b5.BackgroundColor = Color.Gray;
            this.b6.BackgroundColor = Color.Gray;
            this.b7.BackgroundColor = Color.Gray;
            this.b8.BackgroundColor = Color.Gray;
            this.b9.BackgroundColor = Color.Gray;



            currentState = 1;
            this.OText.Text = "O Player Wait";
            this.XText.Text = "X Player Turn";

            x.Clear();
            o.Clear();
        }
    }


}
;