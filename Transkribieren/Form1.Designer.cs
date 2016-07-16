namespace Transkribieren
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.edtBackTime = new System.Windows.Forms.TextBox();
            this.edtForeward = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblBackHelp = new System.Windows.Forms.Label();
            this.lblForewardHelp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edtFocus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edtBackTimePause = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.edtFile = new System.Windows.Forms.TextBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(12, 48);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.play_Click);
            // 
            // edtBackTime
            // 
            this.edtBackTime.Location = new System.Drawing.Point(89, 88);
            this.edtBackTime.Name = "edtBackTime";
            this.edtBackTime.Size = new System.Drawing.Size(41, 20);
            this.edtBackTime.TabIndex = 2;
            this.edtBackTime.TabStop = false;
            this.edtBackTime.Text = "5";
            // 
            // edtForeward
            // 
            this.edtForeward.Location = new System.Drawing.Point(89, 119);
            this.edtForeward.Name = "edtForeward";
            this.edtForeward.Size = new System.Drawing.Size(41, 20);
            this.edtForeward.TabIndex = 3;
            this.edtForeward.TabStop = false;
            this.edtForeward.Text = "30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "sec. back";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "sec foreward";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Position";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(86, 197);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(22, 13);
            this.lblPosition.TabIndex = 7;
            this.lblPosition.Text = "--:--";
            // 
            // lblBackHelp
            // 
            this.lblBackHelp.AutoSize = true;
            this.lblBackHelp.Location = new System.Drawing.Point(149, 88);
            this.lblBackHelp.Name = "lblBackHelp";
            this.lblBackHelp.Size = new System.Drawing.Size(99, 13);
            this.lblBackHelp.TabIndex = 8;
            this.lblBackHelp.Text = "ctrl + shift + \\u2190";
            // 
            // lblForewardHelp
            // 
            this.lblForewardHelp.AutoSize = true;
            this.lblForewardHelp.Location = new System.Drawing.Point(149, 126);
            this.lblForewardHelp.Name = "lblForewardHelp";
            this.lblForewardHelp.Size = new System.Drawing.Size(114, 13);
            this.lblForewardHelp.TabIndex = 9;
            this.lblForewardHelp.Text = "ctrl + shift + right Arrow";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "ctrl + shift + space ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "set focus here";
            // 
            // edtFocus
            // 
            this.edtFocus.Location = new System.Drawing.Point(18, 244);
            this.edtFocus.Name = "edtFocus";
            this.edtFocus.Size = new System.Drawing.Size(41, 20);
            this.edtFocus.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "sec. back when Pause";
            // 
            // edtBackTimePause
            // 
            this.edtBackTimePause.Location = new System.Drawing.Point(137, 154);
            this.edtBackTimePause.Name = "edtBackTimePause";
            this.edtBackTimePause.Size = new System.Drawing.Size(41, 20);
            this.edtBackTimePause.TabIndex = 15;
            this.edtBackTimePause.TabStop = false;
            this.edtBackTimePause.Text = "3";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // edtFile
            // 
            this.edtFile.Location = new System.Drawing.Point(18, 13);
            this.edtFile.Name = "edtFile";
            this.edtFile.Size = new System.Drawing.Size(113, 20);
            this.edtFile.TabIndex = 17;
            this.edtFile.Text = "C:\\tmp\\Interview.wav";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(144, 12);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(36, 23);
            this.btnChooseFile.TabIndex = 18;
            this.btnChooseFile.Text = "...";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 300);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.edtFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edtBackTimePause);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edtFocus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblForewardHelp);
            this.Controls.Add(this.lblBackHelp);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtForeward);
            this.Controls.Add(this.edtBackTime);
            this.Controls.Add(this.btnPlay);
            this.Name = "Form1";
            this.Text = "Transcription - Less";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox edtBackTime;
        private System.Windows.Forms.TextBox edtForeward;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblBackHelp;
        private System.Windows.Forms.Label lblForewardHelp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtFocus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtBackTimePause;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox edtFile;
        private System.Windows.Forms.Button btnChooseFile;
    }
}

