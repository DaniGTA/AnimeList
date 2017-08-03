using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeList
{
    public partial class Option : Form
    {
        public int list_id = 0;
        public int current_table_config;
        private int item_counter = 0;
        string[] position_cache = new string[10];
        public int del_button_number = 0;
        public int add_button_position = 100;
        public bool check_category = false;
        public Form1 form_cache;
        public int rating_number=0;
        public Option(Form1 form)
        {
            
            list_id = form.list_id;
            InitializeComponent();
            form_cache = form;
            load_table_options();
            color_picker.Text = form.color_picker;
            rating.Text = form.rating_text;
            episode_counter.Text = form.counter_text;
            remove_table.Text = form.remove_table_text;
            rating_number_input.Text = rating_number.ToString();
            rating_chose.SelectedIndex = form.rating_mode;
            mal_warning.Text = form.mal_warning;
            mal_import_label.Text = form.mal_import_text;
            mal_import_1.Text = form.mal_import_1_text;
            mal_import_2.Text = form.mal_import_2_text;
            mal_import_3.Text = form.mal_import_3_text;
            mal_import_4.Text = form.mal_import_4_text;
            mal_import_6.Text = form.mal_import_6_text;

            rating_lable.Text = form.rating_setting_text;
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
            switch_table_options(false);
            rating_chose.Visible = true;
            if (rating_chose.SelectedIndex == 1)
            {
                rating_number_input.Visible = true;
            }
            rating_lable.Visible = true;
            add_category.Visible = true;
            category.Visible = true;
            check_category = true;
            try
            {
                foreach (string category in form_cache.Categorys)
                {
                    add_button_with_text(category);
                }
            }
            catch (NullReferenceException)
            {
            }

        }
        public void add_button_with_text(string text = "")
        {
            if (item_counter <= 6)
            {
                bool free_position = false;
                int free_position_button = 0;
                int free_position_textbox = 0;
                string[] one_time_use = new string[10];
                int counter_x = 0;

                foreach (string position in position_cache)
                {
                    try
                    {
                        if (position.Length == 0)
                        {

                        }
                        else
                        {
                            if (free_position)
                            {
                                one_time_use[counter_x] = position;
                            }
                            else
                            {
                                Debug.WriteLine("Freie plätze wurde geladen");
                                free_position = true;
                                string[] position_split = position.Split('|');
                                free_position_textbox = Int32.Parse(position_split[0]);
                                free_position_button = Int32.Parse(position_split[1]);
                            }
                        }
                    }
                    catch (NullReferenceException)
                    {
                        if (free_position)
                        {
                            one_time_use[counter_x] = position;
                        }
                    }
                    counter_x++;
                }
                position_cache = one_time_use;
                del_button_number++;
                item_counter++;
                Button del_button = new Button();
                del_button.Name = del_button_number.ToString();
                del_button.Text = "X";
                del_button.Visible = true;
                del_button.FlatStyle = FlatStyle.Flat;
                if (free_position)
                {
                    del_button.Location = new Point(free_position_button, 230);
                }
                else
                {
                    add_button_position = add_button_position + 100;
                    del_button.Location = new Point(100 + add_button_position, 230);
                }
                del_button.TabStop = false;
                del_button.FlatAppearance.BorderSize = 0;
                del_button.Height = 23;
                del_button.Width = 23;
                del_button.Click += new EventHandler(question_4_remove_content);
                this.Controls.Add(del_button);

                TextBox input_box = new TextBox();
                input_box.Width = 85;
                input_box.Height = 30;
                input_box.BorderStyle = BorderStyle.None;
                input_box.Visible = true;
                input_box.Name = "input_box_" + del_button_number.ToString();
                input_box.Text = text;
                if (free_position)
                {
                    input_box.Location = new Point(free_position_textbox, 235);
                }
                else
                {
                    input_box.Location = new Point(30 + add_button_position, 235);
                }
                this.Controls.Add(input_box);
            }
        }
        public void question_4_remove_content(object sender, EventArgs e)
        {

            TextBox tbx = this.Controls.Find("input_box_" + (sender as Button).Name, true).FirstOrDefault() as TextBox;
            tbx.Text = "";
            string[] one_use_cache = new string[10];
            item_counter--;
            int counter_x = 0;
            bool already_added = false;
            foreach (string position in position_cache)
            {
                try
                {
                    if (position.Length == 0)
                    {
                        one_use_cache[counter_x] = tbx.Location.X.ToString() + "|" + (sender as Button).Location.X.ToString();
                    }
                    else
                    {
                        one_use_cache[counter_x] = position;
                    }
                }
                catch (NullReferenceException)
                {
                    if (already_added) { }
                    else
                    {
                        already_added = true;
                        one_use_cache[counter_x] = tbx.Location.X.ToString() + "|" + (sender as Button).Location.X.ToString();
                    }
                }
                counter_x++;
            }
            position_cache = one_use_cache;
            this.Controls.Remove(tbx);
            this.Controls.Remove((sender as Button));
        }


        public void load_table_options()
        {
            int x = 0;
            table_options_panel.Controls.Clear();
            table_options_panel.Visible = true;
            while (x <= list_id)
            {
                Debug.WriteLine(list_id + "Add_Config_Btn" + x);
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
                } catch (NullReferenceException) { }
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
                case ("none"):
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
            color_picker.BackColor = colorDlg.Color;
        }
        private void switch_table_options(bool state)
        {
            if (form_cache.my_anime_list_login)
            {
                mal_warning.Visible = state;
                mal_import_label.Visible = state;
                mal_import_1.Visible = state;
                mal_import_2.Visible = state;
                mal_import_3.Visible = state;
                mal_import_4.Visible = state;
                mal_import_6.Visible = state;
            }
            anisearch_id_input.Visible = state;
            anisearch_id.Visible = state;
            table_title.Visible = state;
            color_picker.Visible = state;
            rating.Visible = state;
            episode_counter.Visible = state;
            remove_table.Visible = state;
            add_category.Visible = false;
            category.Visible = false;
            rating_number_input.Visible = false;
            rating_chose.Visible = false;
            rating_lable.Visible = false;
            if (state)
            {

            } else
            {
                current_table_config = -1;
            }
            remove_categorys();
        }

        private void table_title_TextChanged(object sender, EventArgs e)
        {
            Button button = form_cache.Controls.Find(current_table_config.ToString(), true).FirstOrDefault() as Button;
            DataGridView dgv = form_cache.Controls.Find("table_" + current_table_config.ToString(), true).FirstOrDefault() as DataGridView;
            Button button_2 = this.Controls.Find("options" + current_table_config.ToString(), true).FirstOrDefault() as Button;
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

        private void remove_table_Click(object sender, EventArgs e)
        {
            DataGridView dgv = form_cache.Controls.Find("table_" + current_table_config.ToString(), true).FirstOrDefault() as DataGridView;
            Button button = this.Controls.Find("options" + current_table_config.ToString(), true).FirstOrDefault() as Button;
            Button button_2 = this.Controls.Find("options" + current_table_config.ToString(), true).FirstOrDefault() as Button;
            form_cache.remove_button_from_panel(button);
            table_options_panel.Controls.Remove(button_2);
            form_cache.Controls.Remove(dgv);
            switch_table_options(false);
        }

        private void add_category_Click_1(object sender, EventArgs e)
        {
            add_button_with_text();
        }

        private void Option_FormClosing(object sender, FormClosingEventArgs e)
        {
            remove_categorys();
        }
        private void remove_categorys()
        {
            if (check_category)
            {
                check_category = false;
                int x = 0;
                List<string> category_list = new List<string>();
                while (x != del_button_number + 1)
                {
                    try
                    {
                        TextBox tbx = this.Controls.Find("input_box_" + x.ToString(), true).FirstOrDefault() as TextBox;
                        Button btn = this.Controls.Find(x.ToString(), true).FirstOrDefault() as Button;
                        try
                        {
                            if (tbx.Text.Length == 0)
                            {

                            }
                            else
                            {
                                Debug.WriteLine("add to list " + tbx.Text);
                                category_list.Add(tbx.Text);
                            }
                        }
                        catch (NullReferenceException)
                        {

                        }
                        this.Controls.Remove(tbx);
                        this.Controls.Remove(btn);
                    }
                    catch (NullReferenceException) { }
                    x++;
                }
                form_cache.Categorys = category_list.ToArray();
                position_cache = new string[10];
                item_counter = 0;
                del_button_number = 0;
                add_button_position = 100;
            }
        }

       
        public void mal_import(int status)
        {
            try
            {
                if (form_cache.my_anime_list_login)
                {
                    form_cache.is_loading = true;
                    int x = 0;
                    string[] table = mal_animelist_manager.get_table(status, form_cache.mal_username);
                    DataGridView dgv = form_cache.Controls.Find("table_" + current_table_config.ToString(), true).FirstOrDefault() as DataGridView;
                    try
                    {
                        dgv.Rows.Clear();
                    }
                    catch (NullReferenceException) { }

                    while (x <= table.Count())
                    {
                        try
                        {
                            string[] anime_info = table[x].Split('|');
                            dgv.Rows.Add();
                            Image img = mal_animelist_manager.get_image(anime_info[4]);
                            dgv.Rows[dgv.RowCount - 1].Cells[0].Value = img;
                            try
                            {
                                try
                                {
                                    img.Save(Path.Combine(form_cache.image_folder, form_cache.name_for_image(anime_info[2]) + ".png"), System.Drawing.Imaging.ImageFormat.Png);
                                }
                                catch (NotSupportedException) { }
                            }
                            catch (System.Runtime.InteropServices.ExternalException) { }
                            catch (NullReferenceException) { }

                            dgv.Rows[dgv.RowCount - 1].Cells[1].Value = anime_info[3];
                            try
                            {
                                if (form_cache.rating_mode == 1)
                                {
                                    dgv.Rows[dgv.RowCount - 1].Cells[2].Value = anime_info[2];
                                }
                            }
                            catch (IndexOutOfRangeException) { }
                            catch (NullReferenceException) { }
                            catch (ArgumentOutOfRangeException) { }
                        }
                        catch (IndexOutOfRangeException) { }
                        x++;
                    }
                    form_cache.is_loading = false;
                }
            }
            catch (NullReferenceException) { }
            form_cache.is_loading = false;
        }
        public void anisearch_import(int userid)
        {
            anisearch_manager.get_table(Int32.Parse(anisearch_id_input.Text));
            form_cache.is_loading = true;
            int x = 0;
            string[] table = anisearch_manager.get_table(Int32.Parse(anisearch_id_input.Text));
            DataGridView dgv = form_cache.Controls.Find("table_" + current_table_config.ToString(), true).FirstOrDefault() as DataGridView;
            try
            {
                dgv.Rows.Clear();
            }
            catch (NullReferenceException) { }

            while (x <= table.Count())
            {
                try
                {
                    string[] anime_info = table[x].Split('|');
                    dgv.Rows.Add();
                    Image img = mal_animelist_manager.get_image(anime_info[2]);
                    dgv.Rows[dgv.RowCount - 1].Cells[0].Value = img;
                    try
                    {
                        try
                        {
                            img.Save(Path.Combine(form_cache.image_folder, form_cache.name_for_image(anime_info[1]) + ".png"), System.Drawing.Imaging.ImageFormat.Png);
                        }
                        catch (NotSupportedException) { }
                    }
                    catch (System.Runtime.InteropServices.ExternalException) { }
                    catch (NullReferenceException) { }
                    dgv.Rows[dgv.RowCount - 1].Cells[1].Value = anime_info[1];
                }
                catch (IndexOutOfRangeException) { }
                x++;
            }
            form_cache.is_loading = false;
        }
        private void mal_import_1_Click(object sender, EventArgs e)
        {
            mal_import(1);
        }
        private void mal_import_2_Click(object sender, EventArgs e)
        {
            mal_import(2);
        }

        private void mal_import_3_Click(object sender, EventArgs e)
        {
            mal_import(3);
        }

        private void mal_import_4_Click(object sender, EventArgs e)
        {
            mal_import(4);
        }

        private void mal_import_6_Click(object sender, EventArgs e)
        {
            mal_import(6);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            anisearch_import(Int32.Parse(anisearch_id_input.Text));

        }

        private void rating_chose_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(rating_chose.SelectedIndex);
            if(rating_chose.SelectedIndex == 1)
            {
                rating_number_input.Visible = true;
            }
            else
            {
                rating_number_input.Visible = false;
            }
            form_cache.rating_mode = rating_chose.SelectedIndex;
        }

        private void rating_number_input_TextChanged(object sender, EventArgs e)
        {
            if(rating_number_input.TextLength == 0)
            {

            }
            else
            {
                try
                {
                    rating_number = Int32.Parse(rating_number_input.Text);
                }
                catch (FormatException)
                {
                    rating_number_input.Text = "10";
                }
            }
        }
    }
}
