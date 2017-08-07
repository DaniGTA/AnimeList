using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeList
{
    class anime_info_hover
    {
        public static void show_only_image(PictureBox image,Image anime_image,Point mouse_point)
        {
            if (image.Image != anime_image)
            {
                image.BackColor = Color.Transparent;
                image.Name = "hover_image";
                image.Size = new Size(180, 220);
                image.BorderStyle = BorderStyle.None;
                image.SizeMode = PictureBoxSizeMode.Zoom;
                image.Image = anime_image;

            }

            image.Location = mouse_point;
            image.Visible = false;
            image.Visible = true;
        }
    }
}
