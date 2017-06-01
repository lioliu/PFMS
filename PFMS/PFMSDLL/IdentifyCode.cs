using System;
using System.Drawing;
using System.Linq;
namespace PFMSDLL
{
    public class IdentifyCode
    {
        private int Length { set; get; }
        private String Code { set; get; }
        private const String Codelist = "ABCDEFGHIJKLMNOPQRSTUVWXYZ3456789";
        Graphics Graphic { get; }
        IdentifyCode()
        {
            Length = 6;
            Code = GetRandomCode(Length, Codelist);
            Graphic = CreateImage(Code,Length*20,28);
        }
        IdentifyCode(int length)
        {
            Length = length;
            Code = GetRandomCode(Length, Codelist);
            Graphic = CreateImage(Code, Length * 20, 28);
        }
        private Graphics CreateImage(string randomCode,int width,int height)
        {
            int randAngle = 45;
            Bitmap map = new Bitmap(width, height);
            Graphics graph = Graphics.FromImage(map);
            graph.Clear(Color.AliceBlue);
            graph.DrawRectangle(new Pen(Color.Black, 0), 0, 0, map.Width - 1, map.Height - 1);
            graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Random rand = new Random();
            Pen blackPen = new Pen(Color.LightGray, 0);
            Pen DrawLine = new Pen(Color.Black, 0);
            
            for (int i = 0; i < 50; i++)
                graph.DrawRectangle(blackPen, rand.Next(0, map.Width), rand.Next(0, map.Height), 1, 1);
            
            for (int i = 0; i < 5; i++)
                graph.DrawLine(DrawLine, rand.Next(0, map.Width), rand.Next(0, map.Height), rand.Next(0, map.Width), rand.Next(0, map.Height));
            char[] chars = randomCode.ToArray();
            StringFormat format = new StringFormat(StringFormatFlags.NoClip)
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            Color[] color = { Color.Black, Color.Red, Color.Blue, Color.Brown, Color.Orange, Color.Purple };
            string[] font = { "Verdana", "Microsoft Sans Serif", "Comic Sans Ms", "Arial", "宋体", "黑体" };
            for (int i = 0; i < chars.Length; i++)
            {
                int cindex = rand.Next(color.Length);
                int findex = rand.Next(font.Length);
                Font f = new Font(font[findex], 13, FontStyle.Bold);
                Brush b = new SolidBrush(color[cindex]);
                Point dot = new Point(16, 16);
                float angle = rand.Next(-randAngle, randAngle);
                graph.TranslateTransform(dot.X, dot.Y);
                graph.RotateTransform(angle);
                graph.DrawString(chars[i].ToString(), f, b, 1, 1, format);
                graph.RotateTransform(-angle);
                graph.TranslateTransform(2, -dot.Y);
            }
            return graph;
        }
        private String GetRandomCode(int length, string CodeSet)
        {
            String result = string.Empty;
            System.Random random = new Random();
            int rand = 0;
            for (int i = 0; i < length; i++)
            {
                rand = random.Next(CodeSet.Length);
                result += CodeSet[rand];
            }
            return result;
        }
    }
}
