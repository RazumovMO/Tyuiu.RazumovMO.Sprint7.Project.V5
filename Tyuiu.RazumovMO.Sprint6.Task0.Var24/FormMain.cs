﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.RazumovMO.Sprint6.Task0.V24
{
    public partial class FormMain : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form ActiveForm;

        public FormMain()
        {
            InitializeComponent();
            random = new Random();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object button)
        {
            if (button != null)
            {
                if (currentButton == (Button)button)
                {
                    DisableButton();

                    Color color = SelectThemeColor();
                    currentButton = (Button)button;
                    currentButton.BackColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    Panel_TitleBar_DIE.BackColor = color;
                    Panel_Logo_DIE.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousButton in Panel_Main_DIE.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(51, 51, 76);
                    previousButton.ForeColor = Color.White;
                    previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object button)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActivateButton(button);
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Panel_DekstopPanel_DIE.Controls.Add(childForm);
            this.Panel_DekstopPanel_DIE.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Button_Home_DIE_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProducts(), sender);
        }

        private void Button_AboutUs_DIE_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormUser(), sender);
        }

        private void Button_Help_DIE_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHelp(), sender);
        }

    }
}