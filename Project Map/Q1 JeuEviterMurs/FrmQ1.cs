using System;
using System.Windows.Forms;
using VisualArrays;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using NAudio;
using NAudio.Wave;
using System.IO;

namespace Project_Map
{
    public partial class FrmQ1 : Form
    {
        //Variable et constantes
        public const String GAME_NAME = "Project Map Build 13";

        private ClsMasterGrid m_carte;
        private ClsShip m_ship;
        private SoundPlayer m_soundPlayer1;
        private int m_currentSaveSlot = -1;
        private int BUILD = 12;
        //-----------------------------------------------------------------------------
        public FrmQ1()
        {
            InitializeComponent();
            this.Text = GAME_NAME;
            lbl_MainMenu_Build.Text = "Build " + BUILD.ToString();

            viaViewZone.Enabled = false;
            viaViewZone.Hide();
            
            pnl_MainMenu_LoadGame.Enabled = false;
            pnl_MainMenu_LoadGame.Hide();

            this.Size = new System.Drawing.Size(850, 700);

            m_soundPlayer1 = new SoundPlayer("Sounds\\DrunkenSailor.wav");
            m_soundPlayer1.Play();
        }

        #region Événement KeyDown  à compléter
        private void viaEviterMurs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Up &&
                e.KeyCode != Keys.Down &&
                e.KeyCode != Keys.Left &&
                e.KeyCode != Keys.Right)
                return;

            int lastFrame = m_carte.Map[m_ship.Row, m_ship.Col];

            m_carte.Map[m_ship.Row, m_ship.Col] = -1;
            int oldRow = m_ship.Row;
            int oldCol = m_ship.Col;

            switch (e.KeyCode)
            {
                case Keys.Up :
                    m_ship.Row -= 1;
                    if (m_ship.Row == -1)
                    {
                        m_ship.Row = m_carte.Map.GetLength(0) - 1;
                    }
                    if (ShipIsInCollision())
                    {
                        m_ship.Row = oldRow;
                        m_carte.Map[oldRow, oldCol] = lastFrame;
                        break;
                    }
                    if (m_ship.LastDirection.ToString().Length == 2)
                    {
                        m_ship.LastDirection = 2;
                        m_carte.Map[m_ship.Row, m_ship.Col] = 4;
                    }
                    else
                    {
                        m_ship.LastDirection = 22;
                        m_carte.Map[m_ship.Row, m_ship.Col] = 8;
                    }
                    break;
                case Keys.Down :
                    m_ship.Row += 1;
                    if (m_ship.Row == m_carte.Map.GetLength(0))
                    {
                        m_ship.Row = 0;
                    }
                    if (ShipIsInCollision())
                    {
                        m_ship.Row = oldRow;
                        m_carte.Map[oldRow, oldCol] = lastFrame;
                        break;
                    }
                    if (m_ship.LastDirection.ToString().Length == 2)
                    {
                        m_ship.LastDirection = 2;
                        m_carte.Map[m_ship.Row, m_ship.Col] = 2;
                    }
                    else
                    {
                        m_ship.LastDirection = 22;
                        m_carte.Map[m_ship.Row, m_ship.Col] = 6;
                    }
                    break;
                case Keys.Left :
                    m_ship.Col -= 1;
                    if (m_ship.Col == -1)
                    {
                        m_ship.Col = m_carte.Map.GetLength(1) - 1;
                    }
                    if (ShipIsInCollision())
                    {
                        m_ship.Col = oldCol;
                        m_carte.Map[oldRow, oldCol] = lastFrame;
                        break;
                    }
                    if (m_ship.LastDirection.ToString().Length == 2)
                    {
                        m_ship.LastDirection = 1;
                        m_carte.Map[m_ship.Row, m_ship.Col] = 1;
                    }
                    else
                    {
                        m_ship.LastDirection = 11;
                        m_carte.Map[m_ship.Row, m_ship.Col] = 5;
                    }
                    break;
                case Keys.Right :
                    m_ship.Col += 1;
                    if (m_ship.Col == m_carte.Map.GetLength(1))
                    {
                        m_ship.Col = 0;
                    }
                    if (ShipIsInCollision())
                    {
                        m_ship.Col = oldCol;
                        m_carte.Map[oldRow, oldCol] = lastFrame;
                        break;
                    }
                    if (m_ship.LastDirection.ToString().Length == 2)
                    {
                        m_ship.LastDirection = 2;
                        m_carte.Map[m_ship.Row, m_ship.Col] = 3;
                    }
                    else
                    {
                        m_ship.LastDirection = 22;
                        m_carte.Map[m_ship.Row, m_ship.Col] = 7;
                    }
                    break;
                default:
                    break;
            }

           // m_carte.Map[m_ship.Row, m_ship.Col] = 1;
            ViewZoneUpdate();

            System.Threading.Thread.Sleep(100);
        }

        #endregion

        #region Timer des murs - Événement Tick  à compléter

        // -----------------------------------------------------------------------
        private void tmrMurs_Tick(object sender, EventArgs e)
        {
           
        }

        #endregion

        #region Nouvelle partie - NE PAS MODIFIER

        /// -----------------------------------------------------------------------
        /// <summary>
        /// Prépare une nouvelle partie.
        /// </summary>
        /// -----------------------------------------------------------------------
        private void PréparerNouvellePartie()
        {
            this.Size = new System.Drawing.Size(860, 923);
            pnl_mainMenu.Enabled = false;
            pnl_mainMenu.Hide();

            viaViewZone.Enabled = true;
            viaViewZone.Show();

            viaViewZone.Enabled = true;
            viaViewZone.Clear();

            m_carte = new ClsMasterGrid(100, 100, -1);
            m_ship = new ClsShip(50, 50);

            m_carte.Map[51, 50] = -1;
            m_carte.Map[52, 50] = -1;
            m_carte.Map[51, 51] = -1;
            m_carte.Map[53, 54] = 5;
            m_carte.Map[53, 55] = 6;
            m_carte.Map[53, 56] = 5;
            m_carte.Map[0, 99] = 5;
            m_carte.Map[99, 0] = 5;
            m_carte.Map[99, 99] = 5;
            m_carte.Map[0, 0] = 5;
            m_carte.Map[50, 99] = 5;
            m_carte.Map[50, 0] = 6;
            
            // Island Test
            m_carte.Map[53, 53] = 20;
            m_carte.Map[53, 54] = 21;
            m_carte.Map[53, 55] = 22;
            m_carte.Map[54, 53] = 23;
            m_carte.Map[54, 54] = 24;
            m_carte.Map[54, 55] = 25;
            m_carte.Map[55, 53] = 26;
            m_carte.Map[55, 54] = 27;
            m_carte.Map[55, 55] = 28;

            int startRow = m_ship.Row - viaViewZone.RowCount / 2;
            int startCol = m_ship.Col - viaViewZone.ColumnCount / 2;

            int endRow = m_ship.Row + viaViewZone.RowCount / 2;
            int endCol = m_ship.Col + viaViewZone.ColumnCount / 2;

            int viewRow = 0;
            int viewCol = 0;

            for (int row = startRow; row <= endRow; row++)
            {
                for (int col = startCol; col <= endCol; col++)
                {
                    if ((row > m_carte.Map.GetLength(0) || row < 0) || (col > m_carte.Map.GetLength(1) || col < 0))
                    {
                        int newRow = row;
                        int newCol = col;

                        if (row >= m_carte.Map.GetLength(0))
                        {
                            newRow = row - m_carte.Map.GetLength(0);
                        }
                        else if (row < 0)
                        {
                            newRow = row + m_carte.Map.GetLength(0);
                        }
                        if (col >= m_carte.Map.GetLength(1))
                        {
                            newCol = col - m_carte.Map.GetLength(1);
                        }
                        else if (col < 0)
                        {
                            newCol = col + m_carte.Map.GetLength(1);
                        }
                        viaViewZone[viewRow, viewCol] = m_carte.Map[newRow, newCol];
                    }
                    else
                    {
                        viaViewZone[viewRow, viewCol] = m_carte.Map[row, col];
                    }
                    viewCol++;
                }
                viewRow++;
                viewCol = 0;
            }

            viaViewZone[viaViewZone.RowCount / 2, viaViewZone.ColumnCount / 2] = 4;
            
        }

        //------------------------------------------------------------------------
        private void mnuFichierNouvellePartie_Click(object sender, EventArgs e)
        {
            PréparerNouvellePartie();
        }

        //------------------------------------------------------------------------
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion NE PAS MODIFIER

        private void viaEviterMurs_Click(object sender, EventArgs e)
        {

        }

        private void lblScore_Click(object sender, EventArgs e)
        {
            
        }

        private void ViewZoneUpdate()
        {
            int startRow = m_ship.Row - viaViewZone.RowCount / 2;
            int startCol = m_ship.Col - viaViewZone.ColumnCount / 2;

            int endRow = m_ship.Row + viaViewZone.RowCount / 2;
            int endCol = m_ship.Col + viaViewZone.ColumnCount / 2;

            int viewRow = 0;
            int viewCol = 0;

            for (int row = startRow; row <= endRow; row++)
            {
                for (int col = startCol; col <= endCol; col++)
                {
                    if ((row >= m_carte.Map.GetLength(0) || row < 0) || (col >= m_carte.Map.GetLength(1) || col < 0))
                    {
                        int newRow = row;
                        int newCol = col;

                        if (row >= m_carte.Map.GetLength(0))
                        {
                            newRow = row - m_carte.Map.GetLength(0);
                        }
                        else if (row < 0)
                        {
                            newRow = row + m_carte.Map.GetLength(0);
                        }
                        if (col >= m_carte.Map.GetLength(1))
                        {
                            newCol = col - m_carte.Map.GetLength(1);
                        }
                        else if (col < 0)
                        {
                            newCol = col + m_carte.Map.GetLength(1);
                        }
                        viaViewZone[viewRow, viewCol] = m_carte.Map[newRow, newCol];
                    }
                    else
                    {
                        viaViewZone[viewRow, viewCol] = m_carte.Map[row, col];
                    }
                    viewCol++;
                }
                viewRow++;
                viewCol = 0;
            }
        }

        private bool ShipIsInCollision()
        {
            if ((m_ship.Row >= m_carte.Map.GetLength(0) || m_ship.Row < 0) ||
                (m_ship.Col >= m_carte.Map.GetLength(1) || m_ship.Col < 0) ||
                (m_carte.Map[m_ship.Row, m_ship.Col] != 0 && m_carte.Map[m_ship.Row, m_ship.Col] != -1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void viaViewZone_CellMouseDown(object sender, CellMouseEventArgs e)
        {
            if (viaViewZone[e.Row, e.Column] == -1)
            {
                MessageBox.Show("This is water.", "Project_Map", MessageBoxButtons.OK);
            }
            if (viaViewZone[e.Row, e.Column] == 5)
            {
                if (MessageBox.Show ("Do you want engage this ship?", "Project_Map", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                      == DialogResult.Yes)
                {
                    MessageBox.Show ("Get Ready For Combat!", "Project_Map", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Coward...", "Project_Map", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if (viaViewZone[e.Row, e.Column] == 6)
            {
                MessageBox.Show("Trade with this ship will begin.", "Project_Map", MessageBoxButtons.OK);
            }
        }

        private void btn_MainMenu_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
            else
                btn_MainMenu_NewGame.Select();
        }

        private void btn_MainMenu_NewGame_Click(object sender, EventArgs e)
        {
            PréparerNouvellePartie();
            m_currentSaveSlot = 1;
            viaViewZone.Focus();
            m_soundPlayer1.Stop();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viaViewZone.Enabled = false;
            viaViewZone.Hide();

            this.Size = new System.Drawing.Size(850, 700);

            pnl_mainMenu.Enabled = true;
            btn_MainMenu_NewGame.Select();
            pnl_mainMenu.Show();

            m_soundPlayer1.Play();

            m_currentSaveSlot = -1;
        }

        private void btn_MainMenu_LoadGame_Click(object sender, EventArgs e)
        {
            pnl_MainMenu_LoadGame.Enabled = true;
            pnl_MainMenu_LoadGame.Show();

            btn_LoadGame_SaveSlot1.Select();
        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void btn_LoadGame_SaveSlot1_Click(object sender, EventArgs e)
        {
            m_currentSaveSlot = 1;
            LoadGame();
        }

        private void btn_LoadGame_SaveSlot2_Click(object sender, EventArgs e)
        {
            m_currentSaveSlot = 2;
            LoadGame();
        }

        private void btn_LoadGame_SaveSlot3_Click(object sender, EventArgs e)
        {
            m_currentSaveSlot = 3;
            LoadGame();
        }

        private void LoadGame()
        {
            FileStream objFileStream = new FileStream("Saves\\Save_" + m_currentSaveSlot.ToString(), FileMode.Open);

            BinaryReader objBinaryReader = new BinaryReader(objFileStream);

            PréparerNouvellePartie();

            DateTime objOld = DateTime.FromBinary(objBinaryReader.ReadInt64());

            int savedRow = objBinaryReader.ReadInt32();
            int savedCol = objBinaryReader.ReadInt32();

            m_ship.Row = savedRow;
            m_ship.Col = savedCol;
            m_ship.LastDirection = objBinaryReader.ReadInt32();

            objBinaryReader.Close();
            objFileStream.Close();

            m_carte.Map[m_ship.Row, m_ship.Col] = 4;
            ViewZoneUpdate();

            pnl_MainMenu_LoadGame.Enabled = false;
            pnl_MainMenu_LoadGame.Hide();

            m_soundPlayer1.Stop();

            MessageBox.Show("Welcome back! You last played on " + objOld.ToString("dd-MM-yyyy") + " at " + objOld.ToString("HH:mm:ss"), "Project Map", MessageBoxButtons.OK);

            viaViewZone.Focus();
        }

        private void SaveGame()
        {
            if (m_currentSaveSlot != -1)
            {
                FileStream objFileStream = new FileStream("Saves\\Save_" + m_currentSaveSlot.ToString(), FileMode.Create);

                BinaryWriter objBinaryWriter = new BinaryWriter(objFileStream);

                objBinaryWriter.Write(DateTime.Now.ToBinary());

                objBinaryWriter.Write(m_ship.Row);
                objBinaryWriter.Write(m_ship.Col);
                objBinaryWriter.Write(m_ship.LastDirection);

                objBinaryWriter.Close();

                objFileStream.Close();
            }
        }

        private void slot1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_currentSaveSlot = 1;
            SaveGame();
        }

        private void slot2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_currentSaveSlot = 2;
            SaveGame();
        }

        private void slot3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_currentSaveSlot = 3;
            SaveGame();
        }

        private void btn_MainMenu_LoadGame_Back_Click(object sender, EventArgs e)
        {
            pnl_MainMenu_LoadGame.Enabled = false;
            pnl_MainMenu_LoadGame.Hide();

            pnl_mainMenu.Enabled = true;
            btn_MainMenu_NewGame.Select();
            pnl_mainMenu.Show();

            m_currentSaveSlot = -1;
        }
    }
}