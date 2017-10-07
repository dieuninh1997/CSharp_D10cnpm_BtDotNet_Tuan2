namespace D10cnpm_Bai2_DotNet
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
            this.components = new System.ComponentModel.Container();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.lbShow = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cmbAuto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.Color.DarkGray;
            this.txtName.Location = new System.Drawing.Point(78, 57);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(481, 29);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Ninh xinh gái";
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtText
            // 
            this.txtText.ForeColor = System.Drawing.Color.DarkGray;
            this.txtText.Location = new System.Drawing.Point(78, 109);
            this.txtText.Margin = new System.Windows.Forms.Padding(5);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(481, 29);
            this.txtText.TabIndex = 1;
            this.txtText.Text = "Enter your text";
            this.txtText.Enter += new System.EventHandler(this.txtText_Enter);
            this.txtText.Leave += new System.EventHandler(this.txtText_Leave);
            // 
            // lbShow
            // 
            this.lbShow.AutoSize = true;
            this.lbShow.ForeColor = System.Drawing.Color.Red;
            this.lbShow.Location = new System.Drawing.Point(12, 278);
            this.lbShow.Name = "lbShow";
            this.lbShow.Size = new System.Drawing.Size(92, 24);
            this.lbShow.TabIndex = 2;
            this.lbShow.Text = "Show text";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cmbAuto
            // 
            this.cmbAuto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAuto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAuto.FormattingEnabled = true;
            this.cmbAuto.Items.AddRange(new object[] {
            "Alo",
            "Bãi shit",
            "Cờ hó",
            "Diệu Ninh đáng iu",
            "Em gái mưa",
            "Ninh xinh gái",
            "Hello world",
            "Vui nhể",
            "Ăn cứt chó ná",
            "Ngu thì chết",
            "miss you so much"});
            this.cmbAuto.Location = new System.Drawing.Point(172, 176);
            this.cmbAuto.Name = "cmbAuto";
            this.cmbAuto.Size = new System.Drawing.Size(387, 32);
            this.cmbAuto.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(74, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAuto);
            this.Controls.Add(this.lbShow);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Demo textbox with placeholder ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label lbShow;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ComboBox cmbAuto;
        private System.Windows.Forms.Label label1;
    }
}

