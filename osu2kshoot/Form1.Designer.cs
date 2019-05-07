namespace osu2kshoot
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.osuDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.openOsuFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.jacketDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.illustratorTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.levelTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.musicDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.iconDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.difficultyComboBox = new System.Windows.Forms.ComboBox();
            this.backgroundComboBox = new System.Windows.Forms.ComboBox();
            this.layerComboBox = new System.Windows.Forms.ComboBox();
            this.jacketDirectorySearchButton = new System.Windows.Forms.Button();
            this.musicDirectorySearchButton = new System.Windows.Forms.Button();
            this.iconDirectorySearchButton = new System.Windows.Forms.Button();
            this.openJacketFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openIconFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openMusicFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fourRadioButton = new System.Windows.Forms.RadioButton();
            this.sevenRadioButton = new System.Windows.Forms.RadioButton();
            this.sevenRadioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "osu파일";
            // 
            // osuDirectoryTextBox
            // 
            this.osuDirectoryTextBox.Location = new System.Drawing.Point(69, 10);
            this.osuDirectoryTextBox.Name = "osuDirectoryTextBox";
            this.osuDirectoryTextBox.Size = new System.Drawing.Size(271, 21);
            this.osuDirectoryTextBox.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(346, 8);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(39, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "...";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(252, 224);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(133, 34);
            this.ConvertButton.TabIndex = 3;
            this.ConvertButton.Text = "변환";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // openOsuFileDialog
            // 
            this.openOsuFileDialog.Filter = "osu파일|*.osu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "일러 경로";
            // 
            // jacketDirectoryTextBox
            // 
            this.jacketDirectoryTextBox.Location = new System.Drawing.Point(69, 48);
            this.jacketDirectoryTextBox.Name = "jacketDirectoryTextBox";
            this.jacketDirectoryTextBox.Size = new System.Drawing.Size(100, 21);
            this.jacketDirectoryTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "일러러";
            // 
            // illustratorTextBox
            // 
            this.illustratorTextBox.Location = new System.Drawing.Point(69, 75);
            this.illustratorTextBox.Name = "illustratorTextBox";
            this.illustratorTextBox.Size = new System.Drawing.Size(100, 21);
            this.illustratorTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "난이도";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "레벨";
            // 
            // levelTextBox
            // 
            this.levelTextBox.Location = new System.Drawing.Point(69, 129);
            this.levelTextBox.Name = "levelTextBox";
            this.levelTextBox.Size = new System.Drawing.Size(100, 21);
            this.levelTextBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "음악 경로";
            // 
            // musicDirectoryTextBox
            // 
            this.musicDirectoryTextBox.Location = new System.Drawing.Point(69, 156);
            this.musicDirectoryTextBox.Name = "musicDirectoryTextBox";
            this.musicDirectoryTextBox.Size = new System.Drawing.Size(100, 21);
            this.musicDirectoryTextBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "배경";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "레이어";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "아이콘 경로";
            // 
            // iconDirectoryTextBox
            // 
            this.iconDirectoryTextBox.Location = new System.Drawing.Point(69, 237);
            this.iconDirectoryTextBox.Name = "iconDirectoryTextBox";
            this.iconDirectoryTextBox.Size = new System.Drawing.Size(100, 21);
            this.iconDirectoryTextBox.TabIndex = 5;
            // 
            // difficultyComboBox
            // 
            this.difficultyComboBox.FormattingEnabled = true;
            this.difficultyComboBox.Location = new System.Drawing.Point(69, 102);
            this.difficultyComboBox.Name = "difficultyComboBox";
            this.difficultyComboBox.Size = new System.Drawing.Size(100, 20);
            this.difficultyComboBox.TabIndex = 6;
            // 
            // backgroundComboBox
            // 
            this.backgroundComboBox.FormattingEnabled = true;
            this.backgroundComboBox.Location = new System.Drawing.Point(69, 183);
            this.backgroundComboBox.Name = "backgroundComboBox";
            this.backgroundComboBox.Size = new System.Drawing.Size(100, 20);
            this.backgroundComboBox.TabIndex = 6;
            // 
            // layerComboBox
            // 
            this.layerComboBox.FormattingEnabled = true;
            this.layerComboBox.Location = new System.Drawing.Point(69, 211);
            this.layerComboBox.Name = "layerComboBox";
            this.layerComboBox.Size = new System.Drawing.Size(100, 20);
            this.layerComboBox.TabIndex = 6;
            // 
            // jacketDirectorySearchButton
            // 
            this.jacketDirectorySearchButton.Location = new System.Drawing.Point(175, 46);
            this.jacketDirectorySearchButton.Name = "jacketDirectorySearchButton";
            this.jacketDirectorySearchButton.Size = new System.Drawing.Size(39, 23);
            this.jacketDirectorySearchButton.TabIndex = 2;
            this.jacketDirectorySearchButton.Text = "...";
            this.jacketDirectorySearchButton.UseVisualStyleBackColor = true;
            this.jacketDirectorySearchButton.Click += new System.EventHandler(this.JacketDirectorySearchButton_Click);
            // 
            // musicDirectorySearchButton
            // 
            this.musicDirectorySearchButton.Location = new System.Drawing.Point(175, 156);
            this.musicDirectorySearchButton.Name = "musicDirectorySearchButton";
            this.musicDirectorySearchButton.Size = new System.Drawing.Size(39, 23);
            this.musicDirectorySearchButton.TabIndex = 2;
            this.musicDirectorySearchButton.Text = "...";
            this.musicDirectorySearchButton.UseVisualStyleBackColor = true;
            this.musicDirectorySearchButton.Click += new System.EventHandler(this.MusicDirectorySearchButton_Click);
            // 
            // iconDirectorySearchButton
            // 
            this.iconDirectorySearchButton.Location = new System.Drawing.Point(175, 235);
            this.iconDirectorySearchButton.Name = "iconDirectorySearchButton";
            this.iconDirectorySearchButton.Size = new System.Drawing.Size(39, 23);
            this.iconDirectorySearchButton.TabIndex = 2;
            this.iconDirectorySearchButton.Text = "...";
            this.iconDirectorySearchButton.UseVisualStyleBackColor = true;
            this.iconDirectorySearchButton.Click += new System.EventHandler(this.IconDirectorySearchButton_Click);
            // 
            // openJacketFileDialog
            // 
            this.openJacketFileDialog.Filter = "이미지 파일|*.png;*.jpeg;*.jpg*.bmp";
            // 
            // openIconFileDialog
            // 
            this.openIconFileDialog.Filter = "이미지 파일|*.png;*.jpeg;*.jpg*.bmp";
            // 
            // openMusicFileDialog
            // 
            this.openMusicFileDialog.Filter = "음악 파일|*.mp3;*.ogg;*.wav";
            // 
            // fourRadioButton
            // 
            this.fourRadioButton.AutoSize = true;
            this.fourRadioButton.Checked = true;
            this.fourRadioButton.Location = new System.Drawing.Point(252, 46);
            this.fourRadioButton.Name = "fourRadioButton";
            this.fourRadioButton.Size = new System.Drawing.Size(71, 16);
            this.fourRadioButton.TabIndex = 7;
            this.fourRadioButton.TabStop = true;
            this.fourRadioButton.Text = "4K(버튼)";
            this.fourRadioButton.UseVisualStyleBackColor = true;
            // 
            // sevenRadioButton
            // 
            this.sevenRadioButton.Location = new System.Drawing.Point(252, 68);
            this.sevenRadioButton.Name = "sevenRadioButton";
            this.sevenRadioButton.Size = new System.Drawing.Size(97, 16);
            this.sevenRadioButton.TabIndex = 7;
            this.sevenRadioButton.Text = "7K(버튼+FX)";
            this.sevenRadioButton.UseVisualStyleBackColor = true;
            // 
            // sevenRadioButton2
            // 
            this.sevenRadioButton2.Location = new System.Drawing.Point(252, 90);
            this.sevenRadioButton2.Name = "sevenRadioButton2";
            this.sevenRadioButton2.Size = new System.Drawing.Size(129, 16);
            this.sevenRadioButton2.TabIndex = 7;
            this.sevenRadioButton2.Text = "7K(버튼+FX+노브)";
            this.sevenRadioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 264);
            this.Controls.Add(this.sevenRadioButton2);
            this.Controls.Add(this.sevenRadioButton);
            this.Controls.Add(this.fourRadioButton);
            this.Controls.Add(this.layerComboBox);
            this.Controls.Add(this.backgroundComboBox);
            this.Controls.Add(this.difficultyComboBox);
            this.Controls.Add(this.iconDirectoryTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.musicDirectoryTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.levelTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.illustratorTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jacketDirectoryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.iconDirectorySearchButton);
            this.Controls.Add(this.musicDirectorySearchButton);
            this.Controls.Add(this.jacketDirectorySearchButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.osuDirectoryTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "osu2kshoot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox osuDirectoryTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.OpenFileDialog openOsuFileDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jacketDirectoryTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox illustratorTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox levelTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox musicDirectoryTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox iconDirectoryTextBox;
        private System.Windows.Forms.ComboBox difficultyComboBox;
        private System.Windows.Forms.ComboBox backgroundComboBox;
        private System.Windows.Forms.ComboBox layerComboBox;
        private System.Windows.Forms.Button jacketDirectorySearchButton;
        private System.Windows.Forms.Button musicDirectorySearchButton;
        private System.Windows.Forms.Button iconDirectorySearchButton;
        private System.Windows.Forms.OpenFileDialog openJacketFileDialog;
        private System.Windows.Forms.OpenFileDialog openIconFileDialog;
        private System.Windows.Forms.OpenFileDialog openMusicFileDialog;
        private System.Windows.Forms.RadioButton fourRadioButton;
        private System.Windows.Forms.RadioButton sevenRadioButton;
        private System.Windows.Forms.RadioButton sevenRadioButton2;
    }
}

