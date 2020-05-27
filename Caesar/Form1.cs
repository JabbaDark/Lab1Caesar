using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Caesar
{
    public partial class Form1 : Form
    {
        Encoding utf = Encoding.UTF8;
        Encoding win = Encoding.GetEncoding(1251);
        
        public Form1()
        {
            InitializeComponent();

        }

        private void CodeOne_Click(object sender, EventArgs e)// кодирование слова из строки с указанным шагом
        {
            string Message = MesMain.Text;// получение текста из текстового поля
            byte[] meswin = win.GetBytes(Message);// разбиение в удобный для перевода вид
            int S = Convert.ToInt32(Move.Text);// перевод шага шифрования из текстового вида в целочисленный

            for (int i = 0; i < Message.Length; i++)// посимвольный сдвиг букв на указанный шаг
            {
                int a = Convert.ToInt32(meswin[i]);
                
                if (a>64 && a<91)
                {   
                    a = a+S;
                    if (a>90)
                    { a = a - 90 + 64; }
                    if (a > 255)
                    { a = a - 255 + 65; } ;
                    
                    
                }
                if (a>96 && a<123)
                {   
                    a = a+S;
                    if(a>122)
                    { a = a - 122 + 96; }
                    if (a > 255)
                    { a = a - 255 + 96; }
                    
                    
                }
                if(a>191 && a<224)
                {  
                    a = a+S;
                    if (a>223)
                    { a = a - 223 + 191; }
                    if (a > 255)
                    { a = a - 255 + 191; }
                    
                    
                }
                if(a>223 && a<256)
                {
                    a = a+S;
                    if (a > 255)
                    { a = a - 255 + 223; }  
                }
                meswin[i] = Convert.ToByte(a);

            }
            MesFin.Text = win.GetString(meswin);// вывод полученного сообщения в большое текстовое окно
        }

        private void CodeAll_Click(object sender, EventArgs e)// все возможные расшифровки криптограммы
        {
            //принцип тот же, что и в кодировании фразы на заданный шаг, только здесь вместо сдвига вправо на фиксированное число - все варианты сдвигов влево от 1 до 33
            string Message = MesMain.Text;
            byte[] meswin = win.GetBytes(Message);
            byte[] mestemp = win.GetBytes(Message);
            var MesFinArr = new string[33];
            int S = 0;
            for (int j = 0; j < 33; j++)
            {
                S += 1;
                for (int i = 0; i < Message.Length; i++)
                {
                    int a = Convert.ToInt32(meswin[i]);

                    if (a > 64 && a < 91)
                    {
                        a = a - S;
                        if (a < 65)
                        { a = a - 64 + 90; }

                    }
                    if (a > 96 && a < 123)
                    {
                        a = a - S;
                        if (a < 97)
                        { a = a + 122 - 96; }

                    }
                    if (a > 191 && a < 224)
                    {
                        a = a - S;
                        if (a < 192)
                        { a = a + 223 - 191; }

                    }
                    if (a > 223 && a < 256)
                    {
                        a = a - S;
                        if (a < 224)
                        { a = a + 255 - 223; }
                    }
                    mestemp[i] = Convert.ToByte(a);

                }
                MesFinArr[j] = win.GetString(mestemp) + Environment.NewLine;
            }
            for (int x = 0; x < 33; x++)
            {
                MesFin.Text += MesFinArr[x];
            }
        }

        public void button1_Click(object sender, EventArgs e)// Шифрование текста указанного файла в другой текстовый документ, здесь даже немного проще, так как не надо прописывать дополнительные условия чтобы код работал только с буквами
        {
            using ( StreamReader sr = File.OpenText(@"E:\Code\File.txt"))
            {
                char c;
                while (sr.Peek()>-1)
                {
                    c = (char)sr.Read();
                    string mes = c.ToString();
                    byte[] meswin = win.GetBytes(mes);
                    int S = Convert.ToInt32(Move.Text);
                    int a = Convert.ToInt32(meswin[0]);
                    a = a + S;
                    if (a > 255)
                        { a = a - 256; }
                    meswin[0] = Convert.ToByte(a);
                    String temp = win.GetString(meswin);
                    using (StreamWriter FCode = new StreamWriter(@"E:\Code\FileCode.txt", true, System.Text.Encoding.UTF8))
                    {
                        FCode.Write(temp);
                    }
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)// Расшифровка текста, полученного после действия кнопки Зашифровать файл, просто обратные предыдущей кнопке действия
        {
            using (StreamReader sr = File.OpenText(@"E:\Code\FileCode.txt"))
            {
                char c;
                while (sr.Peek() > -1)
                {
                    c = (char)sr.Read();
                    string mes = c.ToString();
                    byte[] meswin = win.GetBytes(mes);
                    int S = Convert.ToInt32(Move.Text);

                    int a = Convert.ToInt32(meswin[0]);
                    a = a - S;
                    if (a < 0)
                        { a = a + 256; }

                    meswin[0] = Convert.ToByte(a);
                    String temp = win.GetString(meswin);
                    using (StreamWriter FCode = new StreamWriter(@"E:\Code\File.txt", true, System.Text.Encoding.UTF8))
                    {
                        FCode.Write(temp);
                    }
                }
            }
        }
    }
}
