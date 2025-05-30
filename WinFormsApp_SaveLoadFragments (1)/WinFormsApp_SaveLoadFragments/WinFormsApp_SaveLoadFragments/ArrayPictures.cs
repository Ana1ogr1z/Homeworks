using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp_SaveLoadFragments
{
    internal class ArrayPictures
    {
        private Bitmap _bmp_picture;
        private Size _size_picture;
        private PictureBox[] _pictures = null;
        private int _count_str;
        private int _count_col;
        public ArrayPictures(Control parent_control, Bitmap bmp_picture, Size size_picture, int count_str, int count_col)
        {
            _count_str = count_str;
            _count_col = count_col;
            _pictures = new PictureBox[count_str * count_col];
            _bmp_picture = bmp_picture;
            _size_picture = size_picture;
            for (int i_w = 0; i_w < _count_col; i_w++)
                for (int i_h = 0; i_h < _count_str; i_h++)
                {
                    int index = Get_Real_Index(i_w, i_h);
                    _pictures[index] = new PictureBox();
                    _pictures[index].Name = "pic_" + i_h.ToString() + "_" + i_w.ToString();
                    _pictures[index].Parent = parent_control;
                    _pictures[index].BorderStyle = BorderStyle.FixedSingle;
                    _pictures[index].SizeMode = PictureBoxSizeMode.StretchImage;
                    _pictures[index].Tag = (int)index;
                }
            Set_Sizes(size_picture);
        }
        public void Change_Bmp(int index, Bitmap bmp_change)
        {
            int w_bmp = _bmp_picture.Width / _count_col;
            int h_bmp = _bmp_picture.Height / _count_str;
            int index_string = Get_String_Index(index);
            int index_column = Get_Column_Index(index);
            RectangleF rect_temp = new RectangleF(index_string * w_bmp, index_column * h_bmp, w_bmp, h_bmp);
            Graphics gr = Graphics.FromImage(_bmp_picture);
            gr.DrawImage(bmp_change, rect_temp);
            Set_Sizes(_size_picture);
        }
        public void Swap_Bmp(int index_first, int index_second)
        {
            int w_bmp = _bmp_picture.Width / _count_col;
            int h_bmp = _bmp_picture.Height / _count_str;
            int index_first_string = Get_String_Index(index_first);
            int index_first_column = Get_Column_Index(index_first);
            RectangleF rect_first = new RectangleF(index_first_string * w_bmp, index_first_column * h_bmp, w_bmp, h_bmp);
            Bitmap bmp_first = _bmp_picture.Clone(rect_first, _bmp_picture.PixelFormat);
            int index_second_string = Get_String_Index(index_second);
            int index_second_column = Get_Column_Index(index_second);
            RectangleF rect_second = new RectangleF(index_second_string * w_bmp, index_second_column * h_bmp, w_bmp, h_bmp);
            Bitmap bmp_second = _bmp_picture.Clone(rect_second, _bmp_picture.PixelFormat);
            Graphics gr = Graphics.FromImage(_bmp_picture);
            gr.DrawImage(bmp_first, rect_second);
            gr.DrawImage(bmp_second, rect_first);
        }
        public void Set_Sizes(Size im_size)
        {
            _size_picture = im_size;
            int w = _size_picture.Width / _count_col;
            int h = _size_picture.Height / _count_str;
            int w_bmp = _bmp_picture.Width / _count_col;
            int h_bmp = _bmp_picture.Height / _count_str;
            Bitmap bmp_temp;
            RectangleF rect_temp;
            for (int i_w = 0; i_w < _count_col; i_w++)
            {
                for (int i_h = 0; i_h < _count_str; i_h++)
                {
                    rect_temp = new RectangleF(i_w * w_bmp, i_h * h_bmp, w_bmp, h_bmp);
                    bmp_temp = _bmp_picture.Clone(rect_temp, _bmp_picture.PixelFormat);
                    int index = Get_Real_Index(i_w, i_h);
                    _pictures[index].Image = bmp_temp;
                    _pictures[index].Width = w;
                    _pictures[index].Height = h;
                    _pictures[index].Left = i_w * w;
                    _pictures[index].Top = i_h * h;
                    _pictures[index].BorderStyle = BorderStyle.FixedSingle;
                    _pictures[index].SizeMode = PictureBoxSizeMode.StretchImage;
                    _pictures[index].Refresh();
                }
            }
        }
        public IEnumerable<PictureBox> Get_Pictures()
        {
            int count = _count_col * _count_str;
            for (int i = 0; i < count; i++)
            {
                if (_pictures != null)
                {
                    yield return _pictures[i];
                }
            }
        }
        public int Get_String_Index(int real_index)
        {
            int ind_string = real_index / _count_str;
            return ind_string;
        }
        public int Get_Column_Index(int real_index)
        {
            int ind_column = real_index % _count_str;
            return ind_column;
        }
        public int Get_Real_Index(int ind_str, int ind_col)
        {
            int index_1d = _count_str * ind_str + ind_col;
            return index_1d;
        }
        public PictureBox this[int index]
        {
            get
            {
                return _pictures[index];
            }
        }
        public PictureBox this[int ind_str, int ind_col]
        {
            get
            {
                if (ind_str < _count_str && ind_col < _count_col)
                {
                    int index = Get_Real_Index(ind_str, ind_col);
                    return _pictures[index];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (ind_str < _count_str && ind_col < _count_col)
                {
                    int index = Get_Real_Index(ind_str, ind_col);
                    _pictures[index] = value;
                }
            }
        }
    }
}
