﻿using GiftShopBusinessLogic.Interfaces;
using GiftShopBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace GiftShopView
{
    public partial class FormGiftSetComponent : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public int Id
        {
            get { return Convert.ToInt32(comboBoxComponent.SelectedValue); }
            set { comboBoxComponent.SelectedValue = value; }
        }

        public string ComponentName { get { return comboBoxComponent.Text; } }

        public int Count
        {
            get { return Convert.ToInt32(textBoxCount.Text); }
            set
            {
                textBoxCount.Text = value.ToString();
            }
        }

        public FormGiftSetComponent(IComponentLogic logic)
        {
            InitializeComponent();
            List<ComponentViewModel> list = logic.Read(null);
            if (list != null)
            {
                comboBoxComponent.DisplayMember = "ComponentName";
                comboBoxComponent.ValueMember = "Id";
                comboBoxComponent.DataSource = list;
                comboBoxComponent.SelectedItem = null;
            }
        }
        /*
        private void FormGiftSetComponent_Load(object sender, EventArgs e)
        {
            try
            {
                List<ComponentViewModel> list = logic.GetList();
                if (list != null)
                {
                    comboBoxComponent.DisplayMember = "ComponentName";
                    comboBoxComponent.ValueMember = "Id";
                    comboBoxComponent.DataSource = list;
                    comboBoxComponent.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            if (ModelView != null)
            {
                comboBoxComponent.Enabled = false;
                comboBoxComponent.SelectedValue = ModelView.ComponentId;
                textBoxCount.Text = ModelView.Count.ToString();
            }
        }
        */
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCount.Text))
            {
                MessageBox.Show("Заполните поле Количество", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxComponent.SelectedValue == null)
            {
                MessageBox.Show("Выберите компонент", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
