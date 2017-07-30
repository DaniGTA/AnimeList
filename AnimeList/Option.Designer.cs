namespace AnimeList
{
    partial class Option
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
            this.show_rating_option = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.table_option_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.allgemeineoptions = new System.Windows.Forms.Label();
            this.table_options_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.color_picker = new System.Windows.Forms.Button();
            this.rating = new System.Windows.Forms.CheckBox();
            this.episode_counter = new System.Windows.Forms.CheckBox();
            this.table_title = new System.Windows.Forms.TextBox();
            this.remove_table = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.Label();
            this.add_category = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // show_rating_option
            // 
            this.show_rating_option.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_rating_option.Location = new System.Drawing.Point(36, 72);
            this.show_rating_option.Name = "show_rating_option";
            this.show_rating_option.Size = new System.Drawing.Size(117, 23);
            this.show_rating_option.TabIndex = 0;
            this.show_rating_option.Text = "rating options";
            this.show_rating_option.UseVisualStyleBackColor = true;
            this.show_rating_option.Click += new System.EventHandler(this.show_rating_option_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 525);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // table_option_label
            // 
            this.table_option_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.table_option_label.Font = new System.Drawing.Font("39 Smooth", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_option_label.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.table_option_label.Location = new System.Drawing.Point(1, 227);
            this.table_option_label.Name = "table_option_label";
            this.table_option_label.Size = new System.Drawing.Size(194, 23);
            this.table_option_label.TabIndex = 2;
            this.table_option_label.Text = "Table Options";
            this.table_option_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(861, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "🏠";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // allgemeineoptions
            // 
            this.allgemeineoptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.allgemeineoptions.Font = new System.Drawing.Font("39 Smooth", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allgemeineoptions.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.allgemeineoptions.Location = new System.Drawing.Point(1, 46);
            this.allgemeineoptions.Name = "allgemeineoptions";
            this.allgemeineoptions.Size = new System.Drawing.Size(194, 23);
            this.allgemeineoptions.TabIndex = 5;
            this.allgemeineoptions.Text = "AllgemeineOptionen";
            this.allgemeineoptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // table_options_panel
            // 
            this.table_options_panel.AutoScroll = true;
            this.table_options_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.table_options_panel.Location = new System.Drawing.Point(1, 254);
            this.table_options_panel.Name = "table_options_panel";
            this.table_options_panel.Size = new System.Drawing.Size(194, 257);
            this.table_options_panel.TabIndex = 7;
            // 
            // color_picker
            // 
            this.color_picker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color_picker.Font = new System.Drawing.Font("39 Smooth", 9F);
            this.color_picker.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.color_picker.Location = new System.Drawing.Point(201, 441);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(146, 23);
            this.color_picker.TabIndex = 8;
            this.color_picker.Text = "color_picker";
            this.color_picker.UseVisualStyleBackColor = false;
            this.color_picker.Visible = false;
            this.color_picker.Click += new System.EventHandler(this.color_picker_Click);
            // 
            // rating
            // 
            this.rating.AutoSize = true;
            this.rating.Font = new System.Drawing.Font("39 Smooth", 9F);
            this.rating.ForeColor = System.Drawing.Color.AliceBlue;
            this.rating.Location = new System.Drawing.Point(204, 493);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(60, 18);
            this.rating.TabIndex = 10;
            this.rating.Text = "rating";
            this.rating.UseVisualStyleBackColor = true;
            this.rating.Visible = false;
            this.rating.CheckedChanged += new System.EventHandler(this.rating_CheckedChanged);
            // 
            // episode_counter
            // 
            this.episode_counter.AutoSize = true;
            this.episode_counter.Font = new System.Drawing.Font("39 Smooth", 9F);
            this.episode_counter.ForeColor = System.Drawing.Color.AliceBlue;
            this.episode_counter.Location = new System.Drawing.Point(204, 470);
            this.episode_counter.Name = "episode_counter";
            this.episode_counter.Size = new System.Drawing.Size(121, 18);
            this.episode_counter.TabIndex = 11;
            this.episode_counter.Text = "episode_counter";
            this.episode_counter.UseVisualStyleBackColor = true;
            this.episode_counter.Visible = false;
            this.episode_counter.CheckedChanged += new System.EventHandler(this.episode_counter_CheckedChanged);
            // 
            // table_title
            // 
            this.table_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.table_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_title.Font = new System.Drawing.Font("39 Smooth", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_title.ForeColor = System.Drawing.SystemColors.Menu;
            this.table_title.Location = new System.Drawing.Point(199, 46);
            this.table_title.MaxLength = 30;
            this.table_title.Name = "table_title";
            this.table_title.Size = new System.Drawing.Size(361, 24);
            this.table_title.TabIndex = 12;
            this.table_title.Visible = false;
            this.table_title.TextChanged += new System.EventHandler(this.table_title_TextChanged);
            // 
            // remove_table
            // 
            this.remove_table.BackColor = System.Drawing.Color.Maroon;
            this.remove_table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_table.Font = new System.Drawing.Font("39 Smooth", 9F);
            this.remove_table.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.remove_table.Location = new System.Drawing.Point(201, 412);
            this.remove_table.Name = "remove_table";
            this.remove_table.Size = new System.Drawing.Size(146, 23);
            this.remove_table.TabIndex = 13;
            this.remove_table.Text = "remove";
            this.remove_table.UseVisualStyleBackColor = false;
            this.remove_table.Visible = false;
            this.remove_table.Click += new System.EventHandler(this.remove_table_Click);
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("39 Smooth", 9F);
            this.category.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.category.Location = new System.Drawing.Point(204, 208);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(58, 14);
            this.category.TabIndex = 14;
            this.category.Text = "category";
            this.category.Visible = false;
            // 
            // add_category
            // 
            this.add_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_category.Font = new System.Drawing.Font("39 Smooth", 9F);
            this.add_category.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_category.Location = new System.Drawing.Point(268, 208);
            this.add_category.Name = "add_category";
            this.add_category.Size = new System.Drawing.Size(146, 23);
            this.add_category.TabIndex = 15;
            this.add_category.Text = "add_category";
            this.add_category.UseVisualStyleBackColor = false;
            this.add_category.Visible = false;
            this.add_category.Click += new System.EventHandler(this.add_category_Click_1);
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(896, 523);
            this.Controls.Add(this.add_category);
            this.Controls.Add(this.category);
            this.Controls.Add(this.remove_table);
            this.Controls.Add(this.table_title);
            this.Controls.Add(this.episode_counter);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.color_picker);
            this.Controls.Add(this.table_options_panel);
            this.Controls.Add(this.allgemeineoptions);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.table_option_label);
            this.Controls.Add(this.show_rating_option);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Option";
            this.Text = "Option";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Option_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button show_rating_option;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label table_option_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label allgemeineoptions;
        private System.Windows.Forms.FlowLayoutPanel table_options_panel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button color_picker;
        private System.Windows.Forms.CheckBox rating;
        private System.Windows.Forms.CheckBox episode_counter;
        private System.Windows.Forms.TextBox table_title;
        private System.Windows.Forms.Button remove_table;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Button add_category;
    }
}