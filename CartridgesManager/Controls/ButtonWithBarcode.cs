﻿using BarcodeLib;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;


namespace CartridgesManager.Controls {
    public partial class ButtonWithBarcode : UserControl {

        private string _barcode = string.Empty;

        /// <summary>
        /// Представляет метод, обрабатывающий событие ButtonClick
        /// </summary>
        /// <param name="barcode">Штрихкод</param>
        public delegate void ButtonClickEventHandler(object sender, EventArgs e);

        /// <summary>
        /// Происходит завершении чтения штрихкода
        /// </summary>
        public event ButtonClickEventHandler ButtonClick;


        public ButtonWithBarcode() {
            InitializeComponent();

            Disposed += ButtonWithBarcode_Disposed;
        }

        private void ButtonWithBarcode_Disposed(object sender, EventArgs e) {
            this.UnregisterControl();
        }

        private void FlatButton_Click(object sender, EventArgs e) {
            ButtonClick?.Invoke(this, e);
        }

        /// <summary>
        /// Возвращает или задает штрихкод кнопки
        /// </summary>
        [Category("Appearance")]
        [Description("Штрихкод кнопки")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Barcode {
            get {
                return _barcode;
            }
            set {
                _barcode = value;
                if (!string.IsNullOrEmpty(_barcode.Trim())) {
                    Barcode barcode = new Barcode();
                    barcode.Alignment = AlignmentPositions.CENTER;
                    barcode.Width = BarcodeBox.Width;
                    barcode.Height = BarcodeBox.Height;
                    Image img = barcode.Encode(TYPE.CODE39, _barcode);
                    BarcodeBox.SizeMode = PictureBoxSizeMode.Zoom;
                    BarcodeBox.Image = (Image)img.Clone();
                }
            }
        }

        /// <summary>
        /// Возвращает или задает текст, связанный с кнопкой
        /// </summary>
        [Category("Appearance")]
        [Description("Текст кнопки")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ButtonText {
            get {
                return FlatButton.Text;
            }
            set {
                FlatButton.Text = value;
            }
        }

        /// <summary>
        /// Возвращает или задает изображение, отображаемое в кнопке
        /// </summary>
        [Category("Appearance")]
        [Description("Изображение отображаемое в кнопке")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image ButtonImage {
            get {
                return FlatButton.Image;
            }
            set {
                FlatButton.Image = value;
            }
        }

        /// <summary>
        /// Возвращает или задает цвет фона кнопки
        /// </summary>
        [Category("Appearance")]
        [Description("Цвет фона кнопки")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color ButtonBackColor {
            get {
                return FlatButton.BackColor;
            }
            set {
                FlatButton.BackColor = value;
            }
        }
    }
}
