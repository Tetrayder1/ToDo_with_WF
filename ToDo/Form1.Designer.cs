namespace ToDo
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
            panel1 = new Panel();
            s_add_text = new TextBox();
            con_button = new PictureBox();
            search_button = new PictureBox();
            add_button = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)con_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)search_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)add_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 0;
            // 
            // s_add_text
            // 
            s_add_text.Location = new Point(0, 0);
            s_add_text.Name = "s_add_text";
            s_add_text.Size = new Size(100, 39);
            s_add_text.TabIndex = 0;
            // 
            // con_button
            // 
            con_button.Location = new Point(0, 0);
            con_button.Name = "con_button";
            con_button.Size = new Size(100, 50);
            con_button.TabIndex = 0;
            con_button.TabStop = false;
            // 
            // search_button
            // 
            search_button.Location = new Point(0, 0);
            search_button.Name = "search_button";
            search_button.Size = new Size(100, 50);
            search_button.TabIndex = 0;
            search_button.TabStop = false;
            // 
            // add_button
            // 
            add_button.Location = new Point(0, 0);
            add_button.Name = "add_button";
            add_button.Size = new Size(100, 50);
            add_button.TabIndex = 0;
            add_button.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(1778, 1025);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)con_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)search_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)add_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TextBox s_add_text;
        private PictureBox con_button;
        private PictureBox search_button;
        private PictureBox add_button;
       
        private PictureBox pictureBox1;
    }
}
