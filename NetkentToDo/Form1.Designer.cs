namespace NetkentToDo
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtToDo = new System.Windows.Forms.TextBox();
            this.BtnAddToDo = new System.Windows.Forms.Button();
            this.LblToDo = new System.Windows.Forms.Label();
            this.LbToDoList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TxtToDo
            // 
            this.TxtToDo.Location = new System.Drawing.Point(71, 4);
            this.TxtToDo.Name = "TxtToDo";
            this.TxtToDo.Size = new System.Drawing.Size(1255, 20);
            this.TxtToDo.TabIndex = 0;
            // 
            // BtnAddToDo
            // 
            this.BtnAddToDo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddToDo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAddToDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddToDo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAddToDo.Location = new System.Drawing.Point(1332, 4);
            this.BtnAddToDo.Name = "BtnAddToDo";
            this.BtnAddToDo.Size = new System.Drawing.Size(75, 23);
            this.BtnAddToDo.TabIndex = 1;
            this.BtnAddToDo.Text = "Ekle";
            this.BtnAddToDo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAddToDo.UseVisualStyleBackColor = false;
            this.BtnAddToDo.Click += new System.EventHandler(this.BtnAddToDo_Click);
            // 
            // LblToDo
            // 
            this.LblToDo.AutoSize = true;
            this.LblToDo.Location = new System.Drawing.Point(28, 9);
            this.LblToDo.Name = "LblToDo";
            this.LblToDo.Size = new System.Drawing.Size(37, 13);
            this.LblToDo.TabIndex = 2;
            this.LblToDo.Text = "To-Do";
            // 
            // LbToDoList
            // 
            this.LbToDoList.FormattingEnabled = true;
            this.LbToDoList.Location = new System.Drawing.Point(12, 605);
            this.LbToDoList.Name = "LbToDoList";
            this.LbToDoList.Size = new System.Drawing.Size(202, 30);
            this.LbToDoList.TabIndex = 3;
            this.LbToDoList.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 661);
            this.Controls.Add(this.LbToDoList);
            this.Controls.Add(this.LblToDo);
            this.Controls.Add(this.BtnAddToDo);
            this.Controls.Add(this.TxtToDo);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtToDo;
        private System.Windows.Forms.Button BtnAddToDo;
        private System.Windows.Forms.Label LblToDo;
        private System.Windows.Forms.ListBox LbToDoList;
    }
}

