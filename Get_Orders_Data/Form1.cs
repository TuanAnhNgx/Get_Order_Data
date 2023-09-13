using IronOcr;
using System.Text.RegularExpressions;
using Get_Orders_Data.BUS;

namespace Get_Orders_Data
{
    public partial class Form1 : Form
    {
        IronTesseract ocr = new IronTesseract();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    string[] folder = Directory.GetDirectories(fbd.SelectedPath);
                    txtInput.Text = fbd.SelectedPath;
                }

                if (txtInput.Text.Length > 0)
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    string[] folder = Directory.GetDirectories(fbd.SelectedPath);
                    txtInput.Text = fbd.SelectedPath;
                }
            }
        }

        void scanFile()
        {
            string folderPath = txtInput.Text;
            string mainText = "";
            //Tìm hết tất cả các file trong folder kể cả sub folder
            // Kiểm tra xem thư mục có tồn tại hay không
            if (Directory.Exists(folderPath))
            {
                // Lấy danh sách tất cả các tệp trong thư mục và các thư mục con
                string[] allFiles = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);

                foreach (string filePath in allFiles)
                {
                    // Do something with the file path
                    //mainText = readFile(filePath);
                    //mainText = cat_chuoi(mainText);
                    //richTextBox1.Text += @"**" + mainText + "\n\n\n";
                    richTextBox1.Text += filePath+"\n\n\n";
                }
            }
            else
            {
                MessageBox.Show("Thư mục không tồn tại. \n");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            scanFile();

            //getExcelData excel = new getExcelData();
            //richTextBox1.Text = excel.data(txtExcel.Text).ToString();

        }

        string readFile(string filePath)
        {
            readText read = new readText(filePath);
            string result = read.Ocr();
            return result;
        }

        string cat_chuoi(string text)
        {
            removeSpecialChar remove = new removeSpecialChar();
            string result = remove.removeUnicode(text);
            result = remove.removeSpecialChars(result);
            result = remove.removeWhiteSpace(result);
            return result;
        }

        void check()
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    txtExcel.Text = openFileDialog1.FileName;
            //}
        }
    }
}