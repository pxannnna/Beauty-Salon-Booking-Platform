<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Booking))
        Me.dtp_date = New System.Windows.Forms.DateTimePicker()
        Me.cbx_time = New System.Windows.Forms.ComboBox()
        Me.cbx_staff = New System.Windows.Forms.ComboBox()
        Me.cbx_procedure = New System.Windows.Forms.ComboBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_saveedit = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_monthandyear = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_now = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.flDays = New System.Windows.Forms.FlowLayoutPanel()
        Me.fl_days = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_1 = New System.Windows.Forms.LinkLabel()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.tbx_customername = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbx_allergies = New System.Windows.Forms.TextBox()
        Me.tbx_addinfo = New System.Windows.Forms.TextBox()
        Me.lbl_allergies = New System.Windows.Forms.Label()
        Me.lbl_info = New System.Windows.Forms.Label()
        Me.lbl_customersusername = New System.Windows.Forms.Label()
        Me.tbx_customerusername = New System.Windows.Forms.TextBox()
        Me.pbx_2 = New System.Windows.Forms.PictureBox()
        Me.pbx_1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.flDays.SuspendLayout()
        Me.fl_days.SuspendLayout()
        CType(Me.pbx_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtp_date
        '
        Me.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_date.Location = New System.Drawing.Point(619, 69)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(139, 20)
        Me.dtp_date.TabIndex = 0
        '
        'cbx_time
        '
        Me.cbx_time.FormattingEnabled = True
        Me.cbx_time.Items.AddRange(New Object() {"9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00"})
        Me.cbx_time.Location = New System.Drawing.Point(764, 68)
        Me.cbx_time.Name = "cbx_time"
        Me.cbx_time.Size = New System.Drawing.Size(65, 21)
        Me.cbx_time.TabIndex = 1
        '
        'cbx_staff
        '
        Me.cbx_staff.FormattingEnabled = True
        Me.cbx_staff.Items.AddRange(New Object() {"Emma Willow", "Carol Sterling", "John Archer"})
        Me.cbx_staff.Location = New System.Drawing.Point(619, 126)
        Me.cbx_staff.Name = "cbx_staff"
        Me.cbx_staff.Size = New System.Drawing.Size(210, 21)
        Me.cbx_staff.TabIndex = 2
        '
        'cbx_procedure
        '
        Me.cbx_procedure.FormattingEnabled = True
        Me.cbx_procedure.Items.AddRange(New Object() {"Babylights, Root melting, Toner", "Ladies Cut and Blowdry", "Hair Extensions", "Full Head Permanent Colour", "Gents haircut and Blowdry", "Bridal Hair/Wedding Hair", "Foliage highlights", "Toner and colour", "Balayage and Tint"})
        Me.cbx_procedure.Location = New System.Drawing.Point(619, 176)
        Me.cbx_procedure.Name = "cbx_procedure"
        Me.cbx_procedure.Size = New System.Drawing.Size(210, 21)
        Me.cbx_procedure.TabIndex = 3
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_clear.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_clear.ForeColor = System.Drawing.Color.Linen
        Me.btn_clear.Location = New System.Drawing.Point(618, 426)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(210, 36)
        Me.btn_clear.TabIndex = 12
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_saveedit
        '
        Me.btn_saveedit.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_saveedit.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_saveedit.ForeColor = System.Drawing.Color.Linen
        Me.btn_saveedit.Location = New System.Drawing.Point(618, 468)
        Me.btn_saveedit.Name = "btn_saveedit"
        Me.btn_saveedit.Size = New System.Drawing.Size(210, 36)
        Me.btn_saveedit.TabIndex = 13
        Me.btn_saveedit.Text = "Save Edit"
        Me.btn_saveedit.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_save.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_save.ForeColor = System.Drawing.Color.Linen
        Me.btn_save.Location = New System.Drawing.Point(618, 384)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(210, 36)
        Me.btn_save.TabIndex = 11
        Me.btn_save.Text = "Save and print"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.lbl_monthandyear)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(842, 50)
        Me.Panel1.TabIndex = 24
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(0, 40)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(592, 35)
        Me.Panel3.TabIndex = 25
        '
        'lbl_monthandyear
        '
        Me.lbl_monthandyear.AutoSize = True
        Me.lbl_monthandyear.Font = New System.Drawing.Font("Lucida Sans Unicode", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_monthandyear.Location = New System.Drawing.Point(12, 9)
        Me.lbl_monthandyear.Name = "lbl_monthandyear"
        Me.lbl_monthandyear.Size = New System.Drawing.Size(174, 28)
        Me.lbl_monthandyear.TabIndex = 25
        Me.lbl_monthandyear.Text = "January, 2024"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_now)
        Me.Panel2.Controls.Add(Me.btn_next)
        Me.Panel2.Controls.Add(Me.btn_back)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(620, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(222, 50)
        Me.Panel2.TabIndex = 0
        '
        'btn_now
        '
        Me.btn_now.Location = New System.Drawing.Point(80, 14)
        Me.btn_now.Name = "btn_now"
        Me.btn_now.Size = New System.Drawing.Size(52, 23)
        Me.btn_now.TabIndex = 9
        Me.btn_now.Text = "Today"
        Me.btn_now.UseVisualStyleBackColor = True
        '
        'btn_next
        '
        Me.btn_next.Location = New System.Drawing.Point(157, 14)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(52, 23)
        Me.btn_next.TabIndex = 10
        Me.btn_next.Text = ">"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(3, 14)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(52, 23)
        Me.btn_back.TabIndex = 8
        Me.btn_back.Text = "<"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkOrange
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Linen
        Me.Label2.Location = New System.Drawing.Point(9, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sunday"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkOrange
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Linen
        Me.Label3.Location = New System.Drawing.Point(92, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 23)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Monday"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DarkOrange
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Linen
        Me.Label4.Location = New System.Drawing.Point(251, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 23)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Wednesday"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DarkOrange
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Linen
        Me.Label5.Location = New System.Drawing.Point(172, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 23)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Tuesday"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.DarkOrange
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Linen
        Me.Label7.Location = New System.Drawing.Point(497, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 23)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Saturday"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.DarkOrange
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Linen
        Me.Label8.Location = New System.Drawing.Point(425, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 23)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Friday"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.DarkOrange
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Linen
        Me.Label9.Location = New System.Drawing.Point(345, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 23)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Thursday"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'flDays
        '
        Me.flDays.Controls.Add(Me.fl_days)
        Me.flDays.Location = New System.Drawing.Point(7, 90)
        Me.flDays.Name = "flDays"
        Me.flDays.Size = New System.Drawing.Size(606, 456)
        Me.flDays.TabIndex = 31
        '
        'fl_days
        '
        Me.fl_days.Controls.Add(Me.Label6)
        Me.fl_days.Controls.Add(Me.lbl_1)
        Me.fl_days.Location = New System.Drawing.Point(3, 3)
        Me.fl_days.Name = "fl_days"
        Me.fl_days.Size = New System.Drawing.Size(75, 67)
        Me.fl_days.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "1"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_1
        '
        Me.lbl_1.AutoSize = True
        Me.lbl_1.Font = New System.Drawing.Font("Lucida Sans Unicode", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_1.LinkColor = System.Drawing.Color.Orange
        Me.lbl_1.Location = New System.Drawing.Point(3, 17)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(65, 13)
        Me.lbl_1.TabIndex = 1
        Me.lbl_1.TabStop = True
        Me.lbl_1.Text = "Appointment 1"
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_delete.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_delete.ForeColor = System.Drawing.Color.Linen
        Me.btn_delete.Location = New System.Drawing.Point(617, 510)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(210, 36)
        Me.btn_delete.TabIndex = 14
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'tbx_customername
        '
        Me.tbx_customername.Location = New System.Drawing.Point(621, 229)
        Me.tbx_customername.Name = "tbx_customername"
        Me.tbx_customername.Size = New System.Drawing.Size(207, 20)
        Me.tbx_customername.TabIndex = 4
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'lbl_name
        '
        Me.lbl_name.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lbl_name.Location = New System.Drawing.Point(619, 206)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(119, 20)
        Me.lbl_name.TabIndex = 54
        Me.lbl_name.Text = "Customer Name"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(618, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Procedure"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label10.Location = New System.Drawing.Point(619, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 20)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Prefered Hairstylist"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label11.Location = New System.Drawing.Point(761, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 20)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Time"
        '
        'tbx_allergies
        '
        Me.tbx_allergies.Location = New System.Drawing.Point(14, 588)
        Me.tbx_allergies.Multiline = True
        Me.tbx_allergies.Name = "tbx_allergies"
        Me.tbx_allergies.Size = New System.Drawing.Size(207, 92)
        Me.tbx_allergies.TabIndex = 6
        '
        'tbx_addinfo
        '
        Me.tbx_addinfo.Location = New System.Drawing.Point(269, 588)
        Me.tbx_addinfo.Multiline = True
        Me.tbx_addinfo.Name = "tbx_addinfo"
        Me.tbx_addinfo.Size = New System.Drawing.Size(207, 92)
        Me.tbx_addinfo.TabIndex = 7
        '
        'lbl_allergies
        '
        Me.lbl_allergies.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_allergies.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lbl_allergies.Location = New System.Drawing.Point(12, 565)
        Me.lbl_allergies.Name = "lbl_allergies"
        Me.lbl_allergies.Size = New System.Drawing.Size(180, 20)
        Me.lbl_allergies.TabIndex = 60
        Me.lbl_allergies.Text = "Allergies"
        '
        'lbl_info
        '
        Me.lbl_info.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_info.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lbl_info.Location = New System.Drawing.Point(269, 565)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(168, 20)
        Me.lbl_info.TabIndex = 61
        Me.lbl_info.Text = "Additional Information"
        '
        'lbl_customersusername
        '
        Me.lbl_customersusername.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customersusername.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lbl_customersusername.Location = New System.Drawing.Point(621, 266)
        Me.lbl_customersusername.Name = "lbl_customersusername"
        Me.lbl_customersusername.Size = New System.Drawing.Size(179, 20)
        Me.lbl_customersusername.TabIndex = 63
        Me.lbl_customersusername.Text = "Customer's Username"
        '
        'tbx_customerusername
        '
        Me.tbx_customerusername.Location = New System.Drawing.Point(623, 289)
        Me.tbx_customerusername.Name = "tbx_customerusername"
        Me.tbx_customerusername.Size = New System.Drawing.Size(207, 20)
        Me.tbx_customerusername.TabIndex = 5
        '
        'pbx_2
        '
        Me.pbx_2.Image = Global.steelworkssalon.My.Resources.Resources.leaf
        Me.pbx_2.Location = New System.Drawing.Point(561, 501)
        Me.pbx_2.Name = "pbx_2"
        Me.pbx_2.Size = New System.Drawing.Size(86, 72)
        Me.pbx_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_2.TabIndex = 64
        Me.pbx_2.TabStop = False
        '
        'pbx_1
        '
        Me.pbx_1.Image = Global.steelworkssalon.My.Resources.Resources.leaf_rotated
        Me.pbx_1.Location = New System.Drawing.Point(764, 332)
        Me.pbx_1.Name = "pbx_1"
        Me.pbx_1.Size = New System.Drawing.Size(86, 72)
        Me.pbx_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_1.TabIndex = 65
        Me.pbx_1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(789, 634)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 685)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.pbx_2)
        Me.Controls.Add(Me.lbl_customersusername)
        Me.Controls.Add(Me.tbx_customerusername)
        Me.Controls.Add(Me.lbl_info)
        Me.Controls.Add(Me.lbl_allergies)
        Me.Controls.Add(Me.tbx_addinfo)
        Me.Controls.Add(Me.tbx_allergies)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.tbx_customername)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.flDays)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_saveedit)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.cbx_procedure)
        Me.Controls.Add(Me.cbx_staff)
        Me.Controls.Add(Me.cbx_time)
        Me.Controls.Add(Me.dtp_date)
        Me.Controls.Add(Me.pbx_1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Booking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Booking"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.flDays.ResumeLayout(False)
        Me.fl_days.ResumeLayout(False)
        Me.fl_days.PerformLayout()
        CType(Me.pbx_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtp_date As DateTimePicker
    Friend WithEvents cbx_time As ComboBox
    Friend WithEvents cbx_staff As ComboBox
    Friend WithEvents cbx_procedure As ComboBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_saveedit As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_monthandyear As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_next As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents flDays As FlowLayoutPanel
    Friend WithEvents fl_days As FlowLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_1 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_now As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents tbx_customername As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents lbl_name As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents tbx_allergies As TextBox
    Friend WithEvents tbx_addinfo As TextBox
    Friend WithEvents lbl_allergies As Label
    Friend WithEvents lbl_info As Label
    Friend WithEvents lbl_customersusername As Label
    Friend WithEvents tbx_customerusername As TextBox
    Friend WithEvents pbx_2 As PictureBox
    Friend WithEvents pbx_1 As PictureBox
End Class
