namespace AnimeList
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.starttitle = new System.Windows.Forms.Label();
            this.create_table_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_true = new System.Windows.Forms.Button();
            this.button_false = new System.Windows.Forms.Button();
            this.question_label = new System.Windows.Forms.Label();
            this.anime_input = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mal_username_label = new System.Windows.Forms.Label();
            this.add_to_table_button = new System.Windows.Forms.Button();
            this.anime_pic_preview = new System.Windows.Forms.PictureBox();
            this.anime_ep = new System.Windows.Forms.Label();
            this.anime_type = new System.Windows.Forms.Label();
            this.anime_description = new System.Windows.Forms.Label();
            this.open_options = new System.Windows.Forms.Button();
            this.star_rating = new System.Windows.Forms.CheckBox();
            this.number_rating = new System.Windows.Forms.CheckBox();
            this.thumbs_rating = new System.Windows.Forms.CheckBox();
            this.number_input = new System.Windows.Forms.TextBox();
            this.finish_rating = new System.Windows.Forms.Button();
            this.planning_table = new System.Windows.Forms.PictureBox();
            this.on_watching_list = new System.Windows.Forms.PictureBox();
            this.cancel_tabel_pic = new System.Windows.Forms.PictureBox();
            this.Watched_list = new System.Windows.Forms.PictureBox();
            this.on_watching_list_label = new System.Windows.Forms.Label();
            this.Watched_list_label = new System.Windows.Forms.Label();
            this.cancel_tabel_label = new System.Windows.Forms.Label();
            this.planning_table_label = new System.Windows.Forms.Label();
            this.finish_list_chooser = new System.Windows.Forms.Button();
            this.on_watching_true_image = new System.Windows.Forms.PictureBox();
            this.Watched_list_true_image = new System.Windows.Forms.PictureBox();
            this.cancel__table_true_image = new System.Windows.Forms.PictureBox();
            this.planning_table_true_image = new System.Windows.Forms.PictureBox();
            this.add_category = new System.Windows.Forms.Button();
            this.add_category_finish = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.move_anime_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.move_to_table_text = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.anime_title = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anime_pic_preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planning_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_watching_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel_tabel_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Watched_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_watching_true_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Watched_list_true_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel__table_true_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planning_table_true_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.close.Location = new System.Drawing.Point(859, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(25, 23);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(1, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(897, 41);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // starttitle
            // 
            this.starttitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.starttitle.Font = new System.Drawing.Font("To forgive", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starttitle.Location = new System.Drawing.Point(-4, 134);
            this.starttitle.Name = "starttitle";
            this.starttitle.Size = new System.Drawing.Size(897, 74);
            this.starttitle.TabIndex = 2;
            this.starttitle.Text = "StartTitle";
            this.starttitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.starttitle.Click += new System.EventHandler(this.starttitle_Click);
            // 
            // create_table_button
            // 
            this.create_table_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.create_table_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_table_button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_table_button.Location = new System.Drawing.Point(272, 237);
            this.create_table_button.Name = "create_table_button";
            this.create_table_button.Size = new System.Drawing.Size(346, 33);
            this.create_table_button.TabIndex = 3;
            this.create_table_button.Text = "TabelleErstellen";
            this.create_table_button.UseVisualStyleBackColor = true;
            this.create_table_button.Click += new System.EventHandler(this.create_table_button_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_true
            // 
            this.button_true.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_true.Location = new System.Drawing.Point(272, 276);
            this.button_true.Name = "button_true";
            this.button_true.Size = new System.Drawing.Size(75, 23);
            this.button_true.TabIndex = 4;
            this.button_true.Text = "button1";
            this.button_true.UseVisualStyleBackColor = true;
            this.button_true.Visible = false;
            this.button_true.Click += new System.EventHandler(this.button_true_Click);
            // 
            // button_false
            // 
            this.button_false.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_false.Location = new System.Drawing.Point(543, 276);
            this.button_false.Name = "button_false";
            this.button_false.Size = new System.Drawing.Size(75, 23);
            this.button_false.TabIndex = 5;
            this.button_false.Text = "button2";
            this.button_false.UseVisualStyleBackColor = true;
            this.button_false.Visible = false;
            this.button_false.Click += new System.EventHandler(this.button_false_Click);
            // 
            // question_label
            // 
            this.question_label.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_label.Location = new System.Drawing.Point(71, 208);
            this.question_label.Name = "question_label";
            this.question_label.Size = new System.Drawing.Size(753, 26);
            this.question_label.TabIndex = 6;
            this.question_label.Text = "Question";
            this.question_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.question_label.Visible = false;
            // 
            // anime_input
            // 
            this.anime_input.AutoCompleteCustomSource.AddRange(new string[] {
            "Sword Art Online",
            "GTA"});
            this.anime_input.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.anime_input.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.anime_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(83)))), ((int)(((byte)(92)))));
            this.anime_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.anime_input.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anime_input.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.anime_input.Location = new System.Drawing.Point(12, 485);
            this.anime_input.Name = "anime_input";
            this.anime_input.Size = new System.Drawing.Size(688, 26);
            this.anime_input.TabIndex = 7;
            this.anime_input.Visible = false;
            this.anime_input.TextChanged += new System.EventHandler(this.anime_input_TextChanged);
            this.anime_input.Enter += new System.EventHandler(this.anime_input_Enter);
            this.anime_input.Leave += new System.EventHandler(this.anime_input_Leave);
            this.anime_input.MouseEnter += new System.EventHandler(this.anime_input_MouseEnter);
            this.anime_input.MouseLeave += new System.EventHandler(this.anime_input_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(801, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // mal_username_label
            // 
            this.mal_username_label.Location = new System.Drawing.Point(644, 12);
            this.mal_username_label.Name = "mal_username_label";
            this.mal_username_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mal_username_label.Size = new System.Drawing.Size(151, 23);
            this.mal_username_label.TabIndex = 9;
            this.mal_username_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // add_to_table_button
            // 
            this.add_to_table_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(86)))), ((int)(((byte)(19)))));
            this.add_to_table_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_to_table_button.Location = new System.Drawing.Point(706, 488);
            this.add_to_table_button.Name = "add_to_table_button";
            this.add_to_table_button.Size = new System.Drawing.Size(178, 23);
            this.add_to_table_button.TabIndex = 10;
            this.add_to_table_button.Text = "Zur Animeliste Hinzufügen";
            this.add_to_table_button.UseVisualStyleBackColor = false;
            this.add_to_table_button.Visible = false;
            this.add_to_table_button.Click += new System.EventHandler(this.add_to_table_button_Click);
            // 
            // anime_pic_preview
            // 
            this.anime_pic_preview.Location = new System.Drawing.Point(736, 64);
            this.anime_pic_preview.Name = "anime_pic_preview";
            this.anime_pic_preview.Size = new System.Drawing.Size(122, 165);
            this.anime_pic_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.anime_pic_preview.TabIndex = 11;
            this.anime_pic_preview.TabStop = false;
            // 
            // anime_ep
            // 
            this.anime_ep.AutoSize = true;
            this.anime_ep.Location = new System.Drawing.Point(706, 247);
            this.anime_ep.Name = "anime_ep";
            this.anime_ep.Size = new System.Drawing.Size(0, 13);
            this.anime_ep.TabIndex = 12;
            // 
            // anime_type
            // 
            this.anime_type.AutoSize = true;
            this.anime_type.Location = new System.Drawing.Point(706, 261);
            this.anime_type.Name = "anime_type";
            this.anime_type.Size = new System.Drawing.Size(0, 13);
            this.anime_type.TabIndex = 13;
            this.anime_type.Click += new System.EventHandler(this.anime_type_Click);
            // 
            // anime_description
            // 
            this.anime_description.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anime_description.Location = new System.Drawing.Point(706, 274);
            this.anime_description.Name = "anime_description";
            this.anime_description.Size = new System.Drawing.Size(178, 211);
            this.anime_description.TabIndex = 14;
            // 
            // open_options
            // 
            this.open_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_options.Location = new System.Drawing.Point(12, 12);
            this.open_options.Name = "open_options";
            this.open_options.Size = new System.Drawing.Size(23, 23);
            this.open_options.TabIndex = 15;
            this.open_options.Text = "⚙";
            this.open_options.UseVisualStyleBackColor = true;
            this.open_options.Click += new System.EventHandler(this.open_options_Click);
            // 
            // star_rating
            // 
            this.star_rating.AutoSize = true;
            this.star_rating.Location = new System.Drawing.Point(403, 286);
            this.star_rating.Name = "star_rating";
            this.star_rating.Size = new System.Drawing.Size(15, 14);
            this.star_rating.TabIndex = 16;
            this.star_rating.UseVisualStyleBackColor = true;
            this.star_rating.Visible = false;
            this.star_rating.CheckedChanged += new System.EventHandler(this.star_rating_CheckedChanged);
            // 
            // number_rating
            // 
            this.number_rating.AutoSize = true;
            this.number_rating.Location = new System.Drawing.Point(403, 306);
            this.number_rating.Name = "number_rating";
            this.number_rating.Size = new System.Drawing.Size(15, 14);
            this.number_rating.TabIndex = 17;
            this.number_rating.UseVisualStyleBackColor = true;
            this.number_rating.Visible = false;
            this.number_rating.CheckedChanged += new System.EventHandler(this.number_rating_CheckedChanged);
            // 
            // thumbs_rating
            // 
            this.thumbs_rating.AutoSize = true;
            this.thumbs_rating.Location = new System.Drawing.Point(403, 263);
            this.thumbs_rating.Name = "thumbs_rating";
            this.thumbs_rating.Size = new System.Drawing.Size(15, 14);
            this.thumbs_rating.TabIndex = 18;
            this.thumbs_rating.UseVisualStyleBackColor = true;
            this.thumbs_rating.Visible = false;
            this.thumbs_rating.CheckedChanged += new System.EventHandler(this.thumbs_rating_CheckedChanged);
            // 
            // number_input
            // 
            this.number_input.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.number_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.number_input.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_input.ForeColor = System.Drawing.Color.AliceBlue;
            this.number_input.Location = new System.Drawing.Point(403, 330);
            this.number_input.MaxLength = 10;
            this.number_input.Name = "number_input";
            this.number_input.Size = new System.Drawing.Size(80, 15);
            this.number_input.TabIndex = 19;
            this.number_input.Text = "10";
            this.number_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.number_input.Visible = false;
            this.number_input.TextChanged += new System.EventHandler(this.number_input_TextChanged);
            // 
            // finish_rating
            // 
            this.finish_rating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finish_rating.Location = new System.Drawing.Point(373, 356);
            this.finish_rating.Name = "finish_rating";
            this.finish_rating.Size = new System.Drawing.Size(141, 23);
            this.finish_rating.TabIndex = 20;
            this.finish_rating.UseVisualStyleBackColor = true;
            this.finish_rating.Visible = false;
            this.finish_rating.Click += new System.EventHandler(this.finish_rating_Click);
            // 
            // planning_table
            // 
            this.planning_table.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.planning_table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.planning_table.Image = ((System.Drawing.Image)(resources.GetObject("planning_table.Image")));
            this.planning_table.Location = new System.Drawing.Point(624, 318);
            this.planning_table.Name = "planning_table";
            this.planning_table.Size = new System.Drawing.Size(117, 73);
            this.planning_table.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.planning_table.TabIndex = 21;
            this.planning_table.TabStop = false;
            this.planning_table.Visible = false;
            this.planning_table.Click += new System.EventHandler(this.planning_table_Click);
            // 
            // on_watching_list
            // 
            this.on_watching_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.on_watching_list.Image = ((System.Drawing.Image)(resources.GetObject("on_watching_list.Image")));
            this.on_watching_list.Location = new System.Drawing.Point(156, 318);
            this.on_watching_list.Name = "on_watching_list";
            this.on_watching_list.Size = new System.Drawing.Size(110, 73);
            this.on_watching_list.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.on_watching_list.TabIndex = 22;
            this.on_watching_list.TabStop = false;
            this.on_watching_list.Visible = false;
            this.on_watching_list.Click += new System.EventHandler(this.on_watching_list_Click);
            // 
            // cancel_tabel_pic
            // 
            this.cancel_tabel_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancel_tabel_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_tabel_pic.Image = ((System.Drawing.Image)(resources.GetObject("cancel_tabel_pic.Image")));
            this.cancel_tabel_pic.Location = new System.Drawing.Point(477, 318);
            this.cancel_tabel_pic.Name = "cancel_tabel_pic";
            this.cancel_tabel_pic.Size = new System.Drawing.Size(117, 73);
            this.cancel_tabel_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cancel_tabel_pic.TabIndex = 23;
            this.cancel_tabel_pic.TabStop = false;
            this.cancel_tabel_pic.Visible = false;
            this.cancel_tabel_pic.Click += new System.EventHandler(this.cancel_tabel_pic_Click);
            // 
            // Watched_list
            // 
            this.Watched_list.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Watched_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Watched_list.Image = ((System.Drawing.Image)(resources.GetObject("Watched_list.Image")));
            this.Watched_list.Location = new System.Drawing.Point(301, 318);
            this.Watched_list.Name = "Watched_list";
            this.Watched_list.Size = new System.Drawing.Size(117, 73);
            this.Watched_list.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Watched_list.TabIndex = 24;
            this.Watched_list.TabStop = false;
            this.Watched_list.Visible = false;
            this.Watched_list.Click += new System.EventHandler(this.Watched_list_Click);
            // 
            // on_watching_list_label
            // 
            this.on_watching_list_label.Location = new System.Drawing.Point(156, 286);
            this.on_watching_list_label.Name = "on_watching_list_label";
            this.on_watching_list_label.Size = new System.Drawing.Size(110, 26);
            this.on_watching_list_label.TabIndex = 25;
            this.on_watching_list_label.Text = "watching";
            this.on_watching_list_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.on_watching_list_label.Visible = false;
            // 
            // Watched_list_label
            // 
            this.Watched_list_label.Location = new System.Drawing.Point(301, 281);
            this.Watched_list_label.Name = "Watched_list_label";
            this.Watched_list_label.Size = new System.Drawing.Size(117, 26);
            this.Watched_list_label.TabIndex = 26;
            this.Watched_list_label.Text = "list";
            this.Watched_list_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Watched_list_label.Visible = false;
            // 
            // cancel_tabel_label
            // 
            this.cancel_tabel_label.Location = new System.Drawing.Point(477, 281);
            this.cancel_tabel_label.Name = "cancel_tabel_label";
            this.cancel_tabel_label.Size = new System.Drawing.Size(117, 26);
            this.cancel_tabel_label.TabIndex = 27;
            this.cancel_tabel_label.Text = "Dropped";
            this.cancel_tabel_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancel_tabel_label.Visible = false;
            // 
            // planning_table_label
            // 
            this.planning_table_label.Location = new System.Drawing.Point(624, 281);
            this.planning_table_label.Name = "planning_table_label";
            this.planning_table_label.Size = new System.Drawing.Size(117, 26);
            this.planning_table_label.TabIndex = 28;
            this.planning_table_label.Text = "planning";
            this.planning_table_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.planning_table_label.Visible = false;
            // 
            // finish_list_chooser
            // 
            this.finish_list_chooser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finish_list_chooser.Location = new System.Drawing.Point(379, 441);
            this.finish_list_chooser.Name = "finish_list_chooser";
            this.finish_list_chooser.Size = new System.Drawing.Size(130, 23);
            this.finish_list_chooser.TabIndex = 29;
            this.finish_list_chooser.UseVisualStyleBackColor = true;
            this.finish_list_chooser.Visible = false;
            this.finish_list_chooser.Click += new System.EventHandler(this.finish_list_chooser_Click);
            // 
            // on_watching_true_image
            // 
            this.on_watching_true_image.Image = ((System.Drawing.Image)(resources.GetObject("on_watching_true_image.Image")));
            this.on_watching_true_image.Location = new System.Drawing.Point(188, 403);
            this.on_watching_true_image.Name = "on_watching_true_image";
            this.on_watching_true_image.Size = new System.Drawing.Size(32, 28);
            this.on_watching_true_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.on_watching_true_image.TabIndex = 30;
            this.on_watching_true_image.TabStop = false;
            this.on_watching_true_image.Visible = false;
            this.on_watching_true_image.Click += new System.EventHandler(this.on_watching_true_image_Click);
            // 
            // Watched_list_true_image
            // 
            this.Watched_list_true_image.Image = ((System.Drawing.Image)(resources.GetObject("Watched_list_true_image.Image")));
            this.Watched_list_true_image.Location = new System.Drawing.Point(341, 403);
            this.Watched_list_true_image.Name = "Watched_list_true_image";
            this.Watched_list_true_image.Size = new System.Drawing.Size(32, 28);
            this.Watched_list_true_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Watched_list_true_image.TabIndex = 31;
            this.Watched_list_true_image.TabStop = false;
            this.Watched_list_true_image.Visible = false;
            this.Watched_list_true_image.Click += new System.EventHandler(this.Watched_list_true_image_Click);
            // 
            // cancel__table_true_image
            // 
            this.cancel__table_true_image.Image = ((System.Drawing.Image)(resources.GetObject("cancel__table_true_image.Image")));
            this.cancel__table_true_image.Location = new System.Drawing.Point(515, 403);
            this.cancel__table_true_image.Name = "cancel__table_true_image";
            this.cancel__table_true_image.Size = new System.Drawing.Size(32, 28);
            this.cancel__table_true_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cancel__table_true_image.TabIndex = 32;
            this.cancel__table_true_image.TabStop = false;
            this.cancel__table_true_image.Visible = false;
            this.cancel__table_true_image.Click += new System.EventHandler(this.cancel__table_true_image_Click);
            // 
            // planning_table_true_image
            // 
            this.planning_table_true_image.Image = ((System.Drawing.Image)(resources.GetObject("planning_table_true_image.Image")));
            this.planning_table_true_image.Location = new System.Drawing.Point(668, 403);
            this.planning_table_true_image.Name = "planning_table_true_image";
            this.planning_table_true_image.Size = new System.Drawing.Size(32, 28);
            this.planning_table_true_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.planning_table_true_image.TabIndex = 33;
            this.planning_table_true_image.TabStop = false;
            this.planning_table_true_image.Visible = false;
            this.planning_table_true_image.Click += new System.EventHandler(this.planning_table_true_image_Click);
            // 
            // add_category
            // 
            this.add_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_category.Location = new System.Drawing.Point(379, 385);
            this.add_category.Name = "add_category";
            this.add_category.Size = new System.Drawing.Size(129, 23);
            this.add_category.TabIndex = 34;
            this.add_category.Text = "add category";
            this.add_category.UseVisualStyleBackColor = true;
            this.add_category.Visible = false;
            this.add_category.Click += new System.EventHandler(this.add_category_Click);
            // 
            // add_category_finish
            // 
            this.add_category_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_category_finish.Location = new System.Drawing.Point(304, 413);
            this.add_category_finish.Name = "add_category_finish";
            this.add_category_finish.Size = new System.Drawing.Size(290, 23);
            this.add_category_finish.TabIndex = 35;
            this.add_category_finish.Text = "Finish";
            this.add_category_finish.UseVisualStyleBackColor = true;
            this.add_category_finish.Visible = false;
            this.add_category_finish.Click += new System.EventHandler(this.add_category_finish_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(688, 47);
            this.flowLayoutPanel1.TabIndex = 41;
            this.flowLayoutPanel1.WrapContents = false;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // move_anime_panel
            // 
            this.move_anime_panel.AutoScroll = true;
            this.move_anime_panel.Location = new System.Drawing.Point(13, 426);
            this.move_anime_panel.Name = "move_anime_panel";
            this.move_anime_panel.Size = new System.Drawing.Size(687, 53);
            this.move_anime_panel.TabIndex = 42;
            this.move_anime_panel.WrapContents = false;
            // 
            // move_to_table_text
            // 
            this.move_to_table_text.AutoSize = true;
            this.move_to_table_text.Location = new System.Drawing.Point(12, 410);
            this.move_to_table_text.Name = "move_to_table_text";
            this.move_to_table_text.Size = new System.Drawing.Size(0, 13);
            this.move_to_table_text.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(828, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // anime_title
            // 
            this.anime_title.Font = new System.Drawing.Font("Arial", 8F);
            this.anime_title.Location = new System.Drawing.Point(706, 38);
            this.anime_title.Name = "anime_title";
            this.anime_title.Size = new System.Drawing.Size(178, 23);
            this.anime_title.TabIndex = 45;
            this.anime_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // image
            // 
            this.image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.image.Location = new System.Drawing.Point(862, 517);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(31, 15);
            this.image.TabIndex = 46;
            this.image.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(896, 523);
            this.Controls.Add(this.image);
            this.Controls.Add(this.starttitle);
            this.Controls.Add(this.anime_title);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.move_to_table_text);
            this.Controls.Add(this.add_category_finish);
            this.Controls.Add(this.add_category);
            this.Controls.Add(this.planning_table_true_image);
            this.Controls.Add(this.cancel__table_true_image);
            this.Controls.Add(this.Watched_list_true_image);
            this.Controls.Add(this.on_watching_true_image);
            this.Controls.Add(this.finish_list_chooser);
            this.Controls.Add(this.planning_table_label);
            this.Controls.Add(this.cancel_tabel_label);
            this.Controls.Add(this.Watched_list_label);
            this.Controls.Add(this.on_watching_list_label);
            this.Controls.Add(this.Watched_list);
            this.Controls.Add(this.cancel_tabel_pic);
            this.Controls.Add(this.on_watching_list);
            this.Controls.Add(this.planning_table);
            this.Controls.Add(this.finish_rating);
            this.Controls.Add(this.number_input);
            this.Controls.Add(this.thumbs_rating);
            this.Controls.Add(this.number_rating);
            this.Controls.Add(this.star_rating);
            this.Controls.Add(this.open_options);
            this.Controls.Add(this.anime_description);
            this.Controls.Add(this.anime_type);
            this.Controls.Add(this.anime_ep);
            this.Controls.Add(this.anime_pic_preview);
            this.Controls.Add(this.add_to_table_button);
            this.Controls.Add(this.mal_username_label);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.anime_input);
            this.Controls.Add(this.question_label);
            this.Controls.Add(this.button_false);
            this.Controls.Add(this.button_true);
            this.Controls.Add(this.create_table_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.move_anime_panel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "AnimeManager";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anime_pic_preview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planning_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_watching_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel_tabel_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Watched_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.on_watching_true_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Watched_list_true_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel__table_true_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planning_table_true_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label starttitle;
        private System.Windows.Forms.Button create_table_button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_true;
        private System.Windows.Forms.Button button_false;
        private System.Windows.Forms.Label question_label;
        private System.Windows.Forms.TextBox anime_input;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label mal_username_label;
        private System.Windows.Forms.Button add_to_table_button;
        private System.Windows.Forms.PictureBox anime_pic_preview;
        private System.Windows.Forms.Label anime_ep;
        private System.Windows.Forms.Label anime_type;
        private System.Windows.Forms.Label anime_description;
        private System.Windows.Forms.Button open_options;
        private System.Windows.Forms.CheckBox star_rating;
        private System.Windows.Forms.CheckBox number_rating;
        private System.Windows.Forms.CheckBox thumbs_rating;
        private System.Windows.Forms.TextBox number_input;
        private System.Windows.Forms.Button finish_rating;
        private System.Windows.Forms.PictureBox planning_table;
        private System.Windows.Forms.PictureBox on_watching_list;
        private System.Windows.Forms.PictureBox cancel_tabel_pic;
        private System.Windows.Forms.PictureBox Watched_list;
        private System.Windows.Forms.Label on_watching_list_label;
        private System.Windows.Forms.Label Watched_list_label;
        private System.Windows.Forms.Label cancel_tabel_label;
        private System.Windows.Forms.Label planning_table_label;
        private System.Windows.Forms.Button finish_list_chooser;
        private System.Windows.Forms.PictureBox on_watching_true_image;
        private System.Windows.Forms.PictureBox Watched_list_true_image;
        private System.Windows.Forms.PictureBox cancel__table_true_image;
        private System.Windows.Forms.PictureBox planning_table_true_image;
        private System.Windows.Forms.Button add_category;
        private System.Windows.Forms.Button add_category_finish;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel move_anime_panel;
        private System.Windows.Forms.Label move_to_table_text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label anime_title;
        private System.Windows.Forms.PictureBox image;
    }
}

