using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using System.Reflection;
using DevExpress.XtraEditors.ViewInfo;

namespace HighlightMathcedSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            InitializeButtonEdit();
        }

        private void InitializeButtonEdit() {
            sampleButtonEdit.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            sampleButtonEdit.Text = "Uriah DXSample";
            sampleButtonEdit.KeyDown += new KeyEventHandler(OnSampleButtonEditKeyDown);
        }

        private void OnSampleButtonEditKeyDown(object sender, KeyEventArgs e) {
            char letter;
            BaseEdit editor = (BaseEdit)sender;
            PropertyInfo pi = typeof(BaseEdit).GetProperty("ViewInfo", BindingFlags.Instance | BindingFlags.NonPublic);
            BaseEditViewInfo viewInfo = (BaseEditViewInfo)pi.GetValue(editor, null);
            StringBuilder matchedString = new StringBuilder(viewInfo.MatchedString);

            if (GetCharToSelect(editor.Text, matchedString.ToString(), out letter) &&
                char.Parse(letter.ToString().ToUpperInvariant()) == (char)e.KeyValue)
                matchedString.Append(editor.Text.Substring(matchedString.Length, 1));
            else if (e.KeyCode == Keys.Back &&
                    matchedString.Length > 0)
                matchedString.Remove(matchedString.Length - 1, 1);
            else return;

            viewInfo.MatchedString = matchedString.ToString();
            editor.Invalidate();
        }

        private bool GetCharToSelect(string text, string matchedString, out char letter) {
            if (matchedString.Length < text.Length) {
                letter = char.Parse(text.Substring(matchedString.Length, 1));
                return true;
            }
            letter = '\0';
            return false;
        }
    }
}