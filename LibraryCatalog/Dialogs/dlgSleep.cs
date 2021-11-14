using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryCatalog.Dialogs
{
    public partial class dlgSleep : Form
    {
        public int Delay { get; protected set; }
        private List<string> _notes;  
        public dlgSleep()
        {
            InitializeComponent();
            CreateNotes();
            Random rnd = new Random();
            int ir = rnd.Next(0, _notes.Count - 1);
            txtNote.Text = _notes[ir];

            ir = rnd.Next(1, 6);
            string filename = Constants.GetAppImgPath();
            //#endif
            string imgpath = $"{filename}me{ir}.jpg";
            Image img = Image.FromFile(imgpath);
            int w = img.Width;
            Bitmap b = new Bitmap(imgpath);
            Utilities.FillPictureBox(pictBox, b); 
        }
        protected void CreateNotes()
        {
            _notes = new List<string>();
            _notes.Add("Смею ли я надеяться осязать свою любимую на брачном ложе?");
            _notes.Add("Спать пора, уснул бычок!\n Лег в коробку на бочок.\n И тебе пора ложиться, с мужем жизнью насладиться!"); 
            _notes.Add("Товарищ! Учение свет, но все же!\n И темнота под одеялом с мужем,\n\t неплохо тоже!"); 
            _notes.Add("Как было бы славно потискать жену!\n Но где она бродит - я не пойму!"); 
            _notes.Add("Ночь наступила, солнце зашло.\n Пусто в постели... Нехорошо..."); 
            _notes.Add("Не драконами только,\n Жива женская душа! \nИди ко мне под одеялко, ласка моя - хороша!"); 
            _notes.Add("Приди ко мне дорогая!\nКрасивая и нагая!"); 
            _notes.Add("Не спится без тебя мне, хоть кричи!\n Мне б попочку огладить в сей ночи!"); 
            _notes.Add("Хочу я девочку свою к себе прижать!\nНо видно, очень долго нужно ждать!"); 
            _notes.Add("Как плохо без Танюшечки моей лежать!\nНо делать нечего,\n\tПридется ждать!"); 
            _notes.Add("Пора уж спать, Танюшечка моя!\nТы завтра прочитаешь Маркеса и Труайя!"); 
            _notes.Add("Танюшечкину штучку я люблю!\nНо нет ее...\nМне плохо, я терплю...");            
        }
        //public void FillPictureBox(Bitmap bmp)
        //{

        //    pictBox.SizeMode = PictureBoxSizeMode.Normal;
        //    int W = pictBox.Width;
        //    int H = pictBox.Height;
        //    int w = bmp.Width;
        //    int h = bmp.Height;
        //    double rh = h / H;
        //    double rw = w / W;
        //    double rate = Math.Max(rh, rw);
        //    if (rate > 0)
        //    {
        //        h = (int)(h / rate);
        //        w = (int)(w / rate);
        //    }


        //    Bitmap resized = new Bitmap(bmp, new Size(w, h));
        //    pictBox.Image = resized;
        //    pictBox.SizeMode = PictureBoxSizeMode.CenterImage;
        //}

        private void OnOK(object sender, EventArgs e)
        {
            Delay = 0;
            DialogResult = DialogResult.OK;
        }

        private void OnOK5Min(object sender, EventArgs e)
        {
            Delay = 5;
            DialogResult = DialogResult.OK;
        }

        private void OnOk10Min(object sender, EventArgs e)
        {
            Delay = 10;
            DialogResult = DialogResult.OK;
        }
    }
}
