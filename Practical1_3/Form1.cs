using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Allen Higgins

namespace Practical1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //method for error hadling
        private void error()
        {
            MessageBox.Show("Invald Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        //method of checking which pannel is currently active
        private void ActivePannel(object sender, EventArgs e)
        {
            //cast object as a checkBox
            CheckBox thisBox = (CheckBox)sender;
            //send name of checkBox into the switch
            switch (thisBox.Name)
            {
                case "checkBox1":
                    //if pannel1 is not enabled
                    if (panel1.Enabled == false)
                    {
                        //the enable it and button4 (clear button)
                        panel1.Enabled = true;
                        button4.Enabled = true;
                    }
                    else
                    {
                        //otherwise disable the pannel and the clear button
                        panel1.Enabled = false;
                        button4.Enabled = false;
                    }
                    break;
                case "checkBox2":
                    //if pannel2 is disabled
                    if (panel2.Enabled == false)
                    {
                        //then enable this pannel and the clear button belong to it
                        panel2.Enabled = true;
                        button5.Enabled = true;
                    }
                    else
                    {
                        //otherwise disable the pannel and the clear button
                        panel2.Enabled = false;
                        button5.Enabled = false;
                    }
                    break;
                case "checkBox3":
                    //if pannel3 id disabled 
                    if (panel3.Enabled == false)
                    {
                        //then enable the pannel and its clear button
                        panel3.Enabled = true;
                        button6.Enabled = true;
                    }
                    else
                    {
                        //otherwise disable the pannel and its clear button
                        panel3.Enabled = false;
                        button6.Enabled = false;
                    }
                    break;
            }
        }
        //method for which converter button is pressed
        private void ThisButton(object sender, EventArgs e)
        {
            //cast the object to a button and send it into the switch
            Button theButton = (Button)sender;
            switch (theButton.Name)
            {
                case "button1":
                    try
                    {
                        //if textBox1 is enabled
                        if (textBox1.Enabled == true)
                        {
                            //inches to feet
                            double value = double.Parse(textBox1.Text);
                            //send the result to textBox2 rounded to 2 decimal places
                            textBox2.Text = Math.Round((value / 12),2).ToString();
                        }
                        else
                        {
                            //otherwise its feet to inches
                            double value = double.Parse(textBox2.Text);
                            textBox1.Text = Math.Round((value * 12),2).ToString();
                        }
                    }
                    catch (Exception)
                    {
                        //else catch the exception ie not numbers
                        //and call the error msg method
                        error();
                    }
                    break;
                case "button2":
                    try
                    {
                        if (textBox4.Enabled == true)
                        {   
                            //pound to euro (1 pound = 1.17 euros)
                            double value = double.Parse(textBox4.Text);
                            //return the result to textBox3
                            textBox3.Text = Math.Round((value *1.17),2).ToString();
                        }
                        else
                        {   
                            //else its euro to pound
                            double value = double.Parse(textBox3.Text);
                            //return the result to textBox4
                            textBox4.Text = Math.Round((value * 0.89),2).ToString();
                        }
                    }
                    catch (Exception)
                    {
                        //else catch the exception ie not numbers
                        //and call the error msg method
                        error();
                    }
                    break;
                case "button3":
                    try
                    {
                        if (textBox6.Enabled == true)
                        {   
                            //celsius to fahrenheit
                            double value = double.Parse(textBox6.Text);
                            //return the result to textBox5
                            textBox5.Text = Math.Round((value * 9 / 5) + 32, 2).ToString();
                        }
                        else
                        {   
                            //else its fahrenheit to celsius
                            double value = double.Parse(textBox5.Text);
                            //return the result to textBox6
                            textBox6.Text = Math.Round((value - 32) * 5 / 9,2).ToString();
                        }
                    }
                    catch (Exception)
                    {
                        //else catch the exception ie not numbers
                        //and call the error msg method
                        error();
                    }
                    break;
            }
        }
        //method for changing textbox fields for convertion input
        private void enableFeild(object sender, EventArgs e)
        {
            //cast the object to a radioButton
            RadioButton rbutton = (RadioButton)sender;
            //send it into the switch
            switch (rbutton.Name)
            {
                //deturmine which case and enable or disable the appropreate textbox
                case "radioButton1":
                    if (radioButton1.Checked == true)
                    {
                        textBox1.Enabled = true;
                        textBox2.Text = "";
                    }
                    else
                    {
                        textBox1.Enabled = false;
                    }
                    break;
                case "radioButton2":
                    if (radioButton2.Checked == true)
                    {
                        textBox2.Enabled = true;
                        textBox1.Text = "";
                    }
                    else
                    {
                        textBox2.Enabled = false;
                    }
                    break;
                case "radioButton3":
                    if (radioButton3.Checked == true)
                    {
                        textBox3.Enabled = true;
                        textBox4.Text = "";
                    }
                    else
                    {
                        textBox3.Enabled = false;
                    }
                    break;
                case "radioButton4":
                    if (radioButton4.Checked == true)
                    {
                        textBox4.Enabled = true;
                        textBox3.Text = "";
                    }
                    else
                    {
                        textBox4.Enabled = false;
                    }
                    break;
                case "radioButton5":
                    if (radioButton5.Checked == true)
                    {
                        textBox5.Enabled = true;
                        textBox6.Text = "";
                    }
                    else
                    {
                        textBox5.Enabled = false;
                    }
                    break;
                case "radioButton6":
                    if (radioButton6.Checked == true)
                    {
                        textBox6.Enabled = true;
                        textBox5.Text = "";
                    }
                    else
                    {
                        textBox6.Enabled = false;
                    }
                    break;
            }
           
        }
        //method for emptying the chosen pannel textfields
        private void clearOut(object sender, EventArgs e)
        {
            //cast the object to a button
            Button btn = (Button)sender;
            //send it into the switch and clear the appropreate textboxs
            switch(btn.Name)
            {
                case "button4":
                    textBox1.Clear();
                    textBox2.Clear();
                    break;
                case "button5":
                    textBox3.Clear();
                    textBox4.Clear();
                    break;
                case "button6":
                    textBox5.Clear();
                    textBox6.Clear();
                    break;
            }
        }
      
    }
}
