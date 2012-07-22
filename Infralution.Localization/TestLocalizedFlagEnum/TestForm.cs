#region File Header
//
// COPYRIGHT:   Copyright 2007 
//              Infralution
//
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
namespace TestLocalizedFlagEnum
{
    /// <summary>
    /// Sample form illustrating the use of Enum values (with Flag attribute) which use a LocalizedEnumConverter 
    /// to automatically convert the displayed values when using databinding
    /// </summary>
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();

            // setup the culture selection combo box
            //
            _cultureComboBox.DataSource = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            _cultureComboBox.SelectedItem = Thread.CurrentThread.CurrentCulture;
            _cultureComboBox.SelectedIndexChanged += new System.EventHandler(_cultureComboBox_SelectedIndexChanged);

            // Set the list box to display the enum values.  Because we have defined the type converter attribute
            // for the TextStyle this will automatically display the localized text
            //
            _enumListBox.DataSource = Enum.GetValues(typeof(TextStyle));
        }

        /// <summary>
        /// Convert the entered (localized) text back to an enum value using the type converter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _convertButton_Click(object sender, EventArgs e)
        {
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(TextStyle));
            try
            {
                object value = converter.ConvertFromString(_textBox.Text);
                MessageBox.Show(string.Format("The enum value is: {0}", value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Change the current thread culture when the selected culture changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _cultureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CultureInfo culture = _cultureComboBox.SelectedItem as CultureInfo;
            Thread.CurrentThread.CurrentCulture = culture;

            // force the combo box to update its values
            //
            _enumListBox.DataSource = Enum.GetValues(typeof(TextStyle));

        }

        /// <summary>
        /// Combine the selected enum values into a single value and display in the textbox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _enumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextStyle newTextStyle = TextStyle.None;
            foreach (TextStyle textStyle in _enumListBox.SelectedItems)
            {
                newTextStyle = newTextStyle | textStyle;
            }
            _textBox.Text = LocalizedEnumConverter.ConvertToString(newTextStyle);
        }
   }
}