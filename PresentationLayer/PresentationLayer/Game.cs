using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Game : Form
    {
        private GameMechanics gameMechanics;
        public Game()
        {
            this.gameMechanics = new GameMechanics();
            InitializeComponent();
            gameMechanics.randomGenerator();
            Test();
        }

        private void Test()
        {
            button5.Text = "" + gameMechanics.GameBoard[0, 0];
            button6.Text = "" + gameMechanics.GameBoard[0, 1];
            button7.Text = "" + gameMechanics.GameBoard[0, 2];
            button8.Text = "" + gameMechanics.GameBoard[0, 3];
            button9.Text = "" + gameMechanics.GameBoard[1, 0];
            button10.Text = "" + gameMechanics.GameBoard[1, 1];
            button11.Text = "" + gameMechanics.GameBoard[1, 2];
            button12.Text = "" + gameMechanics.GameBoard[1, 3];
            button13.Text = "" + gameMechanics.GameBoard[2, 0];
            button14.Text = "" + gameMechanics.GameBoard[2, 1];
            button15.Text = "" + gameMechanics.GameBoard[2, 2];
            button16.Text = "" + gameMechanics.GameBoard[2, 3];
            button17.Text = "" + gameMechanics.GameBoard[3, 0];
            button18.Text = "" + gameMechanics.GameBoard[3, 1];
            button19.Text = "" + gameMechanics.GameBoard[3, 2];
            button20.Text = "" + gameMechanics.GameBoard[3, 3];
            
        }
        private void ResetColors()
        {
            bunifuThinButtonLeftA.ForeColor = Color.White;
            bunifuThinButtonUpW.ForeColor = Color.White;
            bunifuThinButtonRightD.ForeColor = Color.White;
            bunifuThinButtonDownS.ForeColor = Color.White;
        }
      
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                gameMechanics.moveLeft();
                label2Score.Text = "" + gameMechanics.Score;
                label3Moves.Text = "" + gameMechanics.moveCounter;
                Test();
                ResetColors();
                bunifuThinButtonLeftA.ForeColor = Color.Black;
                



            }
            else  if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                gameMechanics.moveRight();
                label2Score.Text = "" + gameMechanics.Score;
                label3Moves.Text = "" + gameMechanics.moveCounter;
                Test();
                ResetColors();
                bunifuThinButtonRightD.ForeColor = Color.Black;
               
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                gameMechanics.moveUp();
                label2Score.Text = "" + gameMechanics.Score;
                label3Moves.Text = "" + gameMechanics.moveCounter;
                Test();
                ResetColors();
                bunifuThinButtonUpW.ForeColor = Color.Black;
                
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                
                gameMechanics.moveDown();
                label2Score.Text = "" + gameMechanics.Score;
                label3Moves.Text = "" + gameMechanics.moveCounter;
                Test();
                ResetColors();
                bunifuThinButtonDownS.ForeColor = Color.Black;
               
            }
        }

    }
}
