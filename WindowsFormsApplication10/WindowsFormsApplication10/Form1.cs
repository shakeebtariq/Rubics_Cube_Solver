using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        bool allow = false;
        bool clicked = true;
        char color = 'r';
        int MoveNumber = 0;


        string AddressOfCpp = "ConsoleApplication1.exe";
        string AddressToWrite = "array.txt";
        string AddressToRead = "output.txt";

        public int[] arr = {1,1,1,1,1,1,1,1,1,
                    2,2,2,2,2,2,2,2,2,
                    3,3,3,3,3,3,3,3,3,
                    6,6,6,6,6,6,6,6,6,
                    4,4,4,4,4,4,4,4,4,
                    5,5,5,5,5,5,5,5,5,
                    };
        //constructor
        public Form1()
        {
            InitializeComponent();
            reset();
        }
        bool CFSC()
        {
           //Left Face is Solved
            for (int i = 0; i < 8; i++)
            {
                if (arr[i] != arr[i + 1])
                    return false;
            }
            //Front face is solved
            for (int i = 9; i < 17; i++)
            {
                if (arr[i] != arr[i + 1])
                    return false;
            }
            //Right Face is solved
            for (int i = 18; i < 26; i++)
            {
                if (arr[i] != arr[i + 1])
                    return false;
            }
            //Back Face is solved
            for (int i = 27; i < 35; i++)
            {
                if (arr[i] != arr[i + 1])
                    return false;
            }
            //Top Face is solved
            for (int i = 36; i < 44; i++)
            {
                if (arr[i] != arr[i + 1])
                    return false;
            }
            //Bottom Face is solved
            for (int i = 45; i < 53; i++)
            {
                if (arr[i] != arr[i + 1])
                    return false;
            }
            return true;
        }
        private bool check(int[] arr)
        {
            int[] temp = { 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < 54; i++)
            {
                if (arr[i] == 1)
                    temp[0]++;
                else if (arr[i] == 2)
                    temp[1]++;
                else if (arr[i] == 3)
                    temp[2]++;
                else if (arr[i] == 4)
                    temp[3]++;
                else if (arr[i] == 5)
                    temp[4]++;
                else if (arr[i] == 6)
                    temp[5]++;
            }
            if (temp[0] > 9 || temp[1] > 9 || temp[2] > 9 || temp[3] > 9 || temp[4] > 9 || temp[5] > 9)
            {
                textBox1.Text = "Error! each color must be 9 ";
                textBox1.BackColor = Color.Gray;
                return false;
            }
            else
            {
                textBox1.Text = "   ";
                textBox1.BackColor = Color.WhiteSmoke;
                return true;
            }
        }
        /*   ----------------------------------------    DISPLAY    --------------------------------------------*/
        private void display(int[] arr)
        {
            //arr[0]
            if (arr[0] == 1)
                button1.BackColor = Color.Blue;
            else if (arr[0] == 2)
                button1.BackColor = Color.Red;
            else if (arr[0] == 3)
                button1.BackColor = Color.Green;
            else if (arr[0] == 4)
                button1.BackColor = Color.Yellow;
            else if (arr[0] == 5)
                button1.BackColor = Color.White;
            else if (arr[0] == 6)
                button1.BackColor = Color.DarkOrange;
            //arr[1]
            if (arr[1] == 1)
                button2.BackColor = Color.Blue;
            else if (arr[1] == 2)
                button2.BackColor = Color.Red;
            else if (arr[1] == 3)
                button2.BackColor = Color.Green;
            else if (arr[1] == 4)
                button2.BackColor = Color.Yellow;
            else if (arr[1] == 5)
                button2.BackColor = Color.White;
            else if (arr[1] == 6)
                button2.BackColor = Color.DarkOrange;
            //arr[2]
            if (arr[2] == 1)
                button3.BackColor = Color.Blue;
            else if (arr[2] == 2)
                button3.BackColor = Color.Red;
            else if (arr[2] == 3)
                button3.BackColor = Color.Green;
            else if (arr[2] == 4)
                button3.BackColor = Color.Yellow;
            else if (arr[2] == 5)
                button3.BackColor = Color.White;
            else if (arr[2] == 6)
                button3.BackColor = Color.DarkOrange;
            //arr[3]
            if (arr[3] == 1)
                button4.BackColor = Color.Blue;
            else if (arr[3] == 2)
                button4.BackColor = Color.Red;
            else if (arr[3] == 3)
                button4.BackColor = Color.Green;
            else if (arr[3] == 4)
                button4.BackColor = Color.Yellow;
            else if (arr[3] == 5)
                button4.BackColor = Color.White;
            else if (arr[3] == 6)
                button4.BackColor = Color.DarkOrange;
            //arr[4]
            if (arr[4] == 1)
                button5.BackColor = Color.Blue;
            else if (arr[4] == 2)
                button5.BackColor = Color.Red;
            else if (arr[4] == 3)
                button5.BackColor = Color.Green;
            else if (arr[4] == 4)
                button5.BackColor = Color.Yellow;
            else if (arr[4] == 5)
                button5.BackColor = Color.White;
            else if (arr[4] == 6)
                button5.BackColor = Color.DarkOrange;
            //arr[5]
            if (arr[5] == 1)
                button6.BackColor = Color.Blue;
            else if (arr[5] == 2)
                button6.BackColor = Color.Red;
            else if (arr[5] == 3)
                button6.BackColor = Color.Green;
            else if (arr[5] == 4)
                button6.BackColor = Color.Yellow;
            else if (arr[5] == 5)
                button6.BackColor = Color.White;
            else if (arr[5] == 6)
                button6.BackColor = Color.DarkOrange;
            //arr[6]
            if (arr[6] == 1)
                button7.BackColor = Color.Blue;
            else if (arr[6] == 2)
                button7.BackColor = Color.Red;
            else if (arr[6] == 3)
                button7.BackColor = Color.Green;
            else if (arr[6] == 4)
                button7.BackColor = Color.Yellow;
            else if (arr[6] == 5)
                button7.BackColor = Color.White;
            else if (arr[6] == 6)
                button7.BackColor = Color.DarkOrange;
            //arr[7]
            if (arr[7] == 1)
                button8.BackColor = Color.Blue;
            else if (arr[7] == 2)
                button8.BackColor = Color.Red;
            else if (arr[7] == 3)
                button8.BackColor = Color.Green;
            else if (arr[7] == 4)
                button8.BackColor = Color.Yellow;
            else if (arr[7] == 5)
                button8.BackColor = Color.White;
            else if (arr[7] == 6)
                button8.BackColor = Color.DarkOrange;
            //arr[8]
            if (arr[8] == 1)
                button9.BackColor = Color.Blue;
            else if (arr[8] == 2)
                button9.BackColor = Color.Red;
            else if (arr[8] == 3)
                button9.BackColor = Color.Green;
            else if (arr[8] == 4)
                button9.BackColor = Color.Yellow;
            else if (arr[8] == 5)
                button9.BackColor = Color.White;
            else if (arr[8] == 6)
                button9.BackColor = Color.DarkOrange;
            //arr[10-1]
            if (arr[10 - 1] == 1)
                button10.BackColor = Color.Blue;
            else if (arr[10 - 1] == 2)
                button10.BackColor = Color.Red;
            else if (arr[10 - 1] == 3)
                button10.BackColor = Color.Green;
            else if (arr[10 - 1] == 4)
                button10.BackColor = Color.Yellow;
            else if (arr[10 - 1] == 5)
                button10.BackColor = Color.White;
            else if (arr[10 - 1] == 6)
                button10.BackColor = Color.DarkOrange;
            //arr[11-1]
            if (arr[11 - 1] == 1)
                button11.BackColor = Color.Blue;
            else if (arr[11 - 1] == 2)
                button11.BackColor = Color.Red;
            else if (arr[11 - 1] == 3)
                button11.BackColor = Color.Green;
            else if (arr[11 - 1] == 4)
                button11.BackColor = Color.Yellow;
            else if (arr[11 - 1] == 5)
                button11.BackColor = Color.White;
            else if (arr[11 - 1] == 6)
                button11.BackColor = Color.DarkOrange;
            //arr[12-1]
            if (arr[12 - 1] == 1)
                button12.BackColor = Color.Blue;
            else if (arr[12 - 1] == 2)
                button12.BackColor = Color.Red;
            else if (arr[12 - 1] == 3)
                button12.BackColor = Color.Green;
            else if (arr[12 - 1] == 4)
                button12.BackColor = Color.Yellow;
            else if (arr[12 - 1] == 5)
                button12.BackColor = Color.White;
            else if (arr[12 - 1] == 6)
                button12.BackColor = Color.DarkOrange;
            //arr[13-1]
            if (arr[13 - 1] == 1)
                button13.BackColor = Color.Blue;
            else if (arr[13 - 1] == 2)
                button13.BackColor = Color.Red;
            else if (arr[13 - 1] == 3)
                button13.BackColor = Color.Green;
            else if (arr[13 - 1] == 4)
                button13.BackColor = Color.Yellow;
            else if (arr[13 - 1] == 5)
                button13.BackColor = Color.White;
            else if (arr[13 - 1] == 6)
                button13.BackColor = Color.DarkOrange;
            //arr[14-1]
            if (arr[14 - 1] == 1)
                button14.BackColor = Color.Blue;
            else if (arr[14 - 1] == 2)
                button14.BackColor = Color.Red;
            else if (arr[14 - 1] == 3)
                button14.BackColor = Color.Green;
            else if (arr[14 - 1] == 4)
                button14.BackColor = Color.Yellow;
            else if (arr[14 - 1] == 5)
                button14.BackColor = Color.White;
            else if (arr[14 - 1] == 6)
                button14.BackColor = Color.DarkOrange;
            //arr[15-1]
            if (arr[15 - 1] == 1)
                button15.BackColor = Color.Blue;
            else if (arr[15 - 1] == 2)
                button15.BackColor = Color.Red;
            else if (arr[15 - 1] == 3)
                button15.BackColor = Color.Green;
            else if (arr[15 - 1] == 4)
                button15.BackColor = Color.Yellow;
            else if (arr[15 - 1] == 5)
                button15.BackColor = Color.White;
            else if (arr[15 - 1] == 6)
                button15.BackColor = Color.DarkOrange;
            //arr[16-1]
            if (arr[16 - 1] == 1)
                button16.BackColor = Color.Blue;
            else if (arr[16 - 1] == 2)
                button16.BackColor = Color.Red;
            else if (arr[16 - 1] == 3)
                button16.BackColor = Color.Green;
            else if (arr[16 - 1] == 4)
                button16.BackColor = Color.Yellow;
            else if (arr[16 - 1] == 5)
                button16.BackColor = Color.White;
            else if (arr[16 - 1] == 6)
                button16.BackColor = Color.DarkOrange;
            //arr[17-1]
            if (arr[17 - 1] == 1)
                button17.BackColor = Color.Blue;
            else if (arr[17 - 1] == 2)
                button17.BackColor = Color.Red;
            else if (arr[17 - 1] == 3)
                button17.BackColor = Color.Green;
            else if (arr[17 - 1] == 4)
                button17.BackColor = Color.Yellow;
            else if (arr[17 - 1] == 5)
                button17.BackColor = Color.White;
            else if (arr[17 - 1] == 6)
                button17.BackColor = Color.DarkOrange;
            //arr[18-1]
            if (arr[18 - 1] == 1)
                button18.BackColor = Color.Blue;
            else if (arr[18 - 1] == 2)
                button18.BackColor = Color.Red;
            else if (arr[18 - 1] == 3)
                button18.BackColor = Color.Green;
            else if (arr[18 - 1] == 4)
                button18.BackColor = Color.Yellow;
            else if (arr[18 - 1] == 5)
                button18.BackColor = Color.White;
            else if (arr[18 - 1] == 6)
                button18.BackColor = Color.DarkOrange;
            //arr[19-1]
            if (arr[19 - 1] == 1)
                button19.BackColor = Color.Blue;
            else if (arr[19 - 1] == 2)
                button19.BackColor = Color.Red;
            else if (arr[19 - 1] == 3)
                button19.BackColor = Color.Green;
            else if (arr[19 - 1] == 4)
                button19.BackColor = Color.Yellow;
            else if (arr[19 - 1] == 5)
                button19.BackColor = Color.White;
            else if (arr[19 - 1] == 6)
                button19.BackColor = Color.DarkOrange;
            //arr[20-1]
            if (arr[20 - 1] == 1)
                button20.BackColor = Color.Blue;
            else if (arr[20 - 1] == 2)
                button20.BackColor = Color.Red;
            else if (arr[20 - 1] == 3)
                button20.BackColor = Color.Green;
            else if (arr[20 - 1] == 4)
                button20.BackColor = Color.Yellow;
            else if (arr[20 - 1] == 5)
                button20.BackColor = Color.White;
            else if (arr[20 - 1] == 6)
                button20.BackColor = Color.DarkOrange;
            //arr[21-1]
            if (arr[21 - 1] == 1)
                button21.BackColor = Color.Blue;
            else if (arr[21 - 1] == 2)
                button21.BackColor = Color.Red;
            else if (arr[21 - 1] == 3)
                button21.BackColor = Color.Green;
            else if (arr[21 - 1] == 4)
                button21.BackColor = Color.Yellow;
            else if (arr[21 - 1] == 5)
                button21.BackColor = Color.White;
            else if (arr[21 - 1] == 6)
                button21.BackColor = Color.DarkOrange;
            //arr[22-1]
            if (arr[22 - 1] == 1)
                button22.BackColor = Color.Blue;
            else if (arr[22 - 1] == 2)
                button22.BackColor = Color.Red;
            else if (arr[22 - 1] == 3)
                button22.BackColor = Color.Green;
            else if (arr[22 - 1] == 4)
                button22.BackColor = Color.Yellow;
            else if (arr[22 - 1] == 5)
                button22.BackColor = Color.White;
            else if (arr[22 - 1] == 6)
                button22.BackColor = Color.DarkOrange;
            //arr[23-1]
            if (arr[23 - 1] == 1)
                button23.BackColor = Color.Blue;
            else if (arr[23 - 1] == 2)
                button23.BackColor = Color.Red;
            else if (arr[23 - 1] == 3)
                button23.BackColor = Color.Green;
            else if (arr[23 - 1] == 4)
                button23.BackColor = Color.Yellow;
            else if (arr[23 - 1] == 5)
                button23.BackColor = Color.White;
            else if (arr[23 - 1] == 6)
                button23.BackColor = Color.DarkOrange;
            //arr[24-1]
            if (arr[24 - 1] == 1)
                button24.BackColor = Color.Blue;
            else if (arr[24 - 1] == 2)
                button24.BackColor = Color.Red;
            else if (arr[24 - 1] == 3)
                button24.BackColor = Color.Green;
            else if (arr[24 - 1] == 4)
                button24.BackColor = Color.Yellow;
            else if (arr[24 - 1] == 5)
                button24.BackColor = Color.White;
            else if (arr[24 - 1] == 6)
                button24.BackColor = Color.DarkOrange;
            //arr[25-1]
            if (arr[25 - 1] == 1)
                button25.BackColor = Color.Blue;
            else if (arr[25 - 1] == 2)
                button25.BackColor = Color.Red;
            else if (arr[25 - 1] == 3)
                button25.BackColor = Color.Green;
            else if (arr[25 - 1] == 4)
                button25.BackColor = Color.Yellow;
            else if (arr[25 - 1] == 5)
                button25.BackColor = Color.White;
            else if (arr[25 - 1] == 6)
                button25.BackColor = Color.DarkOrange;
            //arr[26-1]
            if (arr[26 - 1] == 1)
                button26.BackColor = Color.Blue;
            else if (arr[26 - 1] == 2)
                button26.BackColor = Color.Red;
            else if (arr[26 - 1] == 3)
                button26.BackColor = Color.Green;
            else if (arr[26 - 1] == 4)
                button26.BackColor = Color.Yellow;
            else if (arr[26 - 1] == 5)
                button26.BackColor = Color.White;
            else if (arr[26 - 1] == 6)
                button26.BackColor = Color.DarkOrange;
            //arr[27-1]
            if (arr[27 - 1] == 1)
                button27.BackColor = Color.Blue;
            else if (arr[27 - 1] == 2)
                button27.BackColor = Color.Red;
            else if (arr[27 - 1] == 3)
                button27.BackColor = Color.Green;
            else if (arr[27 - 1] == 4)
                button27.BackColor = Color.Yellow;
            else if (arr[27 - 1] == 5)
                button27.BackColor = Color.White;
            else if (arr[27 - 1] == 6)
                button27.BackColor = Color.DarkOrange;
            //arr[28-1]
            if (arr[28 - 1] == 1)
                button28.BackColor = Color.Blue;
            else if (arr[28 - 1] == 2)
                button28.BackColor = Color.Red;
            else if (arr[28 - 1] == 3)
                button28.BackColor = Color.Green;
            else if (arr[28 - 1] == 4)
                button28.BackColor = Color.Yellow;
            else if (arr[28 - 1] == 5)
                button28.BackColor = Color.White;
            else if (arr[28 - 1] == 6)
                button28.BackColor = Color.DarkOrange;
            //arr[29-1]
            if (arr[29 - 1] == 1)
                button29.BackColor = Color.Blue;
            else if (arr[29 - 1] == 2)
                button29.BackColor = Color.Red;
            else if (arr[29 - 1] == 3)
                button29.BackColor = Color.Green;
            else if (arr[29 - 1] == 4)
                button29.BackColor = Color.Yellow;
            else if (arr[29 - 1] == 5)
                button29.BackColor = Color.White;
            else if (arr[29 - 1] == 6)
                button29.BackColor = Color.DarkOrange;
            //arr[30-1]
            if (arr[30 - 1] == 1)
                button30.BackColor = Color.Blue;
            else if (arr[30 - 1] == 2)
                button30.BackColor = Color.Red;
            else if (arr[30 - 1] == 3)
                button30.BackColor = Color.Green;
            else if (arr[30 - 1] == 4)
                button30.BackColor = Color.Yellow;
            else if (arr[30 - 1] == 5)
                button30.BackColor = Color.White;
            else if (arr[30 - 1] == 6)
                button30.BackColor = Color.DarkOrange;
            //arr[31-1]
            if (arr[31 - 1] == 1)
                button31.BackColor = Color.Blue;
            else if (arr[31 - 1] == 2)
                button31.BackColor = Color.Red;
            else if (arr[31 - 1] == 3)
                button31.BackColor = Color.Green;
            else if (arr[31 - 1] == 4)
                button31.BackColor = Color.Yellow;
            else if (arr[31 - 1] == 5)
                button31.BackColor = Color.White;
            else if (arr[31 - 1] == 6)
                button31.BackColor = Color.DarkOrange;
            //arr[32-1]
            if (arr[32 - 1] == 1)
                button32.BackColor = Color.Blue;
            else if (arr[32 - 1] == 2)
                button32.BackColor = Color.Red;
            else if (arr[32 - 1] == 3)
                button32.BackColor = Color.Green;
            else if (arr[32 - 1] == 4)
                button32.BackColor = Color.Yellow;
            else if (arr[32 - 1] == 5)
                button32.BackColor = Color.White;
            else if (arr[32 - 1] == 6)
                button32.BackColor = Color.DarkOrange;
            //arr[33-1]
            if (arr[33 - 1] == 1)
                button33.BackColor = Color.Blue;
            else if (arr[33 - 1] == 2)
                button33.BackColor = Color.Red;
            else if (arr[33 - 1] == 3)
                button33.BackColor = Color.Green;
            else if (arr[33 - 1] == 4)
                button33.BackColor = Color.Yellow;
            else if (arr[33 - 1] == 5)
                button33.BackColor = Color.White;
            else if (arr[33 - 1] == 6)
                button33.BackColor = Color.DarkOrange;
            //arr[34-1]
            if (arr[34 - 1] == 1)
                button34.BackColor = Color.Blue;
            else if (arr[34 - 1] == 2)
                button34.BackColor = Color.Red;
            else if (arr[34 - 1] == 3)
                button34.BackColor = Color.Green;
            else if (arr[34 - 1] == 4)
                button34.BackColor = Color.Yellow;
            else if (arr[34 - 1] == 5)
                button34.BackColor = Color.White;
            else if (arr[34 - 1] == 6)
                button34.BackColor = Color.DarkOrange;
            //arr[35-1]
            if (arr[35 - 1] == 1)
                button35.BackColor = Color.Blue;
            else if (arr[35 - 1] == 2)
                button35.BackColor = Color.Red;
            else if (arr[35 - 1] == 3)
                button35.BackColor = Color.Green;
            else if (arr[35 - 1] == 4)
                button35.BackColor = Color.Yellow;
            else if (arr[35 - 1] == 5)
                button35.BackColor = Color.White;
            else if (arr[35 - 1] == 6)
                button35.BackColor = Color.DarkOrange;
            //arr[36-1]
            if (arr[36 - 1] == 1)
                button36.BackColor = Color.Blue;
            else if (arr[36 - 1] == 2)
                button36.BackColor = Color.Red;
            else if (arr[36 - 1] == 3)
                button36.BackColor = Color.Green;
            else if (arr[36 - 1] == 4)
                button36.BackColor = Color.Yellow;
            else if (arr[36 - 1] == 5)
                button36.BackColor = Color.White;
            else if (arr[36 - 1] == 6)
                button36.BackColor = Color.DarkOrange;
            //arr[37-1]
            if (arr[37 - 1] == 1)
                button37.BackColor = Color.Blue;
            else if (arr[37 - 1] == 2)
                button37.BackColor = Color.Red;
            else if (arr[37 - 1] == 3)
                button37.BackColor = Color.Green;
            else if (arr[37 - 1] == 4)
                button37.BackColor = Color.Yellow;
            else if (arr[37 - 1] == 5)
                button37.BackColor = Color.White;
            else if (arr[37 - 1] == 6)
                button37.BackColor = Color.DarkOrange;
            //arr[38-1]
            if (arr[38 - 1] == 1)
                button38.BackColor = Color.Blue;
            else if (arr[38 - 1] == 2)
                button38.BackColor = Color.Red;
            else if (arr[38 - 1] == 3)
                button38.BackColor = Color.Green;
            else if (arr[38 - 1] == 4)
                button38.BackColor = Color.Yellow;
            else if (arr[38 - 1] == 5)
                button38.BackColor = Color.White;
            else if (arr[38 - 1] == 6)
                button38.BackColor = Color.DarkOrange;
            //arr[39-1]
            if (arr[39 - 1] == 1)
                button39.BackColor = Color.Blue;
            else if (arr[39 - 1] == 2)
                button39.BackColor = Color.Red;
            else if (arr[39 - 1] == 3)
                button39.BackColor = Color.Green;
            else if (arr[39 - 1] == 4)
                button39.BackColor = Color.Yellow;
            else if (arr[39 - 1] == 5)
                button39.BackColor = Color.White;
            else if (arr[39 - 1] == 6)
                button39.BackColor = Color.DarkOrange;
            //arr[40-1]
            if (arr[40 - 1] == 1)
                button40.BackColor = Color.Blue;
            else if (arr[40 - 1] == 2)
                button40.BackColor = Color.Red;
            else if (arr[40 - 1] == 3)
                button40.BackColor = Color.Green;
            else if (arr[40 - 1] == 4)
                button40.BackColor = Color.Yellow;
            else if (arr[40 - 1] == 5)
                button40.BackColor = Color.White;
            else if (arr[40 - 1] == 6)
                button40.BackColor = Color.DarkOrange;
            //arr[41-1]
            if (arr[41 - 1] == 1)
                button41.BackColor = Color.Blue;
            else if (arr[41 - 1] == 2)
                button41.BackColor = Color.Red;
            else if (arr[41 - 1] == 3)
                button41.BackColor = Color.Green;
            else if (arr[41 - 1] == 4)
                button41.BackColor = Color.Yellow;
            else if (arr[41 - 1] == 5)
                button41.BackColor = Color.White;
            else if (arr[41 - 1] == 6)
                button41.BackColor = Color.DarkOrange;
            //arr[42-1]
            if (arr[42 - 1] == 1)
                button42.BackColor = Color.Blue;
            else if (arr[42 - 1] == 2)
                button42.BackColor = Color.Red;
            else if (arr[42 - 1] == 3)
                button42.BackColor = Color.Green;
            else if (arr[42 - 1] == 4)
                button42.BackColor = Color.Yellow;
            else if (arr[42 - 1] == 5)
                button42.BackColor = Color.White;
            else if (arr[42 - 1] == 6)
                button42.BackColor = Color.DarkOrange;
            //arr[43-1]
            if (arr[43 - 1] == 1)
                button43.BackColor = Color.Blue;
            else if (arr[43 - 1] == 2)
                button43.BackColor = Color.Red;
            else if (arr[43 - 1] == 3)
                button43.BackColor = Color.Green;
            else if (arr[43 - 1] == 4)
                button43.BackColor = Color.Yellow;
            else if (arr[43 - 1] == 5)
                button43.BackColor = Color.White;
            else if (arr[43 - 1] == 6)
                button43.BackColor = Color.DarkOrange;
            //arr[44-1]
            if (arr[44 - 1] == 1)
                button44.BackColor = Color.Blue;
            else if (arr[44 - 1] == 2)
                button44.BackColor = Color.Red;
            else if (arr[44 - 1] == 3)
                button44.BackColor = Color.Green;
            else if (arr[44 - 1] == 4)
                button44.BackColor = Color.Yellow;
            else if (arr[44 - 1] == 5)
                button44.BackColor = Color.White;
            else if (arr[44 - 1] == 6)
                button44.BackColor = Color.DarkOrange;
            //arr[45-1]
            if (arr[45 - 1] == 1)
                button45.BackColor = Color.Blue;
            else if (arr[45 - 1] == 2)
                button45.BackColor = Color.Red;
            else if (arr[45 - 1] == 3)
                button45.BackColor = Color.Green;
            else if (arr[45 - 1] == 4)
                button45.BackColor = Color.Yellow;
            else if (arr[45 - 1] == 5)
                button45.BackColor = Color.White;
            else if (arr[45 - 1] == 6)
                button45.BackColor = Color.DarkOrange;
            //arr[46-1]
            if (arr[46 - 1] == 1)
                button46.BackColor = Color.Blue;
            else if (arr[46 - 1] == 2)
                button46.BackColor = Color.Red;
            else if (arr[46 - 1] == 3)
                button46.BackColor = Color.Green;
            else if (arr[46 - 1] == 4)
                button46.BackColor = Color.Yellow;
            else if (arr[46 - 1] == 5)
                button46.BackColor = Color.White;
            else if (arr[46 - 1] == 6)
                button46.BackColor = Color.DarkOrange;
            //arr[47-1]
            if (arr[47 - 1] == 1)
                button47.BackColor = Color.Blue;
            else if (arr[47 - 1] == 2)
                button47.BackColor = Color.Red;
            else if (arr[47 - 1] == 3)
                button47.BackColor = Color.Green;
            else if (arr[47 - 1] == 4)
                button47.BackColor = Color.Yellow;
            else if (arr[47 - 1] == 5)
                button47.BackColor = Color.White;
            else if (arr[47 - 1] == 6)
                button47.BackColor = Color.DarkOrange;
            //arr[48-1]
            if (arr[48 - 1] == 1)
                button48.BackColor = Color.Blue;
            else if (arr[48 - 1] == 2)
                button48.BackColor = Color.Red;
            else if (arr[48 - 1] == 3)
                button48.BackColor = Color.Green;
            else if (arr[48 - 1] == 4)
                button48.BackColor = Color.Yellow;
            else if (arr[48 - 1] == 5)
                button48.BackColor = Color.White;
            else if (arr[48 - 1] == 6)
                button48.BackColor = Color.DarkOrange;
            //arr[49-1]
            if (arr[49 - 1] == 1)
                button49.BackColor = Color.Blue;
            else if (arr[49 - 1] == 2)
                button49.BackColor = Color.Red;
            else if (arr[49 - 1] == 3)
                button49.BackColor = Color.Green;
            else if (arr[49 - 1] == 4)
                button49.BackColor = Color.Yellow;
            else if (arr[49 - 1] == 5)
                button49.BackColor = Color.White;
            else if (arr[49 - 1] == 6)
                button49.BackColor = Color.DarkOrange;
            //arr[50-1]
            if (arr[50 - 1] == 1)
                button50.BackColor = Color.Blue;
            else if (arr[50 - 1] == 2)
                button50.BackColor = Color.Red;
            else if (arr[50 - 1] == 3)
                button50.BackColor = Color.Green;
            else if (arr[50 - 1] == 4)
                button50.BackColor = Color.Yellow;
            else if (arr[50 - 1] == 5)
                button50.BackColor = Color.White;
            else if (arr[50 - 1] == 6)
                button50.BackColor = Color.DarkOrange;
            //arr[51-1]
            if (arr[51 - 1] == 1)
                button51.BackColor = Color.Blue;
            else if (arr[51 - 1] == 2)
                button51.BackColor = Color.Red;
            else if (arr[51 - 1] == 3)
                button51.BackColor = Color.Green;
            else if (arr[51 - 1] == 4)
                button51.BackColor = Color.Yellow;
            else if (arr[51 - 1] == 5)
                button51.BackColor = Color.White;
            else if (arr[51 - 1] == 6)
                button51.BackColor = Color.DarkOrange;
            //arr[52-1]
            if (arr[52 - 1] == 1)
                button52.BackColor = Color.Blue;
            else if (arr[52 - 1] == 2)
                button52.BackColor = Color.Red;
            else if (arr[52 - 1] == 3)
                button52.BackColor = Color.Green;
            else if (arr[52 - 1] == 4)
                button52.BackColor = Color.Yellow;
            else if (arr[52 - 1] == 5)
                button52.BackColor = Color.White;
            else if (arr[52 - 1] == 6)
                button52.BackColor = Color.DarkOrange;
            //arr[53-1]
            if (arr[53 - 1] == 1)
                button53.BackColor = Color.Blue;
            else if (arr[53 - 1] == 2)
                button53.BackColor = Color.Red;
            else if (arr[53 - 1] == 3)
                button53.BackColor = Color.Green;
            else if (arr[53 - 1] == 4)
                button53.BackColor = Color.Yellow;
            else if (arr[53 - 1] == 5)
                button53.BackColor = Color.White;
            else if (arr[53 - 1] == 6)
                button53.BackColor = Color.DarkOrange;
            //arr[54-1]
            if (arr[54 - 1] == 1)
                button54.BackColor = Color.Blue;
            else if (arr[54 - 1] == 2)
                button54.BackColor = Color.Red;
            else if (arr[54 - 1] == 3)
                button54.BackColor = Color.Green;
            else if (arr[54 - 1] == 4)
                button54.BackColor = Color.Yellow;
            else if (arr[54 - 1] == 5)
                button54.BackColor = Color.White;
            else if (arr[54 - 1] == 6)
                button54.BackColor = Color.DarkOrange;


        }
        /*   ----------------------------------------    DISPLAY END    --------------------------------------------*/


        /*   ----------------------------------------    RESET   --------------------------------------------*/
        public void reset()
        {
            button63.Visible = false;
            button64.Visible = false;
            int[] temp = { 1, 2, 3, 6, 4, 5 };
            int j = 0;
            for (int i = 0; i < 54; i++)
            {
                if (i == 9 || i == 18 || i == 27 || i == 36 || i == 45)
                    j++;
                arr[i] = temp[j];
            }
            display(arr);
        }
        /*   ----------------------------------------    RESET END  --------------------------------------------*/
        protected void Form1_Load(object sender, EventArgs e)
        {

        }
        //bool run = true;
        //bool DSwitch = true;
        protected void button55_Click(object sender, EventArgs e)
        {
            //                          Solve BUtton
            if (check(arr) == true)
            {
                allow = false;
                clicked = true;
                WriteArray();
                using (Process exeProcess = Process.Start(AddressOfCpp))
                {
                    exeProcess.WaitForExit();
                }
                ReadOutput();
                button63.Visible = true;
                button64.Visible = true;
                if (CFSC() == true)
                {
                    MessageBox.Show("Cube is Solves   :)");
                }
                else
                {

                }
            }
        }

        protected void button58_Click(object sender, EventArgs e)
        {
            allow = true;
            color = 'r';
        }

        protected void button57_Click(object sender, EventArgs e)
        {
            allow = true;
            color = 'g';
        }

        protected void button56_Click(object sender, EventArgs e)
        {
            allow = true;
            color = 'w';
        }

        protected void button61_Click(object sender, EventArgs e)
        {
            allow = true;
            color = 'y';
        }

        protected void button60_Click(object sender, EventArgs e)
        {
            allow = true;
            color = 'o';
        }

        protected void button59_Click(object sender, EventArgs e)
        {
            allow = true;
            color = 'b';
        }
        //blue = 1, red = 2 , green = 3, yellow = 4, white = 5,  orange = 6

        //arr[1-1]
        protected void button1_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button1.BackColor = Color.Blue;
                            arr[1 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button1.BackColor = Color.Red;
                            arr[1 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button1.BackColor = Color.Green;
                            arr[1 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button1.BackColor = Color.Yellow;
                            arr[1 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button1.BackColor = Color.White;
                            arr[1 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button1.BackColor = Color.DarkOrange;
                            arr[1 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[2]
        protected void button2_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button2.BackColor = Color.Blue;
                            arr[2 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button2.BackColor = Color.Red;
                            arr[2 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button2.BackColor = Color.Green;
                            arr[2 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button2.BackColor = Color.Yellow;
                            arr[2 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button2.BackColor = Color.White;
                            arr[2 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button2.BackColor = Color.DarkOrange;
                            arr[2 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[3-1]
        protected void button3_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button3.BackColor = Color.Blue;
                            arr[3 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button3.BackColor = Color.Red;
                            arr[3 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button3.BackColor = Color.Green;
                            arr[3 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button3.BackColor = Color.Yellow;
                            arr[3 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button3.BackColor = Color.White;
                            arr[3 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button3.BackColor = Color.DarkOrange;
                            arr[3 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[6-1]
        protected void button6_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button6.BackColor = Color.Blue;
                            arr[6 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button6.BackColor = Color.Red;
                            arr[6 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button6.BackColor = Color.Green;
                            arr[6 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button6.BackColor = Color.Yellow;
                            arr[6 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button6.BackColor = Color.White;
                            arr[6 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button6.BackColor = Color.DarkOrange;
                            arr[6 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[5-1]
        protected void button5_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button5.BackColor = Color.Blue;
                            arr[5 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button5.BackColor = Color.Red;
                            arr[5 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button5.BackColor = Color.Green;
                            arr[5 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button5.BackColor = Color.Yellow;
                            arr[5 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button5.BackColor = Color.White;
                            arr[5 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button5.BackColor = Color.DarkOrange;
                            arr[5 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[4-1]
        protected void button4_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button4.BackColor = Color.Blue;
                            arr[4 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button4.BackColor = Color.Red;
                            arr[4 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button4.BackColor = Color.Green;
                            arr[4 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button4.BackColor = Color.Yellow;
                            arr[4 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button4.BackColor = Color.White;
                            arr[4 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button4.BackColor = Color.DarkOrange;
                            arr[4 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[7-1]
        protected void button7_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button7.BackColor = Color.Blue;
                            arr[7 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button7.BackColor = Color.Red;
                            arr[7 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button7.BackColor = Color.Green;
                            arr[7 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button7.BackColor = Color.Yellow;
                            arr[7 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button7.BackColor = Color.White;
                            arr[7 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button7.BackColor = Color.DarkOrange;
                            arr[7 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[8-1]
        protected void button8_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button8.BackColor = Color.Blue;
                            arr[8 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button8.BackColor = Color.Red;
                            arr[8 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button8.BackColor = Color.Green;
                            arr[8 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button8.BackColor = Color.Yellow;
                            arr[8 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button8.BackColor = Color.White;
                            arr[8 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button8.BackColor = Color.DarkOrange;
                            arr[8 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[9-1]
        protected void button9_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button9.BackColor = Color.Blue;
                            arr[9 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button9.BackColor = Color.Red;
                            arr[9 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button9.BackColor = Color.Green;
                            arr[9 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button9.BackColor = Color.Yellow;
                            arr[9 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button9.BackColor = Color.White;
                            arr[9 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button9.BackColor = Color.DarkOrange;
                            arr[9 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[10-1]
        protected void button10_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button10.BackColor = Color.Blue;
                            arr[10 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button10.BackColor = Color.Red;
                            arr[10 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button10.BackColor = Color.Green;
                            arr[10 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button10.BackColor = Color.Yellow;
                            arr[10 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button10.BackColor = Color.White;
                            arr[10 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button10.BackColor = Color.DarkOrange;
                            arr[10 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[11-1]
        protected void button11_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button11.BackColor = Color.Blue;
                            arr[11 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button11.BackColor = Color.Red;
                            arr[11 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button11.BackColor = Color.Green;
                            arr[11 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button11.BackColor = Color.Yellow;
                            arr[11 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button11.BackColor = Color.White;
                            arr[11 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button11.BackColor = Color.DarkOrange;
                            arr[11 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[12-1]
        protected void button12_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button12.BackColor = Color.Blue;
                            arr[12 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button12.BackColor = Color.Red;
                            arr[12 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button12.BackColor = Color.Green;
                            arr[12 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button12.BackColor = Color.Yellow;
                            arr[12 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button12.BackColor = Color.White;
                            arr[12 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button12.BackColor = Color.DarkOrange;
                            arr[12 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[13-1]
        protected void button13_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button13.BackColor = Color.Blue;
                            arr[13 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button13.BackColor = Color.Red;
                            arr[13 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button13.BackColor = Color.Green;
                            arr[13 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button13.BackColor = Color.Yellow;
                            arr[13 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button13.BackColor = Color.White;
                            arr[13 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button13.BackColor = Color.DarkOrange;
                            arr[13 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[14-1]
        protected void button14_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button14.BackColor = Color.Blue;
                            arr[14 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button14.BackColor = Color.Red;
                            arr[14 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button14.BackColor = Color.Green;
                            arr[14 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button14.BackColor = Color.Yellow;
                            arr[14 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button14.BackColor = Color.White;
                            arr[14 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button14.BackColor = Color.DarkOrange;
                            arr[14 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[15-1]
        protected void button15_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button15.BackColor = Color.Blue;
                            arr[15 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button15.BackColor = Color.Red;
                            arr[15 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button15.BackColor = Color.Green;
                            arr[15 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button15.BackColor = Color.Yellow;
                            arr[15 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button15.BackColor = Color.White;
                            arr[15 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button15.BackColor = Color.DarkOrange;
                            arr[15 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[16-1]
        protected void button16_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button16.BackColor = Color.Blue;
                            arr[16 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button16.BackColor = Color.Red;
                            arr[16 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button16.BackColor = Color.Green;
                            arr[16 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button16.BackColor = Color.Yellow;
                            arr[16 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button16.BackColor = Color.White;
                            arr[16 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button16.BackColor = Color.DarkOrange;
                            arr[16 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[17-1]
        protected void button17_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button17.BackColor = Color.Blue;
                            arr[17 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button17.BackColor = Color.Red;
                            arr[17 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button17.BackColor = Color.Green;
                            arr[17 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button17.BackColor = Color.Yellow;
                            arr[17 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button17.BackColor = Color.White;
                            arr[17 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button17.BackColor = Color.DarkOrange;
                            arr[17 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[18-1]
        protected void button18_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button18.BackColor = Color.Blue;
                            arr[18 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button18.BackColor = Color.Red;
                            arr[18 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button18.BackColor = Color.Green;
                            arr[18 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button18.BackColor = Color.Yellow;
                            arr[18 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button18.BackColor = Color.White;
                            arr[18 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button18.BackColor = Color.DarkOrange;
                            arr[18 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[19-1]
        protected void button19_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button19.BackColor = Color.Blue;
                            arr[19 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button19.BackColor = Color.Red;
                            arr[19 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button19.BackColor = Color.Green;
                            arr[19 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button19.BackColor = Color.Yellow;
                            arr[19 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button19.BackColor = Color.White;
                            arr[19 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button19.BackColor = Color.DarkOrange;
                            arr[19 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[20-1]
        protected void button20_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button20.BackColor = Color.Blue;
                            arr[20 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button20.BackColor = Color.Red;
                            arr[20 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button20.BackColor = Color.Green;
                            arr[20 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button20.BackColor = Color.Yellow;
                            arr[20 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button20.BackColor = Color.White;
                            arr[20 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button20.BackColor = Color.DarkOrange;
                            arr[20 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[21-1]
        protected void button21_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button21.BackColor = Color.Blue;
                            arr[21 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button21.BackColor = Color.Red;
                            arr[21 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button21.BackColor = Color.Green;
                            arr[21 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button21.BackColor = Color.Yellow;
                            arr[21 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button21.BackColor = Color.White;
                            arr[21 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button21.BackColor = Color.DarkOrange;
                            arr[21 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[22-1]
        protected void button22_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button22.BackColor = Color.Blue;
                            arr[22 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button22.BackColor = Color.Red;
                            arr[22 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button22.BackColor = Color.Green;
                            arr[22 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button22.BackColor = Color.Yellow;
                            arr[22 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button22.BackColor = Color.White;
                            arr[22 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button22.BackColor = Color.DarkOrange;
                            arr[22 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[23-1]
        protected void button23_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button23.BackColor = Color.Blue;
                            arr[23 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button23.BackColor = Color.Red;
                            arr[23 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button23.BackColor = Color.Green;
                            arr[23 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button23.BackColor = Color.Yellow;
                            arr[23 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button23.BackColor = Color.White;
                            arr[23 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button23.BackColor = Color.DarkOrange;
                            arr[23 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[24-1]
        protected void button24_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button24.BackColor = Color.Blue;
                            arr[24 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button24.BackColor = Color.Red;
                            arr[24 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button24.BackColor = Color.Green;
                            arr[24 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button24.BackColor = Color.Yellow;
                            arr[24 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button24.BackColor = Color.White;
                            arr[24 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button24.BackColor = Color.DarkOrange;
                            arr[24 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[25-1]
        protected void button25_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button25.BackColor = Color.Blue;
                            arr[25 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button25.BackColor = Color.Red;
                            arr[25 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button25.BackColor = Color.Green;
                            arr[25 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button25.BackColor = Color.Yellow;
                            arr[25 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button25.BackColor = Color.White;
                            arr[25 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button25.BackColor = Color.DarkOrange;
                            arr[25 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[26-1]
        protected void button26_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button26.BackColor = Color.Blue;
                            arr[26 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button26.BackColor = Color.Red;
                            arr[26 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button26.BackColor = Color.Green;
                            arr[26 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button26.BackColor = Color.Yellow;
                            arr[26 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button26.BackColor = Color.White;
                            arr[26 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button26.BackColor = Color.DarkOrange;
                            arr[26 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[27-1]
        protected void button27_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button27.BackColor = Color.Blue;
                            arr[27 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button27.BackColor = Color.Red;
                            arr[27 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button27.BackColor = Color.Green;
                            arr[27 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button27.BackColor = Color.Yellow;
                            arr[27 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button27.BackColor = Color.White;
                            arr[27 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button27.BackColor = Color.DarkOrange;
                            arr[27 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[28-1]
        protected void button28_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button28.BackColor = Color.Blue;
                            arr[28 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button28.BackColor = Color.Red;
                            arr[28 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button28.BackColor = Color.Green;
                            arr[28 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button28.BackColor = Color.Yellow;
                            arr[28 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button28.BackColor = Color.White;
                            arr[28 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button28.BackColor = Color.DarkOrange;
                            arr[28 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[29-1]
        protected void button29_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button29.BackColor = Color.Blue;
                            arr[29 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button29.BackColor = Color.Red;
                            arr[29 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button29.BackColor = Color.Green;
                            arr[29 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button29.BackColor = Color.Yellow;
                            arr[29 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button29.BackColor = Color.White;
                            arr[29 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button29.BackColor = Color.DarkOrange;
                            arr[29 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[30-1]
        protected void button30_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button30.BackColor = Color.Blue;
                            arr[30 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button30.BackColor = Color.Red;
                            arr[30 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button30.BackColor = Color.Green;
                            arr[30 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button30.BackColor = Color.Yellow;
                            arr[30 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button30.BackColor = Color.White;
                            arr[30 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button30.BackColor = Color.DarkOrange;
                            arr[30 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[31-1]
        protected void button31_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button31.BackColor = Color.Blue;
                            arr[31 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button31.BackColor = Color.Red;
                            arr[31 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button31.BackColor = Color.Green;
                            arr[31 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button31.BackColor = Color.Yellow;
                            arr[31 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button31.BackColor = Color.White;
                            arr[31 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button31.BackColor = Color.DarkOrange;
                            arr[31 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[32-1]
        protected void button32_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button32.BackColor = Color.Blue;
                            arr[32 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button32.BackColor = Color.Red;
                            arr[32 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button32.BackColor = Color.Green;
                            arr[32 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button32.BackColor = Color.Yellow;
                            arr[32 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button32.BackColor = Color.White;
                            arr[32 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button32.BackColor = Color.DarkOrange;
                            arr[32 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[33-1]
        protected void button33_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button33.BackColor = Color.Blue;
                            arr[33 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button33.BackColor = Color.Red;
                            arr[33 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button33.BackColor = Color.Green;
                            arr[33 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button33.BackColor = Color.Yellow;
                            arr[33 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button33.BackColor = Color.White;
                            arr[33 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button33.BackColor = Color.DarkOrange;
                            arr[33 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[34-1]
        protected void button34_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button34.BackColor = Color.Blue;
                            arr[34 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button34.BackColor = Color.Red;
                            arr[34 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button34.BackColor = Color.Green;
                            arr[34 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button34.BackColor = Color.Yellow;
                            arr[34 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button34.BackColor = Color.White;
                            arr[34 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button34.BackColor = Color.DarkOrange;
                            arr[34 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[35-1]
        protected void button35_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button35.BackColor = Color.Blue;
                            arr[35 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button35.BackColor = Color.Red;
                            arr[35 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button35.BackColor = Color.Green;
                            arr[35 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button35.BackColor = Color.Yellow;
                            arr[35 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button35.BackColor = Color.White;
                            arr[35 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button35.BackColor = Color.DarkOrange;
                            arr[35 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[36-1]
        protected void button36_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button36.BackColor = Color.Blue;
                            arr[36 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button36.BackColor = Color.Red;
                            arr[36 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button36.BackColor = Color.Green;
                            arr[36 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button36.BackColor = Color.Yellow;
                            arr[36 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button36.BackColor = Color.White;
                            arr[36 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button36.BackColor = Color.DarkOrange;
                            arr[36 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[37-1]
        protected void button37_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button37.BackColor = Color.Blue;
                            arr[37 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button37.BackColor = Color.Red;
                            arr[37 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button37.BackColor = Color.Green;
                            arr[37 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button37.BackColor = Color.Yellow;
                            arr[37 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button37.BackColor = Color.White;
                            arr[37 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button37.BackColor = Color.DarkOrange;
                            arr[37 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[38-1]
        protected void button38_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button38.BackColor = Color.Blue;
                            arr[38 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button38.BackColor = Color.Red;
                            arr[38 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button38.BackColor = Color.Green;
                            arr[38 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button38.BackColor = Color.Yellow;
                            arr[38 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button38.BackColor = Color.White;
                            arr[38 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button38.BackColor = Color.DarkOrange;
                            arr[38 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[39-1]
        protected void button39_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button39.BackColor = Color.Blue;
                            arr[39 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button39.BackColor = Color.Red;
                            arr[39 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button39.BackColor = Color.Green;
                            arr[39 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button39.BackColor = Color.Yellow;
                            arr[39 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button39.BackColor = Color.White;
                            arr[39 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button39.BackColor = Color.DarkOrange;
                            arr[39 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[40-1]
        protected void button40_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button40.BackColor = Color.Blue;
                            arr[40 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button40.BackColor = Color.Red;
                            arr[40 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button40.BackColor = Color.Green;
                            arr[40 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button40.BackColor = Color.Yellow;
                            arr[40 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button40.BackColor = Color.White;
                            arr[40 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button40.BackColor = Color.DarkOrange;
                            arr[40 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[41-1]
        protected void button41_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button41.BackColor = Color.Blue;
                            arr[41 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button41.BackColor = Color.Red;
                            arr[41 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button41.BackColor = Color.Green;
                            arr[41 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button41.BackColor = Color.Yellow;
                            arr[41 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button41.BackColor = Color.White;
                            arr[41 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button41.BackColor = Color.DarkOrange;
                            arr[41 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[42-1]
        protected void button42_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button42.BackColor = Color.Blue;
                            arr[42 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button42.BackColor = Color.Red;
                            arr[42 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button42.BackColor = Color.Green;
                            arr[42 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button42.BackColor = Color.Yellow;
                            arr[42 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button42.BackColor = Color.White;
                            arr[42 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button42.BackColor = Color.DarkOrange;
                            arr[42 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[43-1]
        protected void button43_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button43.BackColor = Color.Blue;
                            arr[43 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button43.BackColor = Color.Red;
                            arr[43 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button43.BackColor = Color.Green;
                            arr[43 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button43.BackColor = Color.Yellow;
                            arr[43 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button43.BackColor = Color.White;
                            arr[43 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button43.BackColor = Color.DarkOrange;
                            arr[43 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[44-1]
        protected void button44_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button44.BackColor = Color.Blue;
                            arr[44 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button44.BackColor = Color.Red;
                            arr[44 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button44.BackColor = Color.Green;
                            arr[44 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button44.BackColor = Color.Yellow;
                            arr[44 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button44.BackColor = Color.White;
                            arr[44 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button44.BackColor = Color.DarkOrange;
                            arr[44 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[45-1]
        protected void button45_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button45.BackColor = Color.Blue;
                            arr[45 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button45.BackColor = Color.Red;
                            arr[45 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button45.BackColor = Color.Green;
                            arr[45 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button45.BackColor = Color.Yellow;
                            arr[45 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button45.BackColor = Color.White;
                            arr[45 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button45.BackColor = Color.DarkOrange;
                            arr[45 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[46-1]
        protected void button46_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button46.BackColor = Color.Blue;
                            arr[46 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button46.BackColor = Color.Red;
                            arr[46 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button46.BackColor = Color.Green;
                            arr[46 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button46.BackColor = Color.Yellow;
                            arr[46 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button46.BackColor = Color.White;
                            arr[46 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button46.BackColor = Color.DarkOrange;
                            arr[46 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[47]
        protected void button47_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button47.BackColor = Color.Blue;
                            arr[47 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button47.BackColor = Color.Red;
                            arr[47 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button47.BackColor = Color.Green;
                            arr[47 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button47.BackColor = Color.Yellow;
                            arr[47 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button47.BackColor = Color.White;
                            arr[47 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button47.BackColor = Color.DarkOrange;
                            arr[47 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[48]
        protected void button48_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button48.BackColor = Color.Blue;
                            arr[48 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button48.BackColor = Color.Red;
                            arr[48 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button48.BackColor = Color.Green;
                            arr[48 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button48.BackColor = Color.Yellow;
                            arr[48 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button48.BackColor = Color.White;
                            arr[48 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button48.BackColor = Color.DarkOrange;
                            arr[48 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[49-1]
        protected void button49_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button49.BackColor = Color.Blue;
                            arr[49 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button49.BackColor = Color.Red;
                            arr[49 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button49.BackColor = Color.Green;
                            arr[49 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button49.BackColor = Color.Yellow;
                            arr[49 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button49.BackColor = Color.White;
                            arr[49 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button49.BackColor = Color.DarkOrange;
                            arr[49 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[50-1]
        protected void button50_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button50.BackColor = Color.Blue;
                            arr[50 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button50.BackColor = Color.Red;
                            arr[50 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button50.BackColor = Color.Green;
                            arr[50 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button50.BackColor = Color.Yellow;
                            arr[50 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button50.BackColor = Color.White;
                            arr[50 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button50.BackColor = Color.DarkOrange;
                            arr[50 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[51-1]
        protected void button51_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button51.BackColor = Color.Blue;
                            arr[51 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button51.BackColor = Color.Red;
                            arr[51 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button51.BackColor = Color.Green;
                            arr[51 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button51.BackColor = Color.Yellow;
                            arr[51 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button51.BackColor = Color.White;
                            arr[51 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button51.BackColor = Color.DarkOrange;
                            arr[51 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[52-1]
        protected void button52_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button52.BackColor = Color.Blue;
                            arr[52 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button52.BackColor = Color.Red;
                            arr[52 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button52.BackColor = Color.Green;
                            arr[52 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button52.BackColor = Color.Yellow;
                            arr[52 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button52.BackColor = Color.White;
                            arr[52 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button52.BackColor = Color.DarkOrange;
                            arr[52 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[53-1]
        protected void button53_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button53.BackColor = Color.Blue;
                            arr[53 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button53.BackColor = Color.Red;
                            arr[53 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button53.BackColor = Color.Green;
                            arr[53 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button53.BackColor = Color.Yellow;
                            arr[53 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button53.BackColor = Color.White;
                            arr[53 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button53.BackColor = Color.DarkOrange;
                            arr[53 - 1] = 6;
                            break;
                        }
                }
            }
        }
        //arr[54-1]
        protected void button54_Click(object sender, EventArgs e)
        {
            if (allow == true)
            {
                switch (color)
                {
                    case 'b':
                        {
                            button54.BackColor = Color.Blue;
                            arr[54 - 1] = 1;
                            break;
                        }
                    case 'r':
                        {
                            button54.BackColor = Color.Red;
                            arr[54 - 1] = 2;
                            break;
                        }
                    case 'g':
                        {
                            button54.BackColor = Color.Green;
                            arr[54 - 1] = 3;
                            break;
                        }
                    case 'y':
                        {
                            button54.BackColor = Color.Yellow;
                            arr[54 - 1] = 4;
                            break;
                        }
                    case 'w':
                        {
                            button54.BackColor = Color.White;
                            arr[54 - 1] = 5;
                            break;
                        }
                    case 'o':
                        {
                            button54.BackColor = Color.DarkOrange;
                            arr[54 - 1] = 6;
                            break;
                        }
                }
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            reset();
            check(arr);
            MoveNumber = 0;
        }
        //Right Clockwise(RC)
        void RC()
        {
            //initializing a temperary array of 12 elements
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            temp[0] = arr[12 - 1];
            temp[1] = arr[15 - 1];
            temp[2] = arr[18 - 1];
            temp[3] = arr[28 - 1];
            temp[4] = arr[31 - 1];
            temp[5] = arr[34 - 1];
            temp[6] = arr[39 - 1];
            temp[7] = arr[42 - 1];
            temp[8] = arr[45 - 1];
            temp[9] = arr[48 - 1];
            temp[10] = arr[51 - 1];
            temp[11] = arr[54 - 1];

            arr[12 - 1] = temp[9];
            arr[15 - 1] = temp[10];
            arr[18 - 1] = temp[11];

            arr[39 - 1] = temp[0];
            arr[42 - 1] = temp[1];
            arr[45 - 1] = temp[2];

            arr[28 - 1] = temp[8];
            arr[31 - 1] = temp[7];
            arr[34 - 1] = temp[6];

            arr[54 - 1] = temp[3];
            arr[51 - 1] = temp[4];
            arr[48 - 1] = temp[5];
            //roting right side
            temp[0] = arr[19 - 1];
            temp[1] = arr[20 - 1];
            temp[2] = arr[21 - 1];
            temp[3] = arr[22 - 1];
            temp[4] = arr[23 - 1];
            temp[5] = arr[24 - 1];
            temp[6] = arr[25 - 1];
            temp[7] = arr[26 - 1];
            temp[8] = arr[27 - 1];
            arr[19 - 1] = temp[6];
            arr[20 - 1] = temp[3];
            arr[21 - 1] = temp[0];
            arr[22 - 1] = temp[7];
            arr[23 - 1] = temp[4];
            arr[24 - 1] = temp[1];
            arr[25 - 1] = temp[8];
            arr[26 - 1] = temp[5];
            arr[27 - 1] = temp[2];

            display(arr);
        }
        //Right Anti-Clockwise(RA)
        void RA()
        {
            //initializing a temperary array of 12 elements
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            temp[0] = arr[12 - 1];
            temp[1] = arr[15 - 1];
            temp[2] = arr[18 - 1];
            temp[3] = arr[28 - 1];
            temp[4] = arr[31 - 1];
            temp[5] = arr[34 - 1];
            temp[6] = arr[39 - 1];
            temp[7] = arr[42 - 1];
            temp[8] = arr[45 - 1];
            temp[9] = arr[48 - 1];
            temp[10] = arr[51 - 1];
            temp[11] = arr[54 - 1];

            arr[12 - 1] = temp[6];
            arr[15 - 1] = temp[7];
            arr[18 - 1] = temp[8];

            arr[39 - 1] = temp[5];
            arr[42 - 1] = temp[4];
            arr[45 - 1] = temp[3];

            arr[28 - 1] = temp[11];
            arr[31 - 1] = temp[10];
            arr[34 - 1] = temp[9];

            arr[54 - 1] = temp[2];
            arr[51 - 1] = temp[1];
            arr[48 - 1] = temp[0];
            //roting right side
            temp[0] = arr[19 - 1];
            temp[1] = arr[20 - 1];
            temp[2] = arr[21 - 1];
            temp[3] = arr[22 - 1];
            temp[4] = arr[23 - 1];
            temp[5] = arr[24 - 1];
            temp[6] = arr[25 - 1];
            temp[7] = arr[26 - 1];
            temp[8] = arr[27 - 1];
            arr[19 - 1] = temp[2];
            arr[20 - 1] = temp[5];
            arr[21 - 1] = temp[8];
            arr[22 - 1] = temp[1];
            arr[23 - 1] = temp[4];
            arr[24 - 1] = temp[7];
            arr[25 - 1] = temp[0];
            arr[26 - 1] = temp[3];
            arr[27 - 1] = temp[6];

            display(arr);
        }
        //left Clockwise(LC)
        void LC()
        {
            //initializing a temperary array of 12 elements
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            temp[0] = arr[10 - 1];
            temp[1] = arr[13 - 1];
            temp[2] = arr[16 - 1];
            temp[3] = arr[30 - 1];
            temp[4] = arr[33 - 1];
            temp[5] = arr[36 - 1];
            temp[6] = arr[37 - 1];
            temp[7] = arr[40 - 1];
            temp[8] = arr[43 - 1];
            temp[9] = arr[46 - 1];
            temp[10] = arr[49 - 1];
            temp[11] = arr[52 - 1];

            arr[37 - 1] = temp[0];
            arr[40 - 1] = temp[1];
            arr[43 - 1] = temp[2];

            arr[10 - 1] = temp[9];
            arr[13 - 1] = temp[10];
            arr[16 - 1] = temp[11];

            arr[30 - 1] = temp[8];
            arr[33 - 1] = temp[7];
            arr[36 - 1] = temp[6];

            arr[46 - 1] = temp[5];
            arr[49 - 1] = temp[4];
            arr[52 - 1] = temp[3];
            //roting right side
            temp[0] = arr[1 - 1];
            temp[1] = arr[2 - 1];
            temp[2] = arr[3 - 1];
            temp[3] = arr[4 - 1];
            temp[4] = arr[5 - 1];
            temp[5] = arr[6 - 1];
            temp[6] = arr[7 - 1];
            temp[7] = arr[8 - 1];
            temp[8] = arr[9 - 1];
            arr[1 - 1] = temp[2];
            arr[2 - 1] = temp[5];
            arr[3 - 1] = temp[8];
            arr[4 - 1] = temp[1];
            arr[5 - 1] = temp[4];
            arr[6 - 1] = temp[7];
            arr[7 - 1] = temp[0];
            arr[8 - 1] = temp[3];
            arr[9 - 1] = temp[6];
            display(arr);
        }
        //left Anti-Clockwise(LA)
        void LA()
        {
            //initializing a temperary array of 12 elements
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            temp[0] = arr[10 - 1];
            temp[1] = arr[13 - 1];
            temp[2] = arr[16 - 1];
            temp[3] = arr[30 - 1];
            temp[4] = arr[33 - 1];
            temp[5] = arr[36 - 1];
            temp[6] = arr[37 - 1];
            temp[7] = arr[40 - 1];
            temp[8] = arr[43 - 1];
            temp[9] = arr[46 - 1];
            temp[10] = arr[49 - 1];
            temp[11] = arr[52 - 1];

            arr[37 - 1] = temp[5];
            arr[40 - 1] = temp[4];
            arr[43 - 1] = temp[3];

            arr[10 - 1] = temp[6];
            arr[13 - 1] = temp[7];
            arr[16 - 1] = temp[8];

            arr[30 - 1] = temp[11];
            arr[33 - 1] = temp[10];
            arr[36 - 1] = temp[9];

            arr[46 - 1] = temp[0];
            arr[49 - 1] = temp[1];
            arr[52 - 1] = temp[2];
            //roting right side
            temp[0] = arr[1 - 1];
            temp[1] = arr[2 - 1];
            temp[2] = arr[3 - 1];
            temp[3] = arr[4 - 1];
            temp[4] = arr[5 - 1];
            temp[5] = arr[6 - 1];
            temp[6] = arr[7 - 1];
            temp[7] = arr[8 - 1];
            temp[8] = arr[9 - 1];
            arr[1 - 1] = temp[6];
            arr[2 - 1] = temp[3];
            arr[3 - 1] = temp[0];
            arr[4 - 1] = temp[7];
            arr[5 - 1] = temp[4];
            arr[6 - 1] = temp[1];
            arr[7 - 1] = temp[8];
            arr[8 - 1] = temp[5];
            arr[9 - 1] = temp[2];
            display(arr);
        }
        //up clockwise(UC)
        void UC()
        {
            //initializing a temperary array of 12 elements
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            temp[0] = arr[1 - 1];
            temp[1] = arr[2 - 1];
            temp[2] = arr[3 - 1];
            temp[3] = arr[10 - 1];
            temp[4] = arr[11 - 1];
            temp[5] = arr[12 - 1];
            temp[6] = arr[19 - 1];
            temp[7] = arr[20 - 1];
            temp[8] = arr[21 - 1];
            temp[9] = arr[28 - 1];
            temp[10] = arr[29 - 1];
            temp[11] = arr[30 - 1];

            arr[1 - 1] = temp[3];
            arr[2 - 1] = temp[4];
            arr[3 - 1] = temp[5];

            arr[10 - 1] = temp[6];
            arr[11 - 1] = temp[7];
            arr[12 - 1] = temp[8];

            arr[19 - 1] = temp[9];
            arr[20 - 1] = temp[10];
            arr[21 - 1] = temp[11];

            arr[28 - 1] = temp[0];
            arr[29 - 1] = temp[1];
            arr[30 - 1] = temp[2];
            //roting right side
            temp[0] = arr[37 - 1];
            temp[1] = arr[38 - 1];
            temp[2] = arr[39 - 1];
            temp[3] = arr[40 - 1];
            temp[4] = arr[41 - 1];
            temp[5] = arr[42 - 1];
            temp[6] = arr[43 - 1];
            temp[7] = arr[44 - 1];
            temp[8] = arr[45 - 1];
            arr[37 - 1] = temp[6];
            arr[38 - 1] = temp[3];
            arr[39 - 1] = temp[0];
            arr[40 - 1] = temp[7];
            arr[41 - 1] = temp[4];
            arr[42 - 1] = temp[1];
            arr[43 - 1] = temp[8];
            arr[44 - 1] = temp[5];
            arr[45 - 1] = temp[2];
            display(arr);
        }
        //up anti-clockwise(UA)
        void UA()
        {
            //initializing a temperary array of 12 elements
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            temp[0] = arr[1 - 1];
            temp[1] = arr[2 - 1];
            temp[2] = arr[3 - 1];
            temp[3] = arr[10 - 1];
            temp[4] = arr[11 - 1];
            temp[5] = arr[12 - 1];
            temp[6] = arr[19 - 1];
            temp[7] = arr[20 - 1];
            temp[8] = arr[21 - 1];
            temp[9] = arr[28 - 1];
            temp[10] = arr[29 - 1];
            temp[11] = arr[30 - 1];

            arr[1 - 1] = temp[9];
            arr[2 - 1] = temp[10];
            arr[3 - 1] = temp[11];

            arr[10 - 1] = temp[0];
            arr[11 - 1] = temp[1];
            arr[12 - 1] = temp[2];

            arr[19 - 1] = temp[3];
            arr[20 - 1] = temp[4];
            arr[21 - 1] = temp[5];

            arr[28 - 1] = temp[6];
            arr[29 - 1] = temp[7];
            arr[30 - 1] = temp[8];
            //roting right side
            temp[0] = arr[37 - 1];
            temp[1] = arr[38 - 1];
            temp[2] = arr[39 - 1];
            temp[3] = arr[40 - 1];
            temp[4] = arr[41 - 1];
            temp[5] = arr[42 - 1];
            temp[6] = arr[43 - 1];
            temp[7] = arr[44 - 1];
            temp[8] = arr[45 - 1];
            arr[37 - 1] = temp[2];
            arr[38 - 1] = temp[5];
            arr[39 - 1] = temp[8];
            arr[40 - 1] = temp[1];
            arr[41 - 1] = temp[4];
            arr[42 - 1] = temp[7];
            arr[43 - 1] = temp[0];
            arr[44 - 1] = temp[3];
            arr[45 - 1] = temp[6];
            display(arr);
        }
        //up clockwise(FC)
        void FC()
        {
            //initializing a temperary array of 12 elements
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            temp[0] = arr[3 - 1];
            temp[1] = arr[6 - 1];
            temp[2] = arr[9 - 1];
            temp[3] = arr[19 - 1];
            temp[4] = arr[22 - 1];
            temp[5] = arr[25 - 1];
            temp[6] = arr[43 - 1];
            temp[7] = arr[44 - 1];
            temp[8] = arr[45 - 1];
            temp[9] = arr[46 - 1];
            temp[10] = arr[47 - 1];
            temp[11] = arr[48 - 1];

            arr[3 - 1] = temp[9];
            arr[6 - 1] = temp[10];
            arr[9 - 1] = temp[11];

            arr[43 - 1] = temp[2];
            arr[44 - 1] = temp[1];
            arr[45 - 1] = temp[0];

            arr[19 - 1] = temp[6];
            arr[22 - 1] = temp[7];
            arr[25 - 1] = temp[8];

            arr[46 - 1] = temp[5];
            arr[47 - 1] = temp[4];
            arr[48 - 1] = temp[3];
            //roting right side
            temp[0] = arr[10 - 1];
            temp[1] = arr[11 - 1];
            temp[2] = arr[12 - 1];
            temp[3] = arr[13 - 1];
            temp[4] = arr[14 - 1];
            temp[5] = arr[15 - 1];
            temp[6] = arr[16 - 1];
            temp[7] = arr[17 - 1];
            temp[8] = arr[18 - 1];
            arr[10 - 1] = temp[6];
            arr[11 - 1] = temp[3];
            arr[12 - 1] = temp[0];
            arr[13 - 1] = temp[7];
            arr[14 - 1] = temp[4];
            arr[15 - 1] = temp[1];
            arr[16 - 1] = temp[8];
            arr[17 - 1] = temp[5];
            arr[18 - 1] = temp[2];
            display(arr);
        }
        //Front anti-clockwise(FA)
        void FA()
        {
            //initializing a temperary array of 12 elements
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            temp[0] = arr[3 - 1];
            temp[1] = arr[6 - 1];
            temp[2] = arr[9 - 1];
            temp[3] = arr[19 - 1];
            temp[4] = arr[22 - 1];
            temp[5] = arr[25 - 1];
            temp[6] = arr[43 - 1];
            temp[7] = arr[44 - 1];
            temp[8] = arr[45 - 1];
            temp[9] = arr[46 - 1];
            temp[10] = arr[47 - 1];
            temp[11] = arr[48 - 1];

            arr[3 - 1] = temp[8];
            arr[6 - 1] = temp[7];
            arr[9 - 1] = temp[6];

            arr[43 - 1] = temp[3];
            arr[44 - 1] = temp[4];
            arr[45 - 1] = temp[5];

            arr[19 - 1] = temp[11];
            arr[22 - 1] = temp[10];
            arr[25 - 1] = temp[9];

            arr[46 - 1] = temp[0];
            arr[47 - 1] = temp[1];
            arr[48 - 1] = temp[2];
            //roting right side
            temp[0] = arr[10 - 1];
            temp[1] = arr[11 - 1];
            temp[2] = arr[12 - 1];
            temp[3] = arr[13 - 1];
            temp[4] = arr[14 - 1];
            temp[5] = arr[15 - 1];
            temp[6] = arr[16 - 1];
            temp[7] = arr[17 - 1];
            temp[8] = arr[18 - 1];
            arr[10 - 1] = temp[2];
            arr[11 - 1] = temp[5];
            arr[12 - 1] = temp[8];
            arr[13 - 1] = temp[1];
            arr[14 - 1] = temp[4];
            arr[15 - 1] = temp[7];
            arr[16 - 1] = temp[0];
            arr[17 - 1] = temp[3];
            arr[18 - 1] = temp[6];
            display(arr);
        }
        //down colockwise(DC)
        void DC()
        {
            //initializing a temperary array of 12 elements
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            temp[0] = arr[7 - 1];
            temp[1] = arr[8 - 1];
            temp[2] = arr[9 - 1];
            temp[3] = arr[16 - 1];
            temp[4] = arr[17 - 1];
            temp[5] = arr[18 - 1];
            temp[6] = arr[25 - 1];
            temp[7] = arr[26 - 1];
            temp[8] = arr[27 - 1];
            temp[9] = arr[34 - 1];
            temp[10] = arr[35 - 1];
            temp[11] = arr[36 - 1];

            arr[7 - 1] = temp[3];
            arr[8 - 1] = temp[4];
            arr[9 - 1] = temp[5];

            arr[16 - 1] = temp[6];
            arr[17 - 1] = temp[7];
            arr[18 - 1] = temp[8];

            arr[25 - 1] = temp[9];
            arr[26 - 1] = temp[10];
            arr[27 - 1] = temp[11];

            arr[34 - 1] = temp[0];
            arr[35 - 1] = temp[1];
            arr[36 - 1] = temp[2];
            //roting right side
            temp[0] = arr[46 - 1];
            temp[1] = arr[47 - 1];
            temp[2] = arr[48 - 1];
            temp[3] = arr[49 - 1];
            temp[4] = arr[50 - 1];
            temp[5] = arr[51 - 1];
            temp[6] = arr[52 - 1];
            temp[7] = arr[53 - 1];
            temp[8] = arr[54 - 1];
            arr[46 - 1] = temp[2];
            arr[47 - 1] = temp[5];
            arr[48 - 1] = temp[8];
            arr[49 - 1] = temp[1];
            arr[50 - 1] = temp[4];
            arr[51 - 1] = temp[7];
            arr[52 - 1] = temp[0];
            arr[53 - 1] = temp[3];
            arr[54 - 1] = temp[6];
            display(arr);
        }
        //down anti-clockwise(DA)
        void DA()
        {
            //initializing a temperary array of 12 elements
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            temp[0] = arr[7 - 1];
            temp[1] = arr[8 - 1];
            temp[2] = arr[9 - 1];
            temp[3] = arr[16 - 1];
            temp[4] = arr[17 - 1];
            temp[5] = arr[18 - 1];
            temp[6] = arr[25 - 1];
            temp[7] = arr[26 - 1];
            temp[8] = arr[27 - 1];
            temp[9] = arr[34 - 1];
            temp[10] = arr[35 - 1];
            temp[11] = arr[36 - 1];

            arr[7 - 1] = temp[9];
            arr[8 - 1] = temp[10];
            arr[9 - 1] = temp[11];

            arr[16 - 1] = temp[0];
            arr[17 - 1] = temp[1];
            arr[18 - 1] = temp[2];

            arr[25 - 1] = temp[3];
            arr[26 - 1] = temp[4];
            arr[27 - 1] = temp[5];

            arr[34 - 1] = temp[6];
            arr[35 - 1] = temp[7];
            arr[36 - 1] = temp[8];
            //roting right side
            temp[0] = arr[46 - 1];
            temp[1] = arr[47 - 1];
            temp[2] = arr[48 - 1];
            temp[3] = arr[49 - 1];
            temp[4] = arr[50 - 1];
            temp[5] = arr[51 - 1];
            temp[6] = arr[52 - 1];
            temp[7] = arr[53 - 1];
            temp[8] = arr[54 - 1];
            arr[46 - 1] = temp[6];
            arr[47 - 1] = temp[3];
            arr[48 - 1] = temp[0];
            arr[49 - 1] = temp[7];
            arr[50 - 1] = temp[4];
            arr[51 - 1] = temp[1];
            arr[52 - 1] = temp[8];
            arr[53 - 1] = temp[5];
            arr[54 - 1] = temp[2];
            display(arr);
        }
        //Back clockwise(BC)
        void BC()
        {
            //initializing a temperary array of 12 elements
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            temp[0] = arr[1 - 1];
            temp[1] = arr[4 - 1];
            temp[2] = arr[7 - 1];
            temp[3] = arr[21 - 1];
            temp[4] = arr[24 - 1];
            temp[5] = arr[27 - 1];
            temp[6] = arr[37 - 1];
            temp[7] = arr[38 - 1];
            temp[8] = arr[39 - 1];
            temp[9] = arr[52 - 1];
            temp[10] = arr[53 - 1];
            temp[11] = arr[54 - 1];

            arr[1 - 1] = temp[9];
            arr[4 - 1] = temp[10];
            arr[7 - 1] = temp[11];

            arr[21 - 1] = temp[6];
            arr[24 - 1] = temp[7];
            arr[27 - 1] = temp[8];

            arr[37 - 1] = temp[2];
            arr[38 - 1] = temp[1];
            arr[39 - 1] = temp[0];

            arr[52 - 1] = temp[5];
            arr[53 - 1] = temp[4];
            arr[54 - 1] = temp[3];
            //roting right side
            temp[0] = arr[28 - 1];
            temp[1] = arr[29 - 1];
            temp[2] = arr[30 - 1];
            temp[3] = arr[31 - 1];
            temp[4] = arr[32 - 1];
            temp[5] = arr[33 - 1];
            temp[6] = arr[34 - 1];
            temp[7] = arr[35 - 1];
            temp[8] = arr[36 - 1];
            arr[28 - 1] = temp[2];
            arr[29 - 1] = temp[5];
            arr[30 - 1] = temp[8];
            arr[31 - 1] = temp[1];
            arr[32 - 1] = temp[4];
            arr[33 - 1] = temp[7];
            arr[34 - 1] = temp[0];
            arr[35 - 1] = temp[3];
            arr[36 - 1] = temp[6];
            display(arr);
        }
        //Back anti-clockwise(BA)
        void BA()
        {
            //initializing a temperary array of 12 elements
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            temp[0] = arr[1 - 1];
            temp[1] = arr[4 - 1];
            temp[2] = arr[7 - 1];
            temp[3] = arr[21 - 1];
            temp[4] = arr[24 - 1];
            temp[5] = arr[27 - 1];
            temp[6] = arr[37 - 1];
            temp[7] = arr[38 - 1];
            temp[8] = arr[39 - 1];
            temp[9] = arr[52 - 1];
            temp[10] = arr[53 - 1];
            temp[11] = arr[54 - 1];

            arr[1 - 1] = temp[8];
            arr[4 - 1] = temp[7];
            arr[7 - 1] = temp[6];

            arr[21 - 1] = temp[11];
            arr[24 - 1] = temp[10];
            arr[27 - 1] = temp[9];

            arr[37 - 1] = temp[3];
            arr[38 - 1] = temp[4];
            arr[39 - 1] = temp[5];

            arr[52 - 1] = temp[0];
            arr[53 - 1] = temp[1];
            arr[54 - 1] = temp[2];
            //roting right side
            temp[0] = arr[28 - 1];
            temp[1] = arr[29 - 1];
            temp[2] = arr[30 - 1];
            temp[3] = arr[31 - 1];
            temp[4] = arr[32 - 1];
            temp[5] = arr[33 - 1];
            temp[6] = arr[34 - 1];
            temp[7] = arr[35 - 1];
            temp[8] = arr[36 - 1];
            arr[28 - 1] = temp[6];
            arr[29 - 1] = temp[3];
            arr[30 - 1] = temp[0];
            arr[31 - 1] = temp[7];
            arr[32 - 1] = temp[4];
            arr[33 - 1] = temp[1];
            arr[34 - 1] = temp[8];
            arr[35 - 1] = temp[5];
            arr[36 - 1] = temp[2];
            display(arr);
        }
        //middle clockwise(MC)
        void MC()
        {
            //initializing a temperary array of 12 elements
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            temp[0] = arr[11 - 1];
            temp[1] = arr[14 - 1];
            temp[2] = arr[17 - 1];
            temp[3] = arr[29 - 1];
            temp[4] = arr[32 - 1];
            temp[5] = arr[35 - 1];
            temp[6] = arr[38 - 1];
            temp[7] = arr[41 - 1];
            temp[8] = arr[44 - 1];
            temp[9] = arr[47 - 1];
            temp[10] = arr[50 - 1];
            temp[11] = arr[53 - 1];

            arr[11 - 1] = temp[9];
            arr[14 - 1] = temp[10];
            arr[17 - 1] = temp[11];

            arr[29 - 1] = temp[8];
            arr[32 - 1] = temp[7];
            arr[35 - 1] = temp[6];

            arr[38 - 1] = temp[0];
            arr[41 - 1] = temp[1];
            arr[44 - 1] = temp[2];

            arr[47 - 1] = temp[5];
            arr[50 - 1] = temp[4];
            arr[53 - 1] = temp[3];
            display(arr);
        }
        //middle anti-clockwise(MA)
        void MA()
        {
            //initializing a temperary array of 12 elements
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            temp[0] = arr[11 - 1];
            temp[1] = arr[14 - 1];
            temp[2] = arr[17 - 1];
            temp[3] = arr[29 - 1];
            temp[4] = arr[32 - 1];
            temp[5] = arr[35 - 1];
            temp[6] = arr[38 - 1];
            temp[7] = arr[41 - 1];
            temp[8] = arr[44 - 1];
            temp[9] = arr[47 - 1];
            temp[10] = arr[50 - 1];
            temp[11] = arr[53 - 1];

            arr[11 - 1] = temp[6];
            arr[14 - 1] = temp[7];
            arr[17 - 1] = temp[8];

            arr[29 - 1] = temp[11];
            arr[32 - 1] = temp[10];
            arr[35 - 1] = temp[9];

            arr[38 - 1] = temp[5];
            arr[41 - 1] = temp[4];
            arr[44 - 1] = temp[3];

            arr[47 - 1] = temp[0];
            arr[50 - 1] = temp[1];
            arr[53 - 1] = temp[2];
            display(arr);
        }
        //equator clockwise(EC)
        void EC()
        {
            //initializing a temperary array of 12 elements
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            temp[0] = arr[4 - 1];
            temp[1] = arr[5 - 1];
            temp[2] = arr[6 - 1];
            temp[3] = arr[13 - 1];
            temp[4] = arr[14 - 1];
            temp[5] = arr[15 - 1];
            temp[6] = arr[22 - 1];
            temp[7] = arr[23 - 1];
            temp[8] = arr[24 - 1];
            temp[9] = arr[31 - 1];
            temp[10] = arr[32 - 1];
            temp[11] = arr[33 - 1];

            arr[4 - 1] = temp[3];
            arr[5 - 1] = temp[4];
            arr[6 - 1] = temp[5];

            arr[13 - 1] = temp[6];
            arr[14 - 1] = temp[7];
            arr[15 - 1] = temp[8];

            arr[22 - 1] = temp[9];
            arr[23 - 1] = temp[10];
            arr[24 - 1] = temp[11];

            arr[31 - 1] = temp[0];
            arr[32 - 1] = temp[1];
            arr[33 - 1] = temp[2];
            display(arr);
        }
        //equator anti-clockwise(EA)
        void EA()
        {
            //initializing a temperary array of 12 elements
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            temp[0] = arr[4 - 1];
            temp[1] = arr[5 - 1];
            temp[2] = arr[6 - 1];
            temp[3] = arr[13 - 1];
            temp[4] = arr[14 - 1];
            temp[5] = arr[15 - 1];
            temp[6] = arr[22 - 1];
            temp[7] = arr[23 - 1];
            temp[8] = arr[24 - 1];
            temp[9] = arr[31 - 1];
            temp[10] = arr[32 - 1];
            temp[11] = arr[33 - 1];

            arr[4 - 1] = temp[9];
            arr[5 - 1] = temp[10];
            arr[6 - 1] = temp[11];

            arr[13 - 1] = temp[0];
            arr[14 - 1] = temp[1];
            arr[15 - 1] = temp[2];

            arr[22 - 1] = temp[3];
            arr[23 - 1] = temp[4];
            arr[24 - 1] = temp[5];

            arr[31 - 1] = temp[6];
            arr[32 - 1] = temp[7];
            arr[33 - 1] = temp[8];
            display(arr);
        }
        //standard clockwise(SC)
        void SC()
        {
            //initializing a temperary array of 12 elements
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            temp[0] = arr[2 - 1];
            temp[1] = arr[5 - 1];
            temp[2] = arr[8 - 1];
            temp[3] = arr[20 - 1];
            temp[4] = arr[23 - 1];
            temp[5] = arr[26 - 1];
            temp[6] = arr[40 - 1];
            temp[7] = arr[41 - 1];
            temp[8] = arr[42 - 1];
            temp[9] = arr[49 - 1];
            temp[10] = arr[50 - 1];
            temp[11] = arr[51 - 1];

            arr[2 - 1] = temp[9];
            arr[5 - 1] = temp[10];
            arr[8 - 1] = temp[11];

            arr[20 - 1] = temp[6];
            arr[23 - 1] = temp[7];
            arr[26 - 1] = temp[8];

            arr[40 - 1] = temp[2];
            arr[41 - 1] = temp[1];
            arr[42 - 1] = temp[0];

            arr[49 - 1] = temp[5];
            arr[50 - 1] = temp[4];
            arr[51 - 1] = temp[3];
            display(arr);
        }
        //standard anti-clockwise(SA)
        void SA()
        {
            //initializing a temperary array of 12 elements
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            temp[0] = arr[2 - 1];
            temp[1] = arr[5 - 1];
            temp[2] = arr[8 - 1];
            temp[3] = arr[20 - 1];
            temp[4] = arr[23 - 1];
            temp[5] = arr[26 - 1];
            temp[6] = arr[40 - 1];
            temp[7] = arr[41 - 1];
            temp[8] = arr[42 - 1];
            temp[9] = arr[49 - 1];
            temp[10] = arr[50 - 1];
            temp[11] = arr[51 - 1];

            arr[2 - 1] = temp[8];
            arr[5 - 1] = temp[7];
            arr[8 - 1] = temp[6];

            arr[20 - 1] = temp[11];
            arr[23 - 1] = temp[10];
            arr[26 - 1] = temp[9];

            arr[40 - 1] = temp[3];
            arr[41 - 1] = temp[4];
            arr[42 - 1] = temp[5];

            arr[49 - 1] = temp[0];
            arr[50 - 1] = temp[1];
            arr[51 - 1] = temp[2];
            display(arr);
        }
        //All Right
        void AR()
        {
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            temp[0] = arr[1 - 1];
            temp[1] = arr[2 - 1];
            temp[2] = arr[3 - 1];
            temp[3] = arr[10 - 1];
            temp[4] = arr[11 - 1];
            temp[5] = arr[12 - 1];
            temp[6] = arr[19 - 1];
            temp[7] = arr[20 - 1];
            temp[8] = arr[21 - 1];
            temp[9] = arr[28 - 1];
            temp[10] = arr[29 - 1];
            temp[11] = arr[30 - 1];

            arr[1 - 1] = temp[9];
            arr[2 - 1] = temp[10];
            arr[3 - 1] = temp[11];

            arr[10 - 1] = temp[0];
            arr[11 - 1] = temp[1];
            arr[12 - 1] = temp[2];

            arr[19 - 1] = temp[3];
            arr[20 - 1] = temp[4];
            arr[21 - 1] = temp[5];

            arr[28 - 1] = temp[6];
            arr[29 - 1] = temp[7];
            arr[30 - 1] = temp[8];

            temp[0] = arr[37 - 1];
            temp[1] = arr[38 - 1];
            temp[2] = arr[39 - 1];
            temp[3] = arr[40 - 1];
            temp[4] = arr[41 - 1];
            temp[5] = arr[42 - 1];
            temp[6] = arr[43 - 1];
            temp[7] = arr[44 - 1];
            temp[8] = arr[45 - 1];
            arr[37 - 1] = temp[2];
            arr[38 - 1] = temp[5];
            arr[39 - 1] = temp[8];
            arr[40 - 1] = temp[1];
            arr[41 - 1] = temp[4];
            arr[42 - 1] = temp[7];
            arr[43 - 1] = temp[0];
            arr[44 - 1] = temp[3];
            arr[45 - 1] = temp[6];

            //Moving middle layer
            temp[0] = arr[4 - 1];
            temp[1] = arr[5 - 1];
            temp[2] = arr[6 - 1];
            temp[3] = arr[13 - 1];
            temp[4] = arr[14 - 1];
            temp[5] = arr[15 - 1];
            temp[6] = arr[22 - 1];
            temp[7] = arr[23 - 1];
            temp[8] = arr[24 - 1];
            temp[9] = arr[31 - 1];
            temp[10] = arr[32 - 1];
            temp[11] = arr[33 - 1];

            arr[4 - 1] = temp[9];
            arr[5 - 1] = temp[10];
            arr[6 - 1] = temp[11];

            arr[13 - 1] = temp[0];
            arr[14 - 1] = temp[1];
            arr[15 - 1] = temp[2];

            arr[22 - 1] = temp[3];
            arr[23 - 1] = temp[4];
            arr[24 - 1] = temp[5];

            arr[31 - 1] = temp[6];
            arr[32 - 1] = temp[7];
            arr[33 - 1] = temp[8];


            temp[0] = arr[7 - 1];
            temp[1] = arr[8 - 1];
            temp[2] = arr[9 - 1];
            temp[3] = arr[16 - 1];
            temp[4] = arr[17 - 1];
            temp[5] = arr[18 - 1];
            temp[6] = arr[25 - 1];
            temp[7] = arr[26 - 1];
            temp[8] = arr[27 - 1];
            temp[9] = arr[34 - 1];
            temp[10] = arr[35 - 1];
            temp[11] = arr[36 - 1];

            arr[7 - 1] = temp[9];
            arr[8 - 1] = temp[10];
            arr[9 - 1] = temp[11];

            arr[16 - 1] = temp[0];
            arr[17 - 1] = temp[1];
            arr[18 - 1] = temp[2];

            arr[25 - 1] = temp[3];
            arr[26 - 1] = temp[4];
            arr[27 - 1] = temp[5];

            arr[34 - 1] = temp[6];
            arr[35 - 1] = temp[7];
            arr[36 - 1] = temp[8];
            //roting right side
            temp[0] = arr[46 - 1];
            temp[1] = arr[47 - 1];
            temp[2] = arr[48 - 1];
            temp[3] = arr[49 - 1];
            temp[4] = arr[50 - 1];
            temp[5] = arr[51 - 1];
            temp[6] = arr[52 - 1];
            temp[7] = arr[53 - 1];
            temp[8] = arr[54 - 1];
            arr[46 - 1] = temp[6];
            arr[47 - 1] = temp[3];
            arr[48 - 1] = temp[0];
            arr[49 - 1] = temp[7];
            arr[50 - 1] = temp[4];
            arr[51 - 1] = temp[1];
            arr[52 - 1] = temp[8];
            arr[53 - 1] = temp[5];
            arr[54 - 1] = temp[2];

            display(arr);
        }
        //All Left
        void AL()
        {
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            temp[0] = arr[1 - 1];
            temp[1] = arr[2 - 1];
            temp[2] = arr[3 - 1];
            temp[3] = arr[10 - 1];
            temp[4] = arr[11 - 1];
            temp[5] = arr[12 - 1];
            temp[6] = arr[19 - 1];
            temp[7] = arr[20 - 1];
            temp[8] = arr[21 - 1];
            temp[9] = arr[28 - 1];
            temp[10] = arr[29 - 1];
            temp[11] = arr[30 - 1];

            arr[1 - 1] = temp[3];
            arr[2 - 1] = temp[4];
            arr[3 - 1] = temp[5];

            arr[10 - 1] = temp[6];
            arr[11 - 1] = temp[7];
            arr[12 - 1] = temp[8];

            arr[19 - 1] = temp[9];
            arr[20 - 1] = temp[10];
            arr[21 - 1] = temp[11];

            arr[28 - 1] = temp[0];
            arr[29 - 1] = temp[1];
            arr[30 - 1] = temp[2];
            //roting right side
            temp[0] = arr[37 - 1];
            temp[1] = arr[38 - 1];
            temp[2] = arr[39 - 1];
            temp[3] = arr[40 - 1];
            temp[4] = arr[41 - 1];
            temp[5] = arr[42 - 1];
            temp[6] = arr[43 - 1];
            temp[7] = arr[44 - 1];
            temp[8] = arr[45 - 1];
            arr[37 - 1] = temp[6];
            arr[38 - 1] = temp[3];
            arr[39 - 1] = temp[0];
            arr[40 - 1] = temp[7];
            arr[41 - 1] = temp[4];
            arr[42 - 1] = temp[1];
            arr[43 - 1] = temp[8];
            arr[44 - 1] = temp[5];
            arr[45 - 1] = temp[2];


            //Movving middle layer
            temp[0] = arr[4 - 1];
            temp[1] = arr[5 - 1];
            temp[2] = arr[6 - 1];
            temp[3] = arr[13 - 1];
            temp[4] = arr[14 - 1];
            temp[5] = arr[15 - 1];
            temp[6] = arr[22 - 1];
            temp[7] = arr[23 - 1];
            temp[8] = arr[24 - 1];
            temp[9] = arr[31 - 1];
            temp[10] = arr[32 - 1];
            temp[11] = arr[33 - 1];

            arr[4 - 1] = temp[3];
            arr[5 - 1] = temp[4];
            arr[6 - 1] = temp[5];

            arr[13 - 1] = temp[6];
            arr[14 - 1] = temp[7];
            arr[15 - 1] = temp[8];

            arr[22 - 1] = temp[9];
            arr[23 - 1] = temp[10];
            arr[24 - 1] = temp[11];

            arr[31 - 1] = temp[0];
            arr[32 - 1] = temp[1];
            arr[33 - 1] = temp[2];



            temp[0] = arr[7 - 1];
            temp[1] = arr[8 - 1];
            temp[2] = arr[9 - 1];
            temp[3] = arr[16 - 1];
            temp[4] = arr[17 - 1];
            temp[5] = arr[18 - 1];
            temp[6] = arr[25 - 1];
            temp[7] = arr[26 - 1];
            temp[8] = arr[27 - 1];
            temp[9] = arr[34 - 1];
            temp[10] = arr[35 - 1];
            temp[11] = arr[36 - 1];

            arr[7 - 1] = temp[3];
            arr[8 - 1] = temp[4];
            arr[9 - 1] = temp[5];

            arr[16 - 1] = temp[6];
            arr[17 - 1] = temp[7];
            arr[18 - 1] = temp[8];

            arr[25 - 1] = temp[9];
            arr[26 - 1] = temp[10];
            arr[27 - 1] = temp[11];

            arr[34 - 1] = temp[0];
            arr[35 - 1] = temp[1];
            arr[36 - 1] = temp[2];
            //roting right side
            temp[0] = arr[46 - 1];
            temp[1] = arr[47 - 1];
            temp[2] = arr[48 - 1];
            temp[3] = arr[49 - 1];
            temp[4] = arr[50 - 1];
            temp[5] = arr[51 - 1];
            temp[6] = arr[52 - 1];
            temp[7] = arr[53 - 1];
            temp[8] = arr[54 - 1];
            arr[46 - 1] = temp[2];
            arr[47 - 1] = temp[5];
            arr[48 - 1] = temp[8];
            arr[49 - 1] = temp[1];
            arr[50 - 1] = temp[4];
            arr[51 - 1] = temp[7];
            arr[52 - 1] = temp[0];
            arr[53 - 1] = temp[3];
            arr[54 - 1] = temp[6];

            display(arr);
        }
        //All Up
        void AU()
        {
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            temp[0] = arr[10 - 1];
            temp[1] = arr[13 - 1];
            temp[2] = arr[16 - 1];
            temp[3] = arr[30 - 1];
            temp[4] = arr[33 - 1];
            temp[5] = arr[36 - 1];
            temp[6] = arr[37 - 1];
            temp[7] = arr[40 - 1];
            temp[8] = arr[43 - 1];
            temp[9] = arr[46 - 1];
            temp[10] = arr[49 - 1];
            temp[11] = arr[52 - 1];

            arr[37 - 1] = temp[0];
            arr[40 - 1] = temp[1];
            arr[43 - 1] = temp[2];

            arr[10 - 1] = temp[9];
            arr[13 - 1] = temp[10];
            arr[16 - 1] = temp[11];

            arr[30 - 1] = temp[8];
            arr[33 - 1] = temp[7];
            arr[36 - 1] = temp[6];

            arr[46 - 1] = temp[5];
            arr[49 - 1] = temp[4];
            arr[52 - 1] = temp[3];
            //roting right side
            temp[0] = arr[1 - 1];
            temp[1] = arr[2 - 1];
            temp[2] = arr[3 - 1];
            temp[3] = arr[4 - 1];
            temp[4] = arr[5 - 1];
            temp[5] = arr[6 - 1];
            temp[6] = arr[7 - 1];
            temp[7] = arr[8 - 1];
            temp[8] = arr[9 - 1];
            arr[1 - 1] = temp[2];
            arr[2 - 1] = temp[5];
            arr[3 - 1] = temp[8];
            arr[4 - 1] = temp[1];
            arr[5 - 1] = temp[4];
            arr[6 - 1] = temp[7];
            arr[7 - 1] = temp[0];
            arr[8 - 1] = temp[3];
            arr[9 - 1] = temp[6];


            temp[0] = arr[11 - 1];
            temp[1] = arr[14 - 1];
            temp[2] = arr[17 - 1];
            temp[3] = arr[29 - 1];
            temp[4] = arr[32 - 1];
            temp[5] = arr[35 - 1];
            temp[6] = arr[38 - 1];
            temp[7] = arr[41 - 1];
            temp[8] = arr[44 - 1];
            temp[9] = arr[47 - 1];
            temp[10] = arr[50 - 1];
            temp[11] = arr[53 - 1];

            arr[11 - 1] = temp[9];
            arr[14 - 1] = temp[10];
            arr[17 - 1] = temp[11];

            arr[29 - 1] = temp[8];
            arr[32 - 1] = temp[7];
            arr[35 - 1] = temp[6];

            arr[38 - 1] = temp[0];
            arr[41 - 1] = temp[1];
            arr[44 - 1] = temp[2];

            arr[47 - 1] = temp[5];
            arr[50 - 1] = temp[4];
            arr[53 - 1] = temp[3];

            temp[0] = arr[12 - 1];
            temp[1] = arr[15 - 1];
            temp[2] = arr[18 - 1];
            temp[3] = arr[28 - 1];
            temp[4] = arr[31 - 1];
            temp[5] = arr[34 - 1];
            temp[6] = arr[39 - 1];
            temp[7] = arr[42 - 1];
            temp[8] = arr[45 - 1];
            temp[9] = arr[48 - 1];
            temp[10] = arr[51 - 1];
            temp[11] = arr[54 - 1];

            arr[12 - 1] = temp[9];
            arr[15 - 1] = temp[10];
            arr[18 - 1] = temp[11];

            arr[39 - 1] = temp[0];
            arr[42 - 1] = temp[1];
            arr[45 - 1] = temp[2];

            arr[28 - 1] = temp[8];
            arr[31 - 1] = temp[7];
            arr[34 - 1] = temp[6];

            arr[54 - 1] = temp[3];
            arr[51 - 1] = temp[4];
            arr[48 - 1] = temp[5];
            //roting right side
            temp[0] = arr[19 - 1];
            temp[1] = arr[20 - 1];
            temp[2] = arr[21 - 1];
            temp[3] = arr[22 - 1];
            temp[4] = arr[23 - 1];
            temp[5] = arr[24 - 1];
            temp[6] = arr[25 - 1];
            temp[7] = arr[26 - 1];
            temp[8] = arr[27 - 1];
            arr[19 - 1] = temp[6];
            arr[20 - 1] = temp[3];
            arr[21 - 1] = temp[0];
            arr[22 - 1] = temp[7];
            arr[23 - 1] = temp[4];
            arr[24 - 1] = temp[1];
            arr[25 - 1] = temp[8];
            arr[26 - 1] = temp[5];
            arr[27 - 1] = temp[2];
            display(arr);
        }
        //All Down
        void AD()
        {
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            temp[0] = arr[10 - 1];
            temp[1] = arr[13 - 1];
            temp[2] = arr[16 - 1];
            temp[3] = arr[30 - 1];
            temp[4] = arr[33 - 1];
            temp[5] = arr[36 - 1];
            temp[6] = arr[37 - 1];
            temp[7] = arr[40 - 1];
            temp[8] = arr[43 - 1];
            temp[9] = arr[46 - 1];
            temp[10] = arr[49 - 1];
            temp[11] = arr[52 - 1];

            arr[37 - 1] = temp[5];
            arr[40 - 1] = temp[4];
            arr[43 - 1] = temp[3];

            arr[10 - 1] = temp[6];
            arr[13 - 1] = temp[7];
            arr[16 - 1] = temp[8];

            arr[30 - 1] = temp[11];
            arr[33 - 1] = temp[10];
            arr[36 - 1] = temp[9];

            arr[46 - 1] = temp[0];
            arr[49 - 1] = temp[1];
            arr[52 - 1] = temp[2];
            //roting right side
            temp[0] = arr[1 - 1];
            temp[1] = arr[2 - 1];
            temp[2] = arr[3 - 1];
            temp[3] = arr[4 - 1];
            temp[4] = arr[5 - 1];
            temp[5] = arr[6 - 1];
            temp[6] = arr[7 - 1];
            temp[7] = arr[8 - 1];
            temp[8] = arr[9 - 1];
            arr[1 - 1] = temp[6];
            arr[2 - 1] = temp[3];
            arr[3 - 1] = temp[0];
            arr[4 - 1] = temp[7];
            arr[5 - 1] = temp[4];
            arr[6 - 1] = temp[1];
            arr[7 - 1] = temp[8];
            arr[8 - 1] = temp[5];
            arr[9 - 1] = temp[2];


            temp[0] = arr[11 - 1];
            temp[1] = arr[14 - 1];
            temp[2] = arr[17 - 1];
            temp[3] = arr[29 - 1];
            temp[4] = arr[32 - 1];
            temp[5] = arr[35 - 1];
            temp[6] = arr[38 - 1];
            temp[7] = arr[41 - 1];
            temp[8] = arr[44 - 1];
            temp[9] = arr[47 - 1];
            temp[10] = arr[50 - 1];
            temp[11] = arr[53 - 1];

            arr[11 - 1] = temp[6];
            arr[14 - 1] = temp[7];
            arr[17 - 1] = temp[8];

            arr[29 - 1] = temp[11];
            arr[32 - 1] = temp[10];
            arr[35 - 1] = temp[9];

            arr[38 - 1] = temp[5];
            arr[41 - 1] = temp[4];
            arr[44 - 1] = temp[3];

            arr[47 - 1] = temp[0];
            arr[50 - 1] = temp[1];
            arr[53 - 1] = temp[2];


            temp[0] = arr[12 - 1];
            temp[1] = arr[15 - 1];
            temp[2] = arr[18 - 1];
            temp[3] = arr[28 - 1];
            temp[4] = arr[31 - 1];
            temp[5] = arr[34 - 1];
            temp[6] = arr[39 - 1];
            temp[7] = arr[42 - 1];
            temp[8] = arr[45 - 1];
            temp[9] = arr[48 - 1];
            temp[10] = arr[51 - 1];
            temp[11] = arr[54 - 1];

            arr[12 - 1] = temp[6];
            arr[15 - 1] = temp[7];
            arr[18 - 1] = temp[8];

            arr[39 - 1] = temp[5];
            arr[42 - 1] = temp[4];
            arr[45 - 1] = temp[3];

            arr[28 - 1] = temp[11];
            arr[31 - 1] = temp[10];
            arr[34 - 1] = temp[9];

            arr[54 - 1] = temp[2];
            arr[51 - 1] = temp[1];
            arr[48 - 1] = temp[0];
            //roting right side
            temp[0] = arr[19 - 1];
            temp[1] = arr[20 - 1];
            temp[2] = arr[21 - 1];
            temp[3] = arr[22 - 1];
            temp[4] = arr[23 - 1];
            temp[5] = arr[24 - 1];
            temp[6] = arr[25 - 1];
            temp[7] = arr[26 - 1];
            temp[8] = arr[27 - 1];
            arr[19 - 1] = temp[2];
            arr[20 - 1] = temp[5];
            arr[21 - 1] = temp[8];
            arr[22 - 1] = temp[1];
            arr[23 - 1] = temp[4];
            arr[24 - 1] = temp[7];
            arr[25 - 1] = temp[0];
            arr[26 - 1] = temp[3];
            arr[27 - 1] = temp[6];
            display(arr);
        }
        void DisplayMoves(string List_of_Moves)
        {
            listView1.Items.Clear();
            if (List_of_Moves != null)
            {
                //listView1.Items(1)
                for (int i = 0; i < List_of_Moves.Length; i++)
                {
                    if (List_of_Moves[i] == 'a')
                        listView1.Items.Add("Right Clockwise");
                    else if (List_of_Moves[i] == 'b')
                        listView1.Items.Add("Right Anti-Clockwise");
                    else if (List_of_Moves[i] == 'c')
                        listView1.Items.Add("Left Clockwise");
                    else if (List_of_Moves[i] == 'd')
                        listView1.Items.Add("Left Anti-Clockwise");
                    else if (List_of_Moves[i] == 'e')
                        listView1.Items.Add("Up Clockwise");
                    else if (List_of_Moves[i] == 'f')
                        listView1.Items.Add("Up Anti-Clockwise");
                    else if (List_of_Moves[i] == 'g')
                        listView1.Items.Add("Down Clockwise");
                    else if (List_of_Moves[i] == 'h')
                        listView1.Items.Add("Down Anti-Clockwise");
                    else if (List_of_Moves[i] == 'i')
                        listView1.Items.Add("Front Clockwise");
                    else if (List_of_Moves[i] == 'j')
                        listView1.Items.Add("Front Anti-Clockwise");
                    else if (List_of_Moves[i] == 'k')
                        listView1.Items.Add("Back Clockwise");
                    else if (List_of_Moves[i] == 'l')
                        listView1.Items.Add("Back Anti-Clockwise");
                    else if (List_of_Moves[i] == 'm')
                        listView1.Items.Add("Middle Clockwise");
                    else if (List_of_Moves[i] == 'n')
                        listView1.Items.Add("Middle Anti-Clockwise");
                    else if (List_of_Moves[i] == 'o')
                        listView1.Items.Add("Equator Clockwise");
                    else if (List_of_Moves[i] == 'p')
                        listView1.Items.Add("Equator Anti-Clockwise");
                    else if (List_of_Moves[i] == 'q')
                        listView1.Items.Add("Standing Clockwise");
                    else if (List_of_Moves[i] == 'r')
                        listView1.Items.Add("Standing Anti-Clockwise");
                    else if (List_of_Moves[i] == 's')
                        listView1.Items.Add("All Right");
                    else if (List_of_Moves[i] == 't')
                        listView1.Items.Add("All Left");
                    else if (List_of_Moves[i] == 'u')
                        listView1.Items.Add("All Up");
                    else if (List_of_Moves[i] == 'v')
                        listView1.Items.Add("All Down");
                }
            }
        }
        void ReadOutput()
        {
            FileStream fs = new FileStream(AddressToRead, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            DisplayMoves(str);
        }
        void WriteArray()
        {
            //convert int array to string
            String.Join("", new List<int>(arr).ConvertAll(i => i.ToString()).ToArray());
            string str = string.Join("", arr);
            //Writing to the file
            System.IO.StreamWriter objWriter;
            objWriter = new System.IO.StreamWriter(AddressToWrite);
            objWriter.Write(str);
            objWriter.Close();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Next Button
        private void button63_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("output.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            if (str != null)
            {
                if (MoveNumber < (str.Length) && MoveNumber >= 0)
                {
                    if (str[MoveNumber] == 'a')
                        RC();
                    else if (str[MoveNumber] == 'b')
                        RA();
                    else if (str[MoveNumber] == 'c')
                        LC();
                    else if (str[MoveNumber] == 'd')
                        LA();
                    else if (str[MoveNumber] == 'e')
                        UC();
                    else if (str[MoveNumber] == 'f')
                        UA();
                    else if (str[MoveNumber] == 'g')
                        DC();
                    else if (str[MoveNumber] == 'h')
                        DA();
                    else if (str[MoveNumber] == 'i')
                        FC();
                    else if (str[MoveNumber] == 'j')
                        FA();
                    else if (str[MoveNumber] == 'k')
                        BC();
                    else if (str[MoveNumber] == 'l')
                        BA();
                    else if (str[MoveNumber] == 'm')
                        MC();
                    else if (str[MoveNumber] == 'n')
                        MA();
                    else if (str[MoveNumber] == 'o')
                        EC();
                    else if (str[MoveNumber] == 'p')
                        EA();
                    else if (str[MoveNumber] == 'q')
                        SC();
                    else if (str[MoveNumber] == 'r')
                        SA();
                    else if (str[MoveNumber] == 's')
                        AR();
                    else if (str[MoveNumber] == 't')
                        AL();
                    else if (str[MoveNumber] == 'u')
                        AU();
                    else if (str[MoveNumber] == 'v')
                        AD();
                    MoveNumber++;
                }
            }
        }
        int[] arr1 = {1,1,1,1,1,1,1,1,1,
                    2,2,2,2,2,2,2,2,2,
                    3,3,3,3,3,3,3,3,3,
                    6,6,6,6,6,6,6,6,6,
                    4,4,4,4,4,4,4,4,4,
                    5,5,5,5,5,5,5,5,5,
                    };
        void DisplayCppArray()
        {
            FileStream fs = new FileStream("temp.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            for (int i = 0; i < 54; i++)
            {
                if (str[i] == '1')
                {
                    arr1[i] = 1;

                }
                else if (str[i] == '2')
                {
                    arr1[i] = 2;

                }
                else if (str[i] == '3')
                {
                    arr1[i] = 3;

                }
                else if (str[i] == '4')
                {
                    arr1[i] = 4;

                }
                else if (str[i] == '5')
                {
                    arr1[i] = 5;

                }
                else if (str[i] == '6')
                {
                    arr1[i] = 6;

                }
            }

        }
        //                             Final Form Button
        private void button65_Click(object sender, EventArgs e)
        {
            if (clicked == true)
            {
                clicked = false;
                FileStream fs = new FileStream("output.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                string str = sr.ReadLine();
                if (str != null)
                {
                    for (int i = MoveNumber; i < str.Length; i++)
                    {
                        if (str[i] == 'a')
                            RC();
                        else if (str[i] == 'b')
                            RA();
                        else if (str[i] == 'c')
                            LC();
                        else if (str[i] == 'd')
                            LA();
                        else if (str[i] == 'e')
                            UC();
                        else if (str[i] == 'f')
                            UA();
                        else if (str[i] == 'g')
                            DC();
                        else if (str[i] == 'h')
                            DA();
                        else if (str[i] == 'i')
                            FC();
                        else if (str[i] == 'j')
                            FA();
                        else if (str[i] == 'k')
                            BC();
                        else if (str[i] == 'l')
                            BA();
                        else if (str[i] == 'm')
                            MC();
                        else if (str[i] == 'n')
                            MA();
                        else if (str[i] == 'o')
                            EC();
                        else if (str[i] == 'p')
                            EA();
                        else if (str[i] == 'q')
                            SC();
                        else if (str[i] == 'r')
                            SA();
                        else if (str[i] == 's')
                            AR();
                        else if (str[i] == 't')
                            AL();
                        else if (str[i] == 'u')
                            AU();
                        else if (str[i] == 'v')
                            AD();
                        MoveNumber++;
                    }
                }
            }
        }
        //                                     Scamble  Button

        private void button66_Click(object sender, EventArgs e)
        {
            clicked = true;
            MoveNumber = 0;
            Random rnd = new Random();
            for (int i = 0; i < 30; i++) 
            {
                int number;
                number = rnd.Next(1,18);
                if (number == 18)
                    RC();
                else if (number == 1)
                    RA();
                else if (number == 2)
                    LC();
                else if (number == 3)
                    LA();
                else if (number == 4)
                    UC();
                else if (number == 5)
                    UA();
                else if (number == 6)
                    DC();
                else if (number == 7)
                    DA();
                else if (number == 8)
                    FC();
                else if (number == 9)
                    FA();
                else if (number == 10)
                    BC();
                else if (number == 11)
                    BA();
                else if (number == 12)
                    MC();
                else if (number == 13)
                    MA();
                else if (number == 14)
                    EC();
                else if (number == 15)
                    EA();
                else if (number == 16)
                    SC();
                else if (number == 17)
                    SA();
            }
        }

        private void button64_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("output.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            if (str != null)
            {
                if (MoveNumber <= (str.Length) && MoveNumber - 1 >= 0)
                {
                    if (str[MoveNumber - 1] == 'a')
                        RA();
                    else if (str[MoveNumber - 1] == 'b')
                        RC();
                    else if (str[MoveNumber - 1] == 'c')
                        LA();
                    else if (str[MoveNumber - 1] == 'd')
                        LC();
                    else if (str[MoveNumber - 1] == 'e')
                        UA();
                    else if (str[MoveNumber - 1] == 'f')
                        UC();
                    else if (str[MoveNumber - 1] == 'g')
                        DA();
                    else if (str[MoveNumber - 1] == 'h')
                        DC();
                    else if (str[MoveNumber - 1] == 'i')
                        FA();
                    else if (str[MoveNumber - 1] == 'j')
                        FC();
                    else if (str[MoveNumber - 1] == 'k')
                        BA();
                    else if (str[MoveNumber - 1] == 'l')
                        BC();
                    else if (str[MoveNumber - 1] == 'm')
                        MA();
                    else if (str[MoveNumber - 1] == 'n')
                        MC();
                    else if (str[MoveNumber - 1] == 'o')
                        EA();
                    else if (str[MoveNumber - 1] == 'p')
                        EC();
                    else if (str[MoveNumber - 1] == 'q')
                        SA();
                    else if (str[MoveNumber - 1] == 'r')
                        SC();
                    else if (str[MoveNumber - 1] == 's')
                        AL();
                    else if (str[MoveNumber - 1] == 't')
                        AR();
                    else if (str[MoveNumber - 1] == 'u')
                        AD();
                    else if (str[MoveNumber - 1] == 'v')
                        AU();
                    MoveNumber--;
                }
            }
        }
    }
}
