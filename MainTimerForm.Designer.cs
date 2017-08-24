namespace TIMER
{
    partial class MainTimerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTimerForm));
            this.SECOND = new System.Windows.Forms.TextBox();
            this.MINUTE = new System.Windows.Forms.TextBox();
            this.HOUR = new System.Windows.Forms.TextBox();
            this.RESET = new System.Windows.Forms.Button();
            this.START = new System.Windows.Forms.Button();
            this.STOP = new System.Windows.Forms.Button();
            this.SHOW_TIMER = new System.Windows.Forms.Button();
            this.SAVE_TIMER = new System.Windows.Forms.Button();
            this.SEARCH_TIMER = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SECOND
            // 
            this.SECOND.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SECOND.Location = new System.Drawing.Point(155, 24);
            this.SECOND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SECOND.Name = "SECOND";
            this.SECOND.ReadOnly = true;
            this.SECOND.Size = new System.Drawing.Size(66, 21);
            this.SECOND.TabIndex = 0;
            this.SECOND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MINUTE
            // 
            this.MINUTE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MINUTE.Location = new System.Drawing.Point(84, 24);
            this.MINUTE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MINUTE.Name = "MINUTE";
            this.MINUTE.ReadOnly = true;
            this.MINUTE.Size = new System.Drawing.Size(66, 21);
            this.MINUTE.TabIndex = 1;
            this.MINUTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HOUR
            // 
            this.HOUR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HOUR.Location = new System.Drawing.Point(13, 24);
            this.HOUR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HOUR.Name = "HOUR";
            this.HOUR.ReadOnly = true;
            this.HOUR.Size = new System.Drawing.Size(66, 21);
            this.HOUR.TabIndex = 2;
            this.HOUR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RESET
            // 
            this.RESET.Location = new System.Drawing.Point(155, 49);
            this.RESET.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(66, 18);
            this.RESET.TabIndex = 3;
            this.RESET.Text = "Reset";
            this.RESET.UseVisualStyleBackColor = true;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // START
            // 
            this.START.Location = new System.Drawing.Point(13, 49);
            this.START.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(66, 18);
            this.START.TabIndex = 4;
            this.START.Text = "Start";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // STOP
            // 
            this.STOP.Location = new System.Drawing.Point(84, 49);
            this.STOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.STOP.Name = "STOP";
            this.STOP.Size = new System.Drawing.Size(66, 18);
            this.STOP.TabIndex = 5;
            this.STOP.Text = "Stop";
            this.STOP.UseVisualStyleBackColor = true;
            this.STOP.Click += new System.EventHandler(this.STOP_Click);
            // 
            // SHOW_TIMER
            // 
            this.SHOW_TIMER.Font = new System.Drawing.Font("굴림", 8F);
            this.SHOW_TIMER.Location = new System.Drawing.Point(13, 72);
            this.SHOW_TIMER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SHOW_TIMER.Name = "SHOW_TIMER";
            this.SHOW_TIMER.Size = new System.Drawing.Size(207, 18);
            this.SHOW_TIMER.TabIndex = 6;
            this.SHOW_TIMER.Text = "오늘의 공부시간은?";
            this.SHOW_TIMER.UseVisualStyleBackColor = true;
            this.SHOW_TIMER.Click += new System.EventHandler(this.SHOW_TIMER_Click);
            // 
            // SAVE_TIMER
            // 
            this.SAVE_TIMER.Font = new System.Drawing.Font("굴림", 8F);
            this.SAVE_TIMER.Location = new System.Drawing.Point(13, 95);
            this.SAVE_TIMER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SAVE_TIMER.Name = "SAVE_TIMER";
            this.SAVE_TIMER.Size = new System.Drawing.Size(207, 18);
            this.SAVE_TIMER.TabIndex = 7;
            this.SAVE_TIMER.Text = "공부시간 저장하기";
            this.SAVE_TIMER.UseVisualStyleBackColor = true;
            this.SAVE_TIMER.Click += new System.EventHandler(this.SAVE_TIMER_CLICK);
            // 
            // SEARCH_TIMER
            // 
            this.SEARCH_TIMER.Font = new System.Drawing.Font("굴림", 8F);
            this.SEARCH_TIMER.Location = new System.Drawing.Point(13, 118);
            this.SEARCH_TIMER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SEARCH_TIMER.Name = "SEARCH_TIMER";
            this.SEARCH_TIMER.Size = new System.Drawing.Size(207, 18);
            this.SEARCH_TIMER.TabIndex = 8;
            this.SEARCH_TIMER.Text = "공부 시간 검색";
            this.SEARCH_TIMER.UseVisualStyleBackColor = true;
            this.SEARCH_TIMER.Click += new System.EventHandler(this.SEARCH_TIMER_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "시";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "분";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "초";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "유용한타이머";
            this.notifyIcon1.BalloonTipTitle = "나만의타이머";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "TIMER";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 48);
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.열기ToolStripMenuItem.Text = "열기";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.ReOpenProgram);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.EndProgram);
            // 
            // MainTimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 146);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SEARCH_TIMER);
            this.Controls.Add(this.SAVE_TIMER);
            this.Controls.Add(this.SHOW_TIMER);
            this.Controls.Add(this.STOP);
            this.Controls.Add(this.START);
            this.Controls.Add(this.RESET);
            this.Controls.Add(this.HOUR);
            this.Controls.Add(this.MINUTE);
            this.Controls.Add(this.SECOND);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainTimerForm";
            this.Text = "타이머 6.0v";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SECOND;
        private System.Windows.Forms.TextBox MINUTE;
        private System.Windows.Forms.TextBox HOUR;
        private System.Windows.Forms.Button RESET;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Button STOP;
        private System.Windows.Forms.Button SHOW_TIMER;
        private System.Windows.Forms.Button SAVE_TIMER;
        private System.Windows.Forms.Button SEARCH_TIMER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
    }
}

