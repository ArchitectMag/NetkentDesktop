namespace NetkentToDo
{
    partial class Form1
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
            this.TxtToDo.Location = new System.Drawing.Point(55, 6);
            this.TxtToDo.Name = "TxtToDo";
            this.TxtToDo.Size = new System.Drawing.Size(639, 20);
            this.TxtToDo.TabIndex = 0;
            // 
            // BtnAddToDo
            // 
            this.BtnAddToDo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddToDo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAddToDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddToDo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAddToDo.Location = new System.Drawing.Point(700, 6);
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
            this.LblToDo.Location = new System.Drawing.Point(12, 9);
            this.LblToDo.Name = "LblToDo";
            this.LblToDo.Size = new System.Drawing.Size(37, 13);
            this.LblToDo.TabIndex = 2;
            this.LblToDo.Text = "To-Do";
            // 
            // LbToDoList
            // 
            this.LbToDoList.FormattingEnabled = true;
            this.LbToDoList.Location = new System.Drawing.Point(55, 49);
            this.LbToDoList.Name = "LbToDoList";
            this.LbToDoList.Size = new System.Drawing.Size(202, 368);
            this.LbToDoList.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbToDoList);
            this.Controls.Add(this.LblToDo);
            this.Controls.Add(this.BtnAddToDo);
            this.Controls.Add(this.TxtToDo);
            this.Name = "Form1";
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

