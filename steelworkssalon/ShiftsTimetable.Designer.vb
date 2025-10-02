<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShiftsTimetable
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShiftsTimetable))
        Me.dgv_shiftstimetable = New System.Windows.Forms.DataGridView()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pbx_exit = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.cbx_dayofweek = New System.Windows.Forms.ComboBox()
        Me.cbx_staff = New System.Windows.Forms.ComboBox()
        Me.lbl_1 = New System.Windows.Forms.Label()
        Me.lbl_2 = New System.Windows.Forms.Label()
        Me.cbx_starttime = New System.Windows.Forms.ComboBox()
        Me.cbx_endtime = New System.Windows.Forms.ComboBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        CType(Me.dgv_shiftstimetable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_shiftstimetable
        '
        Me.dgv_shiftstimetable.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.dgv_shiftstimetable.AllowUserToAddRows = False
        Me.dgv_shiftstimetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_shiftstimetable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_shiftstimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_shiftstimetable.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_shiftstimetable.Location = New System.Drawing.Point(70, 122)
        Me.dgv_shiftstimetable.Name = "dgv_shiftstimetable"
        Me.dgv_shiftstimetable.ReadOnly = True
        Me.dgv_shiftstimetable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv_shiftstimetable.Size = New System.Drawing.Size(706, 150)
        Me.dgv_shiftstimetable.TabIndex = 58
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(2, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(110, 88)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 57
        Me.PictureBox3.TabStop = False
        '
        'pbx_exit
        '
        Me.pbx_exit.Image = CType(resources.GetObject("pbx_exit.Image"), System.Drawing.Image)
        Me.pbx_exit.Location = New System.Drawing.Point(809, 477)
        Me.pbx_exit.Name = "pbx_exit"
        Me.pbx_exit.Size = New System.Drawing.Size(38, 46)
        Me.pbx_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_exit.TabIndex = 56
        Me.pbx_exit.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Location = New System.Drawing.Point(298, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(257, 35)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Shifts Timetable"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 21.75!)
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(105, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 35)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Steel Works"
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_save.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_save.ForeColor = System.Drawing.Color.Linen
        Me.btn_save.Location = New System.Drawing.Point(345, 417)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(210, 36)
        Me.btn_save.TabIndex = 4
        Me.btn_save.Text = "Save changes"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'cbx_dayofweek
        '
        Me.cbx_dayofweek.FormattingEnabled = True
        Me.cbx_dayofweek.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.cbx_dayofweek.Location = New System.Drawing.Point(345, 320)
        Me.cbx_dayofweek.Name = "cbx_dayofweek"
        Me.cbx_dayofweek.Size = New System.Drawing.Size(210, 21)
        Me.cbx_dayofweek.TabIndex = 1
        Me.cbx_dayofweek.Text = "Day of the week"
        '
        'cbx_staff
        '
        Me.cbx_staff.FormattingEnabled = True
        Me.cbx_staff.Items.AddRange(New Object() {"Emma", "Carol", "John"})
        Me.cbx_staff.Location = New System.Drawing.Point(90, 319)
        Me.cbx_staff.Name = "cbx_staff"
        Me.cbx_staff.Size = New System.Drawing.Size(210, 21)
        Me.cbx_staff.TabIndex = 0
        Me.cbx_staff.Text = "Member of Staff"
        '
        'lbl_1
        '
        Me.lbl_1.AutoSize = True
        Me.lbl_1.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lbl_1.Location = New System.Drawing.Point(616, 302)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(62, 15)
        Me.lbl_1.TabIndex = 66
        Me.lbl_1.Text = "Start Time"
        '
        'lbl_2
        '
        Me.lbl_2.AutoSize = True
        Me.lbl_2.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lbl_2.Location = New System.Drawing.Point(616, 366)
        Me.lbl_2.Name = "lbl_2"
        Me.lbl_2.Size = New System.Drawing.Size(57, 15)
        Me.lbl_2.TabIndex = 67
        Me.lbl_2.Text = "End Time"
        '
        'cbx_starttime
        '
        Me.cbx_starttime.FormattingEnabled = True
        Me.cbx_starttime.Items.AddRange(New Object() {"9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", " "})
        Me.cbx_starttime.Location = New System.Drawing.Point(619, 320)
        Me.cbx_starttime.Name = "cbx_starttime"
        Me.cbx_starttime.Size = New System.Drawing.Size(139, 21)
        Me.cbx_starttime.TabIndex = 2
        Me.cbx_starttime.Text = "Time"
        '
        'cbx_endtime
        '
        Me.cbx_endtime.FormattingEnabled = True
        Me.cbx_endtime.Items.AddRange(New Object() {"9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", " "})
        Me.cbx_endtime.Location = New System.Drawing.Point(619, 384)
        Me.cbx_endtime.Name = "cbx_endtime"
        Me.cbx_endtime.Size = New System.Drawing.Size(139, 21)
        Me.cbx_endtime.TabIndex = 3
        Me.cbx_endtime.Text = "Time"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.steelworkssalon.My.Resources.Resources.leaf
        Me.PictureBox7.Location = New System.Drawing.Point(12, 226)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(86, 72)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 70
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.steelworkssalon.My.Resources.Resources.leaf_rotated
        Me.PictureBox8.Location = New System.Drawing.Point(726, 73)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(86, 72)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 71
        Me.PictureBox8.TabStop = False
        '
        'ShiftsTimetable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(859, 535)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbx_endtime)
        Me.Controls.Add(Me.cbx_starttime)
        Me.Controls.Add(Me.lbl_2)
        Me.Controls.Add(Me.lbl_1)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.cbx_dayofweek)
        Me.Controls.Add(Me.cbx_staff)
        Me.Controls.Add(Me.dgv_shiftstimetable)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.pbx_exit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ShiftsTimetable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ShiftsTimetable"
        CType(Me.dgv_shiftstimetable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_shiftstimetable As DataGridView
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents pbx_exit As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents cbx_dayofweek As ComboBox
    Friend WithEvents cbx_staff As ComboBox
    Friend WithEvents lbl_1 As Label
    Friend WithEvents lbl_2 As Label
    Friend WithEvents cbx_starttime As ComboBox
    Friend WithEvents cbx_endtime As ComboBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
End Class
