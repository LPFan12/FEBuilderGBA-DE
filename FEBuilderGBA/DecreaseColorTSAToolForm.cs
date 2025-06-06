﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace FEBuilderGBA
{
    public partial class DecreaseColorTSAToolForm : Form
    {
        public DecreaseColorTSAToolForm()
        {
            InitializeComponent();

            //背景を選択.
            this.Method.SelectedIndex = 1;
            this.ConvertSizeMethod.SelectedIndex = 1;

            AFilename.AllowDropFilename();
            BFilename.AllowDropFilename();

            U.AllowDropFilename(this, ImageFormRef.IMAGE_FILE_FILTER, (string filename) =>
            {
                AFilename.Text = filename;
            });
        }

        public void InitMethod(int i)
        {
            U.SelectedIndexSafety(this.Method, i);
        }

        private void DecreaseColorTSAToolForm_Load(object sender, EventArgs e)
        {

        }

        private void Method_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Method.SelectedIndex == 1)
            {//背景とCG
                U.ForceUpdate(this.ConvertWidth,30 * 8);
                U.ForceUpdate(this.ConvertHeight, 20 * 8);
                U.ForceUpdate(this.ConvertYohaku,  2 * 8);
                U.ForceUpdate(this.ConvertPaletteNo, 8);
                U.ForceUpdate(this.ConvertReserveColor, 1);
                U.ForceUpdate(this.ConvertSizeMethod, 1);
                IgnoreTSA.Checked = false;
            }
            else if (Method.SelectedIndex == 2)
            {//戦闘背景
                U.ForceUpdate(this.ConvertWidth, 30 * 8);
                U.ForceUpdate(this.ConvertHeight, 20 * 8);
                U.ForceUpdate(this.ConvertYohaku, 0);
                U.ForceUpdate(this.ConvertPaletteNo, 8);
                U.ForceUpdate(this.ConvertReserveColor, 1);
                U.ForceUpdate(this.ConvertSizeMethod, 1);
                IgnoreTSA.Checked = false;
            }
            else if (Method.SelectedIndex == 3)
            {//ワールドマップ(でかい)
                if (Program.ROM.RomInfo.version == 8)
                {
                    U.ForceUpdate(this.ConvertWidth, 480);
                    U.ForceUpdate(this.ConvertHeight, 320);
                    U.ForceUpdate(this.ConvertYohaku, 0);
                    U.ForceUpdate(this.ConvertPaletteNo, 4);
                    U.ForceUpdate(this.ConvertReserveColor, 1);
                    U.ForceUpdate(this.ConvertSizeMethod, 1);
                }
                else if (Program.ROM.RomInfo.version == 531)
                {
                    U.ForceUpdate(this.ConvertWidth, 480);
                    U.ForceUpdate(this.ConvertHeight, 320);
                    U.ForceUpdate(this.ConvertYohaku, 0);
                    U.ForceUpdate(this.ConvertPaletteNo, 4);
                    U.ForceUpdate(this.ConvertReserveColor, 1);
                    U.ForceUpdate(this.ConvertSizeMethod, 1);
                }
                else if (Program.ROM.RomInfo.version == 7)
                {
                    U.ForceUpdate(this.ConvertWidth, 1024);
                    U.ForceUpdate(this.ConvertHeight, 688);
                    U.ForceUpdate(this.ConvertYohaku, 0);
                    U.ForceUpdate(this.ConvertPaletteNo, 4);
                    U.ForceUpdate(this.ConvertReserveColor, 1);
                    U.ForceUpdate(this.ConvertSizeMethod, 1);
                }
                else if (Program.ROM.RomInfo.version == 206)
                {
                    U.ForceUpdate(this.ConvertWidth, 1024);
                    U.ForceUpdate(this.ConvertHeight, 688);
                    U.ForceUpdate(this.ConvertYohaku, 0);
                    U.ForceUpdate(this.ConvertPaletteNo, 4);
                    U.ForceUpdate(this.ConvertReserveColor, 1);
                    U.ForceUpdate(this.ConvertSizeMethod, 1);
                }
                else if (Program.ROM.RomInfo.version == 219)
                {
                    U.ForceUpdate(this.ConvertWidth, 1024);
                    U.ForceUpdate(this.ConvertHeight, 688);
                    U.ForceUpdate(this.ConvertYohaku, 0);
                    U.ForceUpdate(this.ConvertPaletteNo, 4);
                    U.ForceUpdate(this.ConvertReserveColor, 1);
                    U.ForceUpdate(this.ConvertSizeMethod, 1);
                }
                else if (Program.ROM.RomInfo.version == 6)
                {//256色なので不要
                    U.ForceUpdate(this.ConvertWidth, 240);
                    U.ForceUpdate(this.ConvertHeight, 160);
                    U.ForceUpdate(this.ConvertYohaku, 0);
                    U.ForceUpdate(this.ConvertPaletteNo, 16);
                    U.ForceUpdate(this.ConvertReserveColor, 0);
                    U.ForceUpdate(this.ConvertSizeMethod, 1);
                }
                IgnoreTSA.Checked = false;
            }
            else if (Method.SelectedIndex == 4)
            {// 04=ワールドマップ(イベント用)
                if (Program.ROM.RomInfo.version == 8)
                {
                    U.ForceUpdate(this.ConvertWidth, 30 * 8);
                    U.ForceUpdate(this.ConvertHeight, 20 * 8);
                    U.ForceUpdate(this.ConvertYohaku, 2 * 8);
                    U.ForceUpdate(this.ConvertPaletteNo, 4);
                    U.ForceUpdate(this.ConvertReserveColor, 1);
                    U.ForceUpdate(this.ConvertSizeMethod, 1);
                    IgnoreTSA.Checked = false;
                }
                else if (Program.ROM.RomInfo.version == 531)
                {
                    U.ForceUpdate(this.ConvertWidth, 30 * 8);
                    U.ForceUpdate(this.ConvertHeight, 20 * 8);
                    U.ForceUpdate(this.ConvertYohaku, 2 * 8);
                    U.ForceUpdate(this.ConvertPaletteNo, 4);
                    U.ForceUpdate(this.ConvertReserveColor, 1);
                    U.ForceUpdate(this.ConvertSizeMethod, 1);
                    IgnoreTSA.Checked = false;
                }
                else if (Program.ROM.RomInfo.version == 7)
                {
                    U.ForceUpdate(this.ConvertWidth, 30 * 8);
                    U.ForceUpdate(this.ConvertHeight, 20 * 8);
                    U.ForceUpdate(this.ConvertYohaku, 2 * 8);
                    U.ForceUpdate(this.ConvertPaletteNo, 4);
                    U.ForceUpdate(this.ConvertReserveColor, 1);
                    U.ForceUpdate(this.ConvertSizeMethod, 1);
                    IgnoreTSA.Checked = false;
                }
                else if (Program.ROM.RomInfo.version == 206)
                {
                    U.ForceUpdate(this.ConvertWidth, 30 * 8);
                    U.ForceUpdate(this.ConvertHeight, 20 * 8);
                    U.ForceUpdate(this.ConvertYohaku, 2 * 8);
                    U.ForceUpdate(this.ConvertPaletteNo, 4);
                    U.ForceUpdate(this.ConvertReserveColor, 1);
                    U.ForceUpdate(this.ConvertSizeMethod, 1);
                    IgnoreTSA.Checked = false;
                }
                else if (Program.ROM.RomInfo.version == 219)
                {
                    U.ForceUpdate(this.ConvertWidth, 30 * 8);
                    U.ForceUpdate(this.ConvertHeight, 20 * 8);
                    U.ForceUpdate(this.ConvertYohaku, 2 * 8);
                    U.ForceUpdate(this.ConvertPaletteNo, 4);
                    U.ForceUpdate(this.ConvertReserveColor, 1);
                    U.ForceUpdate(this.ConvertSizeMethod, 1);
                    IgnoreTSA.Checked = false;
                }
                else if (Program.ROM.RomInfo.version == 6)
                {//256色なので不要
                    U.ForceUpdate(this.ConvertWidth, 240);
                    U.ForceUpdate(this.ConvertHeight, 160);
                    U.ForceUpdate(this.ConvertYohaku, 0);
                    U.ForceUpdate(this.ConvertPaletteNo, 16);
                    U.ForceUpdate(this.ConvertReserveColor, 0);
                    U.ForceUpdate(this.ConvertSizeMethod, 1);
                    IgnoreTSA.Checked = false;
                }
            }
            else if (Method.SelectedIndex == 5)
            {//TSAを利用しない256色
                U.ForceUpdate(this.ConvertWidth, 30 * 8);
                U.ForceUpdate(this.ConvertHeight, 20 * 8);
                U.ForceUpdate(this.ConvertYohaku, 0);
                U.ForceUpdate(this.ConvertPaletteNo, 16);
                U.ForceUpdate(this.ConvertReserveColor, 1);
                U.ForceUpdate(this.ConvertSizeMethod, 1);
                IgnoreTSA.Checked = true;
            }
            else if (Method.SelectedIndex == 6)
            {//ステータス画面背景(FE8)
                U.ForceUpdate(this.ConvertWidth, 30 * 8);
                U.ForceUpdate(this.ConvertHeight, 20 * 8);
                U.ForceUpdate(this.ConvertYohaku, 0);
                U.ForceUpdate(this.ConvertPaletteNo, 4);
                U.ForceUpdate(this.ConvertReserveColor, 1);
                U.ForceUpdate(this.ConvertSizeMethod, 1);
                IgnoreTSA.Checked = false;
            }
            else if (Method.SelectedIndex == 7)
            {//一枚絵マップチップ
                U.ForceUpdate(this.ConvertWidth, 512);
                U.ForceUpdate(this.ConvertHeight, 512);
                U.ForceUpdate(this.ConvertYohaku, 0);
                U.ForceUpdate(this.ConvertPaletteNo, 5);
                U.ForceUpdate(this.ConvertReserveColor, 1);
                U.ForceUpdate(this.ConvertSizeMethod, 0);
                IgnoreTSA.Checked = false;
            }
            else if (Method.SelectedIndex == 8)
            {//一枚絵マップチップ 10色
                U.ForceUpdate(this.ConvertWidth, 512);
                U.ForceUpdate(this.ConvertHeight, 512);
                U.ForceUpdate(this.ConvertYohaku, 0);
                U.ForceUpdate(this.ConvertPaletteNo, 10);
                U.ForceUpdate(this.ConvertReserveColor, 1);
                U.ForceUpdate(this.ConvertSizeMethod, 0);
                IgnoreTSA.Checked = false;
            }
            else if (Method.SelectedIndex == 9)
            {//09=TSAを利用しないBG256色(カットシーン)
                U.ForceUpdate(this.ConvertWidth, 30 * 8);
                U.ForceUpdate(this.ConvertHeight, 20 * 8);
                U.ForceUpdate(this.ConvertYohaku, 2 * 8);
                U.ForceUpdate(this.ConvertPaletteNo, 16);
                U.ForceUpdate(this.ConvertReserveColor, 1);
                U.ForceUpdate(this.ConvertSizeMethod, 1);
                IgnoreTSA.Checked = true;
                //0A=TSAを利用しないBG224色(会話用)
            }
            else if (Method.SelectedIndex == 0xA)
            {//0A=TSAを利用しないBG224色(会話用)
                U.ForceUpdate(this.ConvertWidth, 30 * 8);
                U.ForceUpdate(this.ConvertHeight, 20 * 8);
                U.ForceUpdate(this.ConvertYohaku, 2 * 8);
                U.ForceUpdate(this.ConvertPaletteNo, 14);
                U.ForceUpdate(this.ConvertReserveColor, 1);
                U.ForceUpdate(this.ConvertSizeMethod, 1);
                IgnoreTSA.Checked = true;
            }
        }

        private void AFileSelectButton_Click(object sender, EventArgs e)
        {
            string title = R._("開くファイル名を選択してください");
            string filter = R._("IMAGES|*.png;*.bmp;*.jpg|PNG|*.png|BMP|*.bmp|JPG|*.jpg|All files|*");

            OpenFileDialog open = new OpenFileDialog();
            open.Title = title;
            open.Filter = filter;
            DialogResult dr = open.ShowDialog();
            if (dr != DialogResult.OK)
            {
                return;
            }
            if (!U.CanReadFileRetry(open))
            {
                return;
            }
            this.AFilename.Text = open.FileName;
        }

        private void BFileSelectButton_Click(object sender, EventArgs e)
        {
            string title = R._("保存するファイル名を選択してください");
            string filter = R._("PNG|*.png|BMP|*.bmp|All files|*");
            SaveFileDialog save = new SaveFileDialog();
            save.Title = title;
            save.Filter = filter;
            Program.LastSelectedFilename.Load(this, "", save, "");
            
            DialogResult dr = save.ShowDialog();
            if (dr != DialogResult.OK)
            {
                return;
            }
            if (save.FileNames.Length <= 0 || !U.CanWriteFileRetry(save.FileNames[0]))
            {
                return;
            }
            Program.LastSelectedFilename.Save(this, "", save);
            this.BFilename.Text = save.FileName;
        }

        private void MakeButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(AFilename.Text))
            {
                return;
            }
            if (BFilename.Text == "")
            {
                return;
            }
            if (InputFormRef.IsPleaseWaitDialog(this))
            {//2重割り込み禁止
                return;
            }

            int width = (int)this.ConvertWidth.Value;
            int height = (int)this.ConvertHeight.Value;
            int yohaku = (int)this.ConvertYohaku.Value;
            int paletteno = (int)this.ConvertPaletteNo.Value;
            bool isScalable = (this.ConvertSizeMethod.SelectedIndex == 1);
            bool isReserve1stColor = (this.ConvertReserveColor.SelectedIndex == 1);
            bool ignoreTSA = IgnoreTSA.Checked;

            int errorCode;
            //少し時間がかかるので、しばらくお待ちください表示.
            using (InputFormRef.AutoPleaseWait pleaseWait = new InputFormRef.AutoPleaseWait(this))
            {
                errorCode = DecreaseColor(AFilename.Text, BFilename.Text, width, height, yohaku, paletteno, isScalable, isReserve1stColor, ignoreTSA);
            }
            //エクスプローラで選択しよう
            if (errorCode == 0)
            {
                U.SelectFileByExplorer(BFilename.Text);
            }
        }

        public static int CommandLineDecreaseColor()
        {
            U.echo("CommandLineDecreaseColor");
            string inFilename = U.at(Program.ArgsDic, "--in");
            if (!File.Exists(inFilename))
            {
                U.echo("元ファイルを「--in」で指定してください。");
                return -2;
            }
            string outFilename = U.at(Program.ArgsDic, "--out");
            if (outFilename == "")
            {
                U.echo("出力ファイルを「--out」で指定してください。");
                return -2;
            }
            int width = (int)U.atoi(U.at(Program.ArgsDic, "--width"));
            int height = (int)U.atoi(U.at(Program.ArgsDic, "--height"));
            int yohaku = (int)U.atoi(U.at(Program.ArgsDic, "--yohaku"));
            int paletteno = (int)U.atoi(U.at(Program.ArgsDic, "--paletteno"));
            if (paletteno == 0)
            {
                paletteno = 1;
            }
            bool isScalable = !Program.ArgsDic.ContainsKey("--noScale");
            bool isReserve1stColor = !Program.ArgsDic.ContainsKey("--noReserve1stColor");
            bool ignoreTSA = Program.ArgsDic.ContainsKey("--ignoreTSA");

            return DecreaseColor(inFilename, outFilename, width, height, yohaku, paletteno, isScalable, isReserve1stColor, ignoreTSA);
        }

        public static int DecreaseColor(string inFilename, string outFilename, int width, int height, int yohaku, int paletteno, bool isScalable, bool isReserve1stColor, bool ignoreTSA)
        {
            try
            {

                DecreaseColor dc = new DecreaseColor();

                Bitmap src = new Bitmap(inFilename);
                Bitmap dest;

                if (width > 0 && height > 0)
                {
                    Bitmap src2;
                    if (isScalable)
                    {
                        src2 = ImageUtil.BitmapScale(src, width, height);
                    }
                    else
                    {
                        src2 = ImageUtil.BitmapSizeChange(src, 0, 0, width, height);
                    }
                    dest = dc.Convert(src2, paletteno, yohaku, isReserve1stColor, ignoreTSA);
                    src2.Dispose();
                }
                else
                {
                    dest = dc.Convert(src, paletteno, yohaku, isReserve1stColor, ignoreTSA);
                }

                U.BitmapSave(dest, outFilename);

                src.Dispose();
                dest.Dispose();
            }
            catch (System.Runtime.InteropServices.ExternalException ee)
            {
                R.ShowStopError(R.ExceptionToString(ee));
                return -1;
            }
            catch (System.ArgumentOutOfRangeException ee)
            {
                R.ShowStopError(R.ExceptionToString(ee));
                return -1;
            }
            catch (System.ArgumentException ee)
            {
                R.ShowStopError(R.ExceptionToString(ee));
                return -1;
            }

            return 0;
        }

        private void AFilename_DoubleClick(object sender, EventArgs e)
        {
            this.AFileSelectButton.PerformClick();
        }

        private void BFilename_DoubleClick(object sender, EventArgs e)
        {
            this.BFileSelectButton.PerformClick();
        }

        public static string GetExplainDecreaseColor()
        {
            return R._("16色を超える画像を利用したい場合は、減色ツールを利用してください。\r\nTSAを考慮して減色することで、16色*8パレット利用できます。\r\n");
        }

        private void ConvertPaletteNo_ValueChanged(object sender, EventArgs e)
        {
            IgnoreTSA.Visible = (ConvertPaletteNo.Value >= 4);
        }

    }
}
