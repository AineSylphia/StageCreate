using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StageCreate
{
	public partial class DrawWindow : Form
	{
		public static List<string> lines = new List<string>();
		List<PictureBox> pictureBoxes = new List<PictureBox>();
		List<Rectangle> rectangles = new List<Rectangle>();
		List<Label> labels = new List<Label>();

		int WIDTH = 1920;
		int HEIGHT = 1080;

		int picIndex = 0;

		public DrawWindow()
		{
			InitializeComponent();
		}

		private void LoadString()
		{
			WIDTH /= this.Size.Width;
			HEIGHT /= this.Size.Height;

			string[] div = { "Star", "Fragment", "Planet", "BlackHole", "Alien", "BreakStar", "Meteo" };
			int[] defsize = { 100, 100, 50, 50, 112, 100, 288 };

			foreach (string line in lines)
			{
				string[] del = line.Split(new char[] { });
				if (del[0] == "Result")
				{
					break;
				}

				int index;
				for (index = 0; index < div.Length; ++index)
				{
					if (del[0] == div[index])
						break;
				}

				//string path = @"./data/image/" + images[int.Parse(del[3])] + ".png";
				PictureBox pic = new PictureBox
				{
					Location = new Point(int.Parse(del[1]), int.Parse(del[2])),
					SizeMode = PictureBoxSizeMode.StretchImage,
				};
				pic.BackColor = System.Drawing.Color.Transparent;
				pic.Image = Main.imagesPath[int.Parse(del[3])];
				pic.Size = new Size(defsize[index], defsize[index]);

				if (del[0] == div[2] || del[0] == div[3] || del[0] == div[6])
				{
					if (int.Parse(del[4]) > defsize[index])
						pic.Size = new Size(int.Parse(del[4]), int.Parse(del[4]));
					//else
					//	pic.Size = new Size(defsize[index], defsize[index]);
				}
				if( del[0] == div[4])
				{
					
				}
				if (del[0] == div[6])
				{
					//メテオの移動計算
				}
				pic.Size = new Size(pic.Size.Width / WIDTH, pic.Size.Height / HEIGHT);
				pic.Location = new Point(pic.Location.X / 2 - pic.Size.Width / 2, pic.Location.Y / 2 - pic.Size.Height / 2);
				pictureBoxes.Add(pic);


				Label label = new Label();
				label.Location = new Point(pic.Location.X - pic.Size.Width/4, pic.Location.Y + pic.Size.Height/2);
				label.Text = picIndex.ToString();
				++picIndex;

				labels.Add(label);
			}
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			LoadString();
			for (int i = 0; i < pictureBoxes.Count(); ++i)
			{
				Controls.Add(pictureBoxes[i]);
			}
			for (int i = 0; i < labels.Count(); ++i)
			{
				Controls.Add(labels[i]);
			}
			this.Paint += new System.Windows.Forms.PaintEventHandler(DrawRect);
		}

		private void DrawRect(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			foreach (PictureBox pic in pictureBoxes)
			{
				Pen Black = new Pen(Color.Blue, 3);
				Rectangle rect = new Rectangle();
				rect.Location = pic.Location;
				rect.Size = pic.Size;
				e.Graphics.DrawEllipse(Black, rect);
			}
		}
	}
}