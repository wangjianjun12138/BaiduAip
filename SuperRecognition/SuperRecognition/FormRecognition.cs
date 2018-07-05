using Baidu.Aip.Ocr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperRecognition
{
    public partial class FormRecognition : Form
    {
        private Ocr m_client;
        private String m_imagePath = String.Empty;
        
        public FormRecognition()
        {
            InitializeComponent();
            InltializeRecognition();
        }

        private void InltializeRecognition()
        {
            
            var APP_ID = "11495528";
            var API_KEY = "KLujEE43w3cwnGxjOGZ74o58";
            var SECRET_KEY = "9PzWnq5BOh8ipbdf7WdVp50Ax4f5S33B";
            m_client = new Baidu.Aip.Ocr.Ocr(API_KEY, SECRET_KEY);
            m_client.Timeout = 60000; 
        }


        private void m_buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                var image = File.ReadAllBytes(m_textBoxImagePath.Text);
                var result = m_client.GeneralBasic(image);
                m_textBoxReuslt.Text = result["words_result"].ToString();
            }
            catch (Exception ex)
            {
                m_textBoxReuslt.Text = ex.Message;
            }
            
        }

        private void m_buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_buttonGetImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "图像文件(*.jpg;*.gif;*.bmp;*.png)|*.jpg;*.gif;*.bmp;*.png";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                m_textBoxImagePath.Text = dialog.FileName;
            }
        }

    }
}
