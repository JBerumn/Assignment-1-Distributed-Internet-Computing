using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1_DIC_
{
    public partial class Form1 : Form
    {
        List<int> storeItems = new List<int>();
        List<string> myInventory = new List<string>();


        public Form1()
        {
            InitializeComponent();
            storeItems.Add(5);
            storeItems.Add(5);
            storeItems.Add(5);



        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            itemList.Visible = true;
            shirt.Visible = true;
            shoes.Visible = true;
            hat.Visible = true;
            closeButton.Visible = true;

            shirtCounter.Visible = true;
            shoeCounter.Visible = true;
            hatCounter.Visible = true;

            shirtRemove.Visible = false;
            shoesRemove.Visible = false;
            hatRemove.Visible = false;



        }
        private void returnButton_Click(object sender, EventArgs e)
        {
           
            shirt.Visible = false;
            shoes.Visible = false;
            hat.Visible = false;

            shirtCounter.Visible = true;
            shoeCounter.Visible = true;
            hatCounter.Visible = true;
            closeButton.Visible = true;


            shirtRemove.Visible = true;
            shoesRemove.Visible = true;
            hatRemove.Visible = true;
        } 
        private void inventoryButton_Click(object sender, EventArgs e)
        {
            

            MessageBox.Show("Our Inventory: \nShirt:" + Myshirts + "\nShoes:" + Myshoe + "\nHats:" + Myhats + "\nTotal Price: " + (shirts * 2.00) + (shoe * 6) + (hats * 2.00));


        }  
        void reportButton_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Your Inventory: \nShirt:" + Myshirts + "\nShoes:" + Myshoe + "\nHats:" + Myhats+"\nTotal Price: "+(Myshirts*2.00)+(Myshoe*6)+(Myhats*2.00));




        }
        

        private float shirts = 5;
        private float shoe = 5;
        private float hats = 5;

        private float Myshirts = 0;
        private float Myshoe = 0;
        private float Myhats = 0;

       

        public void shirt_Click(object sender, EventArgs e)
        {
            if (shirts <= 0)
            {
                MessageBox.Show("We're out of this item");
                shirts++;
            }
            shirts--;
            Myshirts++;
            shirtCounter.Text = shirts.ToString();
        }

        public void shoes_Click(object sender, EventArgs e)
        {
            if (shoe <= 0)
            {
                MessageBox.Show("We're out of this item");
                shoe++;
            }
            shoe--;
            Myshoe++;
            shoeCounter.Text = shoe.ToString();
        }

        public void hat_Click(object sender, EventArgs e)
        {
            if (hats <= 0)
            {
                MessageBox.Show("We're out of this item");
                hats++;
            }
            hats--;
            Myhats++;
            hatCounter.Text = hats.ToString();
        }

        private void itemList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void shirtRemove_Click(object sender, EventArgs e)
        {
            if(shirts>=5)
            {
                MessageBox.Show("You don't have any to return");
                shirts--;
            }

            shirts++;
            shirtCounter.Text = shirts.ToString();
        }

        private void shoesRemove_Click(object sender, EventArgs e)
        {
            if (shoe >= 5)
            {
                MessageBox.Show("You don't have any to return");
                shoe--;
            }
            shoe++;
            shoeCounter.Text = shoe.ToString();
        }

        private void hatRemove_Click(object sender, EventArgs e)
        {
            if (hats >= 5)
            {
                MessageBox.Show("You don't have any to return");
                hats--;
            }
            hats++;
            hatCounter.Text = hats.ToString();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            itemList.Visible = false;
            shirt.Visible = false;
            shoes.Visible = false;
            hat.Visible = false;

            shirtCounter.Visible = false;
            shoeCounter.Visible = false;
            hatCounter.Visible = false;

            shirtRemove.Visible = false;
            shoesRemove.Visible = false;
            hatRemove.Visible = false;

            closeButton.Visible = false;
        }
    }
}
