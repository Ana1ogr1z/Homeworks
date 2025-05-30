using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp_SaveLoadFragments
{
    public partial class form_Main : Form
    {
        private ArrayPictures _arr_pictures;
        private int clickCount = 0;
        private int firstIndex = -1;
        private int secondIndex = -1;
        public form_Main()
        {
            InitializeComponent();
            int ind_image = 0;
            Image im_pic = (Image)Properties.Resources.ResourceManager.GetObject("Task_" + (ind_image + 1).ToString());
            Bitmap bmp_pic = new Bitmap(im_pic);
            Size size_pic = new Size(pictureBox.Width, pictureBox.Height);
            _arr_pictures = new ArrayPictures(pictureBox, bmp_pic, size_pic, 3, 4);
            AssignPictures();
        }
        private void AssignPictures()
        {
            foreach (PictureBox pic in _arr_pictures.Get_Pictures())
            {
                int index = (int)pic.Tag;
                pic.Click += new EventHandler(fragment_Click);
                pic.Visible = true;
            }
        }
        void fragment_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            int index = (int)pic.Tag;
            clickCount++;

            if (clickCount == 1)
            {
                firstIndex = index;
            }
            else if (clickCount == 2)
            {
                secondIndex = index;

                if (firstIndex != -1 && secondIndex != -1)
                {
                    _arr_pictures.Swap_Bmp(firstIndex, secondIndex);
                }

                clickCount = 0;
                firstIndex = -1;
                secondIndex = -1;
            }
            if (radioButton_Load.Checked)
            {
                Load_Fragment(index);
            }
            else
            {
                Save_Fragment(index);
            }
        }
        private void Load_Fragment(int index)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "файлы картинок (*.bmp;*.jpg;*.jpeg;)|*.bmp;*.jpg;.jpeg|All files(*.*) | *.* ";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap pic_show = new Bitmap(openFileDialog.FileName);
                _arr_pictures.Change_Bmp(index, pic_show);
            }
        }
        private void Save_Fragment(int index)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "файлы картинок (*.bmp;*.jpg;*.jpeg;)|*.bmp;*.jpg;.jpeg|All files(*.*) | *.* ";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string str_file = saveFileDialog.FileName;
                PictureBox pic = _arr_pictures[index];
                pic.Image.Save(str_file);
            }
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //private void ArrangeControls()
        //{
        //    int padding = 10;
        //    int controlHeight = 30;
        //    int buttonWidth = (this.ClientSize.Width - 3 * padding) / 3;
        //    radioButton_SaveAs.Location = new Point(padding, this.ClientSize.Height - padding - controlHeight);
        //    radioButton_SaveAs.Size = new Size(buttonWidth, controlHeight);
        //    radioButton_Load.Location = new Point(2 * padding + buttonWidth, this.ClientSize.Height - padding - controlHeight);
        //    radioButton_Load.Size = new Size(buttonWidth, controlHeight);
        //    button_Close.Location = new Point(3 * padding + 2 * buttonWidth, this.ClientSize.Height - padding - controlHeight);
        //    button_Close.Size = new Size(buttonWidth, controlHeight);
        //}
        private void form_Main_Resize(object sender, EventArgs e)
        {
            //ArrangeControls();
        }
    }
}
