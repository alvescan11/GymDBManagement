namespace Laborator1
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
            components = new System.ComponentModel.Container();
            dataGridParent = new DataGridView();
            dataGridChild = new DataGridView();
            SalaFitness = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            bindingSource1 = new BindingSource(components);
            button3 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridParent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridChild).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridParent
            // 
            dataGridParent.BackgroundColor = SystemColors.Highlight;
            dataGridParent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridParent.Location = new Point(34, 60);
            dataGridParent.Name = "dataGridParent";
            dataGridParent.RowHeadersWidth = 62;
            dataGridParent.RowTemplate.Height = 33;
            dataGridParent.Size = new Size(471, 182);
            dataGridParent.TabIndex = 0;
            // 
            // dataGridChild
            // 
            dataGridChild.BackgroundColor = SystemColors.Highlight;
            dataGridChild.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridChild.GridColor = SystemColors.HotTrack;
            dataGridChild.Location = new Point(558, 55);
            dataGridChild.Name = "dataGridChild";
            dataGridChild.RowHeadersWidth = 62;
            dataGridChild.RowTemplate.Height = 33;
            dataGridChild.Size = new Size(558, 182);
            dataGridChild.TabIndex = 1;
            // 
            // SalaFitness
            // 
            SalaFitness.AutoSize = true;
            SalaFitness.Location = new Point(103, 32);
            SalaFitness.Name = "SalaFitness";
            SalaFitness.Size = new Size(98, 25);
            SalaFitness.TabIndex = 2;
            SalaFitness.Text = "SalaFitness";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(567, 27);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 3;
            label2.Text = "Antrenor";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.HotTrack;
            textBox1.Location = new Point(86, 368);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 340);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 5;
            label1.Text = "SALA";
            // 
            // button1
            // 
            button1.Location = new Point(589, 248);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Stergere";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(124, 248);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 8;
            button3.Text = "Adauga";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(833, 248);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 9;
            button2.Text = "Actualizare";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(833, 297);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "numeAnt";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(833, 334);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "prenumeAnt";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(833, 371);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "id";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1212, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(SalaFitness);
            Controls.Add(dataGridChild);
            Controls.Add(dataGridParent);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridParent).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridChild).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridParent;
        private DataGridView dataGridChild;
        private Label SalaFitness;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private BindingSource bindingSource1;
        private Button button3;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}