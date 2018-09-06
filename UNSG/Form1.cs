using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UNSG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;

            ruler = new Ruler();
            SetText();

            //データ読み込み
            try
            {
                var data = System.IO.File.ReadAllText(filePath, endode);

                MenuNoDialog.Checked = data[0] == '1';
                textBoxMemo.Text = data.Remove(0, 1);
            }
            catch (Exception)
            {
            }
        }

        public string filePath = "data";
        public System.Text.Encoding endode = System.Text.Encoding.GetEncoding("shift_jis");

        /// <summary>
        /// 表示更新
        /// </summary>
        private void SetText()
        {
            stateMode.Text = ruler.Name;
            stateMode.ForeColor = ruler.NameColor;

            stateTurn.Text = string.Format("{0}ターン目", ruler.Turn);
            stateAction.Text = string.Format("最大{0}回", ruler.Action);
            stateLP.Text = ruler.LP.ToString(); ;
        }

        public Ruler ruler;

        /// <summary>
        /// キー押下時イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (ruler.IsDead) return;

            //ルーラーのタブ以外はリターン
            if (tabControl1.SelectedIndex != 0) return;

            int Damage;
            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    ruler.LP += e.Control ? 10 : -10;
                    break;

                case Keys.D1:
                case Keys.D2:
                case Keys.D3:
                case Keys.D4:
                case Keys.D5:
                case Keys.D6:
                case Keys.D7:
                case Keys.D8:
                case Keys.D9:
                    Damage = e.KeyValue - 48;
                    ruler.LP += e.Control ? Damage : -Damage;
                    break;

                case Keys.NumPad1:
                case Keys.NumPad2:
                case Keys.NumPad3:
                case Keys.NumPad4:
                case Keys.NumPad5:
                case Keys.NumPad6:
                case Keys.NumPad7:
                case Keys.NumPad8:
                case Keys.NumPad9:
                    Damage = e.KeyValue - 96;
                    ruler.LP += e.Control ? Damage : -Damage;
                    break;

                case Keys.Add:
                case Keys.Oemplus:
                    ruler.Action--;
                    break;

                case Keys.Return:
                    ruler.Turn++;
                    ruler.ResetAction(ruler.Mode);
                    break;

                default:
                    break;
            }

            // 撃破時
            if (ruler.LP <= 0 && ruler.Mode != Ruler.RulerMode.Death)
            {
                // 青か赤か
                if (ruler.Mode == Ruler.RulerMode.Mode1 && ruler.Turn % 2 == 0)
                {
                    ruler.Mode = Ruler.RulerMode.Mode2Red;
                }
                else if (ruler.Mode == Ruler.RulerMode.Mode1 && ruler.Turn % 2 == 1)
                {
                    ruler.Mode = Ruler.RulerMode.Mode2Blue;
                }
                else if (ruler.Mode == Ruler.RulerMode.Mode2Red)
                {
                    ruler.Mode = Ruler.RulerMode.Mode3;
                }
                else
                {
                    ruler.Mode++;
                }

                ruler.SetData(ruler.Mode);
            }

            ruler.LP = Math.Max(0, ruler.LP);

            //補正
            ruler.Action = Math.Max(0, ruler.Action);

            SetText();
        }

        private void リセットToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void バージョンToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show
            (
                "アンサガツール\n\nv0.1.4\n\n2014/11/17\n製作者 : We",
                "情報",
                MessageBoxButtons.OK
            );
        }

        private void 使い方ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show
            (
                "ルーラータブ\n"
                + "　　Enterキーを押すとターン数が1増えます\n"
                + "　　+キーを押すと行動回数が1減ります。\n"
                + "　　数字キーを押すと押した数字の数だけLPが減ります。\n"
                + "　　0を押すと10減ります。\n"
                + "　　Ctrl + 数字キーでLPが増えます。\n\n"
                + "カウンタタブ\n"
                + "　　数字を直接入力するか、ボタンを押して増減できます。\n\n"
                + "メモタブ\n"
                + "　　ご自由にお使いください。\n"
                + "　　書いた内容は終了時に保存されます。",
                "使い方",
                MessageBoxButtons.OK
            );
        }

        private void buttonBowL_Click(object sender, EventArgs e) => SetValue(textBoxBow, -1);
        private void buttonBowR_Click(object sender, EventArgs e) => SetValue(textBoxBow, 1);
        private void buttonDifL_Click(object sender, EventArgs e) => SetValue(textBoxDif, -1);
        private void buttonDifR_Click(object sender, EventArgs e) => SetValue(textBoxDif, 1);
        private void button2_Click(object sender, EventArgs e) => SetValue(textBox1, -1);
        private void button4_Click(object sender, EventArgs e) => SetValue(textBox2, -1);
        private void button6_Click(object sender, EventArgs e) => SetValue(textBox3, -1);
        private void button1_Click_1(object sender, EventArgs e) => SetValue(textBox1, 1);
        private void button3_Click(object sender, EventArgs e) => SetValue(textBox2, 1);
        private void button5_Click(object sender, EventArgs e) => SetValue(textBox3, 1);

        private void SetValue(TextBox tBox, int n)
        {
            int result = 0;

            if (int.TryParse(tBox.Text, out result))
            {
                result += n;

                //範囲内に丸め込み
                result = Math.Min(20, result);
                result = Math.Max(0, result);
            }
            else
            {
                result = 0;
            }

            tBox.Text = result.ToString();
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                textBoxMemo.Select();
            }
        }

        private void button11_Click(object sender, EventArgs e) => textBoxBow.Text = "0";
        private void button10_Click(object sender, EventArgs e) => textBoxDif.Text = "0";
        private void button9_Click(object sender, EventArgs e) => textBox1.Text = "0";
        private void button8_Click(object sender, EventArgs e) => textBox2.Text = "0";
        private void button7_Click(object sender, EventArgs e) => textBox3.Text = "0";

        /// <summary>
        /// 終了処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string StringData = MenuNoDialog.Checked ? "1" : "0";

            StringData += textBoxMemo.Text;
            System.IO.File.WriteAllText(filePath, StringData, endode);
        }

        private void ルーラーToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CanRulerReset()) return;

            ruler.SetData(Ruler.RulerMode.Mode1);
            ruler.ResetAction(Ruler.RulerMode.Mode1);
            SetText();
        }

        private bool CanRulerReset()
        {
            if (MenuNoDialog.Checked) return true;
            if (DialogResult.Yes == MessageBox.Show("ルーラーの表示内容を初期化します。\nよろしいですか？",
              "確認",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Exclamation,
              MessageBoxDefaultButton.Button2))
            {
                return true;
            }

            return false;
        }

        private void カウンタToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CanCounterReset()) return;

            textBoxBow.Text = "0";
            textBoxDif.Text = "0";
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
        }

        private bool CanCounterReset()
        {
            if (MenuNoDialog.Checked) return true;
            if (DialogResult.Yes == MessageBox.Show("カウンタの表示内容を初期化します。\nよろしいですか？",
             "確認",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Exclamation,
             MessageBoxDefaultButton.Button2))
            {
                return true;
            }
            return false;
        }
    }
}
