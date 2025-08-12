using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Text;
using ToDo.Data;
using ToDo.Properties;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;

namespace ToDo
{
    public partial class Form1 : Form
    {
        Config config;
        Random rndm = new Random();
        Panel panel2;
        Panel List_panel;
        List<Bitmap> circles = new List<Bitmap> { Resource.arrow__1_, Resource.arrow, Resource.marker, Resource.marker__1_ };
        public Form1()
        {
            InitializeComponent();
            //string[] vision_values = Vision_values();

            List_panel = new Panel();
            panel2 = new Panel();
            panel2.Controls.Clear();
            YenileForm(List_panel);
           
            //ListEt();

        }

        public async void YenileForm(Panel List_panel)
        {
            panel2.Controls.Clear();
            panel2.Dispose();

            using DataContext dataContext = new DataContext();

            Vision_table? sv = await dataContext.Vision.Where(table => table.IsSelected == true).FirstOrDefaultAsync();

            AdapterVision adapter = new AdapterVision(sv);

           s_add_text.Font = new System.Drawing.Font(VisionValuesClass.getfontstyle(), 14.875F, FontStyle.Italic);
            s_add_text.ForeColor = Color.FromArgb(VisionValuesClass.getvalues()[0][0], VisionValuesClass.getvalues()[0][1], VisionValuesClass.getvalues()[0][2], VisionValuesClass.getvalues()[0][3]);
            s_add_text.BackColor = Color.FromArgb(VisionValuesClass.getvalues()[3][1], VisionValuesClass.getvalues()[3][2], VisionValuesClass.getvalues()[3][3]);
            s_add_text.Location = new Point(573, 25);
            s_add_text.Multiline = true;
            s_add_text.Name = "s_add_text";
            s_add_text.Size = new Size(965, 50);
            s_add_text.TabIndex = 8;
            s_add_text.KeyUp += s_add_text_KeyUp;


            PictureBox con_button = new PictureBox();
            con_button.BackColor = Color.Transparent;
            con_button.Image = Properties.Resource.arrow__4_;
            con_button.Location = new Point(1702, 12);
            con_button.Name = "con_button";
            con_button.Size = new Size(73, 73);
            con_button.SizeMode = PictureBoxSizeMode.Zoom;
            con_button.TabIndex = 9;
            con_button.TabStop = false;
            con_button.Click += con_button_Click;
            // 
            // search_button
            // 

            PictureBox search_button = new PictureBox();
            search_button.BackColor = Color.Transparent;
            search_button.Image = Properties.Resource.arrow__5_;
            search_button.Location = new Point(1544, 12);
            search_button.Name = "search_button";
            search_button.Size = new Size(73, 73);
            search_button.SizeMode = PictureBoxSizeMode.Zoom;
            search_button.TabIndex = 10;
            search_button.TabStop = false;
            search_button.Click += search_button_Click;
            // 
            // add_button
            // 

            PictureBox add_button = new PictureBox();
            add_button.BackColor = Color.Transparent;
            add_button.Image = Properties.Resource.arrow__7_;
            add_button.Location = new Point(1623, 12);
            add_button.Name = "add_button";
            add_button.Size = new Size(73, 73);
            add_button.SizeMode = PictureBoxSizeMode.Zoom;
            add_button.TabIndex = 11;
            add_button.TabStop = false;
            add_button.Click += add_button_Click;

            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resource.todothed1_removebg_preview__1_;
            pictureBox1.Location = new Point(3, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(560, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;

            Panel panel1 = new Panel();
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Location = new Point(1, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(1781, 14);
            panel1.TabIndex = 1;

            List_panel.AutoScroll = true;
            List_panel.BackColor = Color.FromArgb(VisionValuesClass.getvalues()[1][0], VisionValuesClass.getvalues()[1][1], VisionValuesClass.getvalues()[1][2], VisionValuesClass.getvalues()[1][3]);
            List_panel.Location = new Point(26, 124);
            List_panel.Name = "List_panel";
            List_panel.Size = new Size(1760, 903);
            List_panel.TabIndex = 12;

            List_panel.Controls.Clear();
            using var db = new DataContext();
            var lists = await db.Todos.ToListAsync();

            int height = 10;
            IEnumerable<Todos_table> list1 = lists.Reverse<Todos_table>();
            int i = 0;
            foreach (var item in list1)
            {
                //
                //done_button
                //
                PictureBox donebutton = new PictureBox();
                donebutton.BackColor = Color.Transparent;
                donebutton.Image = circles[rndm.Next(0, 4)];
                donebutton.Location = new Point(1630, 7);
                donebutton.Name = $"done_button{item.Id}";
                donebutton.Size = new Size(73, 66);
                donebutton.SizeMode = PictureBoxSizeMode.Zoom;
                donebutton.TabIndex = 12;
                donebutton.TabStop = false;
                donebutton.Click += donebutton_Click;
                if (item.IsComplete) donebutton.Image = Properties.Resource.arrow__6_;
                // 
                // update_button
                // 
                PictureBox updatebutton = new PictureBox();
                updatebutton.BackColor = Color.Transparent;
                updatebutton.Image = Properties.Resource.arrow__3_;
                updatebutton.Location = new Point(85, 7);
                updatebutton.Name = "update_button";
                updatebutton.Size = new Size(73, 66);
                updatebutton.SizeMode = PictureBoxSizeMode.Zoom;
                updatebutton.TabIndex = 11;
                updatebutton.TabStop = false;
                updatebutton.Click += updatebutton_Click;
                // 
                // delete_button
                // 
                PictureBox deletebutton = new PictureBox();
                deletebutton.BackColor = Color.Transparent;
                deletebutton.Image = Properties.Resource.arrow__2_;
                deletebutton.Location = new Point(6, 7);
                deletebutton.Name = $"{i}";
                deletebutton.Size = new Size(73, 66);
                deletebutton.SizeMode = PictureBoxSizeMode.Zoom;
                deletebutton.TabIndex = 10;
                deletebutton.TabStop = false;
                deletebutton.Click += delete_button_Click;
                // 
                // todo_text
                // 
                TextBox todotext = new TextBox();
                todotext.BorderStyle = BorderStyle.None;
                todotext.Font = new System.Drawing.Font(VisionValuesClass.getfontstyle(), 13.875F, FontStyle.Regular, GraphicsUnit.Point, 162);
                todotext.Location = new Point(164, 16);
                todotext.Multiline = true;
                todotext.Name = "todotext";
                todotext.Text = item.ToDo;
                todotext.Size = new Size(1460, 50);
                todotext.TabIndex = 7;
                todotext.TextAlign = HorizontalAlignment.Left;
                todotext.ForeColor = Color.FromArgb(VisionValuesClass.getvalues()[0][0], VisionValuesClass.getvalues()[0][1], VisionValuesClass.getvalues()[0][2], VisionValuesClass.getvalues()[0][3]);
                todotext.BackColor = Color.FromArgb(VisionValuesClass.getvalues()[2][1], VisionValuesClass.getvalues()[2][2], VisionValuesClass.getvalues()[2][3]);
                todotext.KeyPress += text_KeyPress;

                if (item.IsComplete) todotext.ForeColor = Color.Silver;

                Panel panel = new Panel();
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Controls.Add(donebutton);
                panel.Controls.Add(updatebutton);
                panel.Controls.Add(deletebutton);
                panel.Controls.Add(todotext);
                panel.Location = new Point(10, height);
                panel.Name = $"{item.Id}";
                panel.Size = new Size(1708, 82);
                panel.TabIndex = 7;
                panel.BackColor = Color.FromArgb(VisionValuesClass.getvalues()[2][1], VisionValuesClass.getvalues()[2][2], VisionValuesClass.getvalues()[2][3]);
                List_panel.Controls.Add(panel);
                height += 92;
                i++;
            }

            panel2 = new Panel();
            panel2.BackColor = Color.FromArgb(VisionValuesClass.getvalues()[1][1], VisionValuesClass.getvalues()[1][2], VisionValuesClass.getvalues()[1][3]);
            //panel2.Controls.Add(List_panel);
            panel2.Controls.Add(con_button);
            panel2.Controls.Add(add_button);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(search_button);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(s_add_text);
            panel2.Controls.Add(List_panel);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1781, 1028);
            panel2.TabIndex = 14;

            this.Controls.Add(panel2);
        }


        public async void ListEt(string text = "")
        {
            List_panel.Controls.Clear();
            panel2.Controls.Remove(List_panel);
            Panel List_panel1 = new Panel();
            List_panel1.AutoScroll = true;
            List_panel1.BackColor = Color.FromArgb(VisionValuesClass.getvalues()[1][0], VisionValuesClass.getvalues()[1][1], VisionValuesClass.getvalues()[1][2], VisionValuesClass.getvalues()[1][3]);
            List_panel1.Location = new Point(0, 124);
            List_panel1.Name = "List_panel";
            List_panel1.Size = new Size(1786, 903);
            List_panel1.TabIndex = 12;
            using DataContext dataContext = new DataContext();

            using var db = new DataContext();
            var lists = await db.Todos.ToListAsync();
            if (text != "") lists = await db.Todos.Where(table => table.ToDo.Contains(text)).ToListAsync();
            int height = 10;
            IEnumerable<Todos_table> list1 = lists.Reverse<Todos_table>();
            int i = 0;
            foreach (var item in list1)
            {
                //
                //done_button
                //
                PictureBox donebutton = new PictureBox();
                donebutton.BackColor = Color.Transparent;
                donebutton.Image = circles[rndm.Next(0, 4)];
                donebutton.Location = new Point(1630, 7);
                donebutton.Name = $"done_button{item.Id}";
                donebutton.Size = new Size(73, 66);
                donebutton.SizeMode = PictureBoxSizeMode.Zoom;
                donebutton.TabIndex = 12;
                donebutton.TabStop = false;
                donebutton.Click += donebutton_Click;
                if (item.IsComplete) donebutton.Image = Properties.Resource.arrow__6_;

                // 
                // update_button
                // 
                PictureBox updatebutton = new PictureBox();
                updatebutton.BackColor = Color.Transparent;
                updatebutton.Image = Properties.Resource.arrow__3_;
                updatebutton.Location = new Point(85, 7);
                updatebutton.Name = "update_button";
                updatebutton.Size = new Size(73, 66);
                updatebutton.SizeMode = PictureBoxSizeMode.Zoom;
                updatebutton.TabIndex = 11;
                updatebutton.TabStop = false;
                updatebutton.Click += updatebutton_Click;
                // 
                // delete_button
                // 
                PictureBox deletebutton = new PictureBox();
                deletebutton.BackColor = Color.Transparent;
                deletebutton.Image = Properties.Resource.arrow__2_;
                deletebutton.Location = new Point(6, 7);
                deletebutton.Name = $"{i}";
                deletebutton.Size = new Size(73, 66);
                deletebutton.SizeMode = PictureBoxSizeMode.Zoom;
                deletebutton.TabIndex = 10;
                deletebutton.TabStop = false;
                deletebutton.Click += delete_button_Click;
                // 
                // todo_text
                // 
                TextBox todotext = new TextBox();
                todotext.BorderStyle = BorderStyle.None;
                todotext.Font = new System.Drawing.Font(VisionValuesClass.getfontstyle(), 13.875F, FontStyle.Regular, GraphicsUnit.Point, 162);
                todotext.Location = new Point(164, 16);
                todotext.Multiline = true;
                todotext.Name = "todotext";
                todotext.Text = item.ToDo;
                todotext.Size = new Size(1460, 50);
                todotext.TabIndex = 7;
                todotext.TextAlign = HorizontalAlignment.Left;
                todotext.ForeColor = Color.FromArgb(VisionValuesClass.getvalues()[0][0], VisionValuesClass.getvalues()[0][1], VisionValuesClass.getvalues()[0][2], VisionValuesClass.getvalues()[0][3]);
                todotext.BackColor = Color.FromArgb(VisionValuesClass.getvalues()[2][1], VisionValuesClass.getvalues()[2][2], VisionValuesClass.getvalues()[2][3]);
                todotext.KeyPress += text_KeyPress;

                if (item.IsComplete) todotext.ForeColor = Color.Silver;

                Panel panel = new Panel();
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Controls.Add(donebutton);
                panel.Controls.Add(updatebutton);
                panel.Controls.Add(deletebutton);
                panel.Controls.Add(todotext);
                panel.Location = new Point(10, height);
                panel.Name = $"{item.Id}";
                panel.Size = new Size(1708, 82);
                panel.TabIndex = 7;
                panel.BackColor = Color.FromArgb(VisionValuesClass.getvalues()[2][1], VisionValuesClass.getvalues()[2][2], VisionValuesClass.getvalues()[2][3]);
                List_panel.Controls.Add(panel);
                height += 92;
                i++;
            }
            panel2.Controls.Add(List_panel);

        }

        public async void Form1_Load(object sender, EventArgs e)
        {

        }
        private async void updatebutton_Click(object sender, EventArgs e)
        {
            using DataContext db = new DataContext();
            PictureBox btn = sender as PictureBox;
            Control panel = btn.Parent;
            int id = int.Parse(panel.Name);
            var todo = await db.Todos.Where(table => table.Id == id).FirstOrDefaultAsync();

            todo.DateTime = todo.DateTime;
            todo.IsComplete = todo.IsComplete;
            todo.ToDo = panel.Controls[3].Text;

            await db.SaveChangesAsync();

        }

        private async void text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //enter etdikde update etmesi ucun istifade edilen kod bloku
                using DataContext db = new DataContext();
                TextBox btn = sender as TextBox;
                Control panel = btn.Parent;
                StringBuilder text = new StringBuilder();
                foreach (char i in panel.Controls[3].Text.ToCharArray())
                {
                    if (i != '\r') text.Append(i);
                    else break;
                }
                int id = int.Parse(panel.Name);
                var todo = await db.Todos.Where(table => table.Id == id).FirstOrDefaultAsync();

                todo.DateTime = todo.DateTime;
                todo.IsComplete = todo.IsComplete;
                todo.ToDo = text.ToString();
                await db.SaveChangesAsync();
                btn.Text = text.ToString();
                btn.SelectionStart = text.Length;
            }
        }

