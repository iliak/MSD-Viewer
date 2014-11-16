using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBM
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			updating = true;
			pixelformat.DataSource = Enum.GetValues(typeof(PixelFormat));
			pixelformat.SelectedItem = PixelFormat.Format32bppPArgb;

			updating = false;

			BringToFront();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ouvrirToolStripButton_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fd = new FolderBrowserDialog();
			if (fd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
				return;

			SetDirectory(fd.SelectedPath);

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="dir"></param>
		private void SetDirectory(string dir)
		{
			listBox1.Items.Clear();

			if (!Directory.Exists(dir + "/assets"))
			{
				MessageBox.Show("Wrong directory !", "Error", MessageBoxButtons.OK);
				return;
			}

			Directory.SetCurrentDirectory(dir + "/assets");

			string[] files = Directory.GetFiles(dir + "/assets", "*.obm");
			foreach (string file in files)
				listBox1.Items.Add(Path.GetFileName(file));

		}


		/// <summary>
		/// 
		/// </summary>
		private void Clear()
		{
			ImgWidth = 0;
			ImgHeight = 0;
			Data = null;
			Palette = null;

			t_header.Clear();
			t_subheader.Clear();
			t_width.Clear();
			t_height.Clear();

			if (pictureBox1.Image != null)
				pictureBox1.Image.Dispose();
			pictureBox1.Image = null;
			pictureBox1.Size = Size.Empty;
			pictureBox1.Refresh();

		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		private bool LoadAsset(string name)
		{

			// 0x0404 : Format8bppIndexed
			// 0x0801 : Format8bppIndexed
			// 0x0804 : Format8bppIndexed
			// 0x1800 : Format24bppRgb
			// 0x1804 : Format16bppArgb1555
			// 0x2000 : Format24bppRgb
			// 0x2001 : Format32bppArgb
			//
			Clear();

			FileInfo info = new FileInfo(name);

			using (BinaryReader br = new BinaryReader(File.Open(name, FileMode.Open)))
			{
				short tag = br.ReadInt16();
				t_header.Text = "0x" + tag.ToString("X4");
				if (tag != 0x494F)
					return false;


				byte tag1 = br.ReadByte();
				byte tag2 = br.ReadByte();
				tag = (short)(tag1 | tag2 << 8);
				t_subheader.Text = "0x" + tag.ToString("X4");
				t_binary.Text = Convert.ToString(tag2, 2).PadLeft(8, '0') + " " + Convert.ToString(tag1, 2).PadLeft(8, '0');


				ImgWidth = br.ReadInt16();
				ImgHeight = br.ReadInt16();

				switch (tag)
				{
					// (Width * Height) / 2 + (32 + 8)
					// Format: (?) Palette 16 colors
					// Stride: Width / 2
					case 0x404:
					{
						Format = PixelFormat.Format8bppIndexed;
						Stride = ImgWidth / 2;

						Palette = new Color[16];
						for (int i = 0; i < 16; i++)
						{
							int val = br.ReadUInt16();
							int a = (val & 1) == 1 ? 255 : 0;
							int r = (val >> 1) & 0x1F;
							int g = (val >> 6) & 0x1F;
							int b = (val >> 11) & 0x1F;

							Palette[i] = Color.FromArgb(a, b * 8, g * 8, r * 8);
						}

						Data = br.ReadBytes((ImgWidth / 2) * ImgHeight);
					}
					break;

					// Width * Height + (1024 + 8)
					// Format: Format8bppIndexed
					// Stride: Width
					case 0x801:
					{
						Format = PixelFormat.Format8bppIndexed;
						Stride = ImgWidth;

						Palette = new Color[256];
						for (int i = 0; i < 256; i++)
						{
							int b = br.ReadByte();
							int g = br.ReadByte();
							int r = br.ReadByte();
							int a = br.ReadByte();
							Palette[i] = Color.FromArgb(a, b, g, r);
						}

						Data = br.ReadBytes(ImgWidth * ImgHeight);
					}
					break;

					// Width * Height + (512 + 8)
					// Format: Indexed ARGB1555
					// Stride: Width
					case 0x804:
					{
						Format = PixelFormat.Format8bppIndexed;
						Stride = ImgWidth;

						Palette = new Color[256];
						for (int i = 0; i < 256; i++)
						{
							int val = br.ReadUInt16();
							int a = (val & 1) == 1 ? 255 : 0;
							int r = (val >> 1) & 0x1F;
							int g = (val >> 6) & 0x1F;
							int b = (val >> 11) & 0x1F;
							Palette[i] = Color.FromArgb(a, b * 8, g * 8, r * 8);
						}

						Data = br.ReadBytes(ImgWidth * ImgHeight);

					}
					break;

					// Width * Height * 3 + 8
					// Format: Format24bppRgb
					// Stride : Width * 3
					case 0x1800:
					{
						Format = PixelFormat.Format24bppRgb;
						Stride = ImgWidth * 3;

						Data = br.ReadBytes(ImgWidth * ImgHeight * 3);

						// Swap BGR => RGB
						for (int i = 0; i < Data.Length; i += 3)
						{
							byte r = Data[i];
							//byte g = data[i + 1];
							byte b = Data[i + 2];
							//byte a = data[i + 3];

							Data[i] = b;
							//data[i + 1] = g;
							Data[i + 2] = r;
							//data[i + 3] = a;
						}
					}
					break;

					// Width * Height * 2 + 8
					// Format: Format16bppArgb1555
					// Stride : Width * 2
					case 0x1804:
					{
						Format = PixelFormat.Format16bppArgb1555;
						Stride = ImgWidth * 2;

						Data = br.ReadBytes(ImgWidth * ImgHeight * 2);

					}
					break;

					// Width * Height * 3 + 8
					// Format: Format24bppRgb
					// Stride : Width * 3
					case 0x2000:
					{
						Format = PixelFormat.Format24bppRgb;
						Stride = ImgWidth * 3;

						Data = br.ReadBytes(ImgWidth * ImgHeight * 3);

						// Swap BGR => RGB
						for (int i = 0; i < Data.Length; i += 3)
						{
							byte r = Data[i];
							//byte g = data[i + 1];
							byte b = Data[i + 2];
							//byte a = data[i + 3];

							Data[i] = b;
							//data[i + 1] = g;
							Data[i + 2] = r;
							//data[i + 3] = a;
						}
					}
					break;



					// Width * Height * 4 + 8
					// Format: Format32bppArgb
					// Stride : Width * 4
					case 0x2001:
					{
						Format = PixelFormat.Format32bppArgb;
						Stride = ImgWidth * 4;

						Data = br.ReadBytes(ImgWidth * ImgHeight * 4);

						// Swap BGRA => ARGB
						for (int i = 0; i < Data.Length; i += 4)
						{
							byte r = Data[i];
							//byte g = data[i + 1];
							byte b = Data[i + 2];
							//byte a = data[i + 3];

							Data[i] = b;
							//data[i + 1] = g;
							Data[i + 2] = r;
							//data[i + 3] = a;
						}

					}
					break;


					default:
					{

					}
					break;

				}




				UpdatePicture();

			}
			return true;
		}


		/// <summary>
		/// 
		/// </summary>
		private void UpdatePicture()
		{
			if (updating || ImgWidth == 0 || ImgHeight == 0)
				return;

			updating = true;


			updating = false;

			pictureBox1.Image = new Bitmap(ImgWidth, ImgHeight, Stride,
				Format,
				Marshal.UnsafeAddrOfPinnedArrayElement(Data, 0));


			if (Palette != null)
			{
				ColorPalette pal = pictureBox1.Image.Palette;

				for (int i = 0; i < Palette.Length; i++)
				{
					pal.Entries[i] = Palette[i];
				}

				pictureBox1.Image.Palette = pal;
			}


			pictureBox1.Size = new Size(ImgWidth, ImgHeight);

			//pictureBox1.Refresh();
			pictureBox1.Invalidate();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			string asset = (string)listBox1.SelectedItem;

			FileInfo i = new FileInfo(asset);

			t_name.Text = asset;
			t_size.Text = i.Length.ToString("N0");
			LoadAsset(asset);
		}




		private void pixelformat_SelectedIndexChanged(object sender, EventArgs e)
		{
			Format = (PixelFormat)pixelformat.SelectedItem;
			UpdatePicture();
		}


		private void button1_Click(object sender, EventArgs e)
		{
			UpdatePicture();
		}

		byte[] Data;


		public int ImgWidth
		{
			get
			{
				return _width;
			}
			set
			{
				_width = value;
				t_width.Text = value.ToString();
			}
		}
		int _width;

		public int ImgHeight
		{
			get
			{
				return _height;
			}
			set
			{
				_height = value;
				t_height.Text = value.ToString();
			}
		}
		int _height;

		public int Stride
		{
			get
			{
				return _stride;
			}
			set
			{
				_stride = value;
			}
		}
		int _stride = 1;



		public PixelFormat Format
		{
			get
			{
				return _format;
			}
			set
			{
				_format = value;
			}
		}
		PixelFormat _format = 0;

		private Color[] Palette;

		bool updating;

	}
}
