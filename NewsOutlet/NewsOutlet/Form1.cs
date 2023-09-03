using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace NewsOutlet
{
    public partial class Form1 : Form
    {


        long currentEpochTime = DateTimeOffset.Now.ToUnixTimeSeconds();
        static Stack<News> stack = new Stack<News>();
        static List<News> recentNews;


        public Form1()
        {
            InitializeComponent();
        }
        private void backbtn_Click(object sender, EventArgs e)
        {
            if (stack.Count() == 0)
            {

                MessageBox.Show("Sorry! You have reached the first news you selected or you are yet to select one!");
                return;
            }
            else {


                richTextBox1.Clear();
                var temp = stack.Peek();
                richTextBox1.AppendText(temp.toStringNews());
                stack.Pop();

            }

        }

        private void ShowTrendingsrbtn_CheckedChanged(object sender, EventArgs e) {

            recentNews = News.FilterTrending();


            if (ShowTrendingsrbtn.Checked)
            {
                lstbxNews.Items.Clear();
                foreach (var news in recentNews)
                {
                    if (keywordtxt.Text == "")
                    {
                        var csv_format = news.toString(); 
                        lstbxNews.Items.Add(csv_format); 

                    }
                    else
                    {
                        for (int i = 0; i < news.Keywords.Length; i++)
                        {
                            if (keywordtxt.Text == "")
                            {

                                var csv_format = news.toString();
                                lstbxNews.Items.Add(csv_format);

                            }
                            else if (keywordtxt.Text == news.Keywords[i])
                            {
                                var csv_format = news.toString(); 
                                lstbxNews.Items.Add(csv_format);
                            }
                        }
                    }
                    
                   

                }
            }
        }

        private void showRecentrbtn_CheckedChanged(object sender, EventArgs e)
        {
             
            recentNews = News.FilterRecent(currentEpochTime);

            if (showRecentrbtn.Checked) {
                lstbxNews.Items.Clear();
                foreach (var news in recentNews)
                {
                    if (keywordtxt.Text == "")
                    {
                        var csv_format = news.toString(); 
                        lstbxNews.Items.Add(csv_format);  
                    }
                    else
                    {
                        for (int i = 0; i < news.Keywords.Length; i++)
                        {
                            if (keywordtxt.Text == "") {

                                var csv_format = news.toString(); 
                                lstbxNews.Items.Add(csv_format);

                            }
                            else if (keywordtxt.Text == news.Keywords[i])
                            {
                                 
                                var csv_format = news.toString();  
                                lstbxNews.Items.Add(csv_format);
                            }
                        }
                    }
                    
                }
            }

            

        }

        private void setbtn_Click(object sender, EventArgs e)
        {
            if (txtxSetTime.Text == "")
            {

                MessageBox.Show("Please, set the time");
                return;

            }
            else {

                currentEpochTime = long.Parse(txtxSetTime.Text);


            }
             
        }

        private void lstbxNews_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            if (txtID.Text == "")
            {

                MessageBox.Show("Please, enter an id before selecting show.");

            }
            else {
                if (recentNews == null)
                {
                    MessageBox.Show("Please, select trending or recent news first");

                }
                else {
                    string ID = txtID.Text;
                    foreach (News neww in recentNews)
                    {

                        if (ID == neww.ID)
                        {
                            neww.Hits += 1;
                            stack.Push(neww);
                            richTextBox1.AppendText(stack.Peek().toStringNews());

                        }

                    }

                }           

            }
            

        }
    }
}
