namespace Project_Map
{
    partial class FrmQ1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQ1));
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slot1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slot2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slot3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_NewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.viaViewZone = new VisualArrays.VisualIntArray();
            this.imlPièces = new System.Windows.Forms.ImageList(this.components);
            this.pnl_mainMenu = new System.Windows.Forms.Panel();
            this.pnl_MainMenu_LoadGame = new System.Windows.Forms.Panel();
            this.btn_MainMenu_LoadGame_Back = new System.Windows.Forms.Button();
            this.btn_LoadGame_SaveSlot3 = new System.Windows.Forms.Button();
            this.btn_LoadGame_SaveSlot2 = new System.Windows.Forms.Button();
            this.btn_LoadGame_SaveSlot1 = new System.Windows.Forms.Button();
            this.btn_MainMenu_Exit = new System.Windows.Forms.Button();
            this.btn_MainMenu_LoadGame = new System.Windows.Forms.Button();
            this.btn_MainMenu_NewGame = new System.Windows.Forms.Button();
            this.lbl_MainMenu_Build = new System.Windows.Forms.Label();
            this.lbl_MainMenu_Title = new System.Windows.Forms.Label();
            this.mnuPrincipal.SuspendLayout();
            this.pnl_mainMenu.SuspendLayout();
            this.pnl_MainMenu_LoadGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(854, 24);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveGameToolStripMenuItem,
            this.mainMenuToolStripMenuItem,
            this.mnu_NewGame,
            this.mnuFichierSep1,
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Text = "&Fichier";
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slot1ToolStripMenuItem,
            this.slot2ToolStripMenuItem,
            this.slot3ToolStripMenuItem});
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveGameToolStripMenuItem.Text = "Save Game";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
            // 
            // slot1ToolStripMenuItem
            // 
            this.slot1ToolStripMenuItem.Name = "slot1ToolStripMenuItem";
            this.slot1ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.slot1ToolStripMenuItem.Text = "Slot 1";
            this.slot1ToolStripMenuItem.Click += new System.EventHandler(this.slot1ToolStripMenuItem_Click);
            // 
            // slot2ToolStripMenuItem
            // 
            this.slot2ToolStripMenuItem.Name = "slot2ToolStripMenuItem";
            this.slot2ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.slot2ToolStripMenuItem.Text = "Slot 2";
            this.slot2ToolStripMenuItem.Click += new System.EventHandler(this.slot2ToolStripMenuItem_Click);
            // 
            // slot3ToolStripMenuItem
            // 
            this.slot3ToolStripMenuItem.Name = "slot3ToolStripMenuItem";
            this.slot3ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.slot3ToolStripMenuItem.Text = "Slot 3";
            this.slot3ToolStripMenuItem.Click += new System.EventHandler(this.slot3ToolStripMenuItem_Click);
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // mnu_NewGame
            // 
            this.mnu_NewGame.Name = "mnu_NewGame";
            this.mnu_NewGame.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnu_NewGame.Size = new System.Drawing.Size(180, 22);
            this.mnu_NewGame.Text = "New Game";
            this.mnu_NewGame.Click += new System.EventHandler(this.mnuFichierNouvellePartie_Click);
            // 
            // mnuFichierSep1
            // 
            this.mnuFichierSep1.Name = "mnuFichierSep1";
            this.mnuFichierSep1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(180, 22);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // viaViewZone
            // 
            this.viaViewZone.BackColor = System.Drawing.Color.CornflowerBlue;
            this.viaViewZone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viaViewZone.BackgroundImage")));
            this.viaViewZone.CellMargin = 0;
            this.viaViewZone.CellSize = new System.Drawing.Size(95, 73);
            this.viaViewZone.ColumnCount = 9;
            this.viaViewZone.DefaultValue = -1;
            this.viaViewZone.EnabledAppearance.ImageList = this.imlPièces;
            this.viaViewZone.EnabledAppearance.Style = VisualArrays.enuBkgStyle.None;
            this.viaViewZone.ForeColor = System.Drawing.Color.Black;
            this.viaViewZone.GraphAppearance.BarColor = System.Drawing.Color.Black;
            this.viaViewZone.GraphAppearance.BarValueColor = System.Drawing.Color.Transparent;
            this.viaViewZone.GridAppearance.Color = System.Drawing.Color.Black;
            this.viaViewZone.GridAppearance.LineSize = 0;
            this.viaViewZone.Location = new System.Drawing.Point(0, 27);
            this.viaViewZone.Margin = new System.Windows.Forms.Padding(0);
            this.viaViewZone.Name = "viaViewZone";
            this.viaViewZone.Padding = new System.Windows.Forms.Padding(0);
            this.viaViewZone.RowCount = 9;
            this.viaViewZone.RowHeader.ForeColor = System.Drawing.Color.White;
            this.viaViewZone.Size = new System.Drawing.Size(855, 657);
            this.viaViewZone.TabIndex = 3;
            this.viaViewZone.Text = "visualIntArray1";
            this.viaViewZone.View = VisualArrays.enuIntView.ImageList;
            this.viaViewZone.CellMouseDown += new System.EventHandler<VisualArrays.CellMouseEventArgs>(this.viaViewZone_CellMouseDown);
            this.viaViewZone.Click += new System.EventHandler(this.viaEviterMurs_Click);
            this.viaViewZone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.viaEviterMurs_KeyDown);
            // 
            // imlPièces
            // 
            this.imlPièces.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlPièces.ImageStream")));
            this.imlPièces.TransparentColor = System.Drawing.Color.Transparent;
            this.imlPièces.Images.SetKeyName(0, "Water8.jpg");
            this.imlPièces.Images.SetKeyName(1, "BoatTest.bmp");
            this.imlPièces.Images.SetKeyName(2, "Boat22WTrailFinal.bmp");
            this.imlPièces.Images.SetKeyName(3, "Boat23WTrailFixed2.bmp");
            this.imlPièces.Images.SetKeyName(4, "Boat24WTrailFinalFinal.bmp");
            this.imlPièces.Images.SetKeyName(5, "BoatTestTestTesterr2.bmp");
            this.imlPièces.Images.SetKeyName(6, "Boat22WTrailVariation.bmp");
            this.imlPièces.Images.SetKeyName(7, "Boat23WTrailVariationFinal copy.bmp");
            this.imlPièces.Images.SetKeyName(8, "Boat24WTrailVariationFinal.bmp");
            this.imlPièces.Images.SetKeyName(9, "CellBleuCiel.bmp");
            this.imlPièces.Images.SetKeyName(10, "CellJaune.bmp");
            this.imlPièces.Images.SetKeyName(11, "CellLime.bmp");
            this.imlPièces.Images.SetKeyName(12, "CellMauve.bmp");
            this.imlPièces.Images.SetKeyName(13, "CellOrange.bmp");
            this.imlPièces.Images.SetKeyName(14, "CellRouge.bmp");
            this.imlPièces.Images.SetKeyName(15, "CellGrise.bmp");
            this.imlPièces.Images.SetKeyName(16, "CellBleu.bmp");
            this.imlPièces.Images.SetKeyName(17, "BoatAloneWithTransparancyTEst.png");
            this.imlPièces.Images.SetKeyName(18, "BoatAloneWithTransparancyTEst8b.png");
            this.imlPièces.Images.SetKeyName(19, "BoatAloneWithTransparancyTEst8bFull Thres.png");
            this.imlPièces.Images.SetKeyName(20, "TopLeftCorner.png");
            this.imlPièces.Images.SetKeyName(21, "TopSide1.png");
            this.imlPièces.Images.SetKeyName(22, "TopRightCorner.png");
            this.imlPièces.Images.SetKeyName(23, "LeftSide1.png");
            this.imlPièces.Images.SetKeyName(24, "BaseTileParch.png");
            this.imlPièces.Images.SetKeyName(25, "RightSide1.png");
            this.imlPièces.Images.SetKeyName(26, "BottomLeftCorner.png");
            this.imlPièces.Images.SetKeyName(27, "BottomSide1.png");
            this.imlPièces.Images.SetKeyName(28, "BottomRightCorner.png");
            // 
            // pnl_mainMenu
            // 
            this.pnl_mainMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_mainMenu.BackgroundImage")));
            this.pnl_mainMenu.Controls.Add(this.pnl_MainMenu_LoadGame);
            this.pnl_mainMenu.Controls.Add(this.btn_MainMenu_Exit);
            this.pnl_mainMenu.Controls.Add(this.btn_MainMenu_LoadGame);
            this.pnl_mainMenu.Controls.Add(this.btn_MainMenu_NewGame);
            this.pnl_mainMenu.Controls.Add(this.lbl_MainMenu_Build);
            this.pnl_mainMenu.Controls.Add(this.lbl_MainMenu_Title);
            this.pnl_mainMenu.Location = new System.Drawing.Point(0, 27);
            this.pnl_mainMenu.Name = "pnl_mainMenu";
            this.pnl_mainMenu.Size = new System.Drawing.Size(855, 657);
            this.pnl_mainMenu.TabIndex = 4;
            // 
            // pnl_MainMenu_LoadGame
            // 
            this.pnl_MainMenu_LoadGame.BackColor = System.Drawing.Color.Black;
            this.pnl_MainMenu_LoadGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_MainMenu_LoadGame.BackgroundImage")));
            this.pnl_MainMenu_LoadGame.Controls.Add(this.btn_MainMenu_LoadGame_Back);
            this.pnl_MainMenu_LoadGame.Controls.Add(this.btn_LoadGame_SaveSlot3);
            this.pnl_MainMenu_LoadGame.Controls.Add(this.btn_LoadGame_SaveSlot2);
            this.pnl_MainMenu_LoadGame.Controls.Add(this.btn_LoadGame_SaveSlot1);
            this.pnl_MainMenu_LoadGame.Location = new System.Drawing.Point(0, 0);
            this.pnl_MainMenu_LoadGame.Name = "pnl_MainMenu_LoadGame";
            this.pnl_MainMenu_LoadGame.Size = new System.Drawing.Size(855, 657);
            this.pnl_MainMenu_LoadGame.TabIndex = 5;
            // 
            // btn_MainMenu_LoadGame_Back
            // 
            this.btn_MainMenu_LoadGame_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_MainMenu_LoadGame_Back.BackgroundImage")));
            this.btn_MainMenu_LoadGame_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MainMenu_LoadGame_Back.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MainMenu_LoadGame_Back.Location = new System.Drawing.Point(260, 418);
            this.btn_MainMenu_LoadGame_Back.Margin = new System.Windows.Forms.Padding(0);
            this.btn_MainMenu_LoadGame_Back.Name = "btn_MainMenu_LoadGame_Back";
            this.btn_MainMenu_LoadGame_Back.Size = new System.Drawing.Size(344, 42);
            this.btn_MainMenu_LoadGame_Back.TabIndex = 7;
            this.btn_MainMenu_LoadGame_Back.Text = "Back";
            this.btn_MainMenu_LoadGame_Back.UseVisualStyleBackColor = true;
            this.btn_MainMenu_LoadGame_Back.Click += new System.EventHandler(this.btn_MainMenu_LoadGame_Back_Click);
            // 
            // btn_LoadGame_SaveSlot3
            // 
            this.btn_LoadGame_SaveSlot3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_LoadGame_SaveSlot3.BackgroundImage")));
            this.btn_LoadGame_SaveSlot3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadGame_SaveSlot3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadGame_SaveSlot3.Location = new System.Drawing.Point(260, 297);
            this.btn_LoadGame_SaveSlot3.Margin = new System.Windows.Forms.Padding(0);
            this.btn_LoadGame_SaveSlot3.Name = "btn_LoadGame_SaveSlot3";
            this.btn_LoadGame_SaveSlot3.Size = new System.Drawing.Size(344, 42);
            this.btn_LoadGame_SaveSlot3.TabIndex = 6;
            this.btn_LoadGame_SaveSlot3.Text = "Save Slot 3";
            this.btn_LoadGame_SaveSlot3.UseVisualStyleBackColor = true;
            this.btn_LoadGame_SaveSlot3.Click += new System.EventHandler(this.btn_LoadGame_SaveSlot3_Click);
            // 
            // btn_LoadGame_SaveSlot2
            // 
            this.btn_LoadGame_SaveSlot2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_LoadGame_SaveSlot2.BackgroundImage")));
            this.btn_LoadGame_SaveSlot2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadGame_SaveSlot2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadGame_SaveSlot2.Location = new System.Drawing.Point(260, 168);
            this.btn_LoadGame_SaveSlot2.Margin = new System.Windows.Forms.Padding(0);
            this.btn_LoadGame_SaveSlot2.Name = "btn_LoadGame_SaveSlot2";
            this.btn_LoadGame_SaveSlot2.Size = new System.Drawing.Size(344, 42);
            this.btn_LoadGame_SaveSlot2.TabIndex = 5;
            this.btn_LoadGame_SaveSlot2.Text = "Save Slot 2";
            this.btn_LoadGame_SaveSlot2.UseVisualStyleBackColor = true;
            this.btn_LoadGame_SaveSlot2.Click += new System.EventHandler(this.btn_LoadGame_SaveSlot2_Click);
            // 
            // btn_LoadGame_SaveSlot1
            // 
            this.btn_LoadGame_SaveSlot1.BackColor = System.Drawing.Color.Black;
            this.btn_LoadGame_SaveSlot1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_LoadGame_SaveSlot1.BackgroundImage")));
            this.btn_LoadGame_SaveSlot1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadGame_SaveSlot1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadGame_SaveSlot1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_LoadGame_SaveSlot1.Location = new System.Drawing.Point(260, 45);
            this.btn_LoadGame_SaveSlot1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_LoadGame_SaveSlot1.Name = "btn_LoadGame_SaveSlot1";
            this.btn_LoadGame_SaveSlot1.Size = new System.Drawing.Size(344, 42);
            this.btn_LoadGame_SaveSlot1.TabIndex = 4;
            this.btn_LoadGame_SaveSlot1.Text = "Save Slot 1";
            this.btn_LoadGame_SaveSlot1.UseVisualStyleBackColor = false;
            this.btn_LoadGame_SaveSlot1.Click += new System.EventHandler(this.btn_LoadGame_SaveSlot1_Click);
            // 
            // btn_MainMenu_Exit
            // 
            this.btn_MainMenu_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_MainMenu_Exit.BackgroundImage")));
            this.btn_MainMenu_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MainMenu_Exit.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MainMenu_Exit.Location = new System.Drawing.Point(260, 460);
            this.btn_MainMenu_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_MainMenu_Exit.Name = "btn_MainMenu_Exit";
            this.btn_MainMenu_Exit.Size = new System.Drawing.Size(344, 42);
            this.btn_MainMenu_Exit.TabIndex = 4;
            this.btn_MainMenu_Exit.Text = "Exit";
            this.btn_MainMenu_Exit.UseVisualStyleBackColor = true;
            this.btn_MainMenu_Exit.Click += new System.EventHandler(this.btn_MainMenu_Exit_Click);
            // 
            // btn_MainMenu_LoadGame
            // 
            this.btn_MainMenu_LoadGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_MainMenu_LoadGame.BackgroundImage")));
            this.btn_MainMenu_LoadGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MainMenu_LoadGame.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MainMenu_LoadGame.Location = new System.Drawing.Point(260, 368);
            this.btn_MainMenu_LoadGame.Margin = new System.Windows.Forms.Padding(0);
            this.btn_MainMenu_LoadGame.Name = "btn_MainMenu_LoadGame";
            this.btn_MainMenu_LoadGame.Size = new System.Drawing.Size(344, 42);
            this.btn_MainMenu_LoadGame.TabIndex = 3;
            this.btn_MainMenu_LoadGame.Text = "Load Game";
            this.btn_MainMenu_LoadGame.UseVisualStyleBackColor = true;
            this.btn_MainMenu_LoadGame.Click += new System.EventHandler(this.btn_MainMenu_LoadGame_Click);
            // 
            // btn_MainMenu_NewGame
            // 
            this.btn_MainMenu_NewGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_MainMenu_NewGame.BackgroundImage")));
            this.btn_MainMenu_NewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MainMenu_NewGame.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MainMenu_NewGame.Location = new System.Drawing.Point(260, 275);
            this.btn_MainMenu_NewGame.Margin = new System.Windows.Forms.Padding(0);
            this.btn_MainMenu_NewGame.Name = "btn_MainMenu_NewGame";
            this.btn_MainMenu_NewGame.Size = new System.Drawing.Size(344, 42);
            this.btn_MainMenu_NewGame.TabIndex = 2;
            this.btn_MainMenu_NewGame.Text = "New Game";
            this.btn_MainMenu_NewGame.UseVisualStyleBackColor = true;
            this.btn_MainMenu_NewGame.Click += new System.EventHandler(this.btn_MainMenu_NewGame_Click);
            // 
            // lbl_MainMenu_Build
            // 
            this.lbl_MainMenu_Build.AutoSize = true;
            this.lbl_MainMenu_Build.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MainMenu_Build.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MainMenu_Build.Location = new System.Drawing.Point(390, 143);
            this.lbl_MainMenu_Build.Name = "lbl_MainMenu_Build";
            this.lbl_MainMenu_Build.Size = new System.Drawing.Size(77, 25);
            this.lbl_MainMenu_Build.TabIndex = 1;
            this.lbl_MainMenu_Build.Text = "Build 9";
            // 
            // lbl_MainMenu_Title
            // 
            this.lbl_MainMenu_Title.AutoSize = true;
            this.lbl_MainMenu_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MainMenu_Title.Font = new System.Drawing.Font("French Script MT", 64F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MainMenu_Title.Location = new System.Drawing.Point(243, 45);
            this.lbl_MainMenu_Title.Name = "lbl_MainMenu_Title";
            this.lbl_MainMenu_Title.Size = new System.Drawing.Size(383, 98);
            this.lbl_MainMenu_Title.TabIndex = 0;
            this.lbl_MainMenu_Title.Text = "Project Map";
            // 
            // FrmQ1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(854, 885);
            this.Controls.Add(this.pnl_mainMenu);
            this.Controls.Add(this.viaViewZone);
            this.Controls.Add(this.mnuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(400, 50);
            this.MainMenuStrip = this.mnuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FrmQ1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Project_Map";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.pnl_mainMenu.ResumeLayout(false);
            this.pnl_mainMenu.PerformLayout();
            this.pnl_MainMenu_LoadGame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.ToolStripMenuItem mnu_NewGame;
        private System.Windows.Forms.ToolStripSeparator mnuFichierSep1;
        private VisualArrays.VisualIntArray viaViewZone;
        private System.Windows.Forms.ImageList imlPièces;
        private System.Windows.Forms.Panel pnl_mainMenu;
        private System.Windows.Forms.Label lbl_MainMenu_Title;
        private System.Windows.Forms.Label lbl_MainMenu_Build;
        private System.Windows.Forms.Button btn_MainMenu_NewGame;
        private System.Windows.Forms.Button btn_MainMenu_Exit;
        private System.Windows.Forms.Button btn_MainMenu_LoadGame;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_MainMenu_LoadGame;
        private System.Windows.Forms.Button btn_LoadGame_SaveSlot3;
        private System.Windows.Forms.Button btn_LoadGame_SaveSlot2;
        private System.Windows.Forms.Button btn_LoadGame_SaveSlot1;
        private System.Windows.Forms.ToolStripMenuItem slot1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slot2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slot3ToolStripMenuItem;
        private System.Windows.Forms.Button btn_MainMenu_LoadGame_Back;
    }
}

