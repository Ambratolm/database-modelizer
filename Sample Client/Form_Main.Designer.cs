namespace SampleClient
{
    partial class Form_Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_details = new System.Windows.Forms.GroupBox();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.label_gender = new System.Windows.Forms.Label();
            this.dateTimePicker_birthDate = new System.Windows.Forms.DateTimePicker();
            this.label_birthDate = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.groupBox_list = new System.Windows.Forms.GroupBox();
            this.dataGridView_list = new System.Windows.Forms.DataGridView();
            this.groupBox_search = new System.Windows.Forms.GroupBox();
            this.button_clearSearch = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label_search = new System.Windows.Forms.Label();
            this.groupBox_operations = new System.Windows.Forms.GroupBox();
            this.button_previous = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_last = new System.Windows.Forms.Button();
            this.button_first = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.label_current = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.groupBox_details.SuspendLayout();
            this.groupBox_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list)).BeginInit();
            this.groupBox_search.SuspendLayout();
            this.groupBox_operations.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_details
            // 
            this.groupBox_details.Controls.Add(this.comboBox_gender);
            this.groupBox_details.Controls.Add(this.label_gender);
            this.groupBox_details.Controls.Add(this.dateTimePicker_birthDate);
            this.groupBox_details.Controls.Add(this.label_birthDate);
            this.groupBox_details.Controls.Add(this.label_name);
            this.groupBox_details.Controls.Add(this.textBox_name);
            this.groupBox_details.Location = new System.Drawing.Point(15, 12);
            this.groupBox_details.Name = "groupBox_details";
            this.groupBox_details.Size = new System.Drawing.Size(246, 200);
            this.groupBox_details.TabIndex = 0;
            this.groupBox_details.TabStop = false;
            this.groupBox_details.Text = "Details";
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gender.Location = new System.Drawing.Point(23, 95);
            this.comboBox_gender.MaxDropDownItems = 2;
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(203, 21);
            this.comboBox_gender.TabIndex = 3;
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Location = new System.Drawing.Point(23, 79);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(46, 13);
            this.label_gender.TabIndex = 2;
            this.label_gender.Text = "Gender:";
            // 
            // dateTimePicker_birthDate
            // 
            this.dateTimePicker_birthDate.Location = new System.Drawing.Point(26, 155);
            this.dateTimePicker_birthDate.Name = "dateTimePicker_birthDate";
            this.dateTimePicker_birthDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_birthDate.TabIndex = 5;
            this.dateTimePicker_birthDate.Value = new System.DateTime(1979, 1, 1, 0, 0, 0, 0);
            // 
            // label_birthDate
            // 
            this.label_birthDate.AutoSize = true;
            this.label_birthDate.Location = new System.Drawing.Point(23, 139);
            this.label_birthDate.Name = "label_birthDate";
            this.label_birthDate.Size = new System.Drawing.Size(59, 13);
            this.label_birthDate.TabIndex = 4;
            this.label_birthDate.Text = "Birth Date:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(20, 26);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(38, 13);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(23, 42);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(203, 20);
            this.textBox_name.TabIndex = 1;
            // 
            // groupBox_list
            // 
            this.groupBox_list.Controls.Add(this.dataGridView_list);
            this.groupBox_list.Location = new System.Drawing.Point(267, 96);
            this.groupBox_list.Name = "groupBox_list";
            this.groupBox_list.Size = new System.Drawing.Size(379, 332);
            this.groupBox_list.TabIndex = 3;
            this.groupBox_list.TabStop = false;
            this.groupBox_list.Text = "List";
            // 
            // dataGridView_list
            // 
            this.dataGridView_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_list.Location = new System.Drawing.Point(14, 19);
            this.dataGridView_list.Name = "dataGridView_list";
            this.dataGridView_list.Size = new System.Drawing.Size(349, 307);
            this.dataGridView_list.TabIndex = 0;
            this.dataGridView_list.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_list_RowEnter);
            // 
            // groupBox_search
            // 
            this.groupBox_search.Controls.Add(this.button_clearSearch);
            this.groupBox_search.Controls.Add(this.button_search);
            this.groupBox_search.Controls.Add(this.textBox_search);
            this.groupBox_search.Controls.Add(this.label_search);
            this.groupBox_search.Location = new System.Drawing.Point(267, 12);
            this.groupBox_search.Name = "groupBox_search";
            this.groupBox_search.Size = new System.Drawing.Size(379, 78);
            this.groupBox_search.TabIndex = 2;
            this.groupBox_search.TabStop = false;
            this.groupBox_search.Text = "Search";
            // 
            // button_clearSearch
            // 
            this.button_clearSearch.Location = new System.Drawing.Point(259, 35);
            this.button_clearSearch.Name = "button_clearSearch";
            this.button_clearSearch.Size = new System.Drawing.Size(23, 23);
            this.button_clearSearch.TabIndex = 2;
            this.button_clearSearch.Text = "X";
            this.button_clearSearch.UseVisualStyleBackColor = true;
            this.button_clearSearch.Click += new System.EventHandler(this.button_clearSearch_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(288, 35);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 3;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(14, 37);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(239, 20);
            this.textBox_search.TabIndex = 1;
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Location = new System.Drawing.Point(11, 21);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(74, 13);
            this.label_search.TabIndex = 0;
            this.label_search.Text = "Search Name:";
            // 
            // groupBox_operations
            // 
            this.groupBox_operations.Controls.Add(this.button_previous);
            this.groupBox_operations.Controls.Add(this.button_next);
            this.groupBox_operations.Controls.Add(this.button_last);
            this.groupBox_operations.Controls.Add(this.button_first);
            this.groupBox_operations.Controls.Add(this.button_delete);
            this.groupBox_operations.Controls.Add(this.button_update);
            this.groupBox_operations.Controls.Add(this.label_current);
            this.groupBox_operations.Controls.Add(this.button_add);
            this.groupBox_operations.Location = new System.Drawing.Point(15, 218);
            this.groupBox_operations.Name = "groupBox_operations";
            this.groupBox_operations.Size = new System.Drawing.Size(246, 210);
            this.groupBox_operations.TabIndex = 1;
            this.groupBox_operations.TabStop = false;
            this.groupBox_operations.Text = "Operations";
            // 
            // button_previous
            // 
            this.button_previous.Location = new System.Drawing.Point(80, 66);
            this.button_previous.Name = "button_previous";
            this.button_previous.Size = new System.Drawing.Size(40, 23);
            this.button_previous.TabIndex = 2;
            this.button_previous.Text = "<";
            this.button_previous.UseVisualStyleBackColor = true;
            this.button_previous.Click += new System.EventHandler(this.button_previous_Click);
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(126, 66);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(40, 23);
            this.button_next.TabIndex = 3;
            this.button_next.Text = ">";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_last
            // 
            this.button_last.Location = new System.Drawing.Point(172, 66);
            this.button_last.Name = "button_last";
            this.button_last.Size = new System.Drawing.Size(40, 23);
            this.button_last.TabIndex = 4;
            this.button_last.Text = ">|";
            this.button_last.UseVisualStyleBackColor = true;
            this.button_last.Click += new System.EventHandler(this.button_last_Click);
            // 
            // button_first
            // 
            this.button_first.Location = new System.Drawing.Point(34, 66);
            this.button_first.Name = "button_first";
            this.button_first.Size = new System.Drawing.Size(40, 23);
            this.button_first.TabIndex = 1;
            this.button_first.Text = "|<";
            this.button_first.UseVisualStyleBackColor = true;
            this.button_first.Click += new System.EventHandler(this.button_first_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(159, 105);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(53, 23);
            this.button_delete.TabIndex = 7;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(92, 105);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(61, 23);
            this.button_update.TabIndex = 6;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label_current
            // 
            this.label_current.AutoSize = true;
            this.label_current.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label_current.Location = new System.Drawing.Point(31, 36);
            this.label_current.Name = "label_current";
            this.label_current.Size = new System.Drawing.Size(68, 13);
            this.label_current.TabIndex = 0;
            this.label_current.Text = "<Current>";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(34, 105);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(52, 23);
            this.button_add.TabIndex = 5;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 440);
            this.Controls.Add(this.groupBox_operations);
            this.Controls.Add(this.groupBox_search);
            this.Controls.Add(this.groupBox_list);
            this.Controls.Add(this.groupBox_details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sample Client";
            this.groupBox_details.ResumeLayout(false);
            this.groupBox_details.PerformLayout();
            this.groupBox_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_list)).EndInit();
            this.groupBox_search.ResumeLayout(false);
            this.groupBox_search.PerformLayout();
            this.groupBox_operations.ResumeLayout(false);
            this.groupBox_operations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_details;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.DateTimePicker dateTimePicker_birthDate;
        private System.Windows.Forms.Label label_birthDate;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.GroupBox groupBox_list;
        private System.Windows.Forms.DataGridView dataGridView_list;
        private System.Windows.Forms.GroupBox groupBox_search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.GroupBox groupBox_operations;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label_current;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_previous;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_last;
        private System.Windows.Forms.Button button_first;
        private System.Windows.Forms.Button button_clearSearch;
    }
}

