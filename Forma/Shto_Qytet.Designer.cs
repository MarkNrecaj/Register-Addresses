namespace RegistreAddress
{
    partial class Shto_Qytet
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.qyteti_textbox = new System.Windows.Forms.TextBox();
            this.zip_textbox = new System.Windows.Forms.TextBox();
            this.button1_B = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emri i qytetit:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kodi Postar:";
            // 
            // qyteti_textbox
            // 
            this.qyteti_textbox.Location = new System.Drawing.Point(332, 88);
            this.qyteti_textbox.Name = "qyteti_textbox";
            this.qyteti_textbox.Size = new System.Drawing.Size(128, 20);
            this.qyteti_textbox.TabIndex = 3;
            // 
            // zip_textbox
            // 
            this.zip_textbox.Location = new System.Drawing.Point(332, 121);
            this.zip_textbox.Name = "zip_textbox";
            this.zip_textbox.Size = new System.Drawing.Size(128, 20);
            this.zip_textbox.TabIndex = 4;
            // 
            // button1_B
            // 
            this.button1_B.Active = false;
            this.button1_B.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.button1_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.button1_B.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1_B.BorderRadius = 0;
            this.button1_B.ButtonText = "               Krijo";
            this.button1_B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1_B.DisabledColor = System.Drawing.Color.Gray;
            this.button1_B.Iconcolor = System.Drawing.Color.Transparent;
            this.button1_B.Iconimage = null;
            this.button1_B.Iconimage_right = null;
            this.button1_B.Iconimage_right_Selected = null;
            this.button1_B.Iconimage_Selected = null;
            this.button1_B.IconMarginLeft = 0;
            this.button1_B.IconMarginRight = 0;
            this.button1_B.IconRightVisible = true;
            this.button1_B.IconRightZoom = 0D;
            this.button1_B.IconVisible = true;
            this.button1_B.IconZoom = 90D;
            this.button1_B.IsTab = false;
            this.button1_B.Location = new System.Drawing.Point(303, 164);
            this.button1_B.Name = "button1_B";
            this.button1_B.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.button1_B.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.button1_B.OnHoverTextColor = System.Drawing.Color.White;
            this.button1_B.selected = false;
            this.button1_B.Size = new System.Drawing.Size(125, 37);
            this.button1_B.TabIndex = 20;
            this.button1_B.Text = "               Krijo";
            this.button1_B.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1_B.Textcolor = System.Drawing.Color.White;
            this.button1_B.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_B.Click += new System.EventHandler(this.button1_B_Click);
            // 
            // Shto_Qytet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.button1_B);
            this.Controls.Add(this.zip_textbox);
            this.Controls.Add(this.qyteti_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Shto_Qytet";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qyteti_textbox;
        private System.Windows.Forms.TextBox zip_textbox;
        private Bunifu.Framework.UI.BunifuFlatButton button1_B;
    }
}