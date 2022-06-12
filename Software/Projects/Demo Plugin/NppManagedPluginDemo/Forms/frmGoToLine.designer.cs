namespace Kbg.Demo.Namespace
{
	partial class frmGoToLine
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
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.buttonNewId = new System.Windows.Forms.Button();
            this.buttonLastId = new System.Windows.Forms.Button();
            this.labelMain = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownIdLength = new System.Windows.Forms.NumericUpDown();
            this.labelIdLength = new System.Windows.Forms.Label();
            this.checkBoxSpaceBefore = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdLength)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(12, 64);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(33, 17);
            this.radioButtonA.TabIndex = 15;
            this.radioButtonA.Text = "id";
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(12, 79);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(45, 17);
            this.radioButtonB.TabIndex = 16;
            this.radioButtonB.Text = "<id>";
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Checked = true;
            this.radioButtonC.Location = new System.Drawing.Point(12, 94);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(48, 17);
            this.radioButtonC.TabIndex = 17;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "<id>,";
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Location = new System.Drawing.Point(12, 109);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(59, 17);
            this.radioButtonD.TabIndex = 18;
            this.radioButtonD.Text = "<id>,\\n";
            this.radioButtonD.UseVisualStyleBackColor = true;
            // 
            // buttonNewId
            // 
            this.buttonNewId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewId.Location = new System.Drawing.Point(12, 241);
            this.buttonNewId.Name = "buttonNewId";
            this.buttonNewId.Size = new System.Drawing.Size(270, 23);
            this.buttonNewId.TabIndex = 9;
            this.buttonNewId.Text = "New ID";
            this.buttonNewId.UseVisualStyleBackColor = true;
            this.buttonNewId.Click += new System.EventHandler(this.buttonNewId_Click);
            // 
            // buttonLastId
            // 
            this.buttonLastId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLastId.Enabled = false;
            this.buttonLastId.Location = new System.Drawing.Point(12, 270);
            this.buttonLastId.Name = "buttonLastId";
            this.buttonLastId.Size = new System.Drawing.Size(270, 23);
            this.buttonLastId.TabIndex = 10;
            this.buttonLastId.Text = "Last ID";
            this.buttonLastId.UseVisualStyleBackColor = true;
            this.buttonLastId.Click += new System.EventHandler(this.buttonLastId_Click);
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Location = new System.Drawing.Point(9, 9);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(63, 13);
            this.labelMain.TabIndex = 19;
            this.labelMain.Text = "XXXXXXXX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Id style:";
            // 
            // numericUpDownIdLength
            // 
            this.numericUpDownIdLength.Location = new System.Drawing.Point(11, 198);
            this.numericUpDownIdLength.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDownIdLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIdLength.Name = "numericUpDownIdLength";
            this.numericUpDownIdLength.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownIdLength.TabIndex = 21;
            this.numericUpDownIdLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownIdLength.ValueChanged += new System.EventHandler(this.numericUpDownIdLength_ValueChanged);
            // 
            // labelIdLength
            // 
            this.labelIdLength.AutoSize = true;
            this.labelIdLength.Location = new System.Drawing.Point(9, 180);
            this.labelIdLength.Name = "labelIdLength";
            this.labelIdLength.Size = new System.Drawing.Size(51, 13);
            this.labelIdLength.TabIndex = 22;
            this.labelIdLength.Text = "Id length:";
            // 
            // checkBoxSpaceBefore
            // 
            this.checkBoxSpaceBefore.AutoSize = true;
            this.checkBoxSpaceBefore.Location = new System.Drawing.Point(12, 127);
            this.checkBoxSpaceBefore.Name = "checkBoxSpaceBefore";
            this.checkBoxSpaceBefore.Size = new System.Drawing.Size(88, 17);
            this.checkBoxSpaceBefore.TabIndex = 23;
            this.checkBoxSpaceBefore.Text = "space before";
            this.checkBoxSpaceBefore.UseVisualStyleBackColor = true;
            // 
            // frmGoToLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 427);
            this.Controls.Add(this.checkBoxSpaceBefore);
            this.Controls.Add(this.labelIdLength);
            this.Controls.Add(this.numericUpDownIdLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.radioButtonD);
            this.Controls.Add(this.radioButtonC);
            this.Controls.Add(this.radioButtonB);
            this.Controls.Add(this.radioButtonA);
            this.Controls.Add(this.buttonLastId);
            this.Controls.Add(this.buttonNewId);
            this.Name = "frmGoToLine";
            this.Text = "NppDockableForm";
            this.VisibleChanged += new System.EventHandler(this.FrmGoToLineVisibleChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGoToLine_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.Button buttonNewId;
        private System.Windows.Forms.Button buttonLastId;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownIdLength;
        private System.Windows.Forms.Label labelIdLength;
        private System.Windows.Forms.CheckBox checkBoxSpaceBefore;
    }
}