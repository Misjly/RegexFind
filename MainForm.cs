using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegexTextbox
{
    public partial class MainForm : Form
    {
        private int SelectionStart { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            Regex whitespacePattern = new Regex(@"^\s*$");
            if (whitespacePattern.IsMatch(ExpressionTextBox.Text))
            {
                MessageBox.Show("Regular expression is blank");
                return;
            }
            try
            {
                MainRichTextBox.SelectAll();
                MainRichTextBox.SelectionColor = Color.Black;
                MainRichTextBox.SelectionBackColor = Color.White;
                Regex regex = new Regex(ExpressionTextBox.Text);
                MatchCollection matches = regex.Matches(MainRichTextBox.Text);
                if(matches.Count == 0)
                {
                    MessageBox.Show($"The following specified text was not found:{Environment.NewLine}{regex}");
                    return;
                }
                int startCursorPosition = MainRichTextBox.SelectionStart;
                foreach (Match match in matches)
                {
                    int startIndex = match.Index;
                    int StopIndex = match.Length;
                    MainRichTextBox.Select(startIndex, StopIndex);
                    MainRichTextBox.SelectionColor = Color.White;
                    MainRichTextBox.SelectionBackColor = Color.MediumPurple;
                    MainRichTextBox.SelectionStart = startCursorPosition;
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Expression is not regular");
            }
        }

        private void ExpressionTextBox_TextChanged(object sender, EventArgs e)
        {
            MainRichTextBox.SelectAll();
            MainRichTextBox.SelectionColor = Color.Black;
            MainRichTextBox.SelectionBackColor = Color.White;
            MainRichTextBox.SelectionLength = 0;
        }

        private void MainRichTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(MainRichTextBox.SelectedText == "")
            {
                SelectionStart = MainRichTextBox.SelectionStart;
                MainRichTextBox.SelectAll();
                MainRichTextBox.SelectionColor = Color.Black;
                MainRichTextBox.SelectionBackColor = Color.White;
                MainRichTextBox.SelectionStart = SelectionStart;
                MainRichTextBox.SelectionLength = 0;
            }
        }
    }
}
