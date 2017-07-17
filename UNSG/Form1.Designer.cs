namespace UNSG
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelMode = new System.Windows.Forms.Label();
            this.labelTurn = new System.Windows.Forms.Label();
            this.labelAction = new System.Windows.Forms.Label();
            this.labelLP = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.stateMode = new System.Windows.Forms.Label();
            this.stateTurn = new System.Windows.Forms.Label();
            this.stateLP = new System.Windows.Forms.Label();
            this.stateAction = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDifR = new System.Windows.Forms.Button();
            this.buttonDifL = new System.Windows.Forms.Button();
            this.textBoxDif = new System.Windows.Forms.TextBox();
            this.buttonBowR = new System.Windows.Forms.Button();
            this.buttonBowL = new System.Windows.Forms.Button();
            this.textBoxBow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxMemo = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.リセットToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ルーラーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.カウンタToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuNoDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.使い方ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョンToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMode.Location = new System.Drawing.Point(3, 14);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(67, 14);
            this.labelMode.TabIndex = 0;
            this.labelMode.Text = "ルーラー形態";
            // 
            // labelTurn
            // 
            this.labelTurn.AutoSize = true;
            this.labelTurn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTurn.Location = new System.Drawing.Point(3, 38);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(91, 14);
            this.labelTurn.TabIndex = 1;
            this.labelTurn.Text = "ターン数 [Enter]";
            // 
            // labelAction
            // 
            this.labelAction.AutoSize = true;
            this.labelAction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelAction.Location = new System.Drawing.Point(3, 65);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(74, 14);
            this.labelAction.TabIndex = 2;
            this.labelAction.Text = "残行動数 [+]";
            // 
            // labelLP
            // 
            this.labelLP.AutoSize = true;
            this.labelLP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelLP.Location = new System.Drawing.Point(3, 90);
            this.labelLP.Name = "labelLP";
            this.labelLP.Size = new System.Drawing.Size(74, 14);
            this.labelLP.TabIndex = 3;
            this.labelLP.Tag = "";
            this.labelLP.Text = "残LP [Num]";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 32);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(187, 149);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.stateMode);
            this.tabPage1.Controls.Add(this.stateTurn);
            this.tabPage1.Controls.Add(this.stateLP);
            this.tabPage1.Controls.Add(this.stateAction);
            this.tabPage1.Controls.Add(this.labelMode);
            this.tabPage1.Controls.Add(this.labelTurn);
            this.tabPage1.Controls.Add(this.labelLP);
            this.tabPage1.Controls.Add(this.labelAction);
            this.tabPage1.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(179, 122);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ルーラー";
            // 
            // stateMode
            // 
            this.stateMode.AutoSize = true;
            this.stateMode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stateMode.Location = new System.Drawing.Point(101, 14);
            this.stateMode.Name = "stateMode";
            this.stateMode.Size = new System.Drawing.Size(14, 14);
            this.stateMode.TabIndex = 5;
            this.stateMode.Text = "1";
            // 
            // stateTurn
            // 
            this.stateTurn.AutoSize = true;
            this.stateTurn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stateTurn.Location = new System.Drawing.Point(101, 38);
            this.stateTurn.Name = "stateTurn";
            this.stateTurn.Size = new System.Drawing.Size(14, 14);
            this.stateTurn.TabIndex = 6;
            this.stateTurn.Text = "2";
            // 
            // stateLP
            // 
            this.stateLP.AutoSize = true;
            this.stateLP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stateLP.Location = new System.Drawing.Point(101, 90);
            this.stateLP.Name = "stateLP";
            this.stateLP.Size = new System.Drawing.Size(14, 14);
            this.stateLP.TabIndex = 8;
            this.stateLP.Tag = "";
            this.stateLP.Text = "4";
            // 
            // stateAction
            // 
            this.stateAction.AutoSize = true;
            this.stateAction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stateAction.Location = new System.Drawing.Point(101, 65);
            this.stateAction.Name = "stateAction";
            this.stateAction.Size = new System.Drawing.Size(14, 14);
            this.stateAction.TabIndex = 7;
            this.stateAction.Text = "3";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.buttonDifR);
            this.tabPage2.Controls.Add(this.buttonDifL);
            this.tabPage2.Controls.Add(this.textBoxDif);
            this.tabPage2.Controls.Add(this.buttonBowR);
            this.tabPage2.Controls.Add(this.buttonBowL);
            this.tabPage2.Controls.Add(this.textBoxBow);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(179, 122);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "カウンタ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(104, 92);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(22, 22);
            this.button5.TabIndex = 34;
            this.button5.Text = "→";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(59, 92);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(22, 22);
            this.button6.TabIndex = 33;
            this.button6.Text = "←";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(82, 92);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(21, 21);
            this.textBox3.TabIndex = 32;
            this.textBox3.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 14);
            this.label5.TabIndex = 31;
            this.label5.Text = "投げ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(104, 70);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 22);
            this.button3.TabIndex = 30;
            this.button3.Text = "→";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(59, 70);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(22, 22);
            this.button4.TabIndex = 29;
            this.button4.Text = "←";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 70);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(21, 21);
            this.textBox2.TabIndex = 28;
            this.textBox2.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 14);
            this.label4.TabIndex = 27;
            this.label4.Text = "キック";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 48);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 26;
            this.button1.Text = "→";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(59, 48);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 22);
            this.button2.TabIndex = 25;
            this.button2.Text = "←";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 48);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(21, 21);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 14);
            this.label3.TabIndex = 23;
            this.label3.Text = "パンチ";
            // 
            // buttonDifR
            // 
            this.buttonDifR.Location = new System.Drawing.Point(104, 26);
            this.buttonDifR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDifR.Name = "buttonDifR";
            this.buttonDifR.Size = new System.Drawing.Size(22, 22);
            this.buttonDifR.TabIndex = 22;
            this.buttonDifR.Text = "→";
            this.buttonDifR.UseVisualStyleBackColor = true;
            this.buttonDifR.Click += new System.EventHandler(this.buttonDifR_Click);
            // 
            // buttonDifL
            // 
            this.buttonDifL.Location = new System.Drawing.Point(59, 26);
            this.buttonDifL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDifL.Name = "buttonDifL";
            this.buttonDifL.Size = new System.Drawing.Size(22, 22);
            this.buttonDifL.TabIndex = 21;
            this.buttonDifL.Text = "←";
            this.buttonDifL.UseVisualStyleBackColor = true;
            this.buttonDifL.Click += new System.EventHandler(this.buttonDifL_Click);
            // 
            // textBoxDif
            // 
            this.textBoxDif.Location = new System.Drawing.Point(82, 26);
            this.textBoxDif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDif.Name = "textBoxDif";
            this.textBoxDif.Size = new System.Drawing.Size(21, 21);
            this.textBoxDif.TabIndex = 20;
            this.textBoxDif.Text = "0";
            // 
            // buttonBowR
            // 
            this.buttonBowR.Location = new System.Drawing.Point(104, 4);
            this.buttonBowR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBowR.Name = "buttonBowR";
            this.buttonBowR.Size = new System.Drawing.Size(22, 22);
            this.buttonBowR.TabIndex = 19;
            this.buttonBowR.Text = "→";
            this.buttonBowR.UseVisualStyleBackColor = true;
            this.buttonBowR.Click += new System.EventHandler(this.buttonBowR_Click);
            // 
            // buttonBowL
            // 
            this.buttonBowL.Location = new System.Drawing.Point(59, 4);
            this.buttonBowL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBowL.Name = "buttonBowL";
            this.buttonBowL.Size = new System.Drawing.Size(22, 22);
            this.buttonBowL.TabIndex = 18;
            this.buttonBowL.Text = "←";
            this.buttonBowL.UseVisualStyleBackColor = true;
            this.buttonBowL.Click += new System.EventHandler(this.buttonBowL_Click);
            // 
            // textBoxBow
            // 
            this.textBoxBow.Location = new System.Drawing.Point(82, 4);
            this.textBoxBow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxBow.Name = "textBoxBow";
            this.textBoxBow.Size = new System.Drawing.Size(21, 21);
            this.textBoxBow.TabIndex = 17;
            this.textBoxBow.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "ディフ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "弓";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxMemo);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(179, 122);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "メモ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxMemo
            // 
            this.textBoxMemo.Location = new System.Drawing.Point(0, 0);
            this.textBoxMemo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMemo.Multiline = true;
            this.textBoxMemo.Name = "textBoxMemo";
            this.textBoxMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMemo.Size = new System.Drawing.Size(181, 123);
            this.textBoxMemo.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ヘルプToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(187, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.リセットToolStripMenuItem,
            this.終了XToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem1.Text = "機能(&F)";
            // 
            // リセットToolStripMenuItem
            // 
            this.リセットToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ルーラーToolStripMenuItem,
            this.カウンタToolStripMenuItem,
            this.toolStripMenuItem2,
            this.MenuNoDialog});
            this.リセットToolStripMenuItem.Name = "リセットToolStripMenuItem";
            this.リセットToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.リセットToolStripMenuItem.Text = "リセット(&R)";
            this.リセットToolStripMenuItem.Click += new System.EventHandler(this.リセットToolStripMenuItem_Click);
            // 
            // ルーラーToolStripMenuItem
            // 
            this.ルーラーToolStripMenuItem.Name = "ルーラーToolStripMenuItem";
            this.ルーラーToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.ルーラーToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.ルーラーToolStripMenuItem.Text = "ルーラー (&R)";
            this.ルーラーToolStripMenuItem.Click += new System.EventHandler(this.ルーラーToolStripMenuItem_Click);
            // 
            // カウンタToolStripMenuItem
            // 
            this.カウンタToolStripMenuItem.Name = "カウンタToolStripMenuItem";
            this.カウンタToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.カウンタToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.カウンタToolStripMenuItem.Text = "カウンタ (&C)";
            this.カウンタToolStripMenuItem.Click += new System.EventHandler(this.カウンタToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(211, 6);
            // 
            // MenuNoDialog
            // 
            this.MenuNoDialog.CheckOnClick = true;
            this.MenuNoDialog.Name = "MenuNoDialog";
            this.MenuNoDialog.Size = new System.Drawing.Size(214, 22);
            this.MenuNoDialog.Text = "確認ダイアログを表示しない (&N)";
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.終了XToolStripMenuItem.Text = "終了(&X)";
            this.終了XToolStripMenuItem.Click += new System.EventHandler(this.終了XToolStripMenuItem_Click);
            // 
            // ヘルプToolStripMenuItem
            // 
            this.ヘルプToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.使い方ToolStripMenuItem,
            this.バージョンToolStripMenuItem});
            this.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            this.ヘルプToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ヘルプToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // 使い方ToolStripMenuItem
            // 
            this.使い方ToolStripMenuItem.Name = "使い方ToolStripMenuItem";
            this.使い方ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.使い方ToolStripMenuItem.Text = "使い方(&U)";
            this.使い方ToolStripMenuItem.Click += new System.EventHandler(this.使い方ToolStripMenuItem_Click);
            // 
            // バージョンToolStripMenuItem
            // 
            this.バージョンToolStripMenuItem.Name = "バージョンToolStripMenuItem";
            this.バージョンToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.バージョンToolStripMenuItem.Text = "バージョン(&V)";
            this.バージョンToolStripMenuItem.Click += new System.EventHandler(this.バージョンToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 181);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Meiryo UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "アンサガツール";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelMode;
		private System.Windows.Forms.Label labelTurn;
		private System.Windows.Forms.Label labelAction;
		private System.Windows.Forms.Label labelLP;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label stateMode;
		private System.Windows.Forms.Label stateTurn;
		private System.Windows.Forms.Label stateLP;
		private System.Windows.Forms.Label stateAction;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem リセットToolStripMenuItem;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonDifR;
		private System.Windows.Forms.Button buttonDifL;
		private System.Windows.Forms.TextBox textBoxDif;
		private System.Windows.Forms.Button buttonBowR;
		private System.Windows.Forms.Button buttonBowL;
		private System.Windows.Forms.TextBox textBoxBow;
		private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 使い方ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem バージョンToolStripMenuItem;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TextBox textBoxMemo;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ToolStripMenuItem ルーラーToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem カウンタToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem MenuNoDialog;
	}
}

