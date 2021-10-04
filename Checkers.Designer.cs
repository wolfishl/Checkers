
using System.Windows.Forms;

namespace Checkers
{
    partial class Checkers
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
        private void InitializeComponent(Button[,] board, int BOARD_SIZE)
        {            
            int locationy = 30;
            for (int col = 0; col < BOARD_SIZE; col++)
            {
                int locationx = 60;
                for (int row = 0; row < BOARD_SIZE; row++)
                {
                    board[col,row] = new Button();
                    System.Console.WriteLine($"Square {col}, {row} was created and placed in position {locationx}, {locationy}");
                    //
                    //color
                    //
                    if ((col + row) % 2 == 0)
                    {
                        board[col, row].BackColor = System.Drawing.SystemColors.ActiveCaptionText;

                    }
                    else if ((col + row) % 2 == 1)
                    {
                        board[col, row].BackColor = System.Drawing.Color.Red;
                    }
                    //
                    //location
                    //
                    board[col,row].Location = new System.Drawing.Point(locationx, locationy);
                    //
                    //other criteria
                    //
                    board[col,row].Size = new System.Drawing.Size(75, 75);
                    board[col,row].UseVisualStyleBackColor = false;
                    this.Controls.Add(board[col, row]);
                    locationx += 75;
                }
                locationy += 75;
            }
            
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
           
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(620, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 48);
            this.pictureBox1.TabIndex = 127;
            this.pictureBox1.TabStop = false;
            // 
            // Checkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 651);
            this.Controls.Add(this.pictureBox1);
            //this.Controls.Add(this.button27);
            //this.Controls.Add(this.button28);
            //this.Controls.Add(this.button29);
            //this.Controls.Add(this.button30);
            //this.Controls.Add(this.button31);
            //this.Controls.Add(this.button32);
            //this.Controls.Add(this.button33);
            //this.Controls.Add(this.button34);
            //this.Controls.Add(this.button35);
            //this.Controls.Add(this.button36);
            //this.Controls.Add(this.button37);
            //this.Controls.Add(this.button38);
            //this.Controls.Add(this.button39);
            //this.Controls.Add(this.button40);
            //this.Controls.Add(this.button41);
            //this.Controls.Add(this.button42);
            //this.Controls.Add(this.button43);
            //this.Controls.Add(this.button44);
            //this.Controls.Add(this.button45);
            //this.Controls.Add(this.button46);
            //this.Controls.Add(this.button47);
            //this.Controls.Add(this.button48);
            //this.Controls.Add(this.button49);
            //this.Controls.Add(this.button50);
            //this.Controls.Add(this.button51);
            //this.Controls.Add(this.button52);
            //this.Controls.Add(this.button53);
            //this.Controls.Add(this.button54);
            //this.Controls.Add(this.button55);
            //this.Controls.Add(this.button56);
            //this.Controls.Add(this.button57);
            //this.Controls.Add(this.button58);
            //this.Controls.Add(this.button11);
            //this.Controls.Add(this.button12);
            //this.Controls.Add(this.button13);
            //this.Controls.Add(this.button14);
            //this.Controls.Add(this.button15);
            //this.Controls.Add(this.button16);
            //this.Controls.Add(this.button17);
            //this.Controls.Add(this.button18);
            //this.Controls.Add(this.button19);
            //this.Controls.Add(this.button20);
            //this.Controls.Add(this.button21);
            //this.Controls.Add(this.button22);
            //this.Controls.Add(this.button23);
            //this.Controls.Add(this.button24);
            //this.Controls.Add(this.button25);
            //this.Controls.Add(this.button26);
            //this.Controls.Add(this.button3);
            //this.Controls.Add(this.button4);
            //this.Controls.Add(this.button5);
            //this.Controls.Add(this.button6);
            //this.Controls.Add(this.button7);
            //this.Controls.Add(this.button8);
            //this.Controls.Add(this.button9);
            //this.Controls.Add(this.button10);
            //this.Controls.Add(this.button67);
            //this.Controls.Add(this.button68);
            //this.Controls.Add(this.button69);
            //this.Controls.Add(this.button70);
            //this.Controls.Add(this.button65);
            //this.Controls.Add(this.button66);
            //this.Controls.Add(this.button2);
            //this.Controls.Add(this.button1);
            this.Name = "Checkers";
            this.Text = "Checkers";
            this.Load += new System.EventHandler(this.Checkers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Button button1;
        //private System.Windows.Forms.Button button2;
        //private System.Windows.Forms.Button button65;
        //private System.Windows.Forms.Button button66;
        //private System.Windows.Forms.Button button67;
        //private System.Windows.Forms.Button button68;
        //private System.Windows.Forms.Button button69;
        //private System.Windows.Forms.Button button70;
        //private System.Windows.Forms.Button button3;
        //private System.Windows.Forms.Button button4;
        //private System.Windows.Forms.Button button5;
        //private System.Windows.Forms.Button button6;
        //private System.Windows.Forms.Button button7;
        //private System.Windows.Forms.Button button8;
        //private System.Windows.Forms.Button button9;
        //private System.Windows.Forms.Button button10;
        //private System.Windows.Forms.Button button11;
        //private System.Windows.Forms.Button button12;
        //private System.Windows.Forms.Button button13;
        //private System.Windows.Forms.Button button14;
        //private System.Windows.Forms.Button button15;
        //private System.Windows.Forms.Button button16;
        //private System.Windows.Forms.Button button17;
        //private System.Windows.Forms.Button button18;
        //private System.Windows.Forms.Button button19;
        //private System.Windows.Forms.Button button20;
        //private System.Windows.Forms.Button button21;
        //private System.Windows.Forms.Button button22;
        //private System.Windows.Forms.Button button23;
        //private System.Windows.Forms.Button button24;
        //private System.Windows.Forms.Button button25;
        //private System.Windows.Forms.Button button26;
        //private System.Windows.Forms.Button button27;
        //private System.Windows.Forms.Button button28;
        //private System.Windows.Forms.Button button29;
        //private System.Windows.Forms.Button button30;
        //private System.Windows.Forms.Button button31;
        //private System.Windows.Forms.Button button32;
        //private System.Windows.Forms.Button button33;
        //private System.Windows.Forms.Button button34;
        //private System.Windows.Forms.Button button35;
        //private System.Windows.Forms.Button button36;
        //private System.Windows.Forms.Button button37;
        //private System.Windows.Forms.Button button38;
        //private System.Windows.Forms.Button button39;
        //private System.Windows.Forms.Button button40;
        //private System.Windows.Forms.Button button41;
        //private System.Windows.Forms.Button button42;
        //private System.Windows.Forms.Button button43;
        //private System.Windows.Forms.Button button44;
        //private System.Windows.Forms.Button button45;
        //private System.Windows.Forms.Button button46;
        //private System.Windows.Forms.Button button47;
        //private System.Windows.Forms.Button button48;
        //private System.Windows.Forms.Button button49;
        //private System.Windows.Forms.Button button50;
        //private System.Windows.Forms.Button button51;
        //private System.Windows.Forms.Button button52;
        //private System.Windows.Forms.Button button53;
        //private System.Windows.Forms.Button button54;
        //private System.Windows.Forms.Button button55;
        //private System.Windows.Forms.Button button56;
        //private System.Windows.Forms.Button button57;
        //private System.Windows.Forms.Button button58;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

