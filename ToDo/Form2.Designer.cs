namespace ToDo
{
    partial class Config
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BackColor1 = new TextBox();
            label6 = new Label();
            Apply = new Button();
            TextColor = new TextBox();
            TodoListColor = new TextBox();
            Findinputbc = new TextBox();
            label7 = new Label();
            visionVersion_combob = new ComboBox();
            label8 = new Label();
            vision_Name = new TextBox();
            Update = new Button();
            Create = new Button();
            Fontstyltext = new TextBox();
            Delete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.875F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(23, 68);
            label1.Name = "label1";
            label1.Size = new Size(146, 37);
            label1.TabIndex = 0;
            label1.Text = "BackColor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.875F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(23, 168);
            label2.Name = "label2";
            label2.Size = new Size(141, 37);
            label2.TabIndex = 0;
            label2.Text = "TextColor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.875F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(23, 268);
            label3.Name = "label3";
            label3.Size = new Size(217, 37);
            label3.TabIndex = 0;
            label3.Text = "ToDo_List_Color:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.875F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(23, 366);
            label4.Name = "label4";
            label4.Size = new Size(190, 37);
            label4.TabIndex = 0;
            label4.Text = "Find_input_bc:";
            // 
            // BackColor1
            // 
            BackColor1.BackColor = Color.PeachPuff;
            BackColor1.Location = new Point(241, 68);
            BackColor1.Name = "BackColor1";
            BackColor1.Size = new Size(449, 39);
            BackColor1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.875F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(23, 466);
            label6.Name = "label6";
            label6.Size = new Size(137, 37);
            label6.TabIndex = 0;
            label6.Text = "FontStyle:";
            // 
            // Apply
            // 
            Apply.BackColor = Color.PaleGoldenrod;
            Apply.Location = new Point(477, 833);
            Apply.Name = "Apply";
            Apply.Size = new Size(213, 66);
            Apply.TabIndex = 2;
            Apply.Text = "Apply";
            Apply.UseVisualStyleBackColor = false;
            Apply.Click += Apply_Click;
            // 
            // TextColor
            // 
            TextColor.BackColor = Color.PeachPuff;
            TextColor.Location = new Point(241, 168);
            TextColor.Name = "TextColor";
            TextColor.Size = new Size(449, 39);
            TextColor.TabIndex = 3;
            // 
            // TodoListColor
            // 
            TodoListColor.BackColor = Color.PeachPuff;
            TodoListColor.Location = new Point(241, 268);
            TodoListColor.Name = "TodoListColor";
            TodoListColor.Size = new Size(449, 39);
            TodoListColor.TabIndex = 3;
            // 
            // Findinputbc
            // 
            Findinputbc.BackColor = Color.PeachPuff;
            Findinputbc.Location = new Point(241, 368);
            Findinputbc.Name = "Findinputbc";
            Findinputbc.Size = new Size(449, 39);
            Findinputbc.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.875F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(23, 766);
            label7.Name = "label7";
            label7.Size = new Size(201, 37);
            label7.TabIndex = 0;
            label7.Text = "Vision_Version:";
            // 
            // visionVersion_combob
            // 
            visionVersion_combob.BackColor = Color.PeachPuff;
            visionVersion_combob.FormattingEnabled = true;
            visionVersion_combob.Location = new Point(241, 768);
            visionVersion_combob.Name = "visionVersion_combob";
            visionVersion_combob.Size = new Size(449, 40);
            visionVersion_combob.TabIndex = 4;
            visionVersion_combob.SelectedIndexChanged += visionVersion_combob_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.875F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(23, 566);
            label8.Name = "label8";
            label8.Size = new Size(184, 37);
            label8.TabIndex = 0;
            label8.Text = "Vision_Name:";
            // 
            // vision_Name
            // 
            vision_Name.BackColor = Color.PeachPuff;
            vision_Name.Location = new Point(241, 568);
            vision_Name.Name = "vision_Name";
            vision_Name.Size = new Size(449, 39);
            vision_Name.TabIndex = 1;
            // 
            // Update
            // 
            Update.BackColor = Color.PaleGoldenrod;
            Update.Location = new Point(241, 833);
            Update.Name = "Update";
            Update.Size = new Size(213, 66);
            Update.TabIndex = 2;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // Create
            // 
            Create.BackColor = Color.PaleGoldenrod;
            Create.Location = new Point(477, 645);
            Create.Name = "Create";
            Create.Size = new Size(213, 66);
            Create.TabIndex = 2;
            Create.Text = "Create";
            Create.UseVisualStyleBackColor = false;
            Create.Click += Create_Click;
            // 
            // Fontstyltext
            // 
            Fontstyltext.BackColor = Color.PeachPuff;
            Fontstyltext.Location = new Point(241, 468);
            Fontstyltext.Name = "Fontstyltext";
            Fontstyltext.Size = new Size(449, 39);
            Fontstyltext.TabIndex = 1;
            // 
            // Delete
            // 
            Delete.BackColor = Color.PaleGoldenrod;
            Delete.Location = new Point(11, 833);
            Delete.Name = "Delete";
            Delete.Size = new Size(213, 66);
            Delete.TabIndex = 2;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // Config
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(706, 923);
            Controls.Add(visionVersion_combob);
            Controls.Add(Findinputbc);
            Controls.Add(TodoListColor);
            Controls.Add(TextColor);
            Controls.Add(Delete);
            Controls.Add(Create);
            Controls.Add(Update);
            Controls.Add(Apply);
            Controls.Add(label7);
            Controls.Add(Fontstyltext);
            Controls.Add(vision_Name);
            Controls.Add(BackColor1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Config";
            Text = "Config";
            Load += Config_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox BackColor1;
        private Label label6;
        private Button Apply;
        private TextBox TextColor;
        private TextBox TodoListColor;
        private TextBox Findinputbc;
        private Label label7;
        private ComboBox visionVersion_combob;
        private Label label8;
        private TextBox vision_Name;
        private Button Update;
        private Button Create;
        private TextBox Fontstyltext;
        private Button Delete;
    }
}