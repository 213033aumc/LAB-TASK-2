namespace Unit_Converter
{
    partial class UnitConverter
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
            this.lbltype = new System.Windows.Forms.Label();
            this.cbtype = new System.Windows.Forms.ComboBox();
            this.lblfrom = new System.Windows.Forms.Label();
            this.tbfrom = new System.Windows.Forms.TextBox();
            this.cbfrom = new System.Windows.Forms.ComboBox();
            this.lblto = new System.Windows.Forms.Label();
            this.tbto = new System.Windows.Forms.TextBox();
            this.cbto = new System.Windows.Forms.ComboBox();
            this.btnconvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(447, 33);
            this.lbltype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(62, 13);
            this.lbltype.TabIndex = 0;
            this.lbltype.Text = "Select Unit ";
            // 
            // cbtype
            // 
            this.cbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtype.FormattingEnabled = true;
            this.cbtype.Items.AddRange(new object[] {
            "Length",
            "Temperature",
            "Area",
            "Time"});
            this.cbtype.Location = new System.Drawing.Point(334, 60);
            this.cbtype.Margin = new System.Windows.Forms.Padding(2);
            this.cbtype.Name = "cbtype";
            this.cbtype.Size = new System.Drawing.Size(320, 21);
            this.cbtype.TabIndex = 1;
            this.cbtype.SelectedIndexChanged += new System.EventHandler(this.cbtype_SelectedIndexChanged);
            // 
            // lblfrom
            // 
            this.lblfrom.AutoSize = true;
            this.lblfrom.Location = new System.Drawing.Point(306, 102);
            this.lblfrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(30, 13);
            this.lblfrom.TabIndex = 2;
            this.lblfrom.Text = "From";
            // 
            // tbfrom
            // 
            this.tbfrom.Location = new System.Drawing.Point(308, 118);
            this.tbfrom.Margin = new System.Windows.Forms.Padding(2);
            this.tbfrom.Name = "tbfrom";
            this.tbfrom.Size = new System.Drawing.Size(141, 20);
            this.tbfrom.TabIndex = 3;
            this.tbfrom.TextChanged += new System.EventHandler(this.tbfrom_TextChanged);
            // 
            // cbfrom
            // 
            this.cbfrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfrom.FormattingEnabled = true;
            this.cbfrom.Location = new System.Drawing.Point(308, 142);
            this.cbfrom.Margin = new System.Windows.Forms.Padding(2);
            this.cbfrom.Name = "cbfrom";
            this.cbfrom.Size = new System.Drawing.Size(141, 21);
            this.cbfrom.TabIndex = 4;
            // 
            // lblto
            // 
            this.lblto.AutoSize = true;
            this.lblto.Location = new System.Drawing.Point(538, 102);
            this.lblto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblto.Name = "lblto";
            this.lblto.Size = new System.Drawing.Size(20, 13);
            this.lblto.TabIndex = 5;
            this.lblto.Text = "To";
            // 
            // tbto
            // 
            this.tbto.Enabled = false;
            this.tbto.Location = new System.Drawing.Point(540, 118);
            this.tbto.Margin = new System.Windows.Forms.Padding(2);
            this.tbto.Name = "tbto";
            this.tbto.Size = new System.Drawing.Size(141, 20);
            this.tbto.TabIndex = 6;
            this.tbto.TextChanged += new System.EventHandler(this.tbto_TextChanged);
            // 
            // cbto
            // 
            this.cbto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbto.FormattingEnabled = true;
            this.cbto.Location = new System.Drawing.Point(541, 142);
            this.cbto.Margin = new System.Windows.Forms.Padding(2);
            this.cbto.Name = "cbto";
            this.cbto.Size = new System.Drawing.Size(140, 21);
            this.cbto.TabIndex = 7;
            // 
            // btnconvert
            // 
            this.btnconvert.Location = new System.Drawing.Point(471, 202);
            this.btnconvert.Margin = new System.Windows.Forms.Padding(2);
            this.btnconvert.Name = "btnconvert";
            this.btnconvert.Size = new System.Drawing.Size(56, 19);
            this.btnconvert.TabIndex = 8;
            this.btnconvert.Text = "Convert";
            this.btnconvert.UseVisualStyleBackColor = true;
            this.btnconvert.Click += new System.EventHandler(this.btnconvert_Click);
            // 
            // UnitConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 562);
            this.Controls.Add(this.btnconvert);
            this.Controls.Add(this.cbto);
            this.Controls.Add(this.tbto);
            this.Controls.Add(this.lblto);
            this.Controls.Add(this.cbfrom);
            this.Controls.Add(this.tbfrom);
            this.Controls.Add(this.lblfrom);
            this.Controls.Add(this.cbtype);
            this.Controls.Add(this.lbltype);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UnitConverter";
            this.Text = "Unit Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.ComboBox cbtype;
        private System.Windows.Forms.Label lblfrom;
        private System.Windows.Forms.TextBox tbfrom;
        private System.Windows.Forms.ComboBox cbfrom;
        private System.Windows.Forms.Label lblto;
        private System.Windows.Forms.TextBox tbto;
        private System.Windows.Forms.ComboBox cbto;
        private System.Windows.Forms.Button btnconvert;
    }
}

