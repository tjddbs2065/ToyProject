﻿namespace KiwoomTrader
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_예수금 = new System.Windows.Forms.Button();
            this.btn_계좌평가잔고내역 = new System.Windows.Forms.Button();
            this.btn_미체결 = new System.Windows.Forms.Button();
            this.btn_tmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_예수금
            // 
            this.btn_예수금.Location = new System.Drawing.Point(12, 12);
            this.btn_예수금.Name = "btn_예수금";
            this.btn_예수금.Size = new System.Drawing.Size(50, 47);
            this.btn_예수금.TabIndex = 0;
            this.btn_예수금.Text = "예수금 조회";
            this.btn_예수금.UseVisualStyleBackColor = true;
            this.btn_예수금.Click += new System.EventHandler(this.btn_예수금_Click);
            // 
            // btn_계좌평가잔고내역
            // 
            this.btn_계좌평가잔고내역.Location = new System.Drawing.Point(68, 12);
            this.btn_계좌평가잔고내역.Name = "btn_계좌평가잔고내역";
            this.btn_계좌평가잔고내역.Size = new System.Drawing.Size(75, 47);
            this.btn_계좌평가잔고내역.TabIndex = 1;
            this.btn_계좌평가잔고내역.Text = "계좌평가 잔고내역";
            this.btn_계좌평가잔고내역.UseVisualStyleBackColor = true;
            this.btn_계좌평가잔고내역.Click += new System.EventHandler(this.btn_계좌평가잔고내역_Click);
            // 
            // btn_미체결
            // 
            this.btn_미체결.Location = new System.Drawing.Point(149, 12);
            this.btn_미체결.Name = "btn_미체결";
            this.btn_미체결.Size = new System.Drawing.Size(55, 47);
            this.btn_미체결.TabIndex = 2;
            this.btn_미체결.Text = "미체결 조회";
            this.btn_미체결.UseVisualStyleBackColor = true;
            this.btn_미체결.Click += new System.EventHandler(this.btn_미체결_Click);
            // 
            // btn_tmp
            // 
            this.btn_tmp.Location = new System.Drawing.Point(210, 12);
            this.btn_tmp.Name = "btn_tmp";
            this.btn_tmp.Size = new System.Drawing.Size(75, 47);
            this.btn_tmp.TabIndex = 3;
            this.btn_tmp.Text = "btn_tmp";
            this.btn_tmp.UseVisualStyleBackColor = true;
            this.btn_tmp.Click += new System.EventHandler(this.btn_tmp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_tmp);
            this.Controls.Add(this.btn_미체결);
            this.Controls.Add(this.btn_계좌평가잔고내역);
            this.Controls.Add(this.btn_예수금);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_예수금;
        private System.Windows.Forms.Button btn_계좌평가잔고내역;
        private System.Windows.Forms.Button btn_미체결;
        private System.Windows.Forms.Button btn_tmp;
    }
}
