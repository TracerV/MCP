using System.Windows.Forms;

namespace XPUDP
{
    partial class MCP_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

                
        

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MCP_form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.simulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xPlaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prepar3DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Connect_button = new System.Windows.Forms.Button();
            this.Stop_button = new System.Windows.Forms.Button();
            this.Reconnect_button = new System.Windows.Forms.Button();
            this.Course1_textBox = new System.Windows.Forms.TextBox();
            this.IAS_textBox = new System.Windows.Forms.TextBox();
            this.HDG_textBox = new System.Windows.Forms.TextBox();
            this.ALT_textBox = new System.Windows.Forms.TextBox();
            this.VS_textBox = new System.Windows.Forms.TextBox();
            this.Course2_textBox = new System.Windows.Forms.TextBox();
            this.Disengage_pictureBox = new System.Windows.Forms.PictureBox();
            this.FD_FO_pictureBox = new System.Windows.Forms.PictureBox();
            this.FD_capt_pictureBox = new System.Windows.Forms.PictureBox();
            this.AT_pictureBox = new System.Windows.Forms.PictureBox();
            this.AT_sw_pictureBox = new System.Windows.Forms.PictureBox();
            this.VS_pictureBox = new System.Windows.Forms.PictureBox();
            this.IAS_pictureBox = new System.Windows.Forms.PictureBox();
            this.Course1_pictureBox = new System.Windows.Forms.PictureBox();
            this.Course2_pictureBox = new System.Windows.Forms.PictureBox();
            this.ALT_pictureBox = new System.Windows.Forms.PictureBox();
            this.HDG_pictureBox = new System.Windows.Forms.PictureBox();
            this.Angle_pictureBox = new System.Windows.Forms.PictureBox();
            this.MA_pilot_pictureBox = new System.Windows.Forms.PictureBox();
            this.MA_copilot_pictureBox = new System.Windows.Forms.PictureBox();
            this.button_ALT_INTV = new System.Windows.Forms.Button();
            this.button_SPD_INTV = new System.Windows.Forms.Button();
            this.button_CO = new System.Windows.Forms.Button();
            this.button_CMD_B = new System.Windows.Forms.Button();
            this.button_CWS_B = new System.Windows.Forms.Button();
            this.button_CWS_A = new System.Windows.Forms.Button();
            this.button_CMD_A = new System.Windows.Forms.Button();
            this.button_VS = new System.Windows.Forms.Button();
            this.button_ALT = new System.Windows.Forms.Button();
            this.button_V_NAV = new System.Windows.Forms.Button();
            this.button_L_NAV = new System.Windows.Forms.Button();
            this.button_VOR_LOC = new System.Windows.Forms.Button();
            this.button_APP = new System.Windows.Forms.Button();
            this.button_HDG = new System.Windows.Forms.Button();
            this.button_LVL_CH = new System.Windows.Forms.Button();
            this.button_N1 = new System.Windows.Forms.Button();
            this.button_Speed = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Disengage_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FD_FO_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FD_capt_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AT_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AT_sw_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VS_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IAS_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Course1_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Course2_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ALT_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDG_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Angle_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MA_pilot_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MA_copilot_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simulatorToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // simulatorToolStripMenuItem
            // 
            this.simulatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xPlaneToolStripMenuItem,
            this.prepar3DToolStripMenuItem});
            this.simulatorToolStripMenuItem.Name = "simulatorToolStripMenuItem";
            this.simulatorToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.simulatorToolStripMenuItem.Text = "Simulator";
            // 
            // xPlaneToolStripMenuItem
            // 
            this.xPlaneToolStripMenuItem.Name = "xPlaneToolStripMenuItem";
            this.xPlaneToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.xPlaneToolStripMenuItem.Text = "X-Plane";
            // 
            // prepar3DToolStripMenuItem
            // 
            this.prepar3DToolStripMenuItem.Name = "prepar3DToolStripMenuItem";
            this.prepar3DToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.prepar3DToolStripMenuItem.Text = "Prepar3D";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.PreferencesToolStripMenuItem_Click);
            // 
            // Connect_button
            // 
            this.Connect_button.Location = new System.Drawing.Point(669, 382);
            this.Connect_button.Name = "Connect_button";
            this.Connect_button.Size = new System.Drawing.Size(75, 23);
            this.Connect_button.TabIndex = 1;
            this.Connect_button.Text = "Connect";
            this.Connect_button.UseVisualStyleBackColor = true;
            this.Connect_button.Click += new System.EventHandler(this.Connect_button_Click);
            // 
            // Stop_button
            // 
            this.Stop_button.Location = new System.Drawing.Point(855, 382);
            this.Stop_button.Name = "Stop_button";
            this.Stop_button.Size = new System.Drawing.Size(75, 23);
            this.Stop_button.TabIndex = 3;
            this.Stop_button.Text = "Stop";
            this.Stop_button.UseVisualStyleBackColor = true;
            this.Stop_button.Click += new System.EventHandler(this.Stop_button_Click);
            // 
            // Reconnect_button
            // 
            this.Reconnect_button.Location = new System.Drawing.Point(750, 382);
            this.Reconnect_button.Name = "Reconnect_button";
            this.Reconnect_button.Size = new System.Drawing.Size(75, 23);
            this.Reconnect_button.TabIndex = 4;
            this.Reconnect_button.Text = "Reconnect";
            this.Reconnect_button.UseVisualStyleBackColor = true;
            this.Reconnect_button.Click += new System.EventHandler(this.Reconnect_button_Click);
            // 
            // Course1_textBox
            // 
            this.Course1_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.Course1_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Course1_textBox.Font = new System.Drawing.Font("DS-Digital", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course1_textBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Course1_textBox.Location = new System.Drawing.Point(93, 66);
            this.Course1_textBox.MaxLength = 3;
            this.Course1_textBox.Name = "Course1_textBox";
            this.Course1_textBox.Size = new System.Drawing.Size(37, 21);
            this.Course1_textBox.TabIndex = 5;
            this.Course1_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IAS_textBox
            // 
            this.IAS_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.IAS_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IAS_textBox.Font = new System.Drawing.Font("DS-Digital", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IAS_textBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.IAS_textBox.Location = new System.Drawing.Point(248, 66);
            this.IAS_textBox.MaxLength = 4;
            this.IAS_textBox.Name = "IAS_textBox";
            this.IAS_textBox.Size = new System.Drawing.Size(56, 21);
            this.IAS_textBox.TabIndex = 6;
            // 
            // HDG_textBox
            // 
            this.HDG_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.HDG_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HDG_textBox.Font = new System.Drawing.Font("DS-Digital", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDG_textBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.HDG_textBox.Location = new System.Drawing.Point(388, 66);
            this.HDG_textBox.MaxLength = 3;
            this.HDG_textBox.Name = "HDG_textBox";
            this.HDG_textBox.Size = new System.Drawing.Size(37, 21);
            this.HDG_textBox.TabIndex = 7;
            this.HDG_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ALT_textBox
            // 
            this.ALT_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.ALT_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ALT_textBox.Font = new System.Drawing.Font("DS-Digital", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALT_textBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ALT_textBox.Location = new System.Drawing.Point(504, 66);
            this.ALT_textBox.MaxLength = 5;
            this.ALT_textBox.Name = "ALT_textBox";
            this.ALT_textBox.Size = new System.Drawing.Size(66, 21);
            this.ALT_textBox.TabIndex = 8;
            this.ALT_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // VS_textBox
            // 
            this.VS_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.VS_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VS_textBox.Font = new System.Drawing.Font("DS-Digital", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VS_textBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.VS_textBox.Location = new System.Drawing.Point(607, 66);
            this.VS_textBox.MaxLength = 5;
            this.VS_textBox.Name = "VS_textBox";
            this.VS_textBox.Size = new System.Drawing.Size(67, 21);
            this.VS_textBox.TabIndex = 9;
            this.VS_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Course2_textBox
            // 
            this.Course2_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.Course2_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Course2_textBox.Font = new System.Drawing.Font("DS-Digital", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course2_textBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Course2_textBox.Location = new System.Drawing.Point(832, 66);
            this.Course2_textBox.MaxLength = 3;
            this.Course2_textBox.Name = "Course2_textBox";
            this.Course2_textBox.Size = new System.Drawing.Size(37, 21);
            this.Course2_textBox.TabIndex = 10;
            this.Course2_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Disengage_pictureBox
            // 
            this.Disengage_pictureBox.BackgroundImage = global::XPUDP.Properties.Resources.Disengage;
            this.Disengage_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Disengage_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Disengage_pictureBox.Location = new System.Drawing.Point(697, 146);
            this.Disengage_pictureBox.Name = "Disengage_pictureBox";
            this.Disengage_pictureBox.Size = new System.Drawing.Size(100, 32);
            this.Disengage_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Disengage_pictureBox.TabIndex = 43;
            this.Disengage_pictureBox.TabStop = false;
            this.Disengage_pictureBox.Click += new System.EventHandler(this.Disengage_pictureBox_Click);
            // 
            // FD_FO_pictureBox
            // 
            this.FD_FO_pictureBox.BackgroundImage = global::XPUDP.Properties.Resources.FD_off;
            this.FD_FO_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FD_FO_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FD_FO_pictureBox.Location = new System.Drawing.Point(818, 145);
            this.FD_FO_pictureBox.Name = "FD_FO_pictureBox";
            this.FD_FO_pictureBox.Size = new System.Drawing.Size(13, 21);
            this.FD_FO_pictureBox.TabIndex = 42;
            this.FD_FO_pictureBox.TabStop = false;
            this.FD_FO_pictureBox.Click += new System.EventHandler(this.FD_FO_pictureBox_Click);
            // 
            // FD_capt_pictureBox
            // 
            this.FD_capt_pictureBox.BackgroundImage = global::XPUDP.Properties.Resources.FD_off;
            this.FD_capt_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FD_capt_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FD_capt_pictureBox.Location = new System.Drawing.Point(131, 146);
            this.FD_capt_pictureBox.Name = "FD_capt_pictureBox";
            this.FD_capt_pictureBox.Size = new System.Drawing.Size(13, 21);
            this.FD_capt_pictureBox.TabIndex = 41;
            this.FD_capt_pictureBox.TabStop = false;
            this.FD_capt_pictureBox.Click += new System.EventHandler(this.FD_capt_pictureBox_Click);
            // 
            // AT_pictureBox
            // 
            this.AT_pictureBox.BackgroundImage = global::XPUDP.Properties.Resources.AT_UnActive;
            this.AT_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AT_pictureBox.Location = new System.Drawing.Point(188, 68);
            this.AT_pictureBox.Name = "AT_pictureBox";
            this.AT_pictureBox.Size = new System.Drawing.Size(12, 5);
            this.AT_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AT_pictureBox.TabIndex = 32;
            this.AT_pictureBox.TabStop = false;
            // 
            // AT_sw_pictureBox
            // 
            this.AT_sw_pictureBox.BackgroundImage = global::XPUDP.Properties.Resources.AT_on;
            this.AT_sw_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AT_sw_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AT_sw_pictureBox.Location = new System.Drawing.Point(184, 70);
            this.AT_sw_pictureBox.Name = "AT_sw_pictureBox";
            this.AT_sw_pictureBox.Size = new System.Drawing.Size(20, 34);
            this.AT_sw_pictureBox.TabIndex = 40;
            this.AT_sw_pictureBox.TabStop = false;
            this.AT_sw_pictureBox.Click += new System.EventHandler(this.AT_sw_pictureBox_Click);
            // 
            // VS_pictureBox
            // 
            this.VS_pictureBox.BackgroundImage = global::XPUDP.Properties.Resources.VS;
            this.VS_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VS_pictureBox.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.VS_pictureBox.Location = new System.Drawing.Point(637, 110);
            this.VS_pictureBox.Name = "VS_pictureBox";
            this.VS_pictureBox.Size = new System.Drawing.Size(19, 60);
            this.VS_pictureBox.TabIndex = 39;
            this.VS_pictureBox.TabStop = false;
            this.VS_pictureBox.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.VS_pictureBox_MouseWheel);
            // 
            // IAS_pictureBox
            // 
            this.IAS_pictureBox.BackgroundImage = global::XPUDP.Properties.Resources.HDG;
            this.IAS_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IAS_pictureBox.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.IAS_pictureBox.Location = new System.Drawing.Point(268, 116);
            this.IAS_pictureBox.Name = "IAS_pictureBox";
            this.IAS_pictureBox.Size = new System.Drawing.Size(32, 32);
            this.IAS_pictureBox.TabIndex = 38;
            this.IAS_pictureBox.TabStop = false;
            this.IAS_pictureBox.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.IAS_pictureBox_MouseWheel);
            // 
            // Course1_pictureBox
            // 
            this.Course1_pictureBox.BackgroundImage = global::XPUDP.Properties.Resources.HDG;
            this.Course1_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Course1_pictureBox.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.Course1_pictureBox.Location = new System.Drawing.Point(82, 101);
            this.Course1_pictureBox.Name = "Course1_pictureBox";
            this.Course1_pictureBox.Size = new System.Drawing.Size(32, 32);
            this.Course1_pictureBox.TabIndex = 37;
            this.Course1_pictureBox.TabStop = false;
            this.Course1_pictureBox.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Course1_pictureBox_MouseWheel);
            // 
            // Course2_pictureBox
            // 
            this.Course2_pictureBox.BackgroundImage = global::XPUDP.Properties.Resources.HDG;
            this.Course2_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Course2_pictureBox.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.Course2_pictureBox.Location = new System.Drawing.Point(847, 101);
            this.Course2_pictureBox.Name = "Course2_pictureBox";
            this.Course2_pictureBox.Size = new System.Drawing.Size(32, 32);
            this.Course2_pictureBox.TabIndex = 36;
            this.Course2_pictureBox.TabStop = false;
            this.Course2_pictureBox.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Course2_pictureBox_MouseWheel);
            // 
            // ALT_pictureBox
            // 
            this.ALT_pictureBox.BackgroundImage = global::XPUDP.Properties.Resources.HDG;
            this.ALT_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ALT_pictureBox.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.ALT_pictureBox.Location = new System.Drawing.Point(521, 101);
            this.ALT_pictureBox.Name = "ALT_pictureBox";
            this.ALT_pictureBox.Size = new System.Drawing.Size(32, 32);
            this.ALT_pictureBox.TabIndex = 35;
            this.ALT_pictureBox.TabStop = false;
            this.ALT_pictureBox.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.ALT_pictureBox_MouseWheel);
            // 
            // HDG_pictureBox
            // 
            this.HDG_pictureBox.BackgroundImage = global::XPUDP.Properties.Resources.HDG;
            this.HDG_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HDG_pictureBox.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.HDG_pictureBox.Location = new System.Drawing.Point(391, 103);
            this.HDG_pictureBox.Name = "HDG_pictureBox";
            this.HDG_pictureBox.Size = new System.Drawing.Size(29, 29);
            this.HDG_pictureBox.TabIndex = 34;
            this.HDG_pictureBox.TabStop = false;
            this.HDG_pictureBox.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.HDG_pictureBox_MouseWheel);
            // 
            // Angle_pictureBox
            // 
            this.Angle_pictureBox.BackgroundImage = global::XPUDP.Properties.Resources.Angle_20;
            this.Angle_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Angle_pictureBox.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.Angle_pictureBox.Location = new System.Drawing.Point(385, 97);
            this.Angle_pictureBox.Name = "Angle_pictureBox";
            this.Angle_pictureBox.Size = new System.Drawing.Size(41, 41);
            this.Angle_pictureBox.TabIndex = 33;
            this.Angle_pictureBox.TabStop = false;
            this.Angle_pictureBox.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Angle_pictureBox_MouseWheel);
            // 
            // MA_pilot_pictureBox
            // 
            this.MA_pilot_pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MA_pilot_pictureBox.BackgroundImage")));
            this.MA_pilot_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MA_pilot_pictureBox.InitialImage = null;
            this.MA_pilot_pictureBox.Location = new System.Drawing.Point(128, 104);
            this.MA_pilot_pictureBox.Name = "MA_pilot_pictureBox";
            this.MA_pilot_pictureBox.Size = new System.Drawing.Size(20, 20);
            this.MA_pilot_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MA_pilot_pictureBox.TabIndex = 30;
            this.MA_pilot_pictureBox.TabStop = false;
            // 
            // MA_copilot_pictureBox
            // 
            this.MA_copilot_pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MA_copilot_pictureBox.BackgroundImage")));
            this.MA_copilot_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MA_copilot_pictureBox.Location = new System.Drawing.Point(815, 104);
            this.MA_copilot_pictureBox.Name = "MA_copilot_pictureBox";
            this.MA_copilot_pictureBox.Size = new System.Drawing.Size(20, 20);
            this.MA_copilot_pictureBox.TabIndex = 31;
            this.MA_copilot_pictureBox.TabStop = false;
            // 
            // button_ALT_INTV
            // 
            this.button_ALT_INTV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ALT_INTV.BackgroundImage")));
            this.button_ALT_INTV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_ALT_INTV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ALT_INTV.FlatAppearance.BorderSize = 0;
            this.button_ALT_INTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ALT_INTV.Location = new System.Drawing.Point(575, 104);
            this.button_ALT_INTV.Name = "button_ALT_INTV";
            this.button_ALT_INTV.Size = new System.Drawing.Size(27, 27);
            this.button_ALT_INTV.TabIndex = 29;
            this.button_ALT_INTV.UseVisualStyleBackColor = true;
            this.button_ALT_INTV.Click += new System.EventHandler(this.button_ALT_INTV_Click_1);
            // 
            // button_SPD_INTV
            // 
            this.button_SPD_INTV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_SPD_INTV.BackgroundImage")));
            this.button_SPD_INTV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_SPD_INTV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SPD_INTV.FlatAppearance.BorderSize = 0;
            this.button_SPD_INTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SPD_INTV.Location = new System.Drawing.Point(315, 104);
            this.button_SPD_INTV.Name = "button_SPD_INTV";
            this.button_SPD_INTV.Size = new System.Drawing.Size(27, 27);
            this.button_SPD_INTV.TabIndex = 28;
            this.button_SPD_INTV.UseVisualStyleBackColor = true;
            this.button_SPD_INTV.Click += new System.EventHandler(this.button_SPD_INTV_Click);
            // 
            // button_CO
            // 
            this.button_CO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_CO.BackgroundImage")));
            this.button_CO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_CO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CO.FlatAppearance.BorderSize = 0;
            this.button_CO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CO.Location = new System.Drawing.Point(232, 106);
            this.button_CO.Name = "button_CO";
            this.button_CO.Size = new System.Drawing.Size(22, 22);
            this.button_CO.TabIndex = 27;
            this.button_CO.UseVisualStyleBackColor = true;
            this.button_CO.Click += new System.EventHandler(this.button_CO_Click);
            // 
            // button_CMD_B
            // 
            this.button_CMD_B.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_CMD_B.BackgroundImage")));
            this.button_CMD_B.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_CMD_B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CMD_B.FlatAppearance.BorderSize = 0;
            this.button_CMD_B.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_CMD_B.Location = new System.Drawing.Point(772, 72);
            this.button_CMD_B.Name = "button_CMD_B";
            this.button_CMD_B.Size = new System.Drawing.Size(27, 20);
            this.button_CMD_B.TabIndex = 25;
            this.button_CMD_B.UseVisualStyleBackColor = true;
            this.button_CMD_B.Click += new System.EventHandler(this.button_CMD_B_Click);
            // 
            // button_CWS_B
            // 
            this.button_CWS_B.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_CWS_B.BackgroundImage")));
            this.button_CWS_B.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_CWS_B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CWS_B.FlatAppearance.BorderSize = 0;
            this.button_CWS_B.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_CWS_B.Location = new System.Drawing.Point(772, 110);
            this.button_CWS_B.Name = "button_CWS_B";
            this.button_CWS_B.Size = new System.Drawing.Size(27, 20);
            this.button_CWS_B.TabIndex = 24;
            this.button_CWS_B.UseVisualStyleBackColor = true;
            this.button_CWS_B.Click += new System.EventHandler(this.button_CWS_B_Click);
            // 
            // button_CWS_A
            // 
            this.button_CWS_A.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_CWS_A.BackgroundImage")));
            this.button_CWS_A.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_CWS_A.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CWS_A.FlatAppearance.BorderSize = 0;
            this.button_CWS_A.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_CWS_A.Location = new System.Drawing.Point(699, 110);
            this.button_CWS_A.Name = "button_CWS_A";
            this.button_CWS_A.Size = new System.Drawing.Size(27, 20);
            this.button_CWS_A.TabIndex = 23;
            this.button_CWS_A.UseVisualStyleBackColor = true;
            this.button_CWS_A.Click += new System.EventHandler(this.button_CWS_A_Click);
            // 
            // button_CMD_A
            // 
            this.button_CMD_A.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_CMD_A.BackgroundImage")));
            this.button_CMD_A.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_CMD_A.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CMD_A.FlatAppearance.BorderSize = 0;
            this.button_CMD_A.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_CMD_A.Location = new System.Drawing.Point(699, 72);
            this.button_CMD_A.Name = "button_CMD_A";
            this.button_CMD_A.Size = new System.Drawing.Size(27, 20);
            this.button_CMD_A.TabIndex = 22;
            this.button_CMD_A.UseVisualStyleBackColor = true;
            this.button_CMD_A.Click += new System.EventHandler(this.button_CMD_A_Click);
            // 
            // button_VS
            // 
            this.button_VS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_VS.BackgroundImage")));
            this.button_VS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_VS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_VS.FlatAppearance.BorderSize = 0;
            this.button_VS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_VS.Location = new System.Drawing.Point(579, 155);
            this.button_VS.Name = "button_VS";
            this.button_VS.Size = new System.Drawing.Size(27, 20);
            this.button_VS.TabIndex = 21;
            this.button_VS.UseVisualStyleBackColor = true;
            this.button_VS.Click += new System.EventHandler(this.button_VS_Click);
            // 
            // button_ALT
            // 
            this.button_ALT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ALT.BackgroundImage")));
            this.button_ALT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_ALT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ALT.FlatAppearance.BorderSize = 0;
            this.button_ALT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ALT.Location = new System.Drawing.Point(524, 155);
            this.button_ALT.Name = "button_ALT";
            this.button_ALT.Size = new System.Drawing.Size(27, 20);
            this.button_ALT.TabIndex = 20;
            this.button_ALT.UseVisualStyleBackColor = true;
            this.button_ALT.Click += new System.EventHandler(this.button_ALT_Click);
            // 
            // button_V_NAV
            // 
            this.button_V_NAV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_V_NAV.BackgroundImage")));
            this.button_V_NAV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_V_NAV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_V_NAV.FlatAppearance.BorderSize = 0;
            this.button_V_NAV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_V_NAV.Location = new System.Drawing.Point(331, 68);
            this.button_V_NAV.Name = "button_V_NAV";
            this.button_V_NAV.Size = new System.Drawing.Size(27, 20);
            this.button_V_NAV.TabIndex = 19;
            this.button_V_NAV.UseVisualStyleBackColor = true;
            this.button_V_NAV.Click += new System.EventHandler(this.button_V_NAV_Click);
            // 
            // button_L_NAV
            // 
            this.button_L_NAV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_L_NAV.BackgroundImage")));
            this.button_L_NAV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_L_NAV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_L_NAV.FlatAppearance.BorderSize = 0;
            this.button_L_NAV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_L_NAV.Location = new System.Drawing.Point(454, 68);
            this.button_L_NAV.Name = "button_L_NAV";
            this.button_L_NAV.Size = new System.Drawing.Size(27, 20);
            this.button_L_NAV.TabIndex = 18;
            this.button_L_NAV.UseVisualStyleBackColor = true;
            this.button_L_NAV.Click += new System.EventHandler(this.button_L_NAV_Click);
            // 
            // button_VOR_LOC
            // 
            this.button_VOR_LOC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_VOR_LOC.BackgroundImage")));
            this.button_VOR_LOC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_VOR_LOC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_VOR_LOC.FlatAppearance.BorderSize = 0;
            this.button_VOR_LOC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_VOR_LOC.Location = new System.Drawing.Point(454, 112);
            this.button_VOR_LOC.Name = "button_VOR_LOC";
            this.button_VOR_LOC.Size = new System.Drawing.Size(27, 20);
            this.button_VOR_LOC.TabIndex = 17;
            this.button_VOR_LOC.UseVisualStyleBackColor = true;
            this.button_VOR_LOC.Click += new System.EventHandler(this.button_VOR_LOC_Click);
            // 
            // button_APP
            // 
            this.button_APP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_APP.BackgroundImage")));
            this.button_APP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_APP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_APP.FlatAppearance.BorderSize = 0;
            this.button_APP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_APP.Location = new System.Drawing.Point(454, 155);
            this.button_APP.Name = "button_APP";
            this.button_APP.Size = new System.Drawing.Size(27, 20);
            this.button_APP.TabIndex = 16;
            this.button_APP.UseVisualStyleBackColor = true;
            this.button_APP.Click += new System.EventHandler(this.button_APP_Click);
            // 
            // button_HDG
            // 
            this.button_HDG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_HDG.BackgroundImage")));
            this.button_HDG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_HDG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_HDG.FlatAppearance.BorderSize = 0;
            this.button_HDG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_HDG.Location = new System.Drawing.Point(393, 155);
            this.button_HDG.Name = "button_HDG";
            this.button_HDG.Size = new System.Drawing.Size(27, 20);
            this.button_HDG.TabIndex = 15;
            this.button_HDG.UseVisualStyleBackColor = true;
            this.button_HDG.Click += new System.EventHandler(this.button_HDG_Click);
            // 
            // button_LVL_CH
            // 
            this.button_LVL_CH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_LVL_CH.BackgroundImage")));
            this.button_LVL_CH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_LVL_CH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_LVL_CH.FlatAppearance.BorderSize = 0;
            this.button_LVL_CH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_LVL_CH.Location = new System.Drawing.Point(329, 155);
            this.button_LVL_CH.Name = "button_LVL_CH";
            this.button_LVL_CH.Size = new System.Drawing.Size(27, 20);
            this.button_LVL_CH.TabIndex = 14;
            this.button_LVL_CH.UseVisualStyleBackColor = true;
            this.button_LVL_CH.Click += new System.EventHandler(this.button_LVL_CH_Click);
            // 
            // button_N1
            // 
            this.button_N1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_N1.BackgroundImage")));
            this.button_N1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_N1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_N1.FlatAppearance.BorderSize = 0;
            this.button_N1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_N1.Location = new System.Drawing.Point(162, 155);
            this.button_N1.Name = "button_N1";
            this.button_N1.Size = new System.Drawing.Size(27, 20);
            this.button_N1.TabIndex = 13;
            this.button_N1.UseVisualStyleBackColor = true;
            this.button_N1.Click += new System.EventHandler(this.button_N1_Click);
            // 
            // button_Speed
            // 
            this.button_Speed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Speed.BackgroundImage")));
            this.button_Speed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Speed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Speed.FlatAppearance.BorderSize = 0;
            this.button_Speed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Speed.Location = new System.Drawing.Point(212, 155);
            this.button_Speed.Name = "button_Speed";
            this.button_Speed.Size = new System.Drawing.Size(27, 20);
            this.button_Speed.TabIndex = 12;
            this.button_Speed.UseVisualStyleBackColor = true;
            this.button_Speed.Click += new System.EventHandler(this.button_Speed_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::XPUDP.Properties.Resources.MCP;
            this.pictureBox1.Location = new System.Drawing.Point(30, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(899, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // MCP_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 417);
            this.Controls.Add(this.Disengage_pictureBox);
            this.Controls.Add(this.FD_FO_pictureBox);
            this.Controls.Add(this.FD_capt_pictureBox);
            this.Controls.Add(this.AT_pictureBox);
            this.Controls.Add(this.AT_sw_pictureBox);
            this.Controls.Add(this.VS_pictureBox);
            this.Controls.Add(this.IAS_pictureBox);
            this.Controls.Add(this.Course1_pictureBox);
            this.Controls.Add(this.Course2_pictureBox);
            this.Controls.Add(this.ALT_pictureBox);
            this.Controls.Add(this.HDG_pictureBox);
            this.Controls.Add(this.Angle_pictureBox);
            this.Controls.Add(this.MA_pilot_pictureBox);
            this.Controls.Add(this.MA_copilot_pictureBox);
            this.Controls.Add(this.button_ALT_INTV);
            this.Controls.Add(this.button_SPD_INTV);
            this.Controls.Add(this.button_CO);
            this.Controls.Add(this.button_CMD_B);
            this.Controls.Add(this.button_CWS_B);
            this.Controls.Add(this.button_CWS_A);
            this.Controls.Add(this.button_CMD_A);
            this.Controls.Add(this.button_VS);
            this.Controls.Add(this.button_ALT);
            this.Controls.Add(this.button_V_NAV);
            this.Controls.Add(this.button_L_NAV);
            this.Controls.Add(this.button_VOR_LOC);
            this.Controls.Add(this.button_APP);
            this.Controls.Add(this.button_HDG);
            this.Controls.Add(this.button_LVL_CH);
            this.Controls.Add(this.button_N1);
            this.Controls.Add(this.button_Speed);
            this.Controls.Add(this.Course2_textBox);
            this.Controls.Add(this.VS_textBox);
            this.Controls.Add(this.ALT_textBox);
            this.Controls.Add(this.HDG_textBox);
            this.Controls.Add(this.IAS_textBox);
            this.Controls.Add(this.Course1_textBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Reconnect_button);
            this.Controls.Add(this.Stop_button);
            this.Controls.Add(this.Connect_button);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MCP_form";
            this.Text = "MCP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MCP_form_FormClosing);
            this.Load += new System.EventHandler(this.MCP_form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Disengage_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FD_FO_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FD_capt_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AT_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AT_sw_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VS_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IAS_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Course1_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Course2_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ALT_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDG_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Angle_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MA_pilot_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MA_copilot_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem simulatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xPlaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prepar3DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.Button Connect_button;
        private System.Windows.Forms.Button Stop_button;
        private System.Windows.Forms.Button Reconnect_button;
        private System.Windows.Forms.TextBox Course1_textBox;
        private System.Windows.Forms.TextBox IAS_textBox;
        private System.Windows.Forms.TextBox HDG_textBox;
        private System.Windows.Forms.TextBox ALT_textBox;
        private System.Windows.Forms.TextBox VS_textBox;
        private System.Windows.Forms.TextBox Course2_textBox;
        private System.Windows.Forms.Button button_Speed;
        private System.Windows.Forms.Button button_N1;
        private System.Windows.Forms.Button button_LVL_CH;
        private System.Windows.Forms.Button button_HDG;
        private System.Windows.Forms.Button button_APP;
        private System.Windows.Forms.Button button_VOR_LOC;
        private System.Windows.Forms.Button button_L_NAV;
        private System.Windows.Forms.Button button_V_NAV;
        private System.Windows.Forms.Button button_ALT;
        private System.Windows.Forms.Button button_VS;
        private System.Windows.Forms.Button button_CMD_A;
        private System.Windows.Forms.Button button_CWS_A;
        private System.Windows.Forms.Button button_CWS_B;
        private System.Windows.Forms.Button button_CMD_B;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_CO;
        private System.Windows.Forms.Button button_SPD_INTV;
        private System.Windows.Forms.Button button_ALT_INTV;
        private System.Windows.Forms.PictureBox MA_pilot_pictureBox;
        private System.Windows.Forms.PictureBox MA_copilot_pictureBox;
        private System.Windows.Forms.PictureBox AT_pictureBox;
        private System.Windows.Forms.PictureBox Angle_pictureBox;
        private PictureBox HDG_pictureBox;
        private PictureBox ALT_pictureBox;
        private PictureBox Course2_pictureBox;
        private PictureBox Course1_pictureBox;
        private PictureBox IAS_pictureBox;
        private PictureBox VS_pictureBox;
        private PictureBox AT_sw_pictureBox;
        private PictureBox FD_capt_pictureBox;
        private PictureBox FD_FO_pictureBox;
        public PictureBox Disengage_pictureBox;
    }
}

