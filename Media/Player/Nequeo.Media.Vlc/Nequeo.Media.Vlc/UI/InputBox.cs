﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nequeo.Media.Vlc.UI
{
    /// <summary>
    /// Input dialog value.
    /// </summary>
    public enum InputType
    {
        /// <summary>
        /// OK button.
        /// </summary>
        OK = 0,
        /// <summary>
        /// Cancel button.
        /// </summary>
        Cancel = 1,
        /// <summary>
        /// No button.
        /// </summary>
        No = 2,
        /// <summary>
        /// Yes button.
        /// </summary>
        Yes = 3,
    }

    /// <summary>
    /// Input window.
    /// </summary>
    public partial class InputBox : Form
    {
        /// <summary>
        /// Input window.
        /// </summary>
        public InputBox()
        {
            InitializeComponent();
        }

        private string _inputValue = "";
        private InputType _inputType = InputType.Cancel;

        /// <summary>
        /// Gets or sets the input value.
        /// </summary>
        public string InputValue
        {
            get { return _inputValue; }
            set { _inputValue = value; }
        }

        /// <summary>
        /// Gets the input type.
        /// </summary>
        public InputType InputType
        {
            get { return _inputType; }
        }

        /// <summary>
        /// Text changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _inputValue = textBox1.Text;
        }

        /// <summary>
        /// Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _inputType = UI.InputType.Cancel;
            Close();
        }

        /// <summary>
        /// OK.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            _inputType = UI.InputType.OK;
            Close();
        }
    }
}
