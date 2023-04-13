using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MyCSharpProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(216, 30);
            label1.TabIndex = 0;
            label1.Text = "XSlime's C# Project";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "Hey！That is a file dialog.";
            // 
            // button1
            // 
            button1.Location = new Point(12, 508);
            button1.Name = "button1";
            button1.Size = new Size(701, 32);
            button1.TabIndex = 1;
            button1.Text = "Open File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ButtonClicked;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 92);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(701, 410);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 3;
            label2.Text = "参数:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(61, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(652, 23);
            textBox2.TabIndex = 4;
            textBox2.Text = "{i}. {path} {floder} {enter}";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 69);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 5;
            label3.Text = "输出:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 552);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "XSlime's C# Project openFileTest";
            Load += Form1_Load;
            Resize += Form1_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            string path;
            string command = textBox2.Text;
            string temp = command;
            string floder;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = "";
                for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                {
                    floder = System.IO.Path.GetDirectoryName(openFileDialog1.FileNames[i]);
                    path = openFileDialog1.FileNames[i];  //获取文件路径
                    temp = command;
                    temp = temp.Replace("{i}", (i + 1).ToString());
                    temp = temp.Replace("{path}", path);
                    temp = temp.Replace("{floder}", floder);
                    temp = temp.Replace("{enter}", Environment.NewLine);
                    //textBox1.Text += $"{i + 1}. {path}{Environment.NewLine}";
                    textBox1.Text += temp;
                }
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.LastIndexOf(Environment.NewLine), Environment.NewLine.Length);
            }
        }


        #endregion

        private Label label1;
        private OpenFileDialog openFileDialog1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
    }
}