using System;
using System.Windows.Forms;

namespace NetkentToDo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAddToDo_Click(object sender, EventArgs e)
        {
            //ctrl + K + C yorum satırı yap
            //ctrl + K + U yorum satırını geri al

            //yazı birden fazla yerde kullanılacaksa bu yöntem

            //string toDoText = TxtToDo.Text;
            //LbToDoList.Items.Add(toDoText);

            LbToDoList.Items.Add(TxtToDo.Text);
            TxtToDo.Text = "";
            // yazı yazı yazı...
        }
    }
}
