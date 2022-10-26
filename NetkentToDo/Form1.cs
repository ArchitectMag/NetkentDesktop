using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace NetkentToDo
{

    public partial class FrmMain : Form
    {
        private int lblCounter = 0;
        private int hight = 50;

        //Dependency Injection

        public FrmMain()
        {
            InitializeComponent();
            SetDesktopLocation(1,2);
        }

        public void BtnAddToDo_Click(object sender, EventArgs e)
        {
            //_lblCounter  = _lblCounter + 1;
            lblCounter++;
            //_hight = _hight + 30;
            hight += 30;
            AddToDoOtherChoose(TxtToDo.Text);
        }

        private bool AddToDoOtherChoose(string todoText)
        {
            if (!string.IsNullOrEmpty(todoText))
            {
                Label lblToDo = new Label();
                lblToDo.Name = "LblToDoText" + lblCounter;
                lblToDo.Text = TxtToDo.Text;

                lblToDo.Location = new Point
                {
                    X = 50,
                    Y = hight
                };


                Button btnDone = new Button();
                btnDone.Text = "Yapıldı";
                btnDone.Name = "BtnToDo" + lblCounter;

                btnDone.Location = new Point
                {
                    X = 350,
                    Y = hight
                };

                Control[] myController = new Control[]
                {
                    lblToDo,btnDone
                };

                this.Controls.AddRange(myController);


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
