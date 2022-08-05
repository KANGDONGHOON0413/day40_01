
namespace day40_01
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.INPUT_Name = new System.Windows.Forms.TextBox();
            this.INPUT_Age = new System.Windows.Forms.TextBox();
            this.INPUT_Fruit = new System.Windows.Forms.TextBox();
            this.INPUT_Num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB01_BTN_Input = new System.Windows.Forms.Button();
            this.TB01_BTN_Delete = new System.Windows.Forms.Button();
            this.TB01_BTN_Update = new System.Windows.Forms.Button();
            this.TB01_BTN_Show = new System.Windows.Forms.Button();
            this.TB02_BTN_Input = new System.Windows.Forms.Button();
            this.TB02_BTN_Delete = new System.Windows.Forms.Button();
            this.TB02_BTN_Update = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.INPUT_Nid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(346, 238);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(392, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(345, 238);
            this.dataGridView2.TabIndex = 1;
            // 
            // INPUT_Name
            // 
            this.INPUT_Name.Location = new System.Drawing.Point(58, 294);
            this.INPUT_Name.Name = "INPUT_Name";
            this.INPUT_Name.Size = new System.Drawing.Size(125, 27);
            this.INPUT_Name.TabIndex = 2;
            // 
            // INPUT_Age
            // 
            this.INPUT_Age.Location = new System.Drawing.Point(233, 294);
            this.INPUT_Age.Name = "INPUT_Age";
            this.INPUT_Age.Size = new System.Drawing.Size(125, 27);
            this.INPUT_Age.TabIndex = 3;
            // 
            // INPUT_Fruit
            // 
            this.INPUT_Fruit.Location = new System.Drawing.Point(608, 294);
            this.INPUT_Fruit.Name = "INPUT_Fruit";
            this.INPUT_Fruit.Size = new System.Drawing.Size(125, 27);
            this.INPUT_Fruit.TabIndex = 5;
            // 
            // INPUT_Num
            // 
            this.INPUT_Num.Location = new System.Drawing.Point(433, 329);
            this.INPUT_Num.Name = "INPUT_Num";
            this.INPUT_Num.Size = new System.Drawing.Size(71, 27);
            this.INPUT_Num.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "나이";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "과일";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "개수";
            // 
            // TB01_BTN_Input
            // 
            this.TB01_BTN_Input.Location = new System.Drawing.Point(12, 327);
            this.TB01_BTN_Input.Name = "TB01_BTN_Input";
            this.TB01_BTN_Input.Size = new System.Drawing.Size(78, 29);
            this.TB01_BTN_Input.TabIndex = 10;
            this.TB01_BTN_Input.Text = "입력";
            this.TB01_BTN_Input.UseVisualStyleBackColor = true;
            this.TB01_BTN_Input.Click += new System.EventHandler(this.TB01_BTN_Input_Click);
            // 
            // TB01_BTN_Delete
            // 
            this.TB01_BTN_Delete.Location = new System.Drawing.Point(96, 327);
            this.TB01_BTN_Delete.Name = "TB01_BTN_Delete";
            this.TB01_BTN_Delete.Size = new System.Drawing.Size(78, 29);
            this.TB01_BTN_Delete.TabIndex = 11;
            this.TB01_BTN_Delete.Text = "삭제";
            this.TB01_BTN_Delete.UseVisualStyleBackColor = true;
            this.TB01_BTN_Delete.Click += new System.EventHandler(this.TB01_BTN_Delete_Click);
            // 
            // TB01_BTN_Update
            // 
            this.TB01_BTN_Update.Location = new System.Drawing.Point(180, 327);
            this.TB01_BTN_Update.Name = "TB01_BTN_Update";
            this.TB01_BTN_Update.Size = new System.Drawing.Size(78, 29);
            this.TB01_BTN_Update.TabIndex = 12;
            this.TB01_BTN_Update.Text = "수정";
            this.TB01_BTN_Update.UseVisualStyleBackColor = true;
            this.TB01_BTN_Update.Click += new System.EventHandler(this.TB01_BTN_Update_Click);
            // 
            // TB01_BTN_Show
            // 
            this.TB01_BTN_Show.Location = new System.Drawing.Point(264, 327);
            this.TB01_BTN_Show.Name = "TB01_BTN_Show";
            this.TB01_BTN_Show.Size = new System.Drawing.Size(94, 29);
            this.TB01_BTN_Show.TabIndex = 13;
            this.TB01_BTN_Show.Text = "과일 보기";
            this.TB01_BTN_Show.UseVisualStyleBackColor = true;
            this.TB01_BTN_Show.Click += new System.EventHandler(this.TB01_BTN_Show_Click);
            // 
            // TB02_BTN_Input
            // 
            this.TB02_BTN_Input.Location = new System.Drawing.Point(510, 327);
            this.TB02_BTN_Input.Name = "TB02_BTN_Input";
            this.TB02_BTN_Input.Size = new System.Drawing.Size(72, 29);
            this.TB02_BTN_Input.TabIndex = 14;
            this.TB02_BTN_Input.Text = "입력";
            this.TB02_BTN_Input.UseVisualStyleBackColor = true;
            this.TB02_BTN_Input.Click += new System.EventHandler(this.TB02_BTN_Input_Click);
            // 
            // TB02_BTN_Delete
            // 
            this.TB02_BTN_Delete.Location = new System.Drawing.Point(588, 327);
            this.TB02_BTN_Delete.Name = "TB02_BTN_Delete";
            this.TB02_BTN_Delete.Size = new System.Drawing.Size(74, 29);
            this.TB02_BTN_Delete.TabIndex = 15;
            this.TB02_BTN_Delete.Text = "삭제";
            this.TB02_BTN_Delete.UseVisualStyleBackColor = true;
            this.TB02_BTN_Delete.Click += new System.EventHandler(this.TB02_BTN_Delete_Click);
            // 
            // TB02_BTN_Update
            // 
            this.TB02_BTN_Update.Location = new System.Drawing.Point(668, 327);
            this.TB02_BTN_Update.Name = "TB02_BTN_Update";
            this.TB02_BTN_Update.Size = new System.Drawing.Size(65, 29);
            this.TB02_BTN_Update.TabIndex = 16;
            this.TB02_BTN_Update.Text = "수정";
            this.TB02_BTN_Update.UseVisualStyleBackColor = true;
            this.TB02_BTN_Update.Click += new System.EventHandler(this.TB02_BTN_Update_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(233, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 46);
            this.label5.TabIndex = 17;
            this.label5.Text = "관계형 DB 실습";
            // 
            // INPUT_Nid
            // 
            this.INPUT_Nid.Location = new System.Drawing.Point(432, 294);
            this.INPUT_Nid.Name = "INPUT_Nid";
            this.INPUT_Nid.Size = new System.Drawing.Size(125, 27);
            this.INPUT_Nid.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Nid";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.INPUT_Nid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB02_BTN_Update);
            this.Controls.Add(this.TB02_BTN_Delete);
            this.Controls.Add(this.TB02_BTN_Input);
            this.Controls.Add(this.TB01_BTN_Show);
            this.Controls.Add(this.TB01_BTN_Update);
            this.Controls.Add(this.TB01_BTN_Delete);
            this.Controls.Add(this.TB01_BTN_Input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.INPUT_Num);
            this.Controls.Add(this.INPUT_Fruit);
            this.Controls.Add(this.INPUT_Age);
            this.Controls.Add(this.INPUT_Name);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox INPUT_Name;
        private System.Windows.Forms.TextBox INPUT_Age;
        private System.Windows.Forms.TextBox INPUT_Fruit;
        private System.Windows.Forms.TextBox INPUT_Num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button TB01_BTN_Input;
        private System.Windows.Forms.Button TB01_BTN_Delete;
        private System.Windows.Forms.Button TB01_BTN_Update;
        private System.Windows.Forms.Button TB01_BTN_Show;
        private System.Windows.Forms.Button TB02_BTN_Input;
        private System.Windows.Forms.Button TB02_BTN_Delete;
        private System.Windows.Forms.Button TB02_BTN_Update;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox INPUT_Nid;
        private System.Windows.Forms.Label label6;
    }
}

