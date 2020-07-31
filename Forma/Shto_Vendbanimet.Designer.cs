namespace RegistreAddress
{
    partial class Shto_Vendbanimet
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
            this.emri_label = new System.Windows.Forms.Label();
            this.emri_textbox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vendbanim_button_B = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // emri_label
            // 
            this.emri_label.AutoSize = true;
            this.emri_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emri_label.Location = new System.Drawing.Point(223, 136);
            this.emri_label.Name = "emri_label";
            this.emri_label.Size = new System.Drawing.Size(114, 15);
            this.emri_label.TabIndex = 11;
            this.emri_label.Text = "Emri i Vendbanimit:";
            // 
            // emri_textbox
            // 
            this.emri_textbox.Location = new System.Drawing.Point(359, 131);
            this.emri_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emri_textbox.Name = "emri_textbox";
            this.emri_textbox.Size = new System.Drawing.Size(121, 20);
            this.emri_textbox.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(359, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Zgjedh Qytetin:";
            // 
            // vendbanim_button_B
            // 
            this.vendbanim_button_B.Active = false;
            this.vendbanim_button_B.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.vendbanim_button_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.vendbanim_button_B.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vendbanim_button_B.BorderRadius = 0;
            this.vendbanim_button_B.ButtonText = "               Krijo";
            this.vendbanim_button_B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vendbanim_button_B.DisabledColor = System.Drawing.Color.Gray;
            this.vendbanim_button_B.Iconcolor = System.Drawing.Color.Transparent;
            this.vendbanim_button_B.Iconimage = null;
            this.vendbanim_button_B.Iconimage_right = null;
            this.vendbanim_button_B.Iconimage_right_Selected = null;
            this.vendbanim_button_B.Iconimage_Selected = null;
            this.vendbanim_button_B.IconMarginLeft = 0;
            this.vendbanim_button_B.IconMarginRight = 0;
            this.vendbanim_button_B.IconRightVisible = true;
            this.vendbanim_button_B.IconRightZoom = 0D;
            this.vendbanim_button_B.IconVisible = true;
            this.vendbanim_button_B.IconZoom = 90D;
            this.vendbanim_button_B.IsTab = false;
            this.vendbanim_button_B.Location = new System.Drawing.Point(310, 174);
            this.vendbanim_button_B.Name = "vendbanim_button_B";
            this.vendbanim_button_B.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.vendbanim_button_B.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.vendbanim_button_B.OnHoverTextColor = System.Drawing.Color.White;
            this.vendbanim_button_B.selected = false;
            this.vendbanim_button_B.Size = new System.Drawing.Size(125, 37);
            this.vendbanim_button_B.TabIndex = 22;
            this.vendbanim_button_B.Text = "               Krijo";
            this.vendbanim_button_B.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vendbanim_button_B.Textcolor = System.Drawing.Color.White;
            this.vendbanim_button_B.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendbanim_button_B.Click += new System.EventHandler(this.vendbanim_button_B_Click);
            // 
            // Shto_Vendbanimet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vendbanim_button_B);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.emri_textbox);
            this.Controls.Add(this.emri_label);
            this.Name = "Shto_Vendbanimet";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Shto_Vendbanimet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label emri_label;
        private System.Windows.Forms.TextBox emri_textbox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton vendbanim_button_B;
    }
}