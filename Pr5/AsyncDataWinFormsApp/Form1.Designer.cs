
namespace AsyncDataWinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAuthor = new TextBox();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnAddBook = new Button();
            listBooks = new ListBox();
            btnLoadBooks = new Button();
            btnLoadUsers = new Button();
            listUsers = new ListBox();
            btnAddUser = new Button();
            label4 = new Label();
            txtNameUser = new TextBox();
            txtBookIds = new TextBox();
            label3 = new Label();
            numPrice = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            numUserId = new NumericUpDown();
            btnAddOrder = new Button();
            btnLoadOrders = new Button();
            listOrders = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUserId).BeginInit();
            SuspendLayout();
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(129, 47);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(125, 27);
            txtAuthor.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(129, 14);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(111, 23);
            label1.TabIndex = 2;
            label1.Text = "Назва книги:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 3;
            label2.Text = "Автор:";
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(277, 28);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(137, 29);
            btnAddBook.TabIndex = 4;
            btnAddBook.Text = "Додати книгу";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // listBooks
            // 
            listBooks.FormattingEnabled = true;
            listBooks.Location = new Point(12, 92);
            listBooks.Name = "listBooks";
            listBooks.Size = new Size(415, 104);
            listBooks.TabIndex = 5;
            // 
            // btnLoadBooks
            // 
            btnLoadBooks.Location = new Point(433, 113);
            btnLoadBooks.Name = "btnLoadBooks";
            btnLoadBooks.Size = new Size(85, 59);
            btnLoadBooks.TabIndex = 6;
            btnLoadBooks.Text = "Оновити список";
            btnLoadBooks.UseVisualStyleBackColor = true;
            btnLoadBooks.Click += btnLoadBooks_Click;
            // 
            // btnLoadUsers
            // 
            btnLoadUsers.Location = new Point(979, 111);
            btnLoadUsers.Name = "btnLoadUsers";
            btnLoadUsers.Size = new Size(84, 63);
            btnLoadUsers.TabIndex = 13;
            btnLoadUsers.Text = "Оновити список";
            btnLoadUsers.UseVisualStyleBackColor = true;
            btnLoadUsers.Click += btnLoadUsers_Click;
            // 
            // listUsers
            // 
            listUsers.FormattingEnabled = true;
            listUsers.Location = new Point(594, 92);
            listUsers.Name = "listUsers";
            listUsers.Size = new Size(379, 104);
            listUsers.TabIndex = 12;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(887, 15);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(170, 29);
            btnAddUser.TabIndex = 11;
            btnAddUser.Text = "Додати користувача";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(594, 15);
            label4.Name = "label4";
            label4.Size = new Size(44, 23);
            label4.TabIndex = 9;
            label4.Text = "Ім'я:";
            // 
            // txtNameUser
            // 
            txtNameUser.Location = new Point(711, 14);
            txtNameUser.Name = "txtNameUser";
            txtNameUser.Size = new Size(125, 27);
            txtNameUser.TabIndex = 8;
            // 
            // txtBookIds
            // 
            txtBookIds.Location = new Point(129, 305);
            txtBookIds.Name = "txtBookIds";
            txtBookIds.Size = new Size(125, 27);
            txtBookIds.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 309);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 15;
            label3.Text = "Книги:";
            // 
            // numPrice
            // 
            numPrice.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numPrice.Location = new Point(129, 338);
            numPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(125, 27);
            numPrice.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(12, 342);
            label5.Name = "label5";
            label5.Size = new Size(50, 23);
            label5.TabIndex = 17;
            label5.Text = "Ціна:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(12, 272);
            label6.Name = "label6";
            label6.Size = new Size(105, 23);
            label6.TabIndex = 18;
            label6.Text = "Користувач:";
            // 
            // numUserId
            // 
            numUserId.Location = new Point(129, 272);
            numUserId.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numUserId.Name = "numUserId";
            numUserId.Size = new Size(125, 27);
            numUserId.TabIndex = 19;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(25, 387);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(201, 29);
            btnAddOrder.TabIndex = 20;
            btnAddOrder.Text = "Створити замовлення";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // btnLoadOrders
            // 
            btnLoadOrders.Location = new Point(878, 342);
            btnLoadOrders.Name = "btnLoadOrders";
            btnLoadOrders.Size = new Size(117, 49);
            btnLoadOrders.TabIndex = 21;
            btnLoadOrders.Text = "Оновити замовлення";
            btnLoadOrders.UseVisualStyleBackColor = true;
            btnLoadOrders.Click += btnLoadOrders_Click_1;
            // 
            // listOrders
            // 
            listOrders.FormattingEnabled = true;
            listOrders.Location = new Point(310, 272);
            listOrders.Name = "listOrders";
            listOrders.Size = new Size(526, 184);
            listOrders.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 463);
            Controls.Add(listOrders);
            Controls.Add(btnLoadOrders);
            Controls.Add(btnAddOrder);
            Controls.Add(numUserId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(numPrice);
            Controls.Add(label3);
            Controls.Add(txtBookIds);
            Controls.Add(btnLoadUsers);
            Controls.Add(listUsers);
            Controls.Add(btnAddUser);
            Controls.Add(label4);
            Controls.Add(txtNameUser);
            Controls.Add(btnLoadBooks);
            Controls.Add(listBooks);
            Controls.Add(btnAddBook);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(txtAuthor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUserId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private TextBox txtAuthor;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private Button btnAddBook;
        private ListBox listBooks;
        private Button btnLoadBooks;
        private Button btnLoadUsers;
        private ListBox listUsers;
        private Button btnAddUser;
        private Label label4;
        private TextBox txtNameUser;
        private TextBox txtBookIds;
        private Label label3;
        private NumericUpDown numPrice;
        private Label label5;
        private Label label6;
        private NumericUpDown numUserId;
        private Button btnAddOrder;
        private Button btnLoadOrders;
        private ListBox listOrders;
    }
}
