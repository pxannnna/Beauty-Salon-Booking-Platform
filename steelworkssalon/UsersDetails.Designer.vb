<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsersDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsersDetails))
        Me.tbx_username = New System.Windows.Forms.TextBox()
        Me.tbx_name = New System.Windows.Forms.TextBox()
        Me.tbx_tel = New System.Windows.Forms.TextBox()
        Me.tbx_surname = New System.Windows.Forms.TextBox()
        Me.cbx_title = New System.Windows.Forms.ComboBox()
        Me.tbx_email = New System.Windows.Forms.TextBox()
        Me.tbx_age = New System.Windows.Forms.TextBox()
        Me.Username = New System.Windows.Forms.Label()
        Me.tbx_allergies = New System.Windows.Forms.TextBox()
        Me.tbx_addinfo = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_addnew = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_saveedit = New System.Windows.Forms.Button()
        Me.dgv_customers = New System.Windows.Forms.DataGridView()
        Me.dgv_staff = New System.Windows.Forms.DataGridView()
        Me.btn_edit2 = New System.Windows.Forms.Button()
        Me.btn_delete2 = New System.Windows.Forms.Button()
        Me.btn_save2 = New System.Windows.Forms.Button()
        Me.btn_add2 = New System.Windows.Forms.Button()
        Me.tbx_salary = New System.Windows.Forms.TextBox()
        Me.tbx_email2 = New System.Windows.Forms.TextBox()
        Me.cbx_title2 = New System.Windows.Forms.ComboBox()
        Me.tbx_surname2 = New System.Windows.Forms.TextBox()
        Me.tbx_tel2 = New System.Windows.Forms.TextBox()
        Me.tbx_name2 = New System.Windows.Forms.TextBox()
        Me.tbx_username2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_first = New System.Windows.Forms.Button()
        Me.btn_last = New System.Windows.Forms.Button()
        Me.btn_prev = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_next2 = New System.Windows.Forms.Button()
        Me.btn_prev2 = New System.Windows.Forms.Button()
        Me.btn_last2 = New System.Windows.Forms.Button()
        Me.btn_first2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.btn_search2 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbx_customerid = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbx_staffid = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbx_customerid2 = New System.Windows.Forms.TextBox()
        Me.tbx_staffid2 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbl_1 = New System.Windows.Forms.Label()
        Me.lbl_2 = New System.Windows.Forms.Label()
        CType(Me.dgv_customers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbx_username
        '
        Me.tbx_username.Location = New System.Drawing.Point(27, 239)
        Me.tbx_username.Name = "tbx_username"
        Me.tbx_username.Size = New System.Drawing.Size(100, 20)
        Me.tbx_username.TabIndex = 0
        '
        'tbx_name
        '
        Me.tbx_name.Location = New System.Drawing.Point(263, 240)
        Me.tbx_name.Name = "tbx_name"
        Me.tbx_name.Size = New System.Drawing.Size(100, 20)
        Me.tbx_name.TabIndex = 2
        '
        'tbx_tel
        '
        Me.tbx_tel.Location = New System.Drawing.Point(501, 240)
        Me.tbx_tel.Name = "tbx_tel"
        Me.tbx_tel.Size = New System.Drawing.Size(100, 20)
        Me.tbx_tel.TabIndex = 4
        '
        'tbx_surname
        '
        Me.tbx_surname.Location = New System.Drawing.Point(382, 240)
        Me.tbx_surname.Name = "tbx_surname"
        Me.tbx_surname.Size = New System.Drawing.Size(100, 20)
        Me.tbx_surname.TabIndex = 3
        '
        'cbx_title
        '
        Me.cbx_title.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_title.FormattingEnabled = True
        Me.cbx_title.Items.AddRange(New Object() {"Mr", "Ms", "Miss", "Mrs", "Dr"})
        Me.cbx_title.Location = New System.Drawing.Point(146, 239)
        Me.cbx_title.Name = "cbx_title"
        Me.cbx_title.Size = New System.Drawing.Size(98, 21)
        Me.cbx_title.TabIndex = 1
        '
        'tbx_email
        '
        Me.tbx_email.Location = New System.Drawing.Point(620, 240)
        Me.tbx_email.Name = "tbx_email"
        Me.tbx_email.Size = New System.Drawing.Size(100, 20)
        Me.tbx_email.TabIndex = 5
        '
        'tbx_age
        '
        Me.tbx_age.Location = New System.Drawing.Point(739, 240)
        Me.tbx_age.Name = "tbx_age"
        Me.tbx_age.Size = New System.Drawing.Size(100, 20)
        Me.tbx_age.TabIndex = 6
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Username.Location = New System.Drawing.Point(29, 211)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(77, 16)
        Me.Username.TabIndex = 8
        Me.Username.Text = "Username"
        '
        'tbx_allergies
        '
        Me.tbx_allergies.Location = New System.Drawing.Point(858, 240)
        Me.tbx_allergies.Name = "tbx_allergies"
        Me.tbx_allergies.Size = New System.Drawing.Size(100, 20)
        Me.tbx_allergies.TabIndex = 7
        '
        'tbx_addinfo
        '
        Me.tbx_addinfo.Location = New System.Drawing.Point(977, 240)
        Me.tbx_addinfo.Name = "tbx_addinfo"
        Me.tbx_addinfo.Size = New System.Drawing.Size(100, 20)
        Me.tbx_addinfo.TabIndex = 8
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(306, 279)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(206, 23)
        Me.btn_save.TabIndex = 20
        Me.btn_save.Text = "Save New"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_addnew
        '
        Me.btn_addnew.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_addnew.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addnew.ForeColor = System.Drawing.Color.White
        Me.btn_addnew.Location = New System.Drawing.Point(34, 279)
        Me.btn_addnew.Name = "btn_addnew"
        Me.btn_addnew.Size = New System.Drawing.Size(206, 23)
        Me.btn_addnew.TabIndex = 19
        Me.btn_addnew.Text = "Add New"
        Me.btn_addnew.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(581, 279)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(206, 23)
        Me.btn_delete.TabIndex = 21
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_saveedit
        '
        Me.btn_saveedit.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_saveedit.ForeColor = System.Drawing.Color.White
        Me.btn_saveedit.Location = New System.Drawing.Point(847, 279)
        Me.btn_saveedit.Name = "btn_saveedit"
        Me.btn_saveedit.Size = New System.Drawing.Size(206, 23)
        Me.btn_saveedit.TabIndex = 22
        Me.btn_saveedit.Text = "Save Edit"
        Me.btn_saveedit.UseVisualStyleBackColor = False
        '
        'dgv_customers
        '
        Me.dgv_customers.AllowUserToAddRows = False
        Me.dgv_customers.AllowUserToDeleteRows = False
        Me.dgv_customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_customers.Location = New System.Drawing.Point(24, 45)
        Me.dgv_customers.Name = "dgv_customers"
        Me.dgv_customers.ReadOnly = True
        Me.dgv_customers.Size = New System.Drawing.Size(1042, 150)
        Me.dgv_customers.TabIndex = 24
        '
        'dgv_staff
        '
        Me.dgv_staff.AllowUserToAddRows = False
        Me.dgv_staff.AllowUserToDeleteRows = False
        Me.dgv_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_staff.Location = New System.Drawing.Point(24, 372)
        Me.dgv_staff.Name = "dgv_staff"
        Me.dgv_staff.ReadOnly = True
        Me.dgv_staff.Size = New System.Drawing.Size(1052, 106)
        Me.dgv_staff.TabIndex = 49
        '
        'btn_edit2
        '
        Me.btn_edit2.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_edit2.ForeColor = System.Drawing.Color.White
        Me.btn_edit2.Location = New System.Drawing.Point(838, 575)
        Me.btn_edit2.Name = "btn_edit2"
        Me.btn_edit2.Size = New System.Drawing.Size(206, 23)
        Me.btn_edit2.TabIndex = 27
        Me.btn_edit2.Text = "Save Edit"
        Me.btn_edit2.UseVisualStyleBackColor = False
        '
        'btn_delete2
        '
        Me.btn_delete2.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_delete2.ForeColor = System.Drawing.Color.White
        Me.btn_delete2.Location = New System.Drawing.Point(582, 575)
        Me.btn_delete2.Name = "btn_delete2"
        Me.btn_delete2.Size = New System.Drawing.Size(206, 23)
        Me.btn_delete2.TabIndex = 26
        Me.btn_delete2.Text = "Delete"
        Me.btn_delete2.UseVisualStyleBackColor = False
        '
        'btn_save2
        '
        Me.btn_save2.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_save2.ForeColor = System.Drawing.Color.White
        Me.btn_save2.Location = New System.Drawing.Point(307, 575)
        Me.btn_save2.Name = "btn_save2"
        Me.btn_save2.Size = New System.Drawing.Size(206, 23)
        Me.btn_save2.TabIndex = 25
        Me.btn_save2.Text = "Save New"
        Me.btn_save2.UseVisualStyleBackColor = False
        '
        'btn_add2
        '
        Me.btn_add2.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_add2.ForeColor = System.Drawing.Color.White
        Me.btn_add2.Location = New System.Drawing.Point(25, 575)
        Me.btn_add2.Name = "btn_add2"
        Me.btn_add2.Size = New System.Drawing.Size(206, 23)
        Me.btn_add2.TabIndex = 24
        Me.btn_add2.Text = "Add New"
        Me.btn_add2.UseVisualStyleBackColor = False
        '
        'tbx_salary
        '
        Me.tbx_salary.Location = New System.Drawing.Point(739, 526)
        Me.tbx_salary.Name = "tbx_salary"
        Me.tbx_salary.Size = New System.Drawing.Size(100, 20)
        Me.tbx_salary.TabIndex = 17
        '
        'tbx_email2
        '
        Me.tbx_email2.Location = New System.Drawing.Point(617, 526)
        Me.tbx_email2.Name = "tbx_email2"
        Me.tbx_email2.Size = New System.Drawing.Size(100, 20)
        Me.tbx_email2.TabIndex = 16
        '
        'cbx_title2
        '
        Me.cbx_title2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_title2.FormattingEnabled = True
        Me.cbx_title2.ItemHeight = 13
        Me.cbx_title2.Items.AddRange(New Object() {"Mr", "Ms", "Miss", "Mrs", "Dr"})
        Me.cbx_title2.Location = New System.Drawing.Point(131, 525)
        Me.cbx_title2.Name = "cbx_title2"
        Me.cbx_title2.Size = New System.Drawing.Size(98, 21)
        Me.cbx_title2.TabIndex = 30
        '
        'tbx_surname2
        '
        Me.tbx_surname2.Location = New System.Drawing.Point(373, 526)
        Me.tbx_surname2.Name = "tbx_surname2"
        Me.tbx_surname2.Size = New System.Drawing.Size(100, 20)
        Me.tbx_surname2.TabIndex = 14
        '
        'tbx_tel2
        '
        Me.tbx_tel2.Location = New System.Drawing.Point(495, 525)
        Me.tbx_tel2.Name = "tbx_tel2"
        Me.tbx_tel2.Size = New System.Drawing.Size(100, 20)
        Me.tbx_tel2.TabIndex = 15
        '
        'tbx_name2
        '
        Me.tbx_name2.Location = New System.Drawing.Point(251, 526)
        Me.tbx_name2.Name = "tbx_name2"
        Me.tbx_name2.Size = New System.Drawing.Size(100, 20)
        Me.tbx_name2.TabIndex = 13
        '
        'tbx_username2
        '
        Me.tbx_username2.Location = New System.Drawing.Point(18, 526)
        Me.tbx_username2.Name = "tbx_username2"
        Me.tbx_username2.Size = New System.Drawing.Size(100, 20)
        Me.tbx_username2.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(144, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Location = New System.Drawing.Point(260, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label3.Location = New System.Drawing.Point(379, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Surname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label4.Location = New System.Drawing.Point(498, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 16)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Phone Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label5.Location = New System.Drawing.Point(617, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 16)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label6.Location = New System.Drawing.Point(736, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 16)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Age"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label7.Location = New System.Drawing.Point(855, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 16)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Allergies"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label8.Location = New System.Drawing.Point(974, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 39)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Additional Information"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label11.Location = New System.Drawing.Point(745, 498)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 16)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Salary"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label12.Location = New System.Drawing.Point(619, 497)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 16)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "Email"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label13.Location = New System.Drawing.Point(497, 498)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 16)
        Me.Label13.TabIndex = 64
        Me.Label13.Text = "Phone Number"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label14.Location = New System.Drawing.Point(375, 498)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 16)
        Me.Label14.TabIndex = 63
        Me.Label14.Text = "Surname"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label15.Location = New System.Drawing.Point(253, 497)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 16)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "Name"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label16.Location = New System.Drawing.Point(136, 498)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 16)
        Me.Label16.TabIndex = 61
        Me.Label16.Text = "Title"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label18.Location = New System.Drawing.Point(24, 499)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(77, 16)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "Username"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1356, 624)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(38, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 67
        Me.PictureBox2.TabStop = False
        '
        'btn_first
        '
        Me.btn_first.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_first.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_first.ForeColor = System.Drawing.Color.White
        Me.btn_first.Location = New System.Drawing.Point(1082, 72)
        Me.btn_first.Name = "btn_first"
        Me.btn_first.Size = New System.Drawing.Size(92, 23)
        Me.btn_first.TabIndex = 68
        Me.btn_first.Text = "|<"
        Me.btn_first.UseVisualStyleBackColor = False
        '
        'btn_last
        '
        Me.btn_last.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_last.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_last.ForeColor = System.Drawing.Color.White
        Me.btn_last.Location = New System.Drawing.Point(1197, 72)
        Me.btn_last.Name = "btn_last"
        Me.btn_last.Size = New System.Drawing.Size(92, 23)
        Me.btn_last.TabIndex = 69
        Me.btn_last.Text = ">|"
        Me.btn_last.UseVisualStyleBackColor = False
        '
        'btn_prev
        '
        Me.btn_prev.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_prev.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_prev.ForeColor = System.Drawing.Color.White
        Me.btn_prev.Location = New System.Drawing.Point(1082, 121)
        Me.btn_prev.Name = "btn_prev"
        Me.btn_prev.Size = New System.Drawing.Size(92, 23)
        Me.btn_prev.TabIndex = 70
        Me.btn_prev.Text = "<<"
        Me.btn_prev.UseVisualStyleBackColor = False
        '
        'btn_next
        '
        Me.btn_next.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_next.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.ForeColor = System.Drawing.Color.White
        Me.btn_next.Location = New System.Drawing.Point(1197, 121)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(92, 23)
        Me.btn_next.TabIndex = 71
        Me.btn_next.Text = ">>"
        Me.btn_next.UseVisualStyleBackColor = False
        '
        'btn_next2
        '
        Me.btn_next2.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_next2.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next2.ForeColor = System.Drawing.Color.White
        Me.btn_next2.Location = New System.Drawing.Point(1197, 455)
        Me.btn_next2.Name = "btn_next2"
        Me.btn_next2.Size = New System.Drawing.Size(92, 23)
        Me.btn_next2.TabIndex = 75
        Me.btn_next2.Text = ">>"
        Me.btn_next2.UseVisualStyleBackColor = False
        '
        'btn_prev2
        '
        Me.btn_prev2.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_prev2.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_prev2.ForeColor = System.Drawing.Color.White
        Me.btn_prev2.Location = New System.Drawing.Point(1082, 455)
        Me.btn_prev2.Name = "btn_prev2"
        Me.btn_prev2.Size = New System.Drawing.Size(92, 23)
        Me.btn_prev2.TabIndex = 74
        Me.btn_prev2.Text = "<<"
        Me.btn_prev2.UseVisualStyleBackColor = False
        '
        'btn_last2
        '
        Me.btn_last2.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_last2.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_last2.ForeColor = System.Drawing.Color.White
        Me.btn_last2.Location = New System.Drawing.Point(1197, 406)
        Me.btn_last2.Name = "btn_last2"
        Me.btn_last2.Size = New System.Drawing.Size(92, 23)
        Me.btn_last2.TabIndex = 73
        Me.btn_last2.Text = ">|"
        Me.btn_last2.UseVisualStyleBackColor = False
        '
        'btn_first2
        '
        Me.btn_first2.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_first2.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_first2.ForeColor = System.Drawing.Color.White
        Me.btn_first2.Location = New System.Drawing.Point(1082, 406)
        Me.btn_first2.Name = "btn_first2"
        Me.btn_first2.Size = New System.Drawing.Size(92, 23)
        Me.btn_first2.TabIndex = 72
        Me.btn_first2.Text = "|<"
        Me.btn_first2.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label9.Location = New System.Drawing.Point(28, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(199, 23)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Customers Details"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label10.Location = New System.Drawing.Point(20, 334)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 23)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Staff Details"
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_search.ForeColor = System.Drawing.Color.White
        Me.btn_search.Location = New System.Drawing.Point(1085, 279)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(206, 23)
        Me.btn_search.TabIndex = 23
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'btn_search2
        '
        Me.btn_search2.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_search2.ForeColor = System.Drawing.Color.White
        Me.btn_search2.Location = New System.Drawing.Point(1086, 575)
        Me.btn_search2.Name = "btn_search2"
        Me.btn_search2.Size = New System.Drawing.Size(206, 23)
        Me.btn_search2.TabIndex = 28
        Me.btn_search2.Text = "Search"
        Me.btn_search2.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label19.Location = New System.Drawing.Point(1083, 211)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(92, 16)
        Me.Label19.TabIndex = 81
        Me.Label19.Text = "CustomerID"
        '
        'tbx_customerid
        '
        Me.tbx_customerid.Location = New System.Drawing.Point(1086, 240)
        Me.tbx_customerid.Name = "tbx_customerid"
        Me.tbx_customerid.Size = New System.Drawing.Size(100, 20)
        Me.tbx_customerid.TabIndex = 10
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label20.Location = New System.Drawing.Point(855, 497)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 16)
        Me.Label20.TabIndex = 83
        Me.Label20.Text = "StaffID"
        '
        'tbx_staffid
        '
        Me.tbx_staffid.Location = New System.Drawing.Point(858, 526)
        Me.tbx_staffid.Name = "tbx_staffid"
        Me.tbx_staffid.Size = New System.Drawing.Size(100, 20)
        Me.tbx_staffid.TabIndex = 18
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label17.Location = New System.Drawing.Point(1258, 198)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(150, 65)
        Me.Label17.TabIndex = 85
        Me.Label17.Text = "Enter CustomerID to search:"
        '
        'tbx_customerid2
        '
        Me.tbx_customerid2.Location = New System.Drawing.Point(1261, 240)
        Me.tbx_customerid2.Name = "tbx_customerid2"
        Me.tbx_customerid2.Size = New System.Drawing.Size(100, 20)
        Me.tbx_customerid2.TabIndex = 84
        '
        'tbx_staffid2
        '
        Me.tbx_staffid2.Location = New System.Drawing.Point(1261, 539)
        Me.tbx_staffid2.Name = "tbx_staffid2"
        Me.tbx_staffid2.Size = New System.Drawing.Size(100, 20)
        Me.tbx_staffid2.TabIndex = 86
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label21.Location = New System.Drawing.Point(1258, 497)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(150, 65)
        Me.Label21.TabIndex = 87
        Me.Label21.Text = "Enter StaffID to search:"
        '
        'lbl_1
        '
        Me.lbl_1.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lbl_1.Location = New System.Drawing.Point(1108, 305)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(168, 65)
        Me.lbl_1.TabIndex = 88
        Me.lbl_1.Text = "Enter either CustomerID or Username to search"
        Me.lbl_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_2
        '
        Me.lbl_2.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lbl_2.Location = New System.Drawing.Point(1108, 601)
        Me.lbl_2.Name = "lbl_2"
        Me.lbl_2.Size = New System.Drawing.Size(168, 65)
        Me.lbl_2.TabIndex = 89
        Me.lbl_2.Text = "Enter either StaffID or Username to search"
        Me.lbl_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'UsersDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1406, 672)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_2)
        Me.Controls.Add(Me.lbl_1)
        Me.Controls.Add(Me.tbx_staffid2)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.tbx_customerid2)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.tbx_staffid)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.tbx_customerid)
        Me.Controls.Add(Me.btn_search2)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_next2)
        Me.Controls.Add(Me.btn_prev2)
        Me.Controls.Add(Me.btn_last2)
        Me.Controls.Add(Me.btn_first2)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.btn_prev)
        Me.Controls.Add(Me.btn_last)
        Me.Controls.Add(Me.btn_first)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_staff)
        Me.Controls.Add(Me.btn_edit2)
        Me.Controls.Add(Me.btn_delete2)
        Me.Controls.Add(Me.btn_save2)
        Me.Controls.Add(Me.btn_add2)
        Me.Controls.Add(Me.tbx_salary)
        Me.Controls.Add(Me.tbx_email2)
        Me.Controls.Add(Me.cbx_title2)
        Me.Controls.Add(Me.tbx_surname2)
        Me.Controls.Add(Me.tbx_tel2)
        Me.Controls.Add(Me.tbx_name2)
        Me.Controls.Add(Me.tbx_username2)
        Me.Controls.Add(Me.dgv_customers)
        Me.Controls.Add(Me.btn_saveedit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_addnew)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.tbx_addinfo)
        Me.Controls.Add(Me.tbx_allergies)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.tbx_age)
        Me.Controls.Add(Me.tbx_email)
        Me.Controls.Add(Me.cbx_title)
        Me.Controls.Add(Me.tbx_surname)
        Me.Controls.Add(Me.tbx_tel)
        Me.Controls.Add(Me.tbx_name)
        Me.Controls.Add(Me.tbx_username)
        Me.Controls.Add(Me.Label17)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UsersDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UsersDetails"
        CType(Me.dgv_customers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_staff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbx_username As TextBox
    Friend WithEvents tbx_name As TextBox
    Friend WithEvents tbx_tel As TextBox
    Friend WithEvents tbx_surname As TextBox
    Friend WithEvents cbx_title As ComboBox
    Friend WithEvents tbx_email As TextBox
    Friend WithEvents tbx_age As TextBox
    Friend WithEvents Username As Label
    Friend WithEvents tbx_allergies As TextBox
    Friend WithEvents tbx_addinfo As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_addnew As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_saveedit As Button
    Friend WithEvents dgv_customers As DataGridView
    Friend WithEvents dgv_staff As DataGridView
    Friend WithEvents btn_edit2 As Button
    Friend WithEvents btn_delete2 As Button
    Friend WithEvents btn_save2 As Button
    Friend WithEvents btn_add2 As Button
    Friend WithEvents tbx_salary As TextBox
    Friend WithEvents tbx_email2 As TextBox
    Friend WithEvents cbx_title2 As ComboBox
    Friend WithEvents tbx_surname2 As TextBox
    Friend WithEvents tbx_tel2 As TextBox
    Friend WithEvents tbx_name2 As TextBox
    Friend WithEvents tbx_username2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_first As Button
    Friend WithEvents btn_last As Button
    Friend WithEvents btn_prev As Button
    Friend WithEvents btn_next As Button
    Friend WithEvents btn_next2 As Button
    Friend WithEvents btn_prev2 As Button
    Friend WithEvents btn_last2 As Button
    Friend WithEvents btn_first2 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_search As Button
    Friend WithEvents btn_search2 As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents tbx_customerid As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents tbx_staffid As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents tbx_customerid2 As TextBox
    Friend WithEvents tbx_staffid2 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents lbl_1 As Label
    Friend WithEvents lbl_2 As Label
End Class
