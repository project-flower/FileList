using System;
using System.IO;
using System.Windows.Forms;

namespace FileList
{
    public partial class FormMain : Form
    {
        #region Private Fields

        private bool messageShowing = false;

        #endregion

        #region Private Methods

        private void saveFile(string text)
        {
            if (messageShowing)
            {
                return;
            }

            messageShowing = true;
            DialogResult dialogResult = saveFileDialog.ShowDialog(this);
            messageShowing = false;

            if (dialogResult != DialogResult.OK)
            {
                return;
            }

            try
            {
                File.WriteAllText(saveFileDialog.FileName, text);
            }
            catch (Exception exception)
            {
                showErrorMessage(exception.Message);
            }
        }

        private void setClipboard(string text)
        {
            try
            {
                Clipboard.SetText(text);
                showMessage("クリップボードにコピーしました。", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception exception)
            {
                showErrorMessage(exception.Message);
            }
        }

        private void showErrorMessage(string message)
        {
            showMessage(message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private DialogResult showMessage(string text, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            if (messageShowing)
            {
                return DialogResult.None;
            }

            messageShowing = true;
            DialogResult result = MessageBox.Show(this, text, Text, buttons, icon);
            messageShowing = false;
            return result;
        }

        #endregion

        // Designer's Methods

        public FormMain()
        {
            InitializeComponent();
        }

        private void dragDrop(object sender, DragEventArgs e)
        {
            if ((!((e.Data.GetData(DataFormats.FileDrop)) is string[] dropData)) || (dropData.Length < 1))
            {
                return;
            }

            string newLine = System.Environment.NewLine;
            string text = (string.Join(newLine, dropData, 0, dropData.Length) + newLine);
            Delegate method = null;

            if (radioButtonClipboard.Checked)
            {
                method = new Action<string>(setClipboard);
            }

            if (radioButtonFile.Checked)
            {
                method = new Action<string>(saveFile);
            }

            if (method == null)
            {
                return;
            }

            BeginInvoke(method, text);
        }

        private void dragEnter(object sender, DragEventArgs e)
        {
            e.Effect
                = (e.Data.GetDataPresent(DataFormats.FileDrop)
                ? DragDropEffects.All
                : DragDropEffects.None);
        }
    }
}
