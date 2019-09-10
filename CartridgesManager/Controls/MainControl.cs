﻿using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;


namespace CartridgesManager.Controls {
    public partial class MainControl : UserControl {

        public MainControl() {
            InitializeComponent();

            // Открытие смены
            NewSessionButton.Barcode = NewSessionButton.RegisterControl(((long)ActionsHelper.MainActions.NewSession),
                delegate (string code) {
                    if (SessionManager.IsSessionCreated) {
                        GuiController.CreateMessage("Смена уже открыта под пользователем " + SessionManager.WorkerName, true);
                        return;
                    }
                    else {
                        UserSelect userSelect = new UserSelect();
                        userSelect.ShowThisPage();
                    }
                });

            ServiceButton.Barcode = ((long)ActionsHelper.MainActions.ServiceCartridge).ToString();
            ServiceButton.ButtonClick += delegate (object s, EventArgs e) {
                // Обслуживание картриджа здесь
            };
            AddNewCartridgeButton.Barcode = ((long)ActionsHelper.MainActions.AddNewCartridge).ToString();
            AddNewCartridgeButton.ButtonClick += delegate (object s, EventArgs e) {
                // Добавление нового картриджа здесь
            };
            ViewInfoButton.Barcode = ((long)ActionsHelper.MainActions.CartridgeInfo).ToString();
            ViewInfoButton.ButtonClick += delegate (object s, EventArgs e) {
                ShowBarcodeBox(true);
            };
            ViewCartridgesButton.Barcode = ((long)ActionsHelper.MainActions.PostOfficeInfo).ToString();
            ViewCartridgesButton.ButtonClick += delegate (object s, EventArgs e) {
                // Просмотр картриджей отделения здесь
            };

            // Закрытие смены
            CloseSessionButton.Barcode = CloseSessionButton.RegisterControl(((long)ActionsHelper.MainActions.CloseSession),
                delegate(string code) {
                    if (SessionManager.IsSessionCreated) {
                        SessionManager.CloseSession();
                        GuiController.CreateMessage("Закрытие смены выполнено", false);
                    }
                    else {
                        GuiController.CreateMessage("Смена еще не открыта", true);
                    }
                });

            // Переключение полноэкранного режима
            FullScreenButton.Barcode = FullScreenButton.RegisterControl(((long)ActionsHelper.MainActions.FullScreen),
                (c) => GuiController.MainForm.SwitchFullScreenMode());

            // Выход из программы
            ExitButton.Barcode = ExitButton.RegisterControl(((long)ActionsHelper.MainActions.ExitApplication),
                (c) => GuiController.ExitApplication());


            MainBarcodeBox.BarcodeEndRead += BarcodeBox1_BarcodeEndRead;
        }

        /// <summary>
        /// Отображает поле для считывания кода картриджа
        /// </summary>
        /// <param name="showBox">Если true будет поле отображено</param>
        public void ShowBarcodeBox(bool showBox) {
            MainBarcodeBox.Visible = showBox;
            if (showBox) {
                MainBarcodeBox.Focus();
            }
        }

        private void BarcodeBox1_BarcodeEndRead(long barcode) {
            CartridgeInfo cartridgeInfo = DatabaseHelper.GetCartridgeInfo(barcode);
            ShowCartridgeInfo ctrl = new ShowCartridgeInfo(barcode, cartridgeInfo);
            ctrl.Dock = DockStyle.Fill;
            Parent.Controls.Add(ctrl);
            ctrl.BringToFront();
            ShowBarcodeBox(false);
        }
    }
}
