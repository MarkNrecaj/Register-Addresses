namespace RegistreAddress
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
            this.serverip = new System.Windows.Forms.TextBox();
            this.chatscreen = new System.Windows.Forms.RichTextBox();
            this.messagebox = new System.Windows.Forms.RichTextBox();
            this.startbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Connectbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sendbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // serverip
            // 
            this.serverip.Location = new System.Drawing.Point(448, 37);
            this.serverip.Name = "serverip";
            this.serverip.Size = new System.Drawing.Size(100, 20);
            this.serverip.TabIndex = 0;
            // 
            // chatscreen
            // 
            this.chatscreen.Location = new System.Drawing.Point(12, 12);
            this.chatscreen.Name = "chatscreen";
            this.chatscreen.Size = new System.Drawing.Size(430, 282);
            this.chatscreen.TabIndex = 2;
            this.chatscreen.Text = "";
            // 
            // messagebox
            // 
            this.messagebox.Location = new System.Drawing.Point(12, 327);
            this.messagebox.Name = "messagebox";
            this.messagebox.Size = new System.Drawing.Size(430, 29);
            this.messagebox.TabIndex = 3;
            this.messagebox.Text = "";
            // 
            // startbutton
            // 
            this.startbutton.Active = false;
            this.startbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.startbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.startbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startbutton.BorderRadius = 0;
            this.startbutton.ButtonText = "              Fillo";
            this.startbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startbutton.DisabledColor = System.Drawing.Color.Gray;
            this.startbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.startbutton.Iconimage = null;
            this.startbutton.Iconimage_right = null;
            this.startbutton.Iconimage_right_Selected = null;
            this.startbutton.Iconimage_Selected = null;
            this.startbutton.IconMarginLeft = 0;
            this.startbutton.IconMarginRight = 0;
            this.startbutton.IconRightVisible = true;
            this.startbutton.IconRightZoom = 0D;
            this.startbutton.IconVisible = true;
            this.startbutton.IconZoom = 90D;
            this.startbutton.IsTab = false;
            this.startbutton.Location = new System.Drawing.Point(448, 63);
            this.startbutton.Name = "startbutton";
            this.startbutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.startbutton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.startbutton.OnHoverTextColor = System.Drawing.Color.White;
            this.startbutton.selected = false;
            this.startbutton.Size = new System.Drawing.Size(116, 32);
            this.startbutton.TabIndex = 14;
            this.startbutton.Text = "              Fillo";
            this.startbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startbutton.Textcolor = System.Drawing.Color.White;
            this.startbutton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click_1);
            // 
            // Connectbutton
            // 
            this.Connectbutton.Active = false;
            this.Connectbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Connectbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Connectbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Connectbutton.BorderRadius = 0;
            this.Connectbutton.ButtonText = "              Lidhu";
            this.Connectbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Connectbutton.DisabledColor = System.Drawing.Color.Gray;
            this.Connectbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.Connectbutton.Iconimage = null;
            this.Connectbutton.Iconimage_right = null;
            this.Connectbutton.Iconimage_right_Selected = null;
            this.Connectbutton.Iconimage_Selected = null;
            this.Connectbutton.IconMarginLeft = 0;
            this.Connectbutton.IconMarginRight = 0;
            this.Connectbutton.IconRightVisible = true;
            this.Connectbutton.IconRightZoom = 0D;
            this.Connectbutton.IconVisible = true;
            this.Connectbutton.IconZoom = 90D;
            this.Connectbutton.IsTab = false;
            this.Connectbutton.Location = new System.Drawing.Point(448, 101);
            this.Connectbutton.Name = "Connectbutton";
            this.Connectbutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Connectbutton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Connectbutton.OnHoverTextColor = System.Drawing.Color.White;
            this.Connectbutton.selected = false;
            this.Connectbutton.Size = new System.Drawing.Size(116, 32);
            this.Connectbutton.TabIndex = 15;
            this.Connectbutton.Text = "              Lidhu";
            this.Connectbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Connectbutton.Textcolor = System.Drawing.Color.White;
            this.Connectbutton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connectbutton.Click += new System.EventHandler(this.Connectbutton_Click_1);
            // 
            // sendbutton
            // 
            this.sendbutton.Active = false;
            this.sendbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.sendbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.sendbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendbutton.BorderRadius = 0;
            this.sendbutton.ButtonText = "            Dergo";
            this.sendbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendbutton.DisabledColor = System.Drawing.Color.Gray;
            this.sendbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.sendbutton.Iconimage = null;
            this.sendbutton.Iconimage_right = null;
            this.sendbutton.Iconimage_right_Selected = null;
            this.sendbutton.Iconimage_Selected = null;
            this.sendbutton.IconMarginLeft = 0;
            this.sendbutton.IconMarginRight = 0;
            this.sendbutton.IconRightVisible = true;
            this.sendbutton.IconRightZoom = 0D;
            this.sendbutton.IconVisible = true;
            this.sendbutton.IconZoom = 90D;
            this.sendbutton.IsTab = false;
            this.sendbutton.Location = new System.Drawing.Point(462, 324);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.sendbutton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.sendbutton.OnHoverTextColor = System.Drawing.Color.White;
            this.sendbutton.selected = false;
            this.sendbutton.Size = new System.Drawing.Size(116, 32);
            this.sendbutton.TabIndex = 16;
            this.sendbutton.Text = "            Dergo";
            this.sendbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sendbutton.Textcolor = System.Drawing.Color.White;
            this.sendbutton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendbutton.Click += new System.EventHandler(this.sendbutton_Click_1);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork_1);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendbutton);
            this.Controls.Add(this.Connectbutton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.messagebox);
            this.Controls.Add(this.chatscreen);
            this.Controls.Add(this.serverip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverip;
        private System.Windows.Forms.RichTextBox chatscreen;
        private System.Windows.Forms.RichTextBox messagebox;
        private Bunifu.Framework.UI.BunifuFlatButton startbutton;
        private Bunifu.Framework.UI.BunifuFlatButton Connectbutton;
        private Bunifu.Framework.UI.BunifuFlatButton sendbutton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}