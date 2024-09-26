using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace Pic2U8G2Code
{
    public partial class frmPic2U8G2Code : Form
    {
        public class GIFFileInfo
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public int FrameCount { get; set; }

            public int NewWidth { get; set; }
            public int NewHeight { get; set; }

            public int ArraySize { get; set; }  //数组大小(每帧字节)
        }

        public frmPic2U8G2Code()
        {
            InitializeComponent();
        }

        private void btnChooseGIFFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "选择动图GIF文件",
                Filter = "GIF文件|*.gif",
                FileName = string.Empty,
                FilterIndex = 0,
                RestoreDirectory = true,
                Multiselect = false,
                ShowReadOnly = false
            };
            var result = openFileDialog.ShowDialog(this);
            if (result != DialogResult.OK) return;
            string GIFFileFullName = openFileDialog.FileName;

            txtGIFFileFullName.Text = GIFFileFullName;

            GIFFileInfo gfi = getGIFSize(GIFFileFullName);

            if (gfi != null)
            {
                lblGIFFileInfo.Text = $"GIF文件信息: 原宽度: {gfi.Width} 原高度: {gfi.Height} 总帧数: {gfi.FrameCount} 生成宽度: {gfi.NewWidth} 生成高度: {gfi.NewHeight} 数组大小(每帧字节): {gfi.ArraySize}";
            }
        }

        private GIFFileInfo getGIFSize(string GIFFileFullName)
        {
            GIFFileInfo res = new GIFFileInfo();

            if (File.Exists(GIFFileFullName))
            {
                using (Image gifImage = Image.FromFile(GIFFileFullName))
                {
                    res.Width = gifImage.Width;
                    res.Height = gifImage.Height;
                    res.FrameCount = gifImage.GetFrameCount(FrameDimension.Time);

                    res.NewWidth = (int)Math.Ceiling((double)res.Width / 8) * 8;
                    res.NewHeight = res.Height;

                    res.ArraySize = res.NewWidth * res.NewHeight / 8;
                }
            }
            return res;
        }

        private void btnGIF2Code_Click(object sender, EventArgs e)
        {
            string GIFFileFullName = txtGIFFileFullName.Text;

            if (File.Exists(GIFFileFullName))
            {
                GIFFileInfo gfi = getGIFSize(GIFFileFullName);
                StringBuilder gifString = new StringBuilder();

                gifString.AppendLine("******************** main.cpp ********************");
                gifString.AppendLine();
                gifString.AppendLine("#include <Arduino.h>");
                gifString.AppendLine("#include <U8g2lib.h>  // 加载 U8g2 库");
                gifString.AppendLine();
                gifString.AppendLine("// 使用SPI的OLED 128X64屏幕");
                gifString.AppendLine("U8G2_SSD1309_128X64_NONAME0_F_4W_SW_SPI u8g2(U8G2_R0, /* clock= */ 16, /* data= */ 17, /* cs= */ 19, /* dc= */ 18, /* reset= */ 5);");
                gifString.AppendLine();
                gifString.AppendLine("// 使用I2C的OLED 128X64屏幕");
                gifString.AppendLine("// U8G2_SSD1309_128X64_NONAME0_F_HW_I2C u8g2(U8G2_R0, /* reset=*/0, /* clock=*/21, /* data=*/22);");
                gifString.AppendLine();
                gifString.AppendLine("void loop()");
                gifString.AppendLine("{");
                gifString.AppendLine("  for (int i = 0; i < gif_length; ++i)");
                gifString.AppendLine("  {");
                gifString.AppendLine("    show_gif(i);");
                gifString.AppendLine("  }");
                gifString.AppendLine("}");
                gifString.AppendLine();

                gifString.AppendLine("void show_gif(int i)");
                gifString.AppendLine("{");
                gifString.AppendLine("  u8g2.setDrawColor(0);");
                gifString.AppendLine("  u8g2.drawBox(0, 0, 128, 64);");
                gifString.AppendLine("  u8g2.setDrawColor(1);");
                gifString.AppendLine($"  u8g2.drawXBM({(128 - gfi.NewWidth) / 2 }, 0, {gfi.NewWidth}, {gfi.NewHeight}, gif[i]);");
                gifString.AppendLine("  u8g2.sendBuffer();");
                gifString.AppendLine("}");
                gifString.AppendLine();

                gifString.AppendLine("******************** gif.h ********************");
                gifString.AppendLine();
                gifString.AppendLine($"static const int gif_length = {gfi.FrameCount};");
                gifString.AppendLine();
                gifString.AppendLine($"static const unsigned char gif[][{gfi.ArraySize}] = {{");

                bool isAddBit = chkGIF2CodeAddBit.Checked;
                using (Image gifImage = Image.FromFile(GIFFileFullName, true))
                {
                    for (int i = 0; i < gfi.FrameCount; i++)
                    {
                        gifImage.SelectActiveFrame(FrameDimension.Time, i);

                        using (Image frameGIF = (Image)gifImage.Clone())
                        {
                            gifString.AppendLine(ConvertImageToHexString(frameGIF, isAddBit));
                        }
                    }
                }
                gifString.AppendLine("};");

                txtCode.Text = gifString.ToString();
            }
        }

        private string ConvertImageToHexString(Image image, bool isAddBit)
        {
            Bitmap bitmap = new Bitmap(image);
            int width = bitmap.Width;
            int height = bitmap.Height;

            StringBuilder hexBuilder = new StringBuilder();

            for (int y = 0; y < height; y++)
            {
                byte currentByte = 0;
                int bitCount = 0;

                for (int x = 0; x < width; x++)
                {
                    Color color = bitmap.GetPixel(x, y);
                    bool isBlack = color.R == 0 && color.G == 0 && color.B == 0;

                    if (isBlack)
                    {
                        currentByte |= (byte)(1 << bitCount);
                    }

                    bitCount++;

                    if (bitCount == 8 || x == width - 1)
                    {
                        hexBuilder.Append("0x" + currentByte.ToString("X2") + ", ");
                        currentByte = 0;
                        bitCount = 0;
                    }
                }

                if (bitCount > 0)
                {
                    // 如果该行的像素点不足8的倍数，不是补0而是在行末补1
                    if (isAddBit) currentByte |= (byte)(0xFF >> (8 - bitCount));

                    hexBuilder.Append("0x" + currentByte.ToString("X2") + ", ");
                }
            }

            return hexBuilder.ToString();
        }

        private void btnChoosePicFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            var result = folderBrowserDialog.ShowDialog(this);
            if (result != DialogResult.OK) return;

            string PicFolderPath = folderBrowserDialog.DirectoryPath;
            txtPicFolderPath.Text = PicFolderPath;

            // 获取所有文件
            string[] files = Directory.GetFiles(PicFolderPath);


            int PicCounter = files.Length;
            int NewWidth, NewHeight, ArraySize;
            if (PicCounter > 0)  // 读取首张宽高处理
            {
                using (Image picImage = Image.FromFile(files[0], true))
                {
                    NewWidth = (int)Math.Ceiling((double)picImage.Width / 8) * 8;
                    NewHeight = picImage.Height;
                    ArraySize = NewWidth * NewHeight / 8;

                    lblPicFolderFileInfo.Text = $"图片信息: 共有 {PicCounter} 个文件，首张图片 原宽 {picImage.Width} 原高 {picImage.Height} 新宽 {NewWidth} 新高 {NewHeight} 数组大小(每帧字节) {ArraySize}";
                }
            }

        }

        private void btnFolderPic2Code_Click(object sender, EventArgs e)
        {
            string PicFolderPath = txtPicFolderPath.Text;

            // 确保目录存在
            if (Directory.Exists(PicFolderPath))
            {
                // 获取所有文件
                string[] files = Directory.GetFiles(PicFolderPath);

                int PicCounter = files.Length;

                int NewWidth, NewHeight, ArraySize = 0;
                if (PicCounter > 0)  
                {
                    // 读取首张宽高 用于计算数组大小
                    using (Image picImage = Image.FromFile(files[0], true))
                    {
                        NewWidth = (int)Math.Ceiling((double)picImage.Width / 8) * 8;
                        NewHeight = picImage.Height;
                        ArraySize = NewWidth * NewHeight / 8;
                    }

                    StringBuilder picString = new StringBuilder();
                    picString.AppendLine("#include <Arduino.h>");
                    picString.AppendLine("#include <U8g2lib.h>  // 加载 U8g2 库");
                    picString.AppendLine();
                    picString.AppendLine("// 使用SPI的OLED 128X64屏幕");
                    picString.AppendLine("U8G2_SSD1309_128X64_NONAME0_F_4W_SW_SPI u8g2(U8G2_R0, /* clock= */ 16, /* data= */ 17, /* cs= */ 19, /* dc= */ 18, /* reset= */ 5);");
                    picString.AppendLine();
                    picString.AppendLine("// 使用I2C的OLED 128X64屏幕");
                    picString.AppendLine("// U8G2_SSD1309_128X64_NONAME0_F_HW_I2C u8g2(U8G2_R0, /* reset=*/0, /* clock=*/21, /* data=*/22);");
                    picString.AppendLine();
                    picString.AppendLine($"static const int pic_counter = {PicCounter};");
                    picString.AppendLine();
                    picString.AppendLine($"static const unsigned char pic[][{ArraySize}] = {{");

                    //   

                    // 处理所有的图片
                    bool isAddBit = chkFolderPic2CodeAddBit.Checked;
                    foreach (string picfile in files)
                    {
                        using (Image picImage = Image.FromFile(picfile, true))
                        {
                            picString.AppendLine(ConvertImageToHexString(picImage, isAddBit));
                        }
                    }

                    picString.AppendLine("};");
                    picString.AppendLine();
                    picString.AppendLine();
                    picString.AppendLine("void setup()");
                    picString.AppendLine("{");
                    picString.AppendLine($"  u8g2.drawXBMP(0, 0, {NewWidth}, {NewHeight}, pic[0]);");
                    picString.AppendLine("}");
                    picString.AppendLine();


                    txtCode.Text = picString.ToString();
                }
            }



        }
    }
}
