using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Delegates_In_Action
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        GetSecretIngredient ingredientMethod = null;
        Suzanne suzanne = new Suzanne();
        Amy amy = new Amy();

        private void getIngedient_Click(object sender, EventArgs e)
        {
            if (ingredientMethod != null)
                Console.WriteLine("I'll add" + ingredientMethod((int)amountIngredient.Value));
            else
                Console.WriteLine("I don't have a secret ingredient");
        }

        private void useSuzannesButton_Click(object sender, EventArgs e)
        {
            ingredientMethod = new GetSecretIngredient(suzanne.MySecretIngredientMethod);
        }

        private void useAmysButton_Click(object sender, EventArgs e)
        {
            ingredientMethod = new GetSecretIngredient(amy.AmysSecretIngredientMethod);
        }
    }
}
