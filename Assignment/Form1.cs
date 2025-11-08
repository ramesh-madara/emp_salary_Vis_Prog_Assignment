using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace Assignment
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;

            // Add this form to be managed by the MaterialSkinManager
            materialSkinManager.AddFormToManage(this);

            // Set the theme (LIGHT or DARK)
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure the color scheme
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Indigo500,   // Main color
                Primary.Indigo700,   // Darker main color
                Primary.Indigo100,   // Lighter main color
                Accent.Pink200,      // Accent color for things like switches
                TextShade.WHITE      // Text color
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
