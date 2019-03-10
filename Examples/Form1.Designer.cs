namespace Examples
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
            this.integerParseExamplesButton1 = new System.Windows.Forms.Button();
            this.integerTryParseExamplesButton1 = new System.Windows.Forms.Button();
            this.integerTryParseOutVarExamplesButton1 = new System.Windows.Forms.Button();
            this.stringArrayToIntArrayVersion1Button = new System.Windows.Forms.Button();
            this.stringArrayToIntArrayVersion2ThrowsExceptionButton = new System.Windows.Forms.Button();
            this.stringArrayToIntArrayVersion2NoExceptionButBadButton = new System.Windows.Forms.Button();
            this.assertAllElementsCanBeConvertedButton = new System.Windows.Forms.Button();
            this.assertAllElementsCanBeConvertedGetOffendersButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.assertBeforeConvertGetOffendersExtensionsButton1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // integerParseExamplesButton1
            // 
            this.integerParseExamplesButton1.Location = new System.Drawing.Point(18, 21);
            this.integerParseExamplesButton1.Name = "integerParseExamplesButton1";
            this.integerParseExamplesButton1.Size = new System.Drawing.Size(462, 23);
            this.integerParseExamplesButton1.TabIndex = 0;
            this.integerParseExamplesButton1.Text = "Integer Parse Example Throw exception";
            this.integerParseExamplesButton1.UseVisualStyleBackColor = true;
            this.integerParseExamplesButton1.Click += new System.EventHandler(this.integerParseExampleButton1_Click);
            // 
            // integerTryParseExamplesButton1
            // 
            this.integerTryParseExamplesButton1.Location = new System.Drawing.Point(18, 50);
            this.integerTryParseExamplesButton1.Name = "integerTryParseExamplesButton1";
            this.integerTryParseExamplesButton1.Size = new System.Drawing.Size(462, 23);
            this.integerTryParseExamplesButton1.TabIndex = 1;
            this.integerTryParseExamplesButton1.Text = "Integer TryParse Example pre-C# 7";
            this.integerTryParseExamplesButton1.UseVisualStyleBackColor = true;
            this.integerTryParseExamplesButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // integerTryParseOutVarExamplesButton1
            // 
            this.integerTryParseOutVarExamplesButton1.Location = new System.Drawing.Point(18, 79);
            this.integerTryParseOutVarExamplesButton1.Name = "integerTryParseOutVarExamplesButton1";
            this.integerTryParseOutVarExamplesButton1.Size = new System.Drawing.Size(462, 23);
            this.integerTryParseOutVarExamplesButton1.TabIndex = 2;
            this.integerTryParseOutVarExamplesButton1.Text = "Integer TryParse Example C# 7";
            this.integerTryParseOutVarExamplesButton1.UseVisualStyleBackColor = true;
            this.integerTryParseOutVarExamplesButton1.Click += new System.EventHandler(this.integerTryParseOutVarExamplesButton1_Click);
            // 
            // stringArrayToIntArrayVersion1Button
            // 
            this.stringArrayToIntArrayVersion1Button.Location = new System.Drawing.Point(18, 137);
            this.stringArrayToIntArrayVersion1Button.Name = "stringArrayToIntArrayVersion1Button";
            this.stringArrayToIntArrayVersion1Button.Size = new System.Drawing.Size(462, 23);
            this.stringArrayToIntArrayVersion1Button.TabIndex = 3;
            this.stringArrayToIntArrayVersion1Button.Text = "String array to int array version 1";
            this.stringArrayToIntArrayVersion1Button.UseVisualStyleBackColor = true;
            this.stringArrayToIntArrayVersion1Button.Click += new System.EventHandler(this.stringArrayToIntArrayVersion1Button_Click);
            // 
            // stringArrayToIntArrayVersion2ThrowsExceptionButton
            // 
            this.stringArrayToIntArrayVersion2ThrowsExceptionButton.Location = new System.Drawing.Point(18, 166);
            this.stringArrayToIntArrayVersion2ThrowsExceptionButton.Name = "stringArrayToIntArrayVersion2ThrowsExceptionButton";
            this.stringArrayToIntArrayVersion2ThrowsExceptionButton.Size = new System.Drawing.Size(462, 23);
            this.stringArrayToIntArrayVersion2ThrowsExceptionButton.TabIndex = 4;
            this.stringArrayToIntArrayVersion2ThrowsExceptionButton.Text = "String array to int array version 2 Throws exception";
            this.stringArrayToIntArrayVersion2ThrowsExceptionButton.UseVisualStyleBackColor = true;
            this.stringArrayToIntArrayVersion2ThrowsExceptionButton.Click += new System.EventHandler(this.stringArrayToIntArrayVersion2ThrowsExceptionButton_Click);
            // 
            // stringArrayToIntArrayVersion2NoExceptionButBadButton
            // 
            this.stringArrayToIntArrayVersion2NoExceptionButBadButton.Location = new System.Drawing.Point(18, 195);
            this.stringArrayToIntArrayVersion2NoExceptionButBadButton.Name = "stringArrayToIntArrayVersion2NoExceptionButBadButton";
            this.stringArrayToIntArrayVersion2NoExceptionButBadButton.Size = new System.Drawing.Size(462, 23);
            this.stringArrayToIntArrayVersion2NoExceptionButBadButton.TabIndex = 5;
            this.stringArrayToIntArrayVersion2NoExceptionButBadButton.Text = "String array to int array version 2 No Exception but bad";
            this.stringArrayToIntArrayVersion2NoExceptionButBadButton.UseVisualStyleBackColor = true;
            this.stringArrayToIntArrayVersion2NoExceptionButBadButton.Click += new System.EventHandler(this.stringArrayToIntArrayVersion2NoExceptionButBadButton_Click);
            // 
            // assertAllElementsCanBeConvertedButton
            // 
            this.assertAllElementsCanBeConvertedButton.Location = new System.Drawing.Point(9, 11);
            this.assertAllElementsCanBeConvertedButton.Name = "assertAllElementsCanBeConvertedButton";
            this.assertAllElementsCanBeConvertedButton.Size = new System.Drawing.Size(462, 23);
            this.assertAllElementsCanBeConvertedButton.TabIndex = 6;
            this.assertAllElementsCanBeConvertedButton.Text = "Assert before attempting conversion on array";
            this.assertAllElementsCanBeConvertedButton.UseVisualStyleBackColor = true;
            this.assertAllElementsCanBeConvertedButton.Click += new System.EventHandler(this.assertAllElementsCanBeConvertedButton_Click);
            // 
            // assertAllElementsCanBeConvertedGetOffendersButton
            // 
            this.assertAllElementsCanBeConvertedGetOffendersButton.Location = new System.Drawing.Point(9, 40);
            this.assertAllElementsCanBeConvertedGetOffendersButton.Name = "assertAllElementsCanBeConvertedGetOffendersButton";
            this.assertAllElementsCanBeConvertedGetOffendersButton.Size = new System.Drawing.Size(462, 23);
            this.assertAllElementsCanBeConvertedGetOffendersButton.TabIndex = 7;
            this.assertAllElementsCanBeConvertedGetOffendersButton.Text = "Assert before attempting conversion on array to offenders";
            this.assertAllElementsCanBeConvertedGetOffendersButton.UseVisualStyleBackColor = true;
            this.assertAllElementsCanBeConvertedGetOffendersButton.Click += new System.EventHandler(this.assertAllElementsCanBeConvertedGetOffendersButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(462, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Assert before attempting conversion on array to offenders";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.assertBeforeConvertGetOffendersExtensionsButton1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.assertAllElementsCanBeConvertedGetOffendersButton);
            this.groupBox1.Controls.Add(this.assertAllElementsCanBeConvertedButton);
            this.groupBox1.Location = new System.Drawing.Point(18, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 161);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // assertBeforeConvertGetOffendersExtensionsButton1
            // 
            this.assertBeforeConvertGetOffendersExtensionsButton1.Location = new System.Drawing.Point(9, 98);
            this.assertBeforeConvertGetOffendersExtensionsButton1.Name = "assertBeforeConvertGetOffendersExtensionsButton1";
            this.assertBeforeConvertGetOffendersExtensionsButton1.Size = new System.Drawing.Size(462, 23);
            this.assertBeforeConvertGetOffendersExtensionsButton1.TabIndex = 9;
            this.assertBeforeConvertGetOffendersExtensionsButton1.Text = "Using Extensions";
            this.assertBeforeConvertGetOffendersExtensionsButton1.UseVisualStyleBackColor = true;
            this.assertBeforeConvertGetOffendersExtensionsButton1.Click += new System.EventHandler(this.assertBeforeConvertGetOffendersExtensionsButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.stringArrayToIntArrayVersion2NoExceptionButBadButton);
            this.Controls.Add(this.stringArrayToIntArrayVersion2ThrowsExceptionButton);
            this.Controls.Add(this.stringArrayToIntArrayVersion1Button);
            this.Controls.Add(this.integerTryParseOutVarExamplesButton1);
            this.Controls.Add(this.integerTryParseExamplesButton1);
            this.Controls.Add(this.integerParseExamplesButton1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code examples";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button integerParseExamplesButton1;
        private System.Windows.Forms.Button integerTryParseExamplesButton1;
        private System.Windows.Forms.Button integerTryParseOutVarExamplesButton1;
        private System.Windows.Forms.Button stringArrayToIntArrayVersion1Button;
        private System.Windows.Forms.Button stringArrayToIntArrayVersion2ThrowsExceptionButton;
        private System.Windows.Forms.Button stringArrayToIntArrayVersion2NoExceptionButBadButton;
        private System.Windows.Forms.Button assertAllElementsCanBeConvertedButton;
        private System.Windows.Forms.Button assertAllElementsCanBeConvertedGetOffendersButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button assertBeforeConvertGetOffendersExtensionsButton1;
    }
}

