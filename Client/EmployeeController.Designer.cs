namespace Client
{
    partial class EmployeeController
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmployeesTable = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbConsole = new System.Windows.Forms.TextBox();
            this.tbSendRequest = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lbAddress = new System.Windows.Forms.Label();
            this.btnGetList = new System.Windows.Forms.Button();
            this.btnGetSalary = new System.Windows.Forms.Button();
            this.btnHoursSalary = new System.Windows.Forms.Button();
            this.mtbAddress = new System.Windows.Forms.MaskedTextBox();
            this.mtbPort = new System.Windows.Forms.MaskedTextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.mtbSalary = new System.Windows.Forms.MaskedTextBox();
            this.mtbHours = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbItemPrice = new System.Windows.Forms.MaskedTextBox();
            this.mtbItemsCount = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbContractPrice = new System.Windows.Forms.MaskedTextBox();
            this.mtbContractPercent = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbPosts = new System.Windows.Forms.ComboBox();
            this.btnDelEmpl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeesTable
            // 
            this.EmployeesTable.AllowUserToAddRows = false;
            this.EmployeesTable.AllowUserToDeleteRows = false;
            this.EmployeesTable.AllowUserToResizeColumns = false;
            this.EmployeesTable.AllowUserToResizeRows = false;
            this.EmployeesTable.ColumnHeadersHeight = 29;
            this.EmployeesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.EmployeesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnPost,
            this.ColumnSalary});
            this.EmployeesTable.Cursor = System.Windows.Forms.Cursors.Default;
            this.EmployeesTable.Location = new System.Drawing.Point(701, 12);
            this.EmployeesTable.Name = "EmployeesTable";
            this.EmployeesTable.ReadOnly = true;
            this.EmployeesTable.RowHeadersVisible = false;
            this.EmployeesTable.RowHeadersWidth = 51;
            this.EmployeesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeesTable.ShowCellErrors = false;
            this.EmployeesTable.ShowCellToolTips = false;
            this.EmployeesTable.ShowEditingIcon = false;
            this.EmployeesTable.ShowRowErrors = false;
            this.EmployeesTable.Size = new System.Drawing.Size(371, 637);
            this.EmployeesTable.TabIndex = 0;
            this.EmployeesTable.TabStop = false;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnPost
            // 
            this.ColumnPost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPost.HeaderText = "Post";
            this.ColumnPost.MinimumWidth = 6;
            this.ColumnPost.Name = "ColumnPost";
            this.ColumnPost.ReadOnly = true;
            this.ColumnPost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnSalary
            // 
            this.ColumnSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSalary.HeaderText = "Salary";
            this.ColumnSalary.MinimumWidth = 6;
            this.ColumnSalary.Name = "ColumnSalary";
            this.ColumnSalary.ReadOnly = true;
            this.ColumnSalary.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(459, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbConsole
            // 
            this.tbConsole.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbConsole.Location = new System.Drawing.Point(12, 427);
            this.tbConsole.Multiline = true;
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.ReadOnly = true;
            this.tbConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbConsole.Size = new System.Drawing.Size(683, 222);
            this.tbConsole.TabIndex = 4;
            this.tbConsole.TabStop = false;
            // 
            // tbSendRequest
            // 
            this.tbSendRequest.Location = new System.Drawing.Point(108, 403);
            this.tbSendRequest.Name = "tbSendRequest";
            this.tbSendRequest.Size = new System.Drawing.Size(587, 20);
            this.tbSendRequest.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 401);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(90, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(543, 17);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(119, 13);
            this.lbAddress.TabIndex = 7;
            this.lbAddress.Text = "IP:                                :";
            // 
            // btnGetList
            // 
            this.btnGetList.Location = new System.Drawing.Point(378, 41);
            this.btnGetList.Name = "btnGetList";
            this.btnGetList.Size = new System.Drawing.Size(317, 34);
            this.btnGetList.TabIndex = 8;
            this.btnGetList.Text = "Get Employees List";
            this.btnGetList.UseVisualStyleBackColor = true;
            this.btnGetList.Click += new System.EventHandler(this.btnGetList_Click);
            // 
            // btnGetSalary
            // 
            this.btnGetSalary.Location = new System.Drawing.Point(378, 81);
            this.btnGetSalary.Name = "btnGetSalary";
            this.btnGetSalary.Size = new System.Drawing.Size(317, 34);
            this.btnGetSalary.TabIndex = 9;
            this.btnGetSalary.Text = "Get Salary For Selected Employees";
            this.btnGetSalary.UseVisualStyleBackColor = true;
            this.btnGetSalary.Click += new System.EventHandler(this.btnGetSalary_Click);
            // 
            // btnHoursSalary
            // 
            this.btnHoursSalary.Location = new System.Drawing.Point(378, 122);
            this.btnHoursSalary.Name = "btnHoursSalary";
            this.btnHoursSalary.Size = new System.Drawing.Size(317, 34);
            this.btnHoursSalary.TabIndex = 10;
            this.btnHoursSalary.Text = "Add Hour And Selary";
            this.btnHoursSalary.UseVisualStyleBackColor = true;
            // 
            // mtbAddress
            // 
            this.mtbAddress.Location = new System.Drawing.Point(563, 12);
            this.mtbAddress.Name = "mtbAddress";
            this.mtbAddress.Size = new System.Drawing.Size(91, 20);
            this.mtbAddress.TabIndex = 11;
            // 
            // mtbPort
            // 
            this.mtbPort.Location = new System.Drawing.Point(660, 12);
            this.mtbPort.Name = "mtbPort";
            this.mtbPort.Size = new System.Drawing.Size(35, 20);
            this.mtbPort.TabIndex = 12;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(378, 12);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 13;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // mtbSalary
            // 
            this.mtbSalary.Location = new System.Drawing.Point(590, 249);
            this.mtbSalary.Margin = new System.Windows.Forms.Padding(2);
            this.mtbSalary.Mask = "#########";
            this.mtbSalary.Name = "mtbSalary";
            this.mtbSalary.Size = new System.Drawing.Size(105, 20);
            this.mtbSalary.TabIndex = 14;
            // 
            // mtbHours
            // 
            this.mtbHours.Location = new System.Drawing.Point(416, 249);
            this.mtbHours.Margin = new System.Windows.Forms.Padding(2);
            this.mtbHours.Mask = "#########";
            this.mtbHours.Name = "mtbHours";
            this.mtbHours.Size = new System.Drawing.Size(126, 20);
            this.mtbHours.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 251);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Salary";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(378, 186);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(317, 34);
            this.btnAddEmployee.TabIndex = 18;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(416, 226);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(278, 20);
            this.tbName.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Post";
            // 
            // mtbItemPrice
            // 
            this.mtbItemPrice.Location = new System.Drawing.Point(458, 271);
            this.mtbItemPrice.Margin = new System.Windows.Forms.Padding(2);
            this.mtbItemPrice.Mask = "#########";
            this.mtbItemPrice.Name = "mtbItemPrice";
            this.mtbItemPrice.Size = new System.Drawing.Size(84, 20);
            this.mtbItemPrice.TabIndex = 23;
            this.mtbItemPrice.Visible = false;
            // 
            // mtbItemsCount
            // 
            this.mtbItemsCount.AllowPromptAsInput = false;
            this.mtbItemsCount.Location = new System.Drawing.Point(621, 271);
            this.mtbItemsCount.Margin = new System.Windows.Forms.Padding(2);
            this.mtbItemsCount.Mask = "#########";
            this.mtbItemsCount.Name = "mtbItemsCount";
            this.mtbItemsCount.Size = new System.Drawing.Size(74, 20);
            this.mtbItemsCount.TabIndex = 24;
            this.mtbItemsCount.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "ItemPrice";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 274);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "ItemCount";
            this.label6.Visible = false;
            // 
            // mtbContractPrice
            // 
            this.mtbContractPrice.Location = new System.Drawing.Point(458, 272);
            this.mtbContractPrice.Margin = new System.Windows.Forms.Padding(2);
            this.mtbContractPrice.Mask = "############";
            this.mtbContractPrice.Name = "mtbContractPrice";
            this.mtbContractPrice.Size = new System.Drawing.Size(84, 20);
            this.mtbContractPrice.TabIndex = 27;
            this.mtbContractPrice.Visible = false;
            // 
            // mtbContractPercent
            // 
            this.mtbContractPercent.Location = new System.Drawing.Point(622, 271);
            this.mtbContractPercent.Margin = new System.Windows.Forms.Padding(2);
            this.mtbContractPercent.Mask = "##";
            this.mtbContractPercent.Name = "mtbContractPercent";
            this.mtbContractPercent.Size = new System.Drawing.Size(73, 20);
            this.mtbContractPercent.TabIndex = 28;
            this.mtbContractPercent.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 275);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "ContractPrice";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(553, 274);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Contract %";
            this.label8.Visible = false;
            // 
            // cbPosts
            // 
            this.cbPosts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosts.FormattingEnabled = true;
            this.cbPosts.Location = new System.Drawing.Point(417, 162);
            this.cbPosts.Margin = new System.Windows.Forms.Padding(2);
            this.cbPosts.Name = "cbPosts";
            this.cbPosts.Size = new System.Drawing.Size(278, 21);
            this.cbPosts.TabIndex = 31;
            this.cbPosts.SelectedIndexChanged += new System.EventHandler(this.cbPosts_SelectedIndexChanged);
            this.cbPosts.SelectionChangeCommitted += new System.EventHandler(this.cbPosts_SelectionChangeCommitted);
            // 
            // btnDelEmpl
            // 
            this.btnDelEmpl.Location = new System.Drawing.Point(378, 297);
            this.btnDelEmpl.Name = "btnDelEmpl";
            this.btnDelEmpl.Size = new System.Drawing.Size(317, 34);
            this.btnDelEmpl.TabIndex = 32;
            this.btnDelEmpl.Text = "Delete Selected Employee";
            this.btnDelEmpl.UseVisualStyleBackColor = true;
            this.btnDelEmpl.Click += new System.EventHandler(this.btnDelEmpl_Click);
            // 
            // EmployeeController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 660);
            this.Controls.Add(this.btnDelEmpl);
            this.Controls.Add(this.cbPosts);
            this.Controls.Add(this.mtbContractPercent);
            this.Controls.Add(this.mtbContractPrice);
            this.Controls.Add(this.mtbItemsCount);
            this.Controls.Add(this.mtbItemPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.mtbHours);
            this.Controls.Add(this.mtbSalary);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.mtbPort);
            this.Controls.Add(this.mtbAddress);
            this.Controls.Add(this.btnHoursSalary);
            this.Controls.Add(this.btnGetSalary);
            this.Controls.Add(this.btnGetList);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbSendRequest);
            this.Controls.Add(this.tbConsole);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.EmployeesTable);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1100, 699);
            this.MinimumSize = new System.Drawing.Size(1100, 699);
            this.Name = "EmployeeController";
            this.Text = "Employee Control Panel";
            this.Load += new System.EventHandler(this.EmployeeController_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalary;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbConsole;
        private System.Windows.Forms.TextBox tbSendRequest;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Button btnGetList;
        private System.Windows.Forms.Button btnGetSalary;
        private System.Windows.Forms.Button btnHoursSalary;
        private System.Windows.Forms.MaskedTextBox mtbAddress;
        private System.Windows.Forms.MaskedTextBox mtbPort;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.MaskedTextBox mtbSalary;
        private System.Windows.Forms.MaskedTextBox mtbHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbItemPrice;
        private System.Windows.Forms.MaskedTextBox mtbItemsCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtbContractPrice;
        private System.Windows.Forms.MaskedTextBox mtbContractPercent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbPosts;
        private System.Windows.Forms.Button btnDelEmpl;
    }
}

