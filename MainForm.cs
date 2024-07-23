/* 
 * Name of Project: ChiayinYanping_InClass5
 * Purpose: Understaing the concept of "class library"
 * Revision History: 
 * - Chiayin Yang & Yanping Guo, July 23 2024, Create basic design and functions.
 */

using Users;

namespace ChiayinYanping_InClass5
{
    public partial class MainForm : Form
    {
        private UserManager userManager;
        private List<string> phrases;
        public MainForm()
        {
            InitializeComponent();
            userManager = new UserManager();
            phrases = new List<string>();
        }

        private void btnGetNewId_Click(object sender, EventArgs e)
        {
            try
            {
                int newId = userManager.GetNewId();
                txtId.Text = newId.ToString();
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            try
            {
                int id = int.Parse(txtId.Text);
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                DateTime dateCreated = dateTimePicker1.Value;

                User newUser = new User(id, username, password, dateCreated);
                userManager.AddNewUser(newUser);

                lblMessage.Text = $"New user \"{username}\" added successfully.";
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void btnSavePhrase_Click(object sender, EventArgs e)
        {
            string phrase = txtPhrase.Text;
            if (!string.IsNullOrWhiteSpace(phrase))
            {
                phrases.Add(phrase);
                txtPhrase.Clear();
            }
        }

        private void btnShowAllPhrases_Click(object sender, EventArgs e)
        {
            string[] phraseArray = phrases.Select(p => new string(p.Where(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)).ToArray()))
                              .Reverse()
                              .ToArray();
            richTextBox1.Clear();
            for (int i = 0; i < phraseArray.Length; i++)
            {
                richTextBox1.AppendText($"{i}: {phraseArray[i]}\n");
            }
        }
    }
}
