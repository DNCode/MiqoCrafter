﻿using MiqoCraftCore;
using System;
using System.Windows.Forms;
using VPL.Threading.Modeler;

namespace MiqoCraft
{
    public partial class FFXIVCraftingListItem : UserControl
    {
        private FFXIVSearchItem _item;

        /// <summary>
        /// Associated Item
        /// </summary>
        public FFXIVSearchItem Item
        {
            get => _item;
            set
            {
                _item = value;

                VPThreading.SetImageFromURL(_mainPictureBox, _item.UrlImage);
                _mainPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                _itemNameLabel.Text = _item.Name;
                _quantityNumericUpDown.Value = _item.Quantity;
            }
        }


        public FFXIVCraftingListItem()
        {
            InitializeComponent();
        }

        private void _quantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (null != Item)
            {
                Item.Quantity = (int)_quantityNumericUpDown.Value;
            }
        }
    }
}
