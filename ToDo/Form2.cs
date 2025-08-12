using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDo.Data;

namespace ToDo
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        public async void Text_write(bool t = false)
        {
            //textbox larin daxilini db alinan melumatlarla doldurur

            using DataContext db = new DataContext();
            Vision_table? all_text = await db.Vision.Where(table => table.IsSelected == true).FirstOrDefaultAsync();
            if (all_text is not null)
            {
                if (t) visionVersion_combob.SelectedText = all_text.Vision_Name;
                BackColor1.Text = all_text.BackColor;
                TextColor.Text = all_text.TextColor;
                TodoListColor.Text = all_text.TodoListColor;
                Findinputbc.Text = all_text.FindInputBC;
                Fontstyltext.Text = all_text.FontStyle;
                vision_Name.Text = all_text.Vision_Name;
            }
            else
            {
                visionVersion_combob.Items.Clear();
                BackColor1.Text = "";
                TextColor.Text = "";
                TodoListColor.Text = "";
                Findinputbc.Text = "";
                Fontstyltext.Text = "";
                vision_Name.Text = "";
            }
        }

        public async void Vision_version_combobox()
        {
            visionVersion_combob.Items.Clear();
            //combox icini doldurur
            using DataContext db = new();
            List<string>? vision_version = await db.Vision.Select(table => table.Vision_Name).ToListAsync();
            if (vision_version.Count != 0) foreach (string item in vision_version) visionVersion_combob.Items.Add(item.ToString());

        }
    
        
        private async void Apply_Click(object sender, EventArgs e)
        {
            using DataContext db = new();
            string? vision_name = visionVersion_combob.SelectedItem.ToString();

            List<Vision_table> vision_s = await db.Vision.ToListAsync();

            if (vision_s is null) { MessageBox.Show("DataBase is empty."); return; }

            foreach (Vision_table? vision in vision_s) vision.IsSelected = vision.Vision_Name == vision_name ? true : false;

            Vision_table? sv = vision_s.Where(table => table.IsSelected == true).FirstOrDefault();

            AdapterVision adapter = new AdapterVision(sv);

            await db.SaveChangesAsync();

        }

   
        private async void Update_Click(object sender, EventArgs e)
        {
            using DataContext db = new();
            string vision_name = visionVersion_combob.SelectedItem.ToString();
            Vision_table? vision_s = await db.Vision.Where(table => table.Vision_Name == vision_name).FirstOrDefaultAsync();
            //vision name yoxlanmalidir
            List<string> vision_s_name = await db.Vision.Select(table => table.Vision_Name).ToListAsync();
            bool key = false;
            foreach (string item in vision_s_name)
            {
                if (item == vision_name)
                {
                    if (key)
                    {
                        MessageBox.Show("There is an element in the database with this name.");
                        return;
                    }
                    key = true;
                }
            }

            vision_s.BackColor = BackColor1.Text;
            vision_s.TextColor = TextColor.Text;
            vision_s.TodoListColor = TodoListColor.Text;
            vision_s.FindInputBC = Findinputbc.Text;
            vision_s.FontStyle = Fontstyltext.Text;
            vision_s.Vision_Name = vision_Name.Text;
            await db.SaveChangesAsync();
        }

        private async void Create_Click(object sender, EventArgs e)
        {
            using DataContext db = new();

            //vision name yoxlanmalidir
            List<string> vision_s_name = await db.Vision.Select(table => table.Vision_Name).ToListAsync();
            foreach (string item in vision_s_name)
            {
                if (item == vision_Name.Text)
                {
                    MessageBox.Show("There is an element in the database with this name.");
                    return;
                }
            }
            Vision_table vi_ta = new Vision_table()
            {
                BackColor = BackColor1.Text,
                TextColor = TextColor.Text,
                TodoListColor = TodoListColor.Text,
                FindInputBC = Findinputbc.Text,
                FontStyle = Fontstyltext.Text,
                Vision_Name = vision_Name.Text,
                IsSelected = false

            };

            db.Vision.Add(vi_ta);
            await db.SaveChangesAsync();
            Text_write();
            Vision_version_combobox();
        }

        private async void visionVersion_combob_SelectedIndexChanged(object sender, EventArgs e)
        {
            //burada secilen visionun deyerlerini ekrana cixardiriq
            string vision_name = visionVersion_combob.Text.ToString();
            using DataContext db = new DataContext();
            var all_text = await db.Vision.Where(table => table.Vision_Name == vision_name).FirstOrDefaultAsync();
            vision_Name.Text = all_text.Vision_Name;
            BackColor1.Text = all_text.BackColor;
            TextColor.Text = all_text.TextColor;
            TodoListColor.Text = all_text.TodoListColor;
            Findinputbc.Text = all_text.FindInputBC;
            Fontstyltext.Text = all_text.FontStyle;
        }

        private void Config_Load(object sender, EventArgs e)
        {
            visionVersion_combob.Items.Clear();
            BackColor1.Text = "";
            TextColor.Text = "";
            TodoListColor.Text = "";
            Findinputbc.Text = "";
            Fontstyltext.Text = "";
            vision_Name.Text = "";

            Vision_version_combobox();
            Text_write(true);
        }

        private async void Delete_Click(object sender, EventArgs e)
        {
            using DataContext db = new DataContext();
            string name = visionVersion_combob.Text == "" ? null : visionVersion_combob.Text;
            if (name is not null)
            {
                Vision_table? visionrow = await db.Vision.Where(table => table.Vision_Name == name).FirstOrDefaultAsync();
                if (visionrow != null)
                {
                    db.Vision.Remove(visionrow);
                    db.SaveChangesAsync();
                    MessageBox.Show("Delete is successful.");
                }
                
            }
            else MessageBox.Show("There is no name here.");
            visionVersion_combob.SelectedText = "";
            Text_write();
            Vision_version_combobox();
        }
    }
}
