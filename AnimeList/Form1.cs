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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Web;

namespace AnimeList
{
    public partial class Form1 : Form
    {
        public string authInfo;

        string[] position_cache = new string[10];
        public bool RefreshAutoCompleteIsNotRunning = true;
        public bool IsTypeing = false;
        public int list_id { get; set; } = 0;
        public int[] list_color;
        public bool MauseGedrückt = false;
        public int xLast;
        public int yLast;
        public int count;
        public string[] Categorys;
        public int item_counter = 0;
        public double gotaGoFast = 0;
        public int del_button_number = 0;
        public bool move_create_table_button_away = false;
        private int old_create_table_button_localtion_x;
        public int add_button_position = 0;
        private string anime_input_watermark_text;
        public bool my_anime_list_login = false;
        public AutoCompleteStringCollection AutoCompleteDataCollection;
        public bool anime_rating_mode = false;
        public bool currently_watching_list;
        public bool complete_list;
        public bool dropped__list;
        public bool plan_to_watch_list;
        public bool interface_loaded = false;
        private string folgen;
        private string a_type;
        private string beschreibung;
        private string Question_2;
        private string Question_3;
        private string Question_4;
        public string remove_table_text;
        private bool IsOnlineCheckActive;
        public string image_text;
        public bool is_loading = false;
        public string name_text;
        public Color global_background;
        public Color fore_background;
        public int rating_mode;
        public string move_to_text;
        public string color_picker;
        public string rating_text;
        public string counter_text;
        public string category_text;
        public string image_folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "table_images");
        public string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "table_config.cfg");
        public Form1()
        {
            InitializeComponent();
            close.TabStop = false;
            close.FlatStyle = FlatStyle.Flat;
            close.FlatAppearance.BorderSize = 0;
            global_background = Color.FromArgb(47, 50, 56);
            fore_background = Color.White;
            lang("ger");
            load();
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            MauseGedrückt = true;
            xLast = e.X;
            yLast = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            MauseGedrückt = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MauseGedrückt)
            {

                int newY = this.Top + (e.Y - yLast);
                int newX = this.Left + (e.X - xLast);

                this.Location = new Point(newX, newY);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lang(string lang)
        {

            switch (lang)
            {

                case "ger":
                    category_text = "kategorien";
                    remove_table_text = "Tabelle entfernen";
                    color_picker = "Farbe wählen";
                    rating_text = "Bewertungen ein/aus schalten für die Tabelle";
                    counter_text = "Folgen zähler ein/aus schalten für die Tabelle";
                    move_to_text = "verschieben nach";
                    name_text = "Name";
                    image_text = "Bild";
                    add_category.Text = "Neue kategorie hinzufügen";
                    add_category_finish.Text = "Kategorie auswahl abschließen";
                    finish_list_chooser.Text = "Fertig";
                    on_watching_list_label.Text = "Eine liste für Anime die man grad Guckt.";
                    Watched_list_label.Text = "Eine liste für geschaute Anime.";
                    cancel_tabel_label.Text = "Eine liste für Abgebrochene Anime.";
                    planning_table_label.Text = "Eine plan liste für Zukünftige Anime.";
                    finish_rating.Text = "Diese bewertung übernehemn";
                    thumbs_rating.Text = "Daumen hoch/runter Bewertung";
                    number_rating.Text = "Nummerrische Bewertung";
                    star_rating.Text = "5 Sterne bewertung ★★★★★";
                    Question_2 = "Wie möchtes du gerne deine Anime bewerten ?";
                    Question_3 = "Welche listen möchtes du haben";
                    Question_4 = "Welche kategorien möchtes du Bewerten ?";
                    folgen = "Folgen";
                    beschreibung = "Beschreibung";
                    a_type = "Type";
                    add_to_table_button.Text = "Zur Animeliste Hinzufügen";
                    starttitle.Text = "Erstelle deine Anime Tabelle";
                    button_false.Text = "Nein";
                    button_true.Text = "Ja";
                    create_table_button.Text = "Neue Tabelle Erstellen";
                    question_label.Text = "Willst du deine Anime Bewerten ?";
                    anime_input_watermark_text = "Füge hier dein Anime zur Liste hinzu";

                    break;

                default:
                    category_text = "Categorys";
                    remove_table_text = "remove table";
                    color_picker = "Color picker";
                    rating_text = "Rating on/off for the table";
                    counter_text = "episode counter for the table on/off";
                    move_to_text = "move to";
                    name_text = "Name";
                    image_text = "Image";
                    add_category.Text = "Add new category";
                    add_category_finish.Text = "Complete category selection";
                    finish_list_chooser.Text = "Finish";
                    on_watching_list_label.Text = "On watch list";
                    Watched_list_label.Text = "Watched list";
                    cancel_tabel_label.Text = "Dropped list";
                    planning_table_label.Text = "Plan to watch";
                    finish_rating.Text = "Choose this Rating methode";
                    thumbs_rating.Text = "Thumbs up/down rating";
                    number_rating.Text = "Number rating";
                    star_rating.Text = "5 Star rating ★★★★★";
                    Question_2 = "How do you wanna rate your Anime";
                    Question_3 = "Wath lists do you want";
                    Question_4 = "What catogorys do you wanna rate";
                    folgen = "Episodes";
                    beschreibung = "Discription";
                    a_type = "Type";
                    add_to_table_button.Text = "Add to Animelist";
                    starttitle.Text = "Make your Anime table";
                    button_false.Text = "No";
                    button_true.Text = "Yes";
                    create_table_button.Text = "Create new table";
                    question_label.Text = "Do you wanna rate your Anime ?";
                    anime_input_watermark_text = "Add your Anime here";

                    break;
            }

        }

        private void create_table_button_Click(object sender, EventArgs e)
        {
            move_create_table_button_away = true;
            count = create_table_button.Location.X;
            old_create_table_button_localtion_x = create_table_button.Location.X;
            timer1.Interval = 1;
            gotaGoFast = 0.01;
            timer1.Start();
            question_label.Visible = true;
            button_false.Visible = true;
            button_true.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (move_create_table_button_away)
            {
                if (this.Width > create_table_button.Location.X)
                {
                    create_table_button.Location = new Point(count, create_table_button.Location.Y);
                    count += Convert.ToInt32(gotaGoFast);
                    gotaGoFast += 0.50;


                }
                else
                {
                    create_table_button.Visible = false;
                    timer1.Stop();
                    create_table_button.Location = new Point(old_create_table_button_localtion_x, create_table_button.Location.Y);
                }
            }
        }

        private void button_true_Click(object sender, EventArgs e)
        {
            question_label.Visible = true;
            button_false.Visible = false;
            button_true.Visible = false;

            anime_rating_mode = true;

            star_rating.Visible = true;

            number_rating.Visible = true;

            thumbs_rating.Visible = true;
            question_label.Text = Question_2;
        }

        private void button_false_Click(object sender, EventArgs e)
        {
            question_label.Visible = false;
            button_false.Visible = false;
            button_true.Visible = false;
            add_to_table_button.Visible = true;
            question_3();
        }

        private void enable_anime_input()
        {
            add_to_table_button.Visible = true;
            anime_input.Visible = true;
            anime_input.Text = anime_input_watermark_text;
            anime_input.ForeColor = SystemColors.GrayText;
        }

        private void anime_input_MouseEnter(object sender, EventArgs e)
        {
            anime_input_focus_gain();
        }

        private void anime_input_MouseLeave(object sender, EventArgs e)
        {
            anime_input_focus_lose();
        }

        private void anime_input_Enter(object sender, EventArgs e)
        {
            anime_input_focus_gain();
        }

        private void anime_input_Leave(object sender, EventArgs e)
        {
            anime_input_focus_lose();
        }

        private void anime_input_focus_lose()
        {
            if (anime_input.TextLength == 0)
            {
                this.AcceptButton = null;
                anime_input.Text = anime_input_watermark_text;
                anime_input.ForeColor = SystemColors.GrayText;
            }
        }
        private void anime_input_focus_gain()
        {
            if (anime_input.Text == anime_input_watermark_text)
            {
                this.AcceptButton = add_to_table_button;
                anime_input.Text = "";
                anime_input.ForeColor = SystemColors.ButtonHighlight;
            }
        }

        private void anime_input_TextChanged(object sender, EventArgs e)
        {
            IsTypeing = true;
            string text = anime_input.Text;
            if (IsOnlineCheckActive)
            {
                Debug.WriteLine("OnlineRequest is Still running");
            }
            else
            {
                if (text != anime_input_watermark_text)
                {
                    if (anime_input.TextLength >= 3)
                    {
                        if (anime_input.TextLength >= 6)
                        {
                            try
                            {
                                Debug.WriteLine("Autocomplete count: " + AutoCompleteDataCollection.Count);
                                if (AutoCompleteDataCollection.Count == 1)
                                {
                                    Debug.WriteLine("Dont refresh AutoComplete");
                                }
                                else
                                {
                                    anime_input.AutoCompleteCustomSource = AutoCompleteDataCollection;
                                    Debug.WriteLine(text);
                                    Thread t = new Thread(() => AutoCompleteThread(text, anime_input_watermark_text));
                                    t.Start();
                                }
                            }
                            catch (NullReferenceException) { }
                        }
                        else
                        {
                            Debug.WriteLine(text);
                            Thread t = new Thread(() => AutoCompleteThread(text, anime_input_watermark_text));
                            t.Start();
                        }
                    }
                }
            }
            if (RefreshAutoCompleteIsNotRunning)
            {
                Thread t_2 = new Thread(() => RefreshAutoComplete(sender));
                t_2.Start();
            }
            IsTypeing = false;
        }
        public void RefreshAutoComplete(object sender)
        {
            RefreshAutoCompleteIsNotRunning = false;
            Thread.Sleep(750);
            if (IsTypeing) { }
            else
            {
                try
                {
                    this.anime_input.BeginInvoke((MethodInvoker)delegate ()
                    {

                        anime_input.AutoCompleteCustomSource = AutoCompleteDataCollection;
                    });
                }
                catch (InvalidOperationException) { }
            }
            RefreshAutoCompleteIsNotRunning = true;
        }
        public void AutoCompleteThread(string text, string watermark_text)
        {
            this.IsOnlineCheckActive = true;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            addItems(DataCollection, text, watermark_text);
            this.AutoCompleteDataCollection = DataCollection;
            this.IsOnlineCheckActive = false;

        }
        public void addItems(AutoCompleteStringCollection col, string text, string watermark_text)
        {
            if (text != watermark_text)
            {
                if (my_anime_list_login)
                {
                    string url = "https://myanimelist.net/api/anime/search.xml?q=" + text;
                    Debug.WriteLine(url);
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                    request.Timeout = 5000;
                    request.Headers["Authorization"] = "Basic " + authInfo;
                    try
                    {
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                        Stream resStream = response.GetResponseStream();
                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            Stream receiveStream = response.GetResponseStream();
                            StreamReader readStream = null;

                            if (response.CharacterSet == null)
                            {
                                readStream = new StreamReader(receiveStream);
                            }
                            else
                            {
                                readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                            }
                            string data = readStream.ReadToEnd();
                            Regex regex = new Regex(@"<entry>([\s\S]*?)\<\/entry>");
                            Debug.WriteLine("GetData");
                            bool pic_reset = true;
                            foreach (Match match in regex.Matches(data))
                            {
                                Regex title = new Regex(@"<title>([\s\S]*?)\<\/title>");
                                Match match_title = title.Match(match.Value);
                                if (match_title.Success)
                                {
                                    col.Add(match_title.Groups[1].Value);
                                    Debug.WriteLine(match_title.Groups[1].Value + " Added to AutoComplete");
                                    Regex eng_title = new Regex(@"<english>([\s\S]*?)\<\/english>");
                                    Match eng_title_match = eng_title.Match(match.Value);
                                    if (match_title.Groups[1].Value.ToUpper() != eng_title_match.Groups[1].Value.ToUpper())
                                    {
                                        if (eng_title_match.Groups[1].Value.ToString().Trim().Count() != 0)
                                        {
                                            col.Add(eng_title_match.Groups[1].Value);
                                        }
                                    }
                                    if (match_title.Groups[1].Value.ToUpper() == text.ToUpper() || eng_title_match.Groups[1].Value.ToUpper() == text.ToUpper())
                                    {
                                        pic_reset = false;
                                        this.anime_pic_preview.BeginInvoke((MethodInvoker)delegate ()
                                        {
                                            Regex image = new Regex(@"<image>([\s\S]*?)\<\/image>");
                                            Match match_image = image.Match(match.Value);
                                            this.anime_pic_preview.Visible = true;
                                            this.anime_pic_preview.Load(match_image.Groups[1].Value);
                                            ;
                                        });

                                        this.anime_ep.BeginInvoke((MethodInvoker)delegate ()
                                        {
                                            Regex episodes = new Regex(@"<episodes>([\s\S]*?)\<\/episodes>");
                                            Match match_episodes = episodes.Match(match.Value);
                                            this.anime_ep.Text = folgen + ": " + match_episodes.Groups[1].Value;
                                            ;
                                        });
                                        this.anime_type.BeginInvoke((MethodInvoker)delegate ()
                                        {
                                            Regex type = new Regex(@"<type>([\s\S]*?)\<\/type>");
                                            Match match_type = type.Match(match.Value);
                                            this.anime_type.Text = a_type + ": " + match_type.Groups[1].Value;
                                            ;
                                        });
                                        this.anime_description.BeginInvoke((MethodInvoker)delegate ()
                                        {
                                            Regex synopsis = new Regex(@"<synopsis>([\s\S]*?)\<\/synopsis>");
                                            Match match_synopsis = synopsis.Match(match.Value);
                                            this.anime_description.Text = beschreibung + ": " + WebUtility.HtmlDecode(match_synopsis.Groups[1].Value);
                                            ;
                                        });
                                    }
                                    else
                                    {
                                        if (pic_reset)
                                        {
                                            this.anime_pic_preview.BeginInvoke((MethodInvoker)delegate ()
                                            {
                                                this.anime_pic_preview.Visible = false;
                                                ;
                                            });
                                            this.anime_ep.BeginInvoke((MethodInvoker)delegate ()
                                            {
                                                this.anime_ep.Text = "";
                                                ;
                                            });
                                            this.anime_type.BeginInvoke((MethodInvoker)delegate ()
                                            {
                                                this.anime_type.Text = "";
                                                ;
                                            });
                                            this.anime_description.BeginInvoke((MethodInvoker)delegate ()
                                            {
                                                this.anime_description.Text = "";
                                                ;
                                            });
                                        }
                                    }

                                }
                                else
                                {
                                    Debug.WriteLine("RegExError");
                                }

                            }
                            response.Close();
                            readStream.Close();

                        }
                    }
                    catch (System.Net.WebException e)
                    {
                        Debug.WriteLine(e);
                    }
                    /*Regex regex = new Regex(@"\d+");
                    Match match = regex.Match("Dot 55 Perls");
                    if (match.Success)
                    {
                        Debug.WriteLine(match.Value);
                    }*/
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mal_login mal_login_form = new mal_login();
            mal_login_form.StartPosition = FormStartPosition.CenterParent;
            this.Visible = false;
            mal_login_form.ShowDialog();
            authInfo = mal_login_form.authInfo;
            my_anime_list_login = mal_login_form.mal_logged_in;
            if (my_anime_list_login)
            {
                mal_username_label.Text = mal_login_form.username + " |";
            }
            this.Visible = true;
        }

        private void anime_type_Click(object sender, EventArgs e)
        {

        }

        private void open_options_Click(object sender, EventArgs e)
        {

                Option options_form = new Option(this);
                options_form.list_id = list_id;
                options_form.StartPosition = FormStartPosition.CenterParent;
                options_form.ShowDialog();
                list_id = options_form.list_id;
                unload();
                load();

        }

        //Question 2 Begin
        private void star_rating_CheckedChanged(object sender, EventArgs e)
        {
            if (star_rating.Checked)
            {

                number_rating.Checked = false;
                thumbs_rating.Checked = false;
                finish_rating.Visible = true;
            }
            else
            {
                if (star_rating.Checked || thumbs_rating.Checked || number_rating.Checked) { } else { finish_rating.Visible = false; }
            }
        }

        private void thumbs_rating_CheckedChanged(object sender, EventArgs e)
        {
            if (thumbs_rating.Checked)
            {
                number_rating.Checked = false;
                star_rating.Checked = false;
                finish_rating.Visible = true;
            }
            else
            {
                if (star_rating.Checked || thumbs_rating.Checked || number_rating.Checked) { } else { finish_rating.Visible = false; }
            }
        }
        private void number_rating_CheckedChanged(object sender, EventArgs e)
        {
            if (number_rating.Checked)
            {
                star_rating.Checked = false;
                thumbs_rating.Checked = false;
                finish_rating.Visible = true;
                number_input.Visible = true;
            }
            else
            {
                number_input.Visible = false;

                if (star_rating.Checked || thumbs_rating.Checked || number_rating.Checked) { } else { finish_rating.Visible = false; }
            }
        }
        //Finish Question 2
        private void finish_rating_Click(object sender, EventArgs e)
        {
            try
            {
                Int32.Parse(number_input.Text);
                if (number_rating.Checked)
                {
                    rating_mode = 1;
                }
                if (star_rating.Checked)
                {
                    rating_mode = 2;
                }
                if (thumbs_rating.Checked)
                {
                    rating_mode = 3;
                }
                finish_rating.Visible = false;
                star_rating.Visible = false;
                number_rating.Visible = false;
                thumbs_rating.Visible = false;
                finish_rating.Visible = false;
                number_input.Visible = false;
                question_3();
            }
            catch (NullReferenceException)
            {

            }
            catch (System.FormatException)
            {
                number_input.Text = "10";
            }
        }
        private void move_table_interface(bool state, string text = "")
        {
            if (state)
            {
                int x = 0;
                move_anime_panel.Controls.Clear();
                while (x <= list_id)
                {
                    try
                    {
                        Button bt = this.Controls.Find(x.ToString(), true).FirstOrDefault() as Button;
                        DataGridView dgv = this.Controls.Find("table_" + x.ToString(), true).FirstOrDefault() as DataGridView;
                        if (!dgv.Visible)
                        {
                            Button btn = new Button();
                            btn.Text = text + " " + move_to_text + " " + bt.Text;
                            btn.Name = bt.Text;
                            btn.BackColor = Color.FromArgb(bt.BackColor.R, bt.BackColor.G, bt.BackColor.B);
                            btn.Visible = true;
                            btn.Width = 200;
                            btn.FlatStyle = FlatStyle.Flat;
                            btn.TabStop = false;
                            btn.Click += Btn_Click;
                            move_anime_panel.Controls.Add(btn);
                        }

                    }
                    catch (NullReferenceException) { }
                    x++;
                }
            }
            move_to_table_text.Visible = state;
            move_anime_panel.Visible = state;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int x = 0;
            while (x <= list_id)
            {
                try
                {
                    Button bt = this.Controls.Find(x.ToString(), true).FirstOrDefault() as Button;
                    DataGridView dgv = this.Controls.Find("table_" + x.ToString(), true).FirstOrDefault() as DataGridView;
                    if (dgv.Visible)
                    {
                        int x_2 = 0;
                        while (x_2 <= list_id)
                        {
                            try {
                                Button btn = this.Controls.Find(x_2.ToString(), true).FirstOrDefault() as Button;
                                if (btn.Text == (sender as Button).Name)
                                {
                                    DataGridView target = this.Controls.Find("table_" + x_2.ToString(), true).FirstOrDefault() as DataGridView;
                                    target.Rows.Add(dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value, dgv.Rows[dgv.SelectedRows[0].Index].Cells[1].Value.ToString());
                                    dgv.Rows[dgv.SelectedRows[0].Index].Dispose();
                                    dgv.Rows.RemoveAt(dgv.SelectedRows[0].Index);
                                    Debug.WriteLine("Ausgwähltes objekt wurde verschoben");
                                }
                            } catch (NullReferenceException) { }
                            x_2++;
                        }
                        x = list_id;
                    }
                }
                catch (NullReferenceException) { }
                x++;
            }
        }

        private void number_input_TextChanged(object sender, EventArgs e)
        {
            move_table_interface(false);
            if (number_input.TextLength == 0)
            {
                finish_rating.Visible = false;


            }
            else
            {
                int output_int;
                bool isNumber = int.TryParse(number_input.Text, out output_int);
                if (isNumber)
                {
                    finish_rating.Visible = true;
                }
                else
                {
                    finish_rating.Visible = false;
                }
            }
        }
        //Question 2 End
        private void question_3()
        {
            question_label.Visible = false;
            starttitle.Text = Question_3;
            on_watching_list_label.Visible = true;
            Watched_list_label.Visible = true;
            cancel_tabel_label.Visible = true;
            planning_table_label.Visible = true;
            on_watching_list.Visible = true;
            Watched_list.Visible = true;
            cancel_tabel_pic.Visible = true;
            planning_table.Visible = true;
            finish_list_chooser.Visible = true;
            Watched_list_true_image.Visible = true;
            on_watching_true_image.Visible = true;
            cancel__table_true_image.Visible = true;
            planning_table_true_image.Visible = true;
        }

        private void finish_list_chooser_Click(object sender, EventArgs e)
        {
            if (anime_rating_mode)
            {
                question_4();
            }
            else
            {
                create_table();
            }
            finish_list_chooser.Visible = false;
            on_watching_list_label.Visible = false;
            Watched_list_label.Visible = false;
            cancel_tabel_label.Visible = false;
            planning_table_label.Visible = false;
            on_watching_list.Visible = false;
            Watched_list.Visible = false;
            cancel_tabel_pic.Visible = false;
            planning_table.Visible = false;
            if (on_watching_true_image.Visible)
            {
                currently_watching_list = true;
            }
            else
            {
                currently_watching_list = false;
            }
            on_watching_true_image.Visible = false;

            if (Watched_list_true_image.Visible)
            {
                complete_list = true;
            }
            else
            {
                complete_list = false;
            }
            Watched_list_true_image.Visible = false;

            if (cancel__table_true_image.Visible)
            {
                dropped__list = true;

            }
            else
            {
                dropped__list = false;
            }
            cancel__table_true_image.Visible = false;

            if (planning_table_true_image.Visible)
            {
                plan_to_watch_list = true;
            }
            else
            {
                plan_to_watch_list = false;
            }
            planning_table_true_image.Visible = false;
        }

        private void on_watching_list_Click(object sender, EventArgs e)
        {
            if (on_watching_true_image.Visible)
            {
                on_watching_true_image.Visible = false;
            }
            else
            {
                on_watching_true_image.Visible = true;
            }
        }

        private void Watched_list_Click(object sender, EventArgs e)
        {
            if (Watched_list_true_image.Visible)
            {
                Watched_list_true_image.Visible = false;
            }
            else
            {
                Watched_list_true_image.Visible = true;
            }
        }

        private void cancel_tabel_pic_Click(object sender, EventArgs e)
        {
            if (cancel__table_true_image.Visible)
            {
                cancel__table_true_image.Visible = false;

            }
            else
            {
                cancel__table_true_image.Visible = true;
            }
        }

        private void planning_table_Click(object sender, EventArgs e)
        {
            if (planning_table_true_image.Visible)
            {
                planning_table_true_image.Visible = false;
            }
            else
            {
                planning_table_true_image.Visible = true;
            }
        }

        private void planning_table_true_image_Click(object sender, EventArgs e)
        {
            if (planning_table_true_image.Visible)
            {
                planning_table_true_image.Visible = false;
            }
            else
            {
                planning_table_true_image.Visible = true;
            }
        }

        private void cancel__table_true_image_Click(object sender, EventArgs e)
        {
            if (cancel__table_true_image.Visible)
            {
                cancel__table_true_image.Visible = false;

            }
            else
            {
                cancel__table_true_image.Visible = true;
            }
        }

        private void Watched_list_true_image_Click(object sender, EventArgs e)
        {
            if (Watched_list_true_image.Visible)
            {
                Watched_list_true_image.Visible = false;
            }
            else
            {
                Watched_list_true_image.Visible = true;
            }
        }

        private void on_watching_true_image_Click(object sender, EventArgs e)
        {
            if (on_watching_true_image.Visible)
            {
                on_watching_true_image.Visible = false;
            }
            else
            {
                on_watching_true_image.Visible = true;
            }
        }

        private void question_4()
        {
            add_button_with_text("Score");
            starttitle.Text = Question_4;
            add_category.Visible = true;
            add_category_finish.Visible = true;
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

        private void add_category_Click(object sender, EventArgs e)
        {
            add_button_with_text();
        }

        private void add_category_finish_Click(object sender, EventArgs e)
        {
            del_button_number++;
            add_category.Visible = false;
            add_category_finish.Visible = false;
            int x = 0;
            List<string> category_list = new List<string>();
            while (x != del_button_number)
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
            Categorys = category_list.ToArray();
            create_table();
        }

        private void create_table()
        {
            if (complete_list)
            {
                new_table("Completed", 51, 130, 28, true);
            }
            if (currently_watching_list)
            {
                new_table("Currently Watching", 159, 86, 19);
            }
            if (dropped__list)
            {
                new_table("Dropped", 119, 17, 35);
            }
            if (plan_to_watch_list)
            {
                new_table("Plan to watch", 20, 34, 73);
            }

            starttitle.Visible = false;
            question_label.Visible = false;
            button_false.Visible = false;
            button_true.Visible = false;
            add_to_table_button.Visible = true;
            enable_anime_input();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void new_table(string name = "", int r = 0, int g = 0, int b = 0, bool rating = false, bool counter = false)
        {
            Button button = new Button();
            button.Name = list_id.ToString();
            button.Text = name;
            button.BackColor = Color.FromArgb(r, g, b);
            button.Visible = true;
            button.FlatStyle = FlatStyle.Flat;
            button.TabStop = false;
            button.FlatAppearance.BorderSize = 0;
            button.Height = 23;
            button.Width = 75;
            button.Top = 0;
            button.AutoSize = true;
            button.Click += new EventHandler(change_table);


            flowLayoutPanel1.Controls.Add(button);
            DataGridView table = new DataGridView();
            table.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(r, g, b);

            DataGridViewImageColumn iconColumn = new DataGridViewImageColumn();
            iconColumn.Name = image_text;
            iconColumn.HeaderText = image_text;
            iconColumn.FillWeight = 10;
            iconColumn.Resizable = DataGridViewTriState.False;
            iconColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            iconColumn.MinimumWidth = 10;
            iconColumn.DefaultCellStyle.NullValue = null;
            iconColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            table.Columns.Insert(0, iconColumn);
            table.AllowUserToAddRows = false;
            table.Columns.Add(name_text, name_text);
            table.BorderStyle = BorderStyle.FixedSingle;
            table.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            table.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(r, g, b);
            table.ColumnHeadersDefaultCellStyle.ForeColor = fore_background;
            table.DefaultCellStyle.BackColor = global_background;
            table.DefaultCellStyle.ForeColor = fore_background;
            table.EnableHeadersVisualStyles = false;
            table.BackgroundColor = global_background;
            table.Name = "table_" + list_id;
            if (rating)
            {
                table.Tag = "rating";
            }
            else
            {
                table.Tag = "none";
            }
            if (counter)
            {
                table.Tag = "counter";
            }
            if (rating && counter)
            {
                table.Tag = "counter_rating";
            }
            table.Height = 350;
            table.Width = 688;
            table.DefaultCellStyle.SelectionBackColor = Color.Black;
            table.DefaultCellStyle.SelectionForeColor = Color.White;
            table.MultiSelect = false;
            table.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            table.RowHeadersVisible = false;
            table.RowHeadersDefaultCellStyle.BackColor = global_background;
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            table.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            table.Location = new Point(12, 85);
            table.CellValueChanged += Table_CellValueChanged1;
            table.SelectionChanged += Table_SelectionChanged;
            table.MouseClick += Table_MouseClick;
            this.Controls.Add(table);
            try
            {
                var list = new List<int>(list_color);
                list.Add(Color.FromArgb(r, g, b).ToArgb());
                list_color = list.ToArray();
            }
            catch (ArgumentNullException)
            {
                var list = new List<int>();
                list.Add(Color.FromArgb(r, g, b).ToArgb());
                list_color = list.ToArray();
            }
            if (rating)
            {
                int x = 2;
                try
                {
                    foreach (string category in Categorys)
                    {
                        try
                        {
                            if (category.Length != 0)
                            {

                                if (rating_mode == 1)
                                {
                                    Debug.WriteLine("add textrow " + category);
                                    table.Columns.Add(category, category);
                                }
                                if (rating_mode == 2)
                                {
                                    DataGridViewComboBoxColumn combobox = new DataGridViewComboBoxColumn();
                                    combobox.Name = category;
                                    combobox.HeaderText = category;
                                    combobox.Resizable = DataGridViewTriState.False;
                                    combobox.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                    combobox.FlatStyle = FlatStyle.Flat;
                                    combobox.Width = 10;
                                    combobox.DefaultCellStyle.NullValue = null;
                                    combobox.Items.Add("★");
                                    combobox.Items.Add("★★");
                                    combobox.Items.Add("★★★");
                                    combobox.Items.Add("★★★★");
                                    combobox.Items.Add("★★★★★");
                                    table.Columns.Insert(2, combobox);
                                    Debug.WriteLine("add comborow " + category);
                                }
                                if (rating_mode == 3)
                                {
                                    DataGridViewComboBoxColumn combobox = new DataGridViewComboBoxColumn();
                                    combobox.Name = category;
                                    combobox.HeaderText = category;
                                    combobox.Resizable = DataGridViewTriState.False;
                                    combobox.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                    combobox.FlatStyle = FlatStyle.Flat;
                                    combobox.DefaultCellStyle.NullValue = null;
                                    combobox.Items.Add("👍");
                                    combobox.Items.Add("👎");
                                    table.Columns.Insert(2, combobox);
                                    Debug.WriteLine("add comborow " + category);
                                }


                                x++;
                            }
                        }
                        catch (NullReferenceException) { }
                    }
                }
                catch (NullReferenceException) { }
            }
            list_id++;
        }

        private void Table_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = (sender as DataGridView).HitTest(e.X, e.Y).RowIndex;
                (sender as DataGridView).CurrentCell = (sender as DataGridView).Rows[(sender as DataGridView).HitTest(e.X, e.Y).RowIndex].Cells[(sender as DataGridView).HitTest(e.X, e.Y).ColumnIndex];
                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem("Delete", del_row));
                }

                m.Show((sender as DataGridView), new Point(e.X, e.Y));
            }
        }
        private void del_row(Object sender, System.EventArgs e)
        {
            int x = 0;
            while (x <= list_id)
            {
                try
                {
                    Button bt = this.Controls.Find(x.ToString(), true).FirstOrDefault() as Button;
                    DataGridView dgv = this.Controls.Find("table_" + x.ToString(), true).FirstOrDefault() as DataGridView;
                    if (dgv.Visible)
                    {

                        dgv.Rows.RemoveAt(dgv.SelectedRows[0].Index);
                        x = list_id;
                        save();
                    }


                }
                catch (NullReferenceException) { }
                x++;
            }
        }
        private void Table_SelectionChanged(object sender, EventArgs e)
        {

           switch((sender as DataGridView).Tag.ToString())
            {
                case ("none"):
                    try
                    {
                        move_table_interface(true, (sender as DataGridView).Rows[(sender as DataGridView).SelectedRows[0].Index].Cells[1].Value.ToString());
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        move_table_interface(false);
                    }
                    catch (NullReferenceException) { }
                    break;
                default:
                    move_table_interface(false);
                    break;
            }
        }

        private void Table_CellValueChanged1(object sender, DataGridViewCellEventArgs e)
        {
            if ((sender as DataGridView).Columns[e.ColumnIndex].HeaderText == name_text)
            {
            }
            if ((sender as DataGridView).ColumnCount > 2)
            {
                Debug.WriteLine("Enter Column check " + e.ColumnIndex);
                if (e.ColumnIndex >= 2)
                {
                    Debug.WriteLine("Checking rating mode");
                    if (rating_mode == 1)
                    {
                        try
                        {
                            int cache = Int32.Parse((sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                            Debug.WriteLine("Checking number complete");
                            if (cache <= Int32.Parse(number_input.Text))
                            {
                                Debug.WriteLine("All OK");

                            }
                            else
                            {
                                (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = number_input.Text;
                            }
                        }
                        catch (NullReferenceException)
                        {

                        }
                        catch (System.FormatException)
                        {
                            (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                        }
                    }
                    if (rating_mode == 2 || rating_mode == 3)
                    {
                        Debug.WriteLine("Save");

                    }
                }
                else
                {
                    try
                    {
                        if (e.ColumnIndex == 1)
                        {
                            if ((sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Contains('|'))
                            {
                                (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Replace('|', ' ').Trim();
                            }
                            else
                            {
                                if (mal_get_image((sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) == "found") {
                                    (sender as DataGridView).Rows[e.RowIndex].Cells[0].Value = anime_pic_preview.Image;
                                    anime_pic_preview.Image = null;
                                }
                                else
                                {
                                    (sender as DataGridView).Rows[e.RowIndex].Cells[0].Value = null;
                                }
                                save();
                            }
                        }
                    }
                    catch (NullReferenceException) { }
                }
            }
            else
            {
                Debug.WriteLine((sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            }
            save();
        }

        private void add_to_table_button_Click(object sender, EventArgs e)
        {
            try
            {
                int x = 0;
                while (x <= list_id)
                {
                    try
                    {

                            DataGridView dgv = this.Controls.Find("table_" + x.ToString(), true).FirstOrDefault() as DataGridView;
                            if (dgv.Visible)
                            {
                                if (anime_input.Text.Length == 0) { }
                                else
                                {
                                    if (anime_input.Text != anime_input_watermark_text)
                                    {
                                        if (anime_pic_preview.Image == null)
                                        {
                                            dgv.Rows.Add(null, anime_input.Text);
                                        }
                                        else
                                        {
                                            dgv.Rows.Add(anime_pic_preview.Image, anime_input.Text);
                                        }
                                    }
                                }

                        }
                    }
                    catch (NullReferenceException) { }
                    x++;
                }
            }
            catch (NullReferenceException) { }
            save();
        }
        public void change_table(object sender, EventArgs e)
        {

            move_table_interface(false);
            add_to_table_button.BackColor = Color.FromArgb((sender as Button).BackColor.ToArgb());
            DataGridView dgv = this.Controls.Find("table_" + (sender as Button).Name, true).FirstOrDefault() as DataGridView;
            hide_all_tables();
            dgv.ClearSelection();
            dgv.Visible = true;
        }
        public void hide_all_tables()
        {
            int x = 0;
            while (x != list_id)
            {
                try
                {
                    DataGridView dgv = this.Controls.Find("table_" + x.ToString(), true).FirstOrDefault() as DataGridView;
                    dgv.Visible = false;

                }
                catch (NullReferenceException)
                {
                }
                x++;
            }
        }
        public void save()
        {
            if (!is_loading)
            {
                Debug.WriteLine(path);
                TextWriter t = new StreamWriter(path, true);
                t.Write("");
                t.Close();
                string text = "[TableConfig]" + Environment.NewLine;
                text += "rating_mode:" + rating_mode.ToString() + Environment.NewLine;
                text += "number_rating_max:" + number_input.Text + Environment.NewLine;
                foreach (string category in Categorys)
                {
                    text += "category:" + category + Environment.NewLine;
                }
                int x = 0;
                while (x <= list_id+1)
                {
                    Button bt = this.Controls.Find(x.ToString(), true).FirstOrDefault() as Button;
                    DataGridView dgv = this.Controls.Find("table_" + x.ToString(), true).FirstOrDefault() as DataGridView;
                    try
                    {
                        text += "TableName:" + bt.Text + Environment.NewLine;
                        text += "RatingTable:" + dgv.Tag + Environment.NewLine;
                        text += "r:" + dgv.ColumnHeadersDefaultCellStyle.BackColor.R.ToString() + Environment.NewLine;
                        text += "g:" + dgv.ColumnHeadersDefaultCellStyle.BackColor.G.ToString() + Environment.NewLine;
                        text += "b:" + dgv.ColumnHeadersDefaultCellStyle.BackColor.B.ToString() + Environment.NewLine;
                        int x_2 = 0;
                        text += "[TableRows]:" + Environment.NewLine;
                        Debug.WriteLine("Readlines from " + bt.Text);
                        while (x_2 <= dgv.RowCount+1)
                        {
                            int x_3 = 0;
                            string row = "";
                            while (x_3<= dgv.ColumnCount+1)
                            {
                                if (x_3 == 0) {
                                    Directory.CreateDirectory(image_folder);
                                    try
                                    {
                                        Image img = (Image)dgv.Rows[x_2].Cells[x_3].Value;
                                        try
                                        {
                                            img.Save(Path.Combine(image_folder, dgv.Rows[x_2].Cells[1].Value.ToString() + ".png"), System.Drawing.Imaging.ImageFormat.Png);
                                        }
                                        catch (System.Runtime.InteropServices.ExternalException) { }
                                        catch (NullReferenceException) { }
                                    }
                                    catch (ArgumentOutOfRangeException) { }
                                }
                                Debug.WriteLine("Read from " + bt.Text + ":" + x_2 + " " + x_3);
                                try
                                {
                                    row += dgv.Rows[x_2].Cells[x_3].Value + "|";
                                }
                                catch (ArgumentOutOfRangeException) { }

                                x_3++;
                            }
                            if (row.Count() != 0)
                            {
                                text += "row:" + row + Environment.NewLine;
                            }
                            x_2++;
                        }
                    }
                    catch (NullReferenceException) { }
                    x++;
                }

                File.WriteAllText(path, text.ToString());
            }
        }
        public void load()
        {
            try
            {
                var allLines = System.IO.File.ReadAllLines(path);
                bool isTableConfig = false;
                string table_name_cache = "";
                bool table_rating_cache = false;
                bool table_counter_cache = false;
                int r_cache = 0;
                int g_cache = 0;
                int b_cache = 0;
                Debug.WriteLine("LoadConfig");
                List<string> category_list = new List<string>();
                foreach (string singleLine in allLines)
                {
                    string singleLine_trim = singleLine.Trim();
                    Debug.WriteLine(singleLine_trim);
                    if (singleLine_trim == "[TableConfig]")
                    {
                        isTableConfig = true;
                        is_loading = true;
                        Debug.WriteLine("Config found");
                    }
                    else
                    {
                        if (isTableConfig)
                        {
                            Debug.WriteLine("Config " + singleLine_trim.Split(':')[0] + " is loading");
                            string singleLine_option_value = singleLine_trim.Split(':')[1];
                            switch (singleLine_trim.Split(':')[0])
                            {
                                case ("rating_mode"):
                                    try
                                    {
                                        rating_mode = Int32.Parse(singleLine_option_value);
                                    }
                                    catch (FormatException) { }
                                    break;

                                case ("number_rating_max"):
                                    try
                                    {
                                        int test_if_number;
                                        test_if_number = Int32.Parse(singleLine_option_value);
                                        number_input.Text = singleLine_option_value;
                                    }
                                    catch (FormatException) { }
                                    break;

                                case ("category"):
                                    category_list.Add(singleLine_option_value);
                                    Categorys = category_list.ToArray();
                                    break;

                                case ("TableName"):
                                    table_name_cache = singleLine_option_value;
                                    break;
                                case ("RatingTable"):
                                    table_rating_cache = false;
                                    table_counter_cache = false;
                                    switch (singleLine_option_value)
                                    {
                                        case ("counter"):
                                            table_counter_cache = true;

                                            break;
                                        case ("counter_rating"):
                                            table_counter_cache = true;
                                            table_rating_cache = true;
                                            break;
                                        case ("rating"):
                                            table_rating_cache = true;
                                            break;
                                        case ("none"):
                                            table_rating_cache = false;
                                            break;
                                        default:
                                            table_rating_cache = false;
                                            break;
                                    }
                                    break;
                                case ("r"):
                                    try
                                    {
                                        r_cache = Int32.Parse(singleLine_option_value);
                                    }
                                    catch (FormatException)
                                    {

                                    }
                                    break;
                                case ("g"):
                                    g_cache = Int32.Parse(singleLine_option_value);
                                    break;
                                case ("b"):
                                    b_cache = Int32.Parse(singleLine_option_value);
                                    break;
                                case ("[TableRows]"):
                                    new_table(table_name_cache, r_cache, g_cache, b_cache, table_rating_cache, table_counter_cache);
                                    break;
                                case ("row"):
                                    DataGridView dgv = this.Controls.Find("table_" + (list_id - 1), true).FirstOrDefault() as DataGridView;
                                    int x = 0;
                                    bool load_image = false;
                                    dgv.Rows.Add();
                                    Debug.WriteLine("Debug Table " + (list_id - 1) + ": " + dgv.RowCount + " " + dgv.ColumnCount);
                                    foreach (string row in singleLine_option_value.Split('|'))
                                    {
                                        Debug.WriteLine(dgv.RowCount - 1 + " " + x + " = " + row);
                                        if (x < dgv.ColumnCount)
                                        {

                                            if (x == 0)
                                            {
                                                if (row == "System.Drawing.Bitmap")
                                                {
                                                    load_image = true;
                                                }
                                            }
                                            else
                                            {
                                                dgv.Rows[dgv.RowCount - 1].Cells[x].Value = row;
                                            }
                                            if (x == 1)
                                            {
                                                if (load_image)
                                                {
                                                    dgv.Rows[dgv.RowCount - 1].Cells[0].Value = Image.FromFile(Path.Combine(image_folder, dgv.Rows[dgv.RowCount - 1].Cells[1].Value.ToString()+".png"));
                                                }
                                            }
                                        }
                                        x++;
                                    }
                                    break;
                                default:
                                    break;


                            }

                        }
                        else
                        {
                            Debug.WriteLine("Config error");
                        }
                    }
                }
                question_label.Visible = false;
                button_false.Visible = false;
                button_true.Visible = false;
                starttitle.Visible = false;
                create_table_button.Visible = false;
                is_loading = false;
                enable_anime_input();
            }
            catch (FileNotFoundException) { }
        }
        public string mal_get_image(string text)
        {
            if (my_anime_list_login)
            {
                string url = "https://myanimelist.net/api/anime/search.xml?q=" + text;
                Debug.WriteLine(url);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Headers["Authorization"] = "Basic " + authInfo;
                request.Timeout = 10000;
                try
                {
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    Stream resStream = response.GetResponseStream();
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        Stream receiveStream = response.GetResponseStream();
                        StreamReader readStream = null;

                        if (response.CharacterSet == null)
                        {
                            readStream = new StreamReader(receiveStream);
                        }
                        else
                        {
                            readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                        }
                        string data = readStream.ReadToEnd();
                        Regex regex = new Regex(@"<entry>([\s\S]*?)\<\/entry>");
                        Debug.WriteLine("GetData");
                        foreach (Match match in regex.Matches(data))
                        {
                            Regex title = new Regex(@"<title>([\s\S]*?)\<\/title>");
                            Match match_title = title.Match(match.Value);
                            if (match_title.Success)
                            {
                                if (match_title.Groups[1].Value.ToUpper() == text.ToUpper())
                                {
                                        Regex image = new Regex(@"<image>([\s\S]*?)\<\/image>");
                                        Match match_image = image.Match(match.Value);
                                        this.anime_pic_preview.Visible = false;
                                        this.anime_pic_preview.Load(match_image.Groups[1].Value);
                                        response.Close();
                                        readStream.Close();
                                    Debug.WriteLine("Image found");
                                    return "found";
                                }
                                }

                            }
                        response.Close();
                        readStream.Close();
                    }
                }
                catch (System.Net.WebException e)
                {
                    Debug.WriteLine(e);
                    return null;
                }
            }
            return null;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void colorchange(int id, Color neu)
        {
            Button bt = this.Controls.Find(id.ToString(), true).FirstOrDefault() as Button;
            DataGridView dgv = this.Controls.Find("table_" + id.ToString(), true).FirstOrDefault() as DataGridView;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = neu;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = neu;
            bt.BackColor = neu;
            list_color[id] = neu.ToArgb();
        }
        public void unload()
        {
            save();
            Categorys = null;
            rating_mode = 0;
            int x = 0;
            while (x <= list_id + 1)
            {
                Button bt = this.Controls.Find(x.ToString(), true).FirstOrDefault() as Button;
                DataGridView dgv = this.Controls.Find("table_" + x.ToString(), true).FirstOrDefault() as DataGridView;
                try
                {
                    flowLayoutPanel1.Controls.Remove(bt);
                    this.Controls.Remove(dgv);
                }
                catch (NullReferenceException) { }
                x++;
            }
        }
        public void remove_button_from_panel(Button btn)
        {
            flowLayoutPanel1.Controls.Remove(btn);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
