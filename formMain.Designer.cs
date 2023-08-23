namespace GeradorDeSenha
{
    partial class formMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonGenerate = new Button();
            checkBoxUpper = new CheckBox();
            checkBoxLower = new CheckBox();
            checkBoxNumeric = new CheckBox();
            checkBoxSpecial = new CheckBox();
            textBoxLength = new TextBox();
            textBoxPassword = new TextBox();
            groupBoxIncludes = new GroupBox();
            buttonCopy = new Button();
            labelLength = new Label();
            statusStrip1 = new StatusStrip();
            StatusLabel = new ToolStripStatusLabel();
            groupBoxIncludes.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(12, 48);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(191, 35);
            buttonGenerate.TabIndex = 0;
            buttonGenerate.Text = "Gerar senha!";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += ButtonGenerate_Click;
            // 
            // checkBoxUpper
            // 
            checkBoxUpper.AutoSize = true;
            checkBoxUpper.Checked = true;
            checkBoxUpper.CheckState = CheckState.Checked;
            checkBoxUpper.Location = new Point(6, 22);
            checkBoxUpper.Name = "checkBoxUpper";
            checkBoxUpper.Size = new Size(85, 19);
            checkBoxUpper.TabIndex = 1;
            checkBoxUpper.Text = "Maiúsculas";
            checkBoxUpper.UseVisualStyleBackColor = true;
            // 
            // checkBoxLower
            // 
            checkBoxLower.AutoSize = true;
            checkBoxLower.Checked = true;
            checkBoxLower.CheckState = CheckState.Checked;
            checkBoxLower.Location = new Point(6, 47);
            checkBoxLower.Name = "checkBoxLower";
            checkBoxLower.Size = new Size(86, 19);
            checkBoxLower.TabIndex = 2;
            checkBoxLower.Text = "Minúsculas";
            checkBoxLower.UseVisualStyleBackColor = true;
            // 
            // checkBoxNumeric
            // 
            checkBoxNumeric.AutoSize = true;
            checkBoxNumeric.Checked = true;
            checkBoxNumeric.CheckState = CheckState.Checked;
            checkBoxNumeric.Location = new Point(117, 22);
            checkBoxNumeric.Name = "checkBoxNumeric";
            checkBoxNumeric.Size = new Size(75, 19);
            checkBoxNumeric.TabIndex = 3;
            checkBoxNumeric.Text = "Números";
            checkBoxNumeric.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpecial
            // 
            checkBoxSpecial.AutoSize = true;
            checkBoxSpecial.Checked = true;
            checkBoxSpecial.CheckState = CheckState.Checked;
            checkBoxSpecial.Location = new Point(117, 47);
            checkBoxSpecial.Name = "checkBoxSpecial";
            checkBoxSpecial.Size = new Size(131, 19);
            checkBoxSpecial.TabIndex = 4;
            checkBoxSpecial.Text = "Caracteres especiais";
            checkBoxSpecial.UseVisualStyleBackColor = true;
            // 
            // textBoxLength
            // 
            textBoxLength.Location = new Point(102, 19);
            textBoxLength.Name = "textBoxLength";
            textBoxLength.Size = new Size(100, 23);
            textBoxLength.TabIndex = 5;
            textBoxLength.Text = "32";
            textBoxLength.KeyPress += TextBoxLength_KeyPress;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(12, 89);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.ReadOnly = true;
            textBoxPassword.Size = new Size(369, 23);
            textBoxPassword.TabIndex = 6;
            // 
            // groupBoxIncludes
            // 
            groupBoxIncludes.Controls.Add(checkBoxUpper);
            groupBoxIncludes.Controls.Add(checkBoxLower);
            groupBoxIncludes.Controls.Add(checkBoxNumeric);
            groupBoxIncludes.Controls.Add(checkBoxSpecial);
            groupBoxIncludes.Location = new Point(209, 12);
            groupBoxIncludes.Name = "groupBoxIncludes";
            groupBoxIncludes.Size = new Size(252, 71);
            groupBoxIncludes.TabIndex = 7;
            groupBoxIncludes.TabStop = false;
            groupBoxIncludes.Text = "Incluir";
            // 
            // buttonCopy
            // 
            buttonCopy.Location = new Point(387, 89);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(74, 23);
            buttonCopy.TabIndex = 8;
            buttonCopy.Text = "Copiar";
            buttonCopy.UseVisualStyleBackColor = true;
            buttonCopy.Click += ButtonCopy_Click;
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(11, 22);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(85, 15);
            labelLength.TabIndex = 9;
            labelLength.Text = "Comprimento:";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { StatusLabel });
            statusStrip1.Location = new Point(0, 117);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(473, 22);
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(39, 17);
            StatusLabel.Text = "Status";
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(473, 139);
            Controls.Add(statusStrip1);
            Controls.Add(labelLength);
            Controls.Add(buttonCopy);
            Controls.Add(groupBoxIncludes);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLength);
            Controls.Add(buttonGenerate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "formMain";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Gerador de Senha";
            Load += FormMain_Load;
            groupBoxIncludes.ResumeLayout(false);
            groupBoxIncludes.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGenerate;
        private CheckBox checkBoxUpper;
        private CheckBox checkBoxLower;
        private CheckBox checkBoxNumeric;
        private CheckBox checkBoxSpecial;
        private TextBox textBoxLength;
        private TextBox textBoxPassword;
        private GroupBox groupBoxIncludes;
        private Button buttonCopy;
        private Label labelLength;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusLabel;
    }
}