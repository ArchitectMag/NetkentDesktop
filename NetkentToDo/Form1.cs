using System;
using System.Drawing;
using System.Windows.Forms;

namespace NetkentToDo
{
    public partial class FrmMain : Form
    {
        int lblCounter = 0;
        int hight = 50;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnAddToDo_Click(object sender, EventArgs e)
        {
            lblCounter = lblCounter + 1;
            AddToDoOtherChoose(TxtToDo.Text);
        }

        private bool AddToDoOtherChoose(string todoText)
        {
            if (!string.IsNullOrEmpty(todoText))
            {
                Label todoLabel = new Label();
                todoLabel.Name = "LblToDoText" + lblCounter;
                todoLabel.Text = "LblToDoText" + lblCounter;
                hight = hight + hight;
                todoLabel.Location = new Point
                {
                    X = 150,
                    Y = hight
                };

                PnlToDoList.Controls.Add(todoLabel);

                TxtToDo.Text = "";
                return true;
            }

            MessageBox.Show("Arkadaş boş yapma...");
            return false;
        }

        #region Calisma
        private bool AddToDoOtherChoosee(string todoText)
        {
            if (!string.IsNullOrEmpty(todoText))
            {
                LbToDoList.Items.Add(todoText);
                TxtToDo.Text = "";
                return true;
            }

            MessageBox.Show("Arkadaş boş yapma...");
            return false;
        }

        //Kontrol yükümlülüğünü üstünden atıyor.
        private void AddToDoOtherChooseExceptional(string todoText)
        {
            try
            {
                LbToDoList.Items.Add(todoText);
                TxtToDo.Text = "";
            }
            catch (Exception e)
            {
                MessageBox.Show("Arkadaş boş yapma..." + e.Message);
            }
        }

        private bool AddToDo(string todoText)
        {
            if (string.IsNullOrEmpty(todoText))
            {
                MessageBox.Show("Arkadaş boş yapma...");
                return false;
            }
            else
            {
                LbToDoList.Items.Add(todoText);
                TxtToDo.Text = "";
                return true;
            }
        }
        #endregion
    }
}
