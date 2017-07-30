using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeList
{
    public partial class Option : Form
    {
       public int list_id = 0;
       public int current_table_config;
       public Form1 form_cache;
       public Option(Form1 form)
        {
            list_id=form.list_id;
            InitializeComponent();
            form_cache = form;
            load_table_options();
            color_picker.Text = form.color_picker;
            rating.Text = form.rating_text;
            episode_counter.Text = form.counter_text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Debug.WriteLine("Close");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Debug.WriteLine("Close");
        }

        private void show_rating_option_Click(object sender, EventArgs e)
        {

        }
        public void load_table_options()
        {
            int x = 0;
            table_options_panel.Controls.Clear();
            table_options_panel.Visible = true;
            while (x <= list_id)
            {
                Debug.WriteLine(list_id + "Add_Config_Btn"+x);
                try
                {
                    Button button = form_cache.Controls.Find(x.ToString(), true).FirstOrDefault() as Button;
                    DataGridView dgv = form_cache.Controls.Find("table_" + x.ToString(), true).FirstOrDefault() as DataGridView;
                    Button btn = new Button();
                    btn.BackColor = Color.FromArgb(button.BackColor.ToArgb());
                    btn.ForeColor = Color.White;
                    btn.Text = button.Text;
                    btn.Name = "options" + x.ToString();
                    btn.Visible = true;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.TabStop = false;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Height = 23;
                    btn.Width = 150;
                    btn.Tag = dgv.Tag;
                    btn.Click += Btn_Click;
                    table_options_panel.Controls.Add(btn);
                }catch (NullReferenceException) { }
                x++;
            }
            Button button_2 = new Button();
            button_2.ForeColor = Color.White;
            button_2.Text = "new table";
            button_2.Name = "new_table";
            button_2.Visible = true;
            button_2.FlatStyle = FlatStyle.Flat;
            button_2.TabStop = false;
            button_2.FlatAppearance.BorderSize = 0;
            button_2.Height = 23;
            button_2.Width = 150;
            button_2.Click += Button_2_Click;
            table_options_panel.Controls.Add(button_2);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            current_table_config = Int32.Parse((sender as Button).Name.ToString().Replace("options", ""));
            switch_table_options(true);
            table_title.Text = (sender as Button).Text;
            rating.Checked = false;
            episode_counter.Checked = false;
            color_picker.BackColor = (sender as Button).BackColor;
            switch ((sender as Button).Tag.ToString())
            {
                case ("counter_rating"):
                    episode_counter.Checked = true;
                    rating.Checked = true;
                    break;
                case ("counter"):
                    episode_counter.Checked = true;
                    break;
                case ("rating"):
                    rating.Checked = true;
                    break;
                case("none"):
                    rating.Checked = false;
                    episode_counter.Checked = false;
                    break;
                default:
                    rating.Checked = false;
                    episode_counter.Checked = false;

                    break;
            }


        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            form_cache.new_table((sender as Button).Text);
            load_table_options();
            switch_table_options(false);
            list_id++;
        }

        private void color_picker_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AllowFullOpen = true;
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = true;
            colorDlg.ShowDialog();
            form_cache.colorchange(current_table_config, colorDlg.Color);
            Button button_2 = this.Controls.Find("options" + current_table_config.ToString(), true).FirstOrDefault() as Button;
            button_2.BackColor = colorDlg.Color;
            color_picker.BackColor= colorDlg.Color;
        }
        private void switch_table_options(bool state)
        {
            table_title.Visible = state;
            color_picker.Visible = state;
            rating.Visible = state;
            episode_counter.Visible = state;
            if (state)
            {

            }else
            {
                current_table_config = -1;
            }
        }

        private void table_title_TextChanged(object sender, EventArgs e)
        {
            Button button = form_cache.Controls.Find(current_table_config.ToString(), true).FirstOrDefault() as Button;
            DataGridView dgv = form_cache.Controls.Find("table_" + current_table_config.ToString(), true).FirstOrDefault() as DataGridView;
            Button button_2 = this.Controls.Find("options"+current_table_config.ToString(), true).FirstOrDefault() as Button;
            button.Text = table_title.Text;
            button_2.Text = table_title.Text;
        }

        private void episode_counter_CheckedChanged(object sender, EventArgs e)
        {
            refresh_checkbox_options();


        }
        private void rating_CheckedChanged(object sender, EventArgs e)
        {
            refresh_checkbox_options();
        }
        public void refresh_checkbox_options()
        {
            DataGridView dgv = form_cache.Controls.Find("table_" + current_table_config.ToString(), true).FirstOrDefault() as DataGridView;
            Button button = this.Controls.Find("options" + current_table_config.ToString(), true).FirstOrDefault() as Button;
            dgv.Tag = "none";
            if (rating.Checked)
            {
                dgv.Tag = "rating";
                button.Tag = "rating";
            }
            if (episode_counter.Checked)
            {
                dgv.Tag = "counter";
                button.Tag = "counter";
            }
            if (episode_counter.Checked && rating.Checked)
            {
                dgv.Tag = "counter_rating";
                button.Tag = "counter_rating";
            }
        }
        
    }
}
