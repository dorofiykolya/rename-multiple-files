using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BatchFileRename
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _toolTip = new ToolTip {AutoPopDelay = 10000, InitialDelay = 500, ReshowDelay = 500, ShowAlways = true};
        }

        private static FileName[] _currentList;
        private readonly ToolTip _toolTip;

        private void Form1_Load(object sender, EventArgs e)
        {
            inputList.DisplayMember = "Name";
            outputList.DisplayMember = "NewName";
            inputList.ValueMember = "Name";
            outputList.ValueMember = "NewName";

            inputTextComboBox.DataSource = DropDownRegExp.Values.ToArray();
            regexpComboBox.DataSource = DropDownRegExp.Values.ToArray();
            outputComboBox.DataSource = DropDownRegExp.Values.ToArray();
            extensionComboBox.DataSource = DropDownRegExp.Values.ToArray();
        }

        private void DragDropHandler(object sender, DragEventArgs e)
        {
            _currentList = null;
            var list = e.Data.GetData(DataFormats.FileDrop) as string[];
            var result = new List<FileName>();
            if (list != null)
                foreach (var f in list)
                {
                    if (File.Exists(f))
                    {
                        var fn = new FileName();
                        fn.name = fn.newName = Path.GetFileNameWithoutExtension(f);
                        fn.path = f;
                        fn.directory = Path.GetDirectoryName(f);
                        fn.fullName = Path.GetFileName(f);
                        fn.extension = fn.newExtension = Path.GetExtension(f);
                        result.Add(fn);
                    }
                }
            result.Sort((f1, f2) => System.String.CompareOrdinal(f1.name, f2.name));
            inputList.DataSource = result.ToArray();
            _currentList = result.ToArray();
            Process();
        }

        private void DragEnterHandler(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Link : DragDropEffects.None;
        }

        private void Process()
        {
            if (_currentList != null)
            {
                foreach (var fileName in _currentList)
                {
                    fileName.newName = GetInputText(fileName.name);
                    fileName.newName = GetInputFromText(fileName.newName);
                    fileName.newName = GetReplaceText(fileName.newName);
                    fileName.newName = GetOutPut(fileName.newName);

                    fileName.newExtension = GetExtension(fileName.extension);
                    fileName.newExtension = GetExtensionOutPut(fileName.newExtension);
                }
                outputList.DataSource = _currentList.ToArray();
            }
        }

        private string GetExtension(string extension)
        {
            return extensionTextBox.Text.Replace("{E}", extension);
        }

        private string GetOutPut(string text)
        {
            return GetBy(text, outputComboBox.Text);
        }

        private string GetExtensionOutPut(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return text;
            }
            var t = text.Length > 0 && text[0] == '.' ? text.Remove(0, 1) : text;
            return "." + GetBy(t, extensionComboBox.Text);
        }

        private string GetReplaceText(string text)
        {
            var inT = replaceInTextBox.Text;
            var outT = replaceOutTextBox.Text;
            var reg = regexpCheckBox.Checked;
            var caseSen = caseSensCheckBox.Checked;

            if (reg)
            {
                try
                {
                    var r = new Regex(inT, caseSen ? RegexOptions.None : RegexOptions.IgnoreCase);
                    text = r.Replace(text, GetReplaceOutText(outT));
                    replaceInTextBox.BackColor = Color.White;
                    _toolTip.SetToolTip(replaceInTextBox, "");
                }
                catch (Exception)
                {
                    replaceInTextBox.BackColor = Color.OrangeRed;
                    _toolTip.SetToolTip(replaceInTextBox, "Не валидное регулярное выражение");
                }
            }
            else
            {
                replaceInTextBox.BackColor = Color.White;
                _toolTip.SetToolTip(replaceInTextBox, "");
                if (caseSen == false && inT.Length > 0)
                {
                    var low = text.ToLower();
                    var searchLow = inT.ToLower();
                    var index = low.IndexOf(searchLow);
                    while (index != -1)
                    {
                        low = low.Remove(index, searchLow.Length);
                        low = low.Insert(index, outT);
                        text = text.Remove(index, inT.Length);
                        text = GetReplaceOutText(text.Insert(index, outT));
                        if (index + searchLow.Length < low.Length)
                        {
                            index = low.IndexOf(searchLow, index + searchLow.Length);
                        }
                        else
                        {
                            index = -1;
                        }
                    }
                }
                else if (text.Length > 0 && inT.Length > 0)
                {
                    text = text.Replace(inT, outT);    
                }
            }
            return text;
        }

        private string GetReplaceOutText(string text)
        {
            return GetBy(text, regexpComboBox.Text);
        }

        private string GetInputFromText(string name)
        {
            return filenNameTextBox.Text.Replace("{N}", name);
        }

        private string GetInputText(string text)
        {
            return GetBy(text, inputTextComboBox.Text);
        }

        private string GetBy(string text, string value)
        {
            string result = null;
            var outText = value;

            if (outText == DropDownRegExp.None)
            {
                result = text;
            }
            else if (outText == DropDownRegExp.Lower)
            {
                result = text.ToLower();
            }
            else if (outText == DropDownRegExp.Upper)
            {
                result = text.ToUpper();
            }
            else if (outText == DropDownRegExp.FirstCharTextUpper)
            {
                var words = text.Split(new char[] { ' ' }, StringSplitOptions.None);
                var t = new StringBuilder();
                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = words[i].ToLower();
                    if (words[i].Length > 0)
                    {
                        var firstWithout = words[i].Remove(0, 1);
                        var first = words[i][0].ToString().ToUpper();
                        words[i] = first + firstWithout;
                    }

                }
                result = string.Join(" ", words);
            }
            else if (outText == DropDownRegExp.FirstCharAllWordsUpper)
            {
                var words = text.Split(new char[] { ' ' }, StringSplitOptions.None);
                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = words[i].ToLower();
                    if (i == 0)
                    {
                        if (words[i].Length > 0)
                        {
                            var firstWithout = words[i].Remove(0, 1);
                            var first = words[i][0].ToString().ToUpper();
                            words[i] = first + firstWithout;
                        }
                    }
                }
                result = string.Join(" ", words);
            }
            return result;
        }

        private void Save()
        {
            foreach (var file in _currentList)
            {
                File.Move(file.path, Path.Combine(file.directory, file.NewName));
            }
            inputList.DataSource = null;
            outputList.DataSource = null;
            inputList.DisplayMember = "Name";
            outputList.DisplayMember = "NewName";
            inputList.ValueMember = "Name";
            outputList.ValueMember = "NewName";
            _currentList = null;
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            Process();
            Save();
        }

        private void filenNameTextBox_TextChanged(object sender, EventArgs e)
        {
            Process();
        }

        private void extensionTextBox_TextChanged(object sender, EventArgs e)
        {
            Process();
        }

        private void replaceInTextBox_TextChanged(object sender, EventArgs e)
        {
            Process();
        }

        private void replaceOutTextBox_TextChanged(object sender, EventArgs e)
        {
            Process();
        }

        private void caseSensCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Process();
        }

        private void regexpCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Process();
        }

        private void regexpComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Process();
        }

        private void outputComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Process();
        }

        private void inputTextComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Process();
        }

        private void extensionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Process();
        }
    }
}
