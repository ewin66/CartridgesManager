﻿namespace CartridgesManager.Controls {
    partial class MainControl {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.ViewInfoButton = new CartridgesManager.Controls.LinearButton();
            this.AddNewCartridgeButton = new CartridgesManager.Controls.LinearButton();
            this.ServiceButton = new CartridgesManager.Controls.LinearButton();
            this.NewSessionButton = new CartridgesManager.Controls.LinearButton();
            this.ViewCartridgesButton = new CartridgesManager.Controls.LinearButton();
            this.CloseSessionButton = new CartridgesManager.Controls.LinearButton();
            this.FullScreenButton = new CartridgesManager.Controls.LinearButton();
            this.ExitButton = new CartridgesManager.Controls.LinearButton();
            this.SuspendLayout();
            // 
            // ViewInfoButton
            // 
            this.ViewInfoButton.BackColor = System.Drawing.Color.White;
            this.ViewInfoButton.Barcode = "";
            this.ViewInfoButton.ButtonBackColor = System.Drawing.Color.DimGray;
            this.ViewInfoButton.ButtonFontSize = 14.25F;
            this.ViewInfoButton.ButtonImage = global::CartridgesManager.Properties.Resources.cartridge_64;
            this.ViewInfoButton.ButtonText = "Просмотр информации о картридже";
            this.ViewInfoButton.CompactMode = false;
            this.ViewInfoButton.Location = new System.Drawing.Point(730, 25);
            this.ViewInfoButton.MinimumSize = new System.Drawing.Size(207, 215);
            this.ViewInfoButton.Name = "ViewInfoButton";
            this.ViewInfoButton.Size = new System.Drawing.Size(207, 215);
            this.ViewInfoButton.TabIndex = 4;
            // 
            // AddNewCartridgeButton
            // 
            this.AddNewCartridgeButton.BackColor = System.Drawing.Color.White;
            this.AddNewCartridgeButton.Barcode = "";
            this.AddNewCartridgeButton.ButtonBackColor = System.Drawing.Color.DimGray;
            this.AddNewCartridgeButton.ButtonFontSize = 14.25F;
            this.AddNewCartridgeButton.ButtonImage = global::CartridgesManager.Properties.Resources.send_64;
            this.AddNewCartridgeButton.ButtonText = "Добавить новый картридж";
            this.AddNewCartridgeButton.CompactMode = false;
            this.AddNewCartridgeButton.Location = new System.Drawing.Point(493, 25);
            this.AddNewCartridgeButton.MinimumSize = new System.Drawing.Size(207, 215);
            this.AddNewCartridgeButton.Name = "AddNewCartridgeButton";
            this.AddNewCartridgeButton.Size = new System.Drawing.Size(207, 215);
            this.AddNewCartridgeButton.TabIndex = 3;
            // 
            // ServiceButton
            // 
            this.ServiceButton.BackColor = System.Drawing.Color.White;
            this.ServiceButton.Barcode = "";
            this.ServiceButton.ButtonBackColor = System.Drawing.Color.DimGray;
            this.ServiceButton.ButtonFontSize = 14.25F;
            this.ServiceButton.ButtonImage = global::CartridgesManager.Properties.Resources.service_64;
            this.ServiceButton.ButtonText = "Обслуживание картриджа";
            this.ServiceButton.CompactMode = false;
            this.ServiceButton.Location = new System.Drawing.Point(262, 25);
            this.ServiceButton.MinimumSize = new System.Drawing.Size(207, 215);
            this.ServiceButton.Name = "ServiceButton";
            this.ServiceButton.Size = new System.Drawing.Size(207, 215);
            this.ServiceButton.TabIndex = 1;
            // 
            // NewSessionButton
            // 
            this.NewSessionButton.BackColor = System.Drawing.Color.White;
            this.NewSessionButton.Barcode = "";
            this.NewSessionButton.ButtonBackColor = System.Drawing.Color.DimGray;
            this.NewSessionButton.ButtonFontSize = 14.25F;
            this.NewSessionButton.ButtonImage = global::CartridgesManager.Properties.Resources.worker_64;
            this.NewSessionButton.ButtonText = "Открыть смену";
            this.NewSessionButton.CompactMode = false;
            this.NewSessionButton.Location = new System.Drawing.Point(25, 25);
            this.NewSessionButton.MinimumSize = new System.Drawing.Size(207, 215);
            this.NewSessionButton.Name = "NewSessionButton";
            this.NewSessionButton.Size = new System.Drawing.Size(207, 215);
            this.NewSessionButton.TabIndex = 0;
            // 
            // ViewCartridgesButton
            // 
            this.ViewCartridgesButton.BackColor = System.Drawing.Color.White;
            this.ViewCartridgesButton.Barcode = "";
            this.ViewCartridgesButton.ButtonBackColor = System.Drawing.Color.DimGray;
            this.ViewCartridgesButton.ButtonFontSize = 14.25F;
            this.ViewCartridgesButton.ButtonImage = global::CartridgesManager.Properties.Resources.search_64;
            this.ViewCartridgesButton.ButtonText = "Просмотр картриджей на отделении";
            this.ViewCartridgesButton.CompactMode = false;
            this.ViewCartridgesButton.Location = new System.Drawing.Point(25, 291);
            this.ViewCartridgesButton.MinimumSize = new System.Drawing.Size(207, 215);
            this.ViewCartridgesButton.Name = "ViewCartridgesButton";
            this.ViewCartridgesButton.Size = new System.Drawing.Size(207, 215);
            this.ViewCartridgesButton.TabIndex = 5;
            // 
            // CloseSessionButton
            // 
            this.CloseSessionButton.BackColor = System.Drawing.Color.White;
            this.CloseSessionButton.Barcode = "";
            this.CloseSessionButton.ButtonBackColor = System.Drawing.Color.DimGray;
            this.CloseSessionButton.ButtonFontSize = 14.25F;
            this.CloseSessionButton.ButtonImage = global::CartridgesManager.Properties.Resources.close_64;
            this.CloseSessionButton.ButtonText = "Закрытие смены";
            this.CloseSessionButton.CompactMode = false;
            this.CloseSessionButton.Location = new System.Drawing.Point(262, 291);
            this.CloseSessionButton.MinimumSize = new System.Drawing.Size(207, 215);
            this.CloseSessionButton.Name = "CloseSessionButton";
            this.CloseSessionButton.Size = new System.Drawing.Size(207, 215);
            this.CloseSessionButton.TabIndex = 6;
            // 
            // FullScreenButton
            // 
            this.FullScreenButton.BackColor = System.Drawing.Color.White;
            this.FullScreenButton.Barcode = "";
            this.FullScreenButton.ButtonBackColor = System.Drawing.Color.DimGray;
            this.FullScreenButton.ButtonFontSize = 14.25F;
            this.FullScreenButton.ButtonImage = global::CartridgesManager.Properties.Resources.fullscreen_64;
            this.FullScreenButton.ButtonText = "Полноэкранный режим (вкл/выкл)";
            this.FullScreenButton.CompactMode = false;
            this.FullScreenButton.Location = new System.Drawing.Point(493, 291);
            this.FullScreenButton.MinimumSize = new System.Drawing.Size(207, 215);
            this.FullScreenButton.Name = "FullScreenButton";
            this.FullScreenButton.Size = new System.Drawing.Size(207, 215);
            this.FullScreenButton.TabIndex = 7;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.White;
            this.ExitButton.Barcode = "";
            this.ExitButton.ButtonBackColor = System.Drawing.Color.DimGray;
            this.ExitButton.ButtonFontSize = 14.25F;
            this.ExitButton.ButtonImage = global::CartridgesManager.Properties.Resources.shutdown_64;
            this.ExitButton.ButtonText = "Выйти из программы";
            this.ExitButton.CompactMode = false;
            this.ExitButton.Location = new System.Drawing.Point(730, 291);
            this.ExitButton.MinimumSize = new System.Drawing.Size(207, 215);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(207, 215);
            this.ExitButton.TabIndex = 8;
            // 
            // MainControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.FullScreenButton);
            this.Controls.Add(this.CloseSessionButton);
            this.Controls.Add(this.ViewCartridgesButton);
            this.Controls.Add(this.ViewInfoButton);
            this.Controls.Add(this.AddNewCartridgeButton);
            this.Controls.Add(this.ServiceButton);
            this.Controls.Add(this.NewSessionButton);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(966, 740);
            this.ResumeLayout(false);

        }

        #endregion
        private LinearButton NewSessionButton;
        private LinearButton ServiceButton;
        private LinearButton AddNewCartridgeButton;
        private LinearButton ViewInfoButton;
        private LinearButton ViewCartridgesButton;
        private LinearButton CloseSessionButton;
        private LinearButton FullScreenButton;
        private LinearButton ExitButton;
    }
}
