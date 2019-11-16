namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.ToggleSwitch.ToggleState toggleState1 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState2 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState3 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AppExit = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AppMaximum = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AppMinimize = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.TogSwitNightMode = new Bunifu.ToggleSwitch.BunifuToggleSwitch();
            this.btnNightMode = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSettings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCall = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnContacts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNewChannel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNewGroup = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblNameMenu = new System.Windows.Forms.Label();
            this.ProfilePic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NoChatSelectLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnMenu = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SidebarPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.listChatPanel = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SidebarPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.panel2);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 21);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AppExit);
            this.panel2.Controls.Add(this.AppMaximum);
            this.panel2.Controls.Add(this.AppMinimize);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(690, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 21);
            this.panel2.TabIndex = 4;
            // 
            // AppExit
            // 
            this.bunifuTransition1.SetDecoration(this.AppExit, BunifuAnimatorNS.DecorationType.None);
            this.AppExit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AppExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(140)))), ((int)(((byte)(145)))));
            this.AppExit.Location = new System.Drawing.Point(80, -6);
            this.AppExit.Name = "AppExit";
            this.AppExit.Size = new System.Drawing.Size(29, 31);
            this.AppExit.TabIndex = 0;
            this.AppExit.Text = "x";
            this.AppExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AppExit.Click += new System.EventHandler(this.AppExit_Click);
            this.AppExit.MouseLeave += new System.EventHandler(this.AppExit_MouseLeave);
            this.AppExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AppExit_MouseMove);
            // 
            // AppMaximum
            // 
            this.bunifuTransition1.SetDecoration(this.AppMaximum, BunifuAnimatorNS.DecorationType.None);
            this.AppMaximum.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AppMaximum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(140)))), ((int)(((byte)(145)))));
            this.AppMaximum.Location = new System.Drawing.Point(48, -5);
            this.AppMaximum.Name = "AppMaximum";
            this.AppMaximum.Size = new System.Drawing.Size(29, 31);
            this.AppMaximum.TabIndex = 0;
            this.AppMaximum.Text = "⃣";
            this.AppMaximum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AppMaximum.Click += new System.EventHandler(this.AppMaximum_Click);
            this.AppMaximum.MouseLeave += new System.EventHandler(this.AppMaximum_MouseLeave);
            this.AppMaximum.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AppMaximum_MouseMove);
            // 
            // AppMinimize
            // 
            this.bunifuTransition1.SetDecoration(this.AppMinimize, BunifuAnimatorNS.DecorationType.None);
            this.AppMinimize.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AppMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(140)))), ((int)(((byte)(145)))));
            this.AppMinimize.Location = new System.Drawing.Point(16, -4);
            this.AppMinimize.Name = "AppMinimize";
            this.AppMinimize.Size = new System.Drawing.Size(29, 31);
            this.AppMinimize.TabIndex = 0;
            this.AppMinimize.Text = "‒";
            this.AppMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AppMinimize.Click += new System.EventHandler(this.AppMinimize_Click);
            this.AppMinimize.MouseLeave += new System.EventHandler(this.AppMinimize_MouseLeave);
            this.AppMinimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AppMinimize_MouseMove);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.MenuPanel.Controls.Add(this.TogSwitNightMode);
            this.MenuPanel.Controls.Add(this.btnNightMode);
            this.MenuPanel.Controls.Add(this.btnSettings);
            this.MenuPanel.Controls.Add(this.btnCall);
            this.MenuPanel.Controls.Add(this.btnContacts);
            this.MenuPanel.Controls.Add(this.btnNewChannel);
            this.MenuPanel.Controls.Add(this.btnNewGroup);
            this.MenuPanel.Controls.Add(this.lblPhoneNumber);
            this.MenuPanel.Controls.Add(this.lblNameMenu);
            this.MenuPanel.Controls.Add(this.ProfilePic);
            this.MenuPanel.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.MenuPanel, BunifuAnimatorNS.DecorationType.None);
            this.MenuPanel.Location = new System.Drawing.Point(2, 21);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(260, 626);
            this.MenuPanel.TabIndex = 2;
            this.MenuPanel.Visible = false;
            this.MenuPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            // 
            // TogSwitNightMode
            // 
            this.TogSwitNightMode.Animation = 5;
            this.TogSwitNightMode.BackColor = System.Drawing.Color.Transparent;
            this.TogSwitNightMode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TogSwitNightMode.BackgroundImage")));
            this.TogSwitNightMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.TogSwitNightMode, BunifuAnimatorNS.DecorationType.None);
            this.TogSwitNightMode.Location = new System.Drawing.Point(197, 387);
            this.TogSwitNightMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TogSwitNightMode.Name = "TogSwitNightMode";
            this.TogSwitNightMode.Size = new System.Drawing.Size(40, 20);
            this.TogSwitNightMode.TabIndex = 6;
            toggleState1.BackColor = System.Drawing.Color.Empty;
            toggleState1.BackColorInner = System.Drawing.Color.Empty;
            toggleState1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            toggleState1.BorderColorInner = System.Drawing.Color.Empty;
            toggleState1.BorderRadius = 1;
            toggleState1.BorderRadiusInner = 1;
            toggleState1.BorderThickness = 1;
            toggleState1.BorderThicknessInner = 1;
            this.TogSwitNightMode.ToggleStateDisabled = toggleState1;
            toggleState2.BackColor = System.Drawing.Color.Empty;
            toggleState2.BackColorInner = System.Drawing.Color.Empty;
            toggleState2.BorderColor = System.Drawing.Color.Maroon;
            toggleState2.BorderColorInner = System.Drawing.Color.Empty;
            toggleState2.BorderRadius = 1;
            toggleState2.BorderRadiusInner = 1;
            toggleState2.BorderThickness = 1;
            toggleState2.BorderThicknessInner = 1;
            this.TogSwitNightMode.ToggleStateOff = toggleState2;
            toggleState3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(5)))), ((int)(((byte)(0)))));
            toggleState3.BackColorInner = System.Drawing.Color.White;
            toggleState3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(5)))), ((int)(((byte)(0)))));
            toggleState3.BorderColorInner = System.Drawing.Color.White;
            toggleState3.BorderRadius = 17;
            toggleState3.BorderRadiusInner = 15;
            toggleState3.BorderThickness = 1;
            toggleState3.BorderThicknessInner = 1;
            this.TogSwitNightMode.ToggleStateOn = toggleState3;
            this.TogSwitNightMode.Value = true;
            // 
            // btnNightMode
            // 
            this.btnNightMode.Active = false;
            this.btnNightMode.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(67)))));
            this.btnNightMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.btnNightMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNightMode.BorderRadius = 0;
            this.btnNightMode.ButtonText = "   Night Mode";
            this.btnNightMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnNightMode, BunifuAnimatorNS.DecorationType.None);
            this.btnNightMode.DisabledColor = System.Drawing.Color.Gray;
            this.btnNightMode.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNightMode.Iconimage = global::TelegramDesktopUI.Properties.Resources.Night_mode;
            this.btnNightMode.Iconimage_right = null;
            this.btnNightMode.Iconimage_right_Selected = null;
            this.btnNightMode.Iconimage_Selected = null;
            this.btnNightMode.IconMarginLeft = 15;
            this.btnNightMode.IconMarginRight = 0;
            this.btnNightMode.IconRightVisible = true;
            this.btnNightMode.IconRightZoom = 0D;
            this.btnNightMode.IconVisible = true;
            this.btnNightMode.IconZoom = 50D;
            this.btnNightMode.IsTab = false;
            this.btnNightMode.Location = new System.Drawing.Point(0, 376);
            this.btnNightMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNightMode.Name = "btnNightMode";
            this.btnNightMode.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.btnNightMode.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(67)))));
            this.btnNightMode.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNightMode.selected = false;
            this.btnNightMode.Size = new System.Drawing.Size(260, 40);
            this.btnNightMode.TabIndex = 5;
            this.btnNightMode.Text = "   Night Mode";
            this.btnNightMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNightMode.Textcolor = System.Drawing.Color.White;
            this.btnNightMode.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNightMode.Click += new System.EventHandler(this.btnNightMode_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Active = false;
            this.btnSettings.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(67)))));
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.BorderRadius = 0;
            this.btnSettings.ButtonText = "   Settings";
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnSettings, BunifuAnimatorNS.DecorationType.None);
            this.btnSettings.DisabledColor = System.Drawing.Color.Gray;
            this.btnSettings.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSettings.Iconimage = global::TelegramDesktopUI.Properties.Resources.Settings;
            this.btnSettings.Iconimage_right = null;
            this.btnSettings.Iconimage_right_Selected = null;
            this.btnSettings.Iconimage_Selected = null;
            this.btnSettings.IconMarginLeft = 15;
            this.btnSettings.IconMarginRight = 0;
            this.btnSettings.IconRightVisible = true;
            this.btnSettings.IconRightZoom = 0D;
            this.btnSettings.IconVisible = true;
            this.btnSettings.IconZoom = 50D;
            this.btnSettings.IsTab = false;
            this.btnSettings.Location = new System.Drawing.Point(0, 329);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.btnSettings.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(67)))));
            this.btnSettings.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSettings.selected = false;
            this.btnSettings.Size = new System.Drawing.Size(260, 40);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "   Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Textcolor = System.Drawing.Color.White;
            this.btnSettings.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnCall
            // 
            this.btnCall.Active = false;
            this.btnCall.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(67)))));
            this.btnCall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.btnCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCall.BorderRadius = 0;
            this.btnCall.ButtonText = "   Call";
            this.btnCall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnCall, BunifuAnimatorNS.DecorationType.None);
            this.btnCall.DisabledColor = System.Drawing.Color.Gray;
            this.btnCall.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCall.Iconimage = global::TelegramDesktopUI.Properties.Resources.Calls;
            this.btnCall.Iconimage_right = null;
            this.btnCall.Iconimage_right_Selected = null;
            this.btnCall.Iconimage_Selected = null;
            this.btnCall.IconMarginLeft = 15;
            this.btnCall.IconMarginRight = 0;
            this.btnCall.IconRightVisible = true;
            this.btnCall.IconRightZoom = 0D;
            this.btnCall.IconVisible = true;
            this.btnCall.IconZoom = 50D;
            this.btnCall.IsTab = false;
            this.btnCall.Location = new System.Drawing.Point(0, 284);
            this.btnCall.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btnCall.Name = "btnCall";
            this.btnCall.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.btnCall.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(67)))));
            this.btnCall.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCall.selected = false;
            this.btnCall.Size = new System.Drawing.Size(260, 40);
            this.btnCall.TabIndex = 4;
            this.btnCall.Text = "   Call";
            this.btnCall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCall.Textcolor = System.Drawing.Color.White;
            this.btnCall.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnContacts
            // 
            this.btnContacts.Active = false;
            this.btnContacts.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(67)))));
            this.btnContacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.btnContacts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContacts.BorderRadius = 0;
            this.btnContacts.ButtonText = "   Contacts";
            this.btnContacts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnContacts, BunifuAnimatorNS.DecorationType.None);
            this.btnContacts.DisabledColor = System.Drawing.Color.Gray;
            this.btnContacts.Iconcolor = System.Drawing.Color.Transparent;
            this.btnContacts.Iconimage = global::TelegramDesktopUI.Properties.Resources.Contacts;
            this.btnContacts.Iconimage_right = null;
            this.btnContacts.Iconimage_right_Selected = null;
            this.btnContacts.Iconimage_Selected = null;
            this.btnContacts.IconMarginLeft = 15;
            this.btnContacts.IconMarginRight = 0;
            this.btnContacts.IconRightVisible = true;
            this.btnContacts.IconRightZoom = 0D;
            this.btnContacts.IconVisible = true;
            this.btnContacts.IconZoom = 50D;
            this.btnContacts.IsTab = false;
            this.btnContacts.Location = new System.Drawing.Point(0, 238);
            this.btnContacts.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.btnContacts.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(67)))));
            this.btnContacts.OnHoverTextColor = System.Drawing.Color.White;
            this.btnContacts.selected = false;
            this.btnContacts.Size = new System.Drawing.Size(260, 40);
            this.btnContacts.TabIndex = 4;
            this.btnContacts.Text = "   Contacts";
            this.btnContacts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContacts.Textcolor = System.Drawing.Color.White;
            this.btnContacts.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnNewChannel
            // 
            this.btnNewChannel.Active = false;
            this.btnNewChannel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(67)))));
            this.btnNewChannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.btnNewChannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewChannel.BorderRadius = 0;
            this.btnNewChannel.ButtonText = "   New Channel";
            this.btnNewChannel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnNewChannel, BunifuAnimatorNS.DecorationType.None);
            this.btnNewChannel.DisabledColor = System.Drawing.Color.Gray;
            this.btnNewChannel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNewChannel.Iconimage = global::TelegramDesktopUI.Properties.Resources.New_channel;
            this.btnNewChannel.Iconimage_right = null;
            this.btnNewChannel.Iconimage_right_Selected = null;
            this.btnNewChannel.Iconimage_Selected = null;
            this.btnNewChannel.IconMarginLeft = 15;
            this.btnNewChannel.IconMarginRight = 0;
            this.btnNewChannel.IconRightVisible = true;
            this.btnNewChannel.IconRightZoom = 0D;
            this.btnNewChannel.IconVisible = true;
            this.btnNewChannel.IconZoom = 50D;
            this.btnNewChannel.IsTab = false;
            this.btnNewChannel.Location = new System.Drawing.Point(0, 192);
            this.btnNewChannel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewChannel.Name = "btnNewChannel";
            this.btnNewChannel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.btnNewChannel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(67)))));
            this.btnNewChannel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNewChannel.selected = false;
            this.btnNewChannel.Size = new System.Drawing.Size(260, 40);
            this.btnNewChannel.TabIndex = 4;
            this.btnNewChannel.Text = "   New Channel";
            this.btnNewChannel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewChannel.Textcolor = System.Drawing.Color.White;
            this.btnNewChannel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnNewGroup
            // 
            this.btnNewGroup.Active = false;
            this.btnNewGroup.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(67)))));
            this.btnNewGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.btnNewGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewGroup.BorderRadius = 0;
            this.btnNewGroup.ButtonText = "   New Group";
            this.btnNewGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnNewGroup, BunifuAnimatorNS.DecorationType.None);
            this.btnNewGroup.DisabledColor = System.Drawing.Color.Gray;
            this.btnNewGroup.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNewGroup.Iconimage = global::TelegramDesktopUI.Properties.Resources.New_group;
            this.btnNewGroup.Iconimage_right = null;
            this.btnNewGroup.Iconimage_right_Selected = null;
            this.btnNewGroup.Iconimage_Selected = null;
            this.btnNewGroup.IconMarginLeft = 15;
            this.btnNewGroup.IconMarginRight = 0;
            this.btnNewGroup.IconRightVisible = false;
            this.btnNewGroup.IconRightZoom = 0D;
            this.btnNewGroup.IconVisible = true;
            this.btnNewGroup.IconZoom = 50D;
            this.btnNewGroup.IsTab = false;
            this.btnNewGroup.Location = new System.Drawing.Point(0, 147);
            this.btnNewGroup.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewGroup.Name = "btnNewGroup";
            this.btnNewGroup.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.btnNewGroup.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(67)))));
            this.btnNewGroup.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNewGroup.selected = false;
            this.btnNewGroup.Size = new System.Drawing.Size(260, 40);
            this.btnNewGroup.TabIndex = 3;
            this.btnNewGroup.Text = "   New Group";
            this.btnNewGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewGroup.Textcolor = System.Drawing.Color.White;
            this.btnNewGroup.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(5)))), ((int)(((byte)(0)))));
            this.bunifuTransition1.SetDecoration(this.lblPhoneNumber, BunifuAnimatorNS.DecorationType.None);
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNumber.Location = new System.Drawing.Point(13, 103);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(123, 20);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "+98 111 222 3344";
            // 
            // lblNameMenu
            // 
            this.lblNameMenu.AutoSize = true;
            this.lblNameMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(5)))), ((int)(((byte)(0)))));
            this.bunifuTransition1.SetDecoration(this.lblNameMenu, BunifuAnimatorNS.DecorationType.None);
            this.lblNameMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNameMenu.ForeColor = System.Drawing.Color.White;
            this.lblNameMenu.Location = new System.Drawing.Point(13, 79);
            this.lblNameMenu.Name = "lblNameMenu";
            this.lblNameMenu.Size = new System.Drawing.Size(135, 20);
            this.lblNameMenu.TabIndex = 2;
            this.lblNameMenu.Text = "Mohammad Javad";
            // 
            // ProfilePic
            // 
            this.bunifuTransition1.SetDecoration(this.ProfilePic, BunifuAnimatorNS.DecorationType.None);
            this.ProfilePic.Image = ((System.Drawing.Image)(resources.GetObject("ProfilePic.Image")));
            this.ProfilePic.Location = new System.Drawing.Point(17, 17);
            this.ProfilePic.Name = "ProfilePic";
            this.ProfilePic.Size = new System.Drawing.Size(52, 49);
            this.ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePic.TabIndex = 1;
            this.ProfilePic.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(5)))), ((int)(((byte)(0)))));
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NoChatSelectLbl
            // 
            this.NoChatSelectLbl.AutoSize = true;
            this.NoChatSelectLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(59)))));
            this.bunifuTransition1.SetDecoration(this.NoChatSelectLbl, BunifuAnimatorNS.DecorationType.None);
            this.NoChatSelectLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NoChatSelectLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.NoChatSelectLbl.Location = new System.Drawing.Point(160, 284);
            this.NoChatSelectLbl.Name = "NoChatSelectLbl";
            this.NoChatSelectLbl.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.NoChatSelectLbl.Size = new System.Drawing.Size(277, 26);
            this.NoChatSelectLbl.TabIndex = 3;
            this.NoChatSelectLbl.Text = "Please select a chat to start messaging";
            this.NoChatSelectLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMenu
            // 
            this.bunifuTransition1.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(140)))), ((int)(((byte)(145)))));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMenu.Location = new System.Drawing.Point(11, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 37);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "≡";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMenu.UseCompatibleTextRendering = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            this.btnMenu.MouseLeave += new System.EventHandler(this.btnMenu_MouseLeave);
            this.btnMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMenu_MouseMove);
            // 
            // SidebarPanel
            // 
            this.SidebarPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.SidebarPanel.Controls.Add(this.panel4);
            this.SidebarPanel.Controls.Add(this.listChatPanel);
            this.bunifuTransition1.SetDecoration(this.SidebarPanel, BunifuAnimatorNS.DecorationType.None);
            this.SidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarPanel.Location = new System.Drawing.Point(0, 21);
            this.SidebarPanel.Name = "SidebarPanel";
            this.SidebarPanel.Size = new System.Drawing.Size(260, 626);
            this.SidebarPanel.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Controls.Add(this.btnMenu);
            this.bunifuTransition1.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(260, 51);
            this.panel4.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.AnimationSpeed = 200;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.txtSearch.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.txtSearch.BorderRadius = 1;
            this.txtSearch.BorderThickness = 1;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.txtSearch, BunifuAnimatorNS.DecorationType.None);
            this.txtSearch.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = null;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.IconPadding = 10;
            this.txtSearch.IconRight = null;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(54, 8);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtSearch.Modified = false;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnIdleState = stateProperties4;
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(194, 35);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextMarginLeft = 5;
            this.txtSearch.TextMarginTop = 0;
            this.txtSearch.TextPlaceholder = "Search";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.WordWrap = true;
            // 
            // listChatPanel
            // 
            this.listChatPanel.AutoScroll = true;
            this.bunifuTransition1.SetDecoration(this.listChatPanel, BunifuAnimatorNS.DecorationType.None);
            this.listChatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listChatPanel.Location = new System.Drawing.Point(0, 0);
            this.listChatPanel.Name = "listChatPanel";
            this.listChatPanel.Size = new System.Drawing.Size(260, 626);
            this.listChatPanel.TabIndex = 3;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.NoChatSelectLbl);
            this.bunifuTransition1.SetDecoration(this.ContentPanel, BunifuAnimatorNS.DecorationType.None);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(260, 21);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(540, 626);
            this.ContentPanel.TabIndex = 5;
            this.ContentPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContentPanel_MouseClick);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.txtSearch;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 50;
            this.bunifuElipse3.TargetControl = this.ProfilePic;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 20;
            this.bunifuElipse4.TargetControl = this.NoChatSelectLbl;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(800, 647);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.SidebarPanel);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sw";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SidebarPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel AppExit;
        private Bunifu.Framework.UI.BunifuCustomLabel AppMinimize;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblNameMenu;
        private System.Windows.Forms.PictureBox ProfilePic;
        private Bunifu.Framework.UI.BunifuCustomLabel NoChatSelectLbl;
        private Bunifu.Framework.UI.BunifuFlatButton btnNewChannel;
        private Bunifu.Framework.UI.BunifuFlatButton btnNewGroup;
        private System.Windows.Forms.Panel SidebarPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel btnMenu;
        private Bunifu.Framework.UI.BunifuCustomLabel AppMaximum;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel listChatPanel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.Panel ContentPanel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuFlatButton btnContacts;
        private Bunifu.Framework.UI.BunifuFlatButton btnSettings;
        private Bunifu.Framework.UI.BunifuFlatButton btnCall;
        private Bunifu.Framework.UI.BunifuFlatButton btnNightMode;
        private Bunifu.ToggleSwitch.BunifuToggleSwitch TogSwitNightMode;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtSearch;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
    }
}