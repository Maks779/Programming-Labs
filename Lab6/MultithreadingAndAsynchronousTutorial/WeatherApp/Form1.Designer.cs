namespace TutorialAsyncAwait
{
    partial class Form1
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
            citiesTextBox = new TextBox();
            cityLabel = new Label();
            resultTextBox = new TextBox();
            searchButton = new Button();
            dummyButton1 = new Button();
            dummyButton2 = new Button();
            dummyTextBox = new TextBox();
            SuspendLayout();
            // 
            // citiesTextBox
            // 
            citiesTextBox.Location = new Point(95, 17);
            citiesTextBox.Name = "citiesTextBox";
            citiesTextBox.Size = new Size(462, 31);
            citiesTextBox.TabIndex = 0;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(12, 20);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(58, 25);
            cityLabel.TabIndex = 1;
            cityLabel.Text = "Cities:";
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(12, 66);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(682, 619);
            resultTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(582, 15);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(112, 34);
            searchButton.TabIndex = 3;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            // 
            // dummyButton1
            // 
            dummyButton1.Location = new Point(717, 15);
            dummyButton1.Name = "dummyButton1";
            dummyButton1.Size = new Size(112, 34);
            dummyButton1.TabIndex = 4;
            dummyButton1.Text = "Dummy1";
            dummyButton1.UseVisualStyleBackColor = true;
            dummyButton1.Click += dummyButton1_Click;
            // 
            // dummyButton2
            // 
            dummyButton2.Location = new Point(835, 15);
            dummyButton2.Name = "dummyButton2";
            dummyButton2.Size = new Size(112, 34);
            dummyButton2.TabIndex = 5;
            dummyButton2.Text = "Dummy2";
            dummyButton2.UseVisualStyleBackColor = true;
            dummyButton2.Click += dummyButton2_Click;
            // 
            // dummyTextBox
            // 
            dummyTextBox.Location = new Point(717, 66);
            dummyTextBox.Multiline = true;
            dummyTextBox.Name = "dummyTextBox";
            dummyTextBox.Size = new Size(370, 619);
            dummyTextBox.TabIndex = 6;
            dummyTextBox.Text = "Here you can put some comments or use Dummy1 or Dummy 2 buttons to change the content...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 697);
            Controls.Add(dummyTextBox);
            Controls.Add(dummyButton2);
            Controls.Add(dummyButton1);
            Controls.Add(searchButton);
            Controls.Add(resultTextBox);
            Controls.Add(cityLabel);
            Controls.Add(citiesTextBox);
            Name = "Form1";
            Text = "Weather app";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox citiesTextBox;
        private Label cityLabel;
        private TextBox resultTextBox;
        private Button searchButton;
        private Button dummyButton1;
        private Button dummyButton2;
        private TextBox dummyTextBox;
    }
}