        private async void add_button_Click(object sender, EventArgs e)
        {
            using DataContext db = new DataContext();
            Todos_table todos_Table = new Todos_table()
            {
                DateTime = DateTime.Now,
                IsComplete = false,
                ToDo = s_add_text.Text
            };

            db.Add<Todos_table>(todos_Table);
            await db.SaveChangesAsync();
            s_add_text.Text = "";
            //hereket etdir butun cedveli yenilemeden
            PictureBox pictureBox = sender as PictureBox;
            Control mainpanel = pictureBox.Parent;
            Control listpanel = mainpanel.Controls[6];

            foreach (Control panel1 in listpanel.Controls)
            {
                panel1.Location = new Point(10, panel1.Location.Y + 92);
                panel1.Controls[2].Name = $"{int.Parse(panel1.Controls[2].Name) + 1}";
            }

            #region panel yarat
            PictureBox donebutton = new PictureBox();
            donebutton.BackColor = Color.Transparent;
            donebutton.Image = circles[rndm.Next(0, 4)];
            donebutton.Location = new Point(1630, 7);
            donebutton.Name = $"done_button{0}";
            donebutton.Size = new Size(73, 66);
            donebutton.SizeMode = PictureBoxSizeMode.Zoom;
            donebutton.TabIndex = 12;
            donebutton.TabStop = false;
            donebutton.Click += donebutton_Click;

            // 
            // update_button
            // 
            PictureBox updatebutton = new PictureBox();
            updatebutton.BackColor = Color.Transparent;
            updatebutton.Image = Properties.Resource.arrow__3_;
            updatebutton.Location = new Point(85, 7);
            updatebutton.Name = "update_button";
            updatebutton.Size = new Size(73, 66);
            updatebutton.SizeMode = PictureBoxSizeMode.Zoom;
            updatebutton.TabIndex = 11;
            updatebutton.TabStop = false;
            updatebutton.Click += updatebutton_Click;
            // 
            // delete_button
            // 
            PictureBox deletebutton = new PictureBox();
            deletebutton.BackColor = Color.Transparent;
            deletebutton.Image = Properties.Resource.arrow__2_;
            deletebutton.Location = new Point(6, 7);
            deletebutton.Name = $"{0}";
            deletebutton.Size = new Size(73, 66);
            deletebutton.SizeMode = PictureBoxSizeMode.Zoom;
            deletebutton.TabIndex = 10;
            deletebutton.TabStop = false;
            deletebutton.Click += delete_button_Click;
            // 
            // todo_text
            // 
            TextBox todotext = new TextBox();
            todotext.BorderStyle = BorderStyle.None;
            todotext.Font = new System.Drawing.Font(VisionValuesClass.getfontstyle(), 13.875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            todotext.Location = new Point(164, 16);
            todotext.Multiline = true;
            todotext.Name = "todotext";
            todotext.Text = todos_Table.ToDo;
            todotext.Size = new Size(1460, 50);
            todotext.TabIndex = 7;
            todotext.TextAlign = HorizontalAlignment.Left;
            todotext.ForeColor = Color.FromArgb(VisionValuesClass.getvalues()[0][0], VisionValuesClass.getvalues()[0][1], VisionValuesClass.getvalues()[0][2], VisionValuesClass.getvalues()[0][3]);
            todotext.BackColor = Color.FromArgb(VisionValuesClass.getvalues()[2][1], VisionValuesClass.getvalues()[2][2], VisionValuesClass.getvalues()[2][3]);
            todotext.KeyPress += text_KeyPress;

            int id = await db.Todos.Select(t => t.Id).FirstOrDefaultAsync();
           
            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(donebutton);
            panel.Controls.Add(updatebutton);
            panel.Controls.Add(deletebutton);
            panel.Controls.Add(todotext);
            panel.Location = new Point(10, 10);
            panel.Name = $"{id}";
            panel.Size = new Size(1708, 82);
            panel.TabIndex = 7;
            panel.BackColor = Color.FromArgb(VisionValuesClass.getvalues()[2][1], VisionValuesClass.getvalues()[2][2], VisionValuesClass.getvalues()[2][3]);
            //önə əlavə edilməlidi

            listpanel.Controls.Add(panel);//bu paneli controls icinde axira atir
            #endregion



            //ListEt();

        }



        private async void donebutton_Click(object sender, EventArgs e)
        {
            PictureBox btn = sender as PictureBox;
            Control panel = btn.Parent;
            int id = int.Parse(panel.Name);


            using var db = new DataContext();

            var todos = db.Todos.Where(t => t.Id == id).FirstOrDefault();
            bool iscomplete = todos.IsComplete;


            if (!iscomplete)
            {
                btn.Image = Properties.Resource.arrow__6_;
                todos.IsComplete = true;
                panel.Controls[3].ForeColor = Color.Silver;
                panel.Controls[3].Font = new System.Drawing.Font(VisionValuesClass.getfontstyle(), 13.875F, FontStyle.Strikeout, GraphicsUnit.Point, 162);
            }
            else
            {
                btn.Image = circles[rndm.Next(0, 4)];
                todos.IsComplete = false;
                panel.Controls[3].ForeColor = Color.FromArgb(VisionValuesClass.getvalues()[0][0], VisionValuesClass.getvalues()[0][1], VisionValuesClass.getvalues()[0][2], VisionValuesClass.getvalues()[0][3]);
                panel.Controls[3].Font = new System.Drawing.Font(VisionValuesClass.getfontstyle(), 13.875F, FontStyle.Regular, GraphicsUnit.Point, 162);

            }

            //db.Database.ExecuteSql($"UPDATE [Todos] SET [IsComplete]='1' where [Id]={id}");
            //bu kod sql dilinde yazilib ancaq bu yazilis orm arxetekturasina yad olan tipdendir

            await db.SaveChangesAsync();

        }

        private async void delete_button_Click(object sender, EventArgs e)
        {
            //s_add_text;
            PictureBox btn = sender as PictureBox;
            Control panel = btn.Parent;
            Control panelList = panel.Parent;
            int id = int.Parse(panel.Name);
            using var db = new DataContext();
            var todos = await db.Todos.Where(table => table.Id == id).FirstOrDefaultAsync();
            db.Remove(todos);
            await db.SaveChangesAsync();
            ListEt();
        }

        //search function
        private void search_button_Click(object sender, EventArgs e)
        {
            //s_add_text;
            ListEt(s_add_text.Text);
        }
        private void s_add_text_KeyUp(object sender, KeyEventArgs e)
        {
            if (s_add_text.Text == "") ListEt();
            if (e.KeyValue == 13)
            {
                //enter eden zaman bu setrin asagi dusmesine mane olur

                StringBuilder text = new StringBuilder();
                foreach (char i in s_add_text.Text.ToCharArray())
                {
                    if (i != '\r') text.Append(i);
                    else break;
                }

                s_add_text.Text = text.ToString();
                s_add_text.SelectionStart = text.Length;
            }
        }

        private async void con_button_Click(object sender, EventArgs e)
        {
            using DataContext db = new DataContext();
            config = new Config();
            Vision_table? visiontable1 = await db.Vision.FirstOrDefaultAsync(t => t.IsSelected == true);
            config.ShowDialog();

            Vision_table? visiontable2 = await db.Vision.FirstOrDefaultAsync(t => t.IsSelected == true);

            if (visiontable1.Vision_Name != visiontable2.Vision_Name || visiontable1 is null)
            {
                panel2.Controls.Clear();
                this.Controls.Clear();
                List_panel = new Panel();
                panel2 = new Panel();
                YenileForm(List_panel);
            }
        }


    }
}
