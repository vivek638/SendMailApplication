namespace Email_Sending_in_CSharp___csharpens.com
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
            this.SenderEmailTextBox = new System.Windows.Forms.TextBox();
            this.SenderEmailPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AttachmentTextBox = new System.Windows.Forms.TextBox();
            this.AttachFileButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ReceiverTextBox = new System.Windows.Forms.TextBox();
            this.SendEmailButon = new System.Windows.Forms.Button();
            this.SendNotSendLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EmailSubjectTextBox = new System.Windows.Forms.TextBox();
            this.EmailBodyTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SenderEmailTextBox
            // 
            this.SenderEmailTextBox.Location = new System.Drawing.Point(121, 30);
            this.SenderEmailTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SenderEmailTextBox.Name = "SenderEmailTextBox";
            this.SenderEmailTextBox.Size = new System.Drawing.Size(230, 25);
            this.SenderEmailTextBox.TabIndex = 0;
            this.SenderEmailTextBox.Text = "myEmail";
            this.SenderEmailTextBox.Click += new System.EventHandler(this.SenderEmailTextBox_Click);
            // 
            // SenderEmailPasswordTextBox
            // 
            this.SenderEmailPasswordTextBox.Location = new System.Drawing.Point(121, 64);
            this.SenderEmailPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SenderEmailPasswordTextBox.Name = "SenderEmailPasswordTextBox";
            this.SenderEmailPasswordTextBox.Size = new System.Drawing.Size(319, 25);
            this.SenderEmailPasswordTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 275);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Attachment";
            // 
            // AttachmentTextBox
            // 
            this.AttachmentTextBox.Location = new System.Drawing.Point(120, 271);
            this.AttachmentTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AttachmentTextBox.Name = "AttachmentTextBox";
            this.AttachmentTextBox.Size = new System.Drawing.Size(210, 25);
            this.AttachmentTextBox.TabIndex = 4;
            // 
            // AttachFileButton
            // 
            this.AttachFileButton.Location = new System.Drawing.Point(338, 268);
            this.AttachFileButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AttachFileButton.Name = "AttachFileButton";
            this.AttachFileButton.Size = new System.Drawing.Size(100, 30);
            this.AttachFileButton.TabIndex = 6;
            this.AttachFileButton.Text = "Attach";
            this.AttachFileButton.UseVisualStyleBackColor = true;
            this.AttachFileButton.Click += new System.EventHandler(this.AttachFileButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Send To";
            // 
            // ReceiverTextBox
            // 
            this.ReceiverTextBox.Location = new System.Drawing.Point(120, 97);
            this.ReceiverTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReceiverTextBox.Name = "ReceiverTextBox";
            this.ReceiverTextBox.Size = new System.Drawing.Size(319, 25);
            this.ReceiverTextBox.TabIndex = 7;
            // 
            // SendEmailButon
            // 
            this.SendEmailButon.Location = new System.Drawing.Point(192, 310);
            this.SendEmailButon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SendEmailButon.Name = "SendEmailButon";
            this.SendEmailButon.Size = new System.Drawing.Size(100, 30);
            this.SendEmailButon.TabIndex = 9;
            this.SendEmailButon.Text = "Send";
            this.SendEmailButon.UseVisualStyleBackColor = true;
            this.SendEmailButon.Click += new System.EventHandler(this.SendEmailButon_Click);
            // 
            // SendNotSendLabel
            // 
            this.SendNotSendLabel.AutoSize = true;
            this.SendNotSendLabel.Location = new System.Drawing.Point(189, 347);
            this.SendNotSendLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SendNotSendLabel.Name = "SendNotSendLabel";
            this.SendNotSendLabel.Size = new System.Drawing.Size(109, 17);
            this.SendNotSendLabel.TabIndex = 10;
            this.SendNotSendLabel.Text = "Send / Not Send";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email Subject";
            // 
            // EmailSubjectTextBox
            // 
            this.EmailSubjectTextBox.Location = new System.Drawing.Point(119, 130);
            this.EmailSubjectTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailSubjectTextBox.Name = "EmailSubjectTextBox";
            this.EmailSubjectTextBox.Size = new System.Drawing.Size(319, 25);
            this.EmailSubjectTextBox.TabIndex = 11;
            // 
            // EmailBodyTextBox
            // 
            this.EmailBodyTextBox.Location = new System.Drawing.Point(119, 162);
            this.EmailBodyTextBox.Name = "EmailBodyTextBox";
            this.EmailBodyTextBox.Size = new System.Drawing.Size(319, 96);
            this.EmailBodyTextBox.TabIndex = 13;
            this.EmailBodyTextBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Email Body";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "@gmail.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 374);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EmailBodyTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmailSubjectTextBox);
            this.Controls.Add(this.SendNotSendLabel);
            this.Controls.Add(this.SendEmailButon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReceiverTextBox);
            this.Controls.Add(this.AttachFileButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AttachmentTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SenderEmailPasswordTextBox);
            this.Controls.Add(this.SenderEmailTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Email";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SenderEmailTextBox;
        private System.Windows.Forms.TextBox SenderEmailPasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AttachmentTextBox;
        private System.Windows.Forms.Button AttachFileButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ReceiverTextBox;
        private System.Windows.Forms.Button SendEmailButon;
        private System.Windows.Forms.Label SendNotSendLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmailSubjectTextBox;
        private System.Windows.Forms.RichTextBox EmailBodyTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

