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
    public partial class mal_login : Form
    {
        private string error_1;
        private bool first_tick = false;
        private string error_2;

        public string username;
        public string authInfo { get;  set; }
        public bool mal_logged_in { get; set; }

        public mal_login()
        {
            InitializeComponent();
            timer1.Interval = 1;
            timer1.Start();
            lang("ger");
        }

        private void mal_login_button_Click(object sender, EventArgs e)
        {
            if(mal_username.TextLength >= 1 && mal_password.TextLength >= 1)
            {
                string url = "https://myanimelist.net/api/";
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                authInfo = mal_username.Text + ":" +mal_password.Text;
                authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
                req.Headers["Authorization"] = "Basic " +authInfo;
                try
                {
                    HttpWebResponse response = (HttpWebResponse)req.GetResponse();
                    Stream resStream = response.GetResponseStream();
                    username = mal_username.Text;
                    mal_logged_in = true;
                    this.Close();
                }
                catch (System.Net.WebException)
                {
                    mal_logged_in = false;
                    error_box.Text = "⚠ | " + error_2;
                    timer1.Interval = 2000;
                    first_tick = false;
                    timer1.Start();
                }
            }
            else
            {
                mal_logged_in = false;
                error_box.Text = "⚠ | " + error_1;
                timer1.Interval = 2000;
                first_tick = false;
                timer1.Start();
            }
        }
        private void lang(string lang)
        {

            switch (lang)
            {

                case "ger":
                    error_1 = "Bitte gib dein Benutzernamen und Passwort ein.";
                    error_2 = "Falsches Passwort oder Benutzername !";
                    mal_username_label.Text = "Benutzername";
                    mal_password_label.Text = "Passwort";
                    mal_login_button.Text = "Einloggen";
                    mal_cancel.Text = "Abbrechen";
                    break;
                default:
                    error_1 = "Please enter your Username and Password.";
                    error_2 = "Wrong Password or Username!";
                    mal_username_label.Text = "Username";
                    mal_password_label.Text = "Password";
                    mal_login_button.Text = "Login";
                    mal_cancel.Text = "Cancel";
                    break;
            }
        }

        private void mal_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (first_tick)
            {
                error_box.Text = "";
            }
            first_tick = true;
            timer1.Stop();
        }
    }
}

