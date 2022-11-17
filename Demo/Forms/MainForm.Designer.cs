
namespace Demo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dgEvent = new System.Windows.Forms.DataGridView();
            this.мероприятияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.piniginiaDataSet = new Demo.piniginiaDataSet();
            this.мероприятияTableAdapter = new Demo.piniginiaDataSetTableAdapters.МероприятияTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEvent = new System.Windows.Forms.ComboBox();
            this.cbDate = new System.Windows.Forms.ComboBox();
            this.btRegistration = new System.Windows.Forms.Button();
            this.btInfoActivity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мероприятияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piniginiaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEvent
            // 
            this.dgEvent.AllowUserToAddRows = false;
            this.dgEvent.AllowUserToDeleteRows = false;
            this.dgEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEvent.Location = new System.Drawing.Point(12, 44);
            this.dgEvent.Name = "dgEvent";
            this.dgEvent.ReadOnly = true;
            this.dgEvent.Size = new System.Drawing.Size(612, 370);
            this.dgEvent.TabIndex = 0;
            // 
            // мероприятияBindingSource
            // 
            this.мероприятияBindingSource.DataMember = "Мероприятия";
            this.мероприятияBindingSource.DataSource = this.piniginiaDataSet;
            // 
            // piniginiaDataSet
            // 
            this.piniginiaDataSet.DataSetName = "piniginiaDataSet";
            this.piniginiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // мероприятияTableAdapter
            // 
            this.мероприятияTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фильтрация по событию:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фильтрация по дате:";
            // 
            // cbEvent
            // 
            this.cbEvent.FormattingEnabled = true;
            this.cbEvent.Location = new System.Drawing.Point(156, 10);
            this.cbEvent.Name = "cbEvent";
            this.cbEvent.Size = new System.Drawing.Size(121, 21);
            this.cbEvent.TabIndex = 3;
            this.cbEvent.SelectedIndexChanged += new System.EventHandler(this.cbEvent_SelectedIndexChanged);
            // 
            // cbDate
            // 
            this.cbDate.FormattingEnabled = true;
            this.cbDate.Location = new System.Drawing.Point(437, 10);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(121, 21);
            this.cbDate.TabIndex = 4;
            this.cbDate.SelectedIndexChanged += new System.EventHandler(this.cbDate_SelectedIndexChanged);
            // 
            // btRegistration
            // 
            this.btRegistration.Location = new System.Drawing.Point(705, 34);
            this.btRegistration.Name = "btRegistration";
            this.btRegistration.Size = new System.Drawing.Size(164, 44);
            this.btRegistration.TabIndex = 5;
            this.btRegistration.Text = "Авторизация";
            this.btRegistration.UseVisualStyleBackColor = true;
            this.btRegistration.Click += new System.EventHandler(this.btRegistration_Click);
            // 
            // btInfoActivity
            // 
            this.btInfoActivity.Location = new System.Drawing.Point(705, 99);
            this.btInfoActivity.Name = "btInfoActivity";
            this.btInfoActivity.Size = new System.Drawing.Size(164, 44);
            this.btInfoActivity.TabIndex = 6;
            this.btInfoActivity.Text = "Подробная информация о мероприятиях";
            this.btInfoActivity.UseVisualStyleBackColor = true;
            this.btInfoActivity.Click += new System.EventHandler(this.btInfoActivity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.btInfoActivity);
            this.Controls.Add(this.btRegistration);
            this.Controls.Add(this.cbDate);
            this.Controls.Add(this.cbEvent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgEvent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мероприятияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piniginiaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEvent;
        private piniginiaDataSet piniginiaDataSet;
        private System.Windows.Forms.BindingSource мероприятияBindingSource;
        private piniginiaDataSetTableAdapters.МероприятияTableAdapter мероприятияTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEvent;
        private System.Windows.Forms.ComboBox cbDate;
        private System.Windows.Forms.Button btRegistration;
        private System.Windows.Forms.Button btInfoActivity;
    }
}

