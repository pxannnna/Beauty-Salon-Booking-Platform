<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookingHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookingHistory))
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_bookinghistory = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.tbx_username = New System.Windows.Forms.TextBox()
        Me.btn_finddetails = New System.Windows.Forms.Button()
        Me.btn_alldetails = New System.Windows.Forms.Button()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_bookinghistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(-3, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(110, 88)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 51
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(798, 364)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'lbl_1
        '
        Me.lbl_1.AutoSize = True
        Me.lbl_1.Font = New System.Drawing.Font("Lucida Sans Unicode", 21.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lbl_1.Location = New System.Drawing.Point(284, 83)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(305, 35)
        Me.lbl_1.TabIndex = 49
        Me.lbl_1.Text = "My Booking History"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 21.75!)
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(100, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 35)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Steel Works"
        '
        'dgv_bookinghistory
        '
        Me.dgv_bookinghistory.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.dgv_bookinghistory.AllowUserToAddRows = False
        Me.dgv_bookinghistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_bookinghistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_bookinghistory.Location = New System.Drawing.Point(71, 139)
        Me.dgv_bookinghistory.Name = "dgv_bookinghistory"
        Me.dgv_bookinghistory.ReadOnly = True
        Me.dgv_bookinghistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv_bookinghistory.Size = New System.Drawing.Size(706, 150)
        Me.dgv_bookinghistory.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label4.Location = New System.Drawing.Point(689, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 16)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Call: +44 1792 897711"
        '
        'lbl_name
        '
        Me.lbl_name.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lbl_name.Location = New System.Drawing.Point(68, 336)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(180, 20)
        Me.lbl_name.TabIndex = 57
        Me.lbl_name.Text = "Customer's Username"
        '
        'tbx_username
        '
        Me.tbx_username.Location = New System.Drawing.Point(71, 359)
        Me.tbx_username.Name = "tbx_username"
        Me.tbx_username.Size = New System.Drawing.Size(207, 20)
        Me.tbx_username.TabIndex = 56
        '
        'btn_finddetails
        '
        Me.btn_finddetails.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_finddetails.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_finddetails.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_finddetails.ForeColor = System.Drawing.Color.Linen
        Me.btn_finddetails.Location = New System.Drawing.Point(319, 320)
        Me.btn_finddetails.Name = "btn_finddetails"
        Me.btn_finddetails.Size = New System.Drawing.Size(210, 36)
        Me.btn_finddetails.TabIndex = 55
        Me.btn_finddetails.Text = "Find Details"
        Me.btn_finddetails.UseVisualStyleBackColor = False
        '
        'btn_alldetails
        '
        Me.btn_alldetails.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_alldetails.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_alldetails.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_alldetails.ForeColor = System.Drawing.Color.Linen
        Me.btn_alldetails.Location = New System.Drawing.Point(319, 374)
        Me.btn_alldetails.Name = "btn_alldetails"
        Me.btn_alldetails.Size = New System.Drawing.Size(210, 36)
        Me.btn_alldetails.TabIndex = 58
        Me.btn_alldetails.Text = "Load All Details"
        Me.btn_alldetails.UseVisualStyleBackColor = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.steelworkssalon.My.Resources.Resources.leaf
        Me.PictureBox7.Location = New System.Drawing.Point(12, 244)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(86, 72)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 66
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.steelworkssalon.My.Resources.Resources.leaf_rotated
        Me.PictureBox8.Location = New System.Drawing.Point(726, 83)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(86, 72)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 67
        Me.PictureBox8.TabStop = False
        '
        'BookingHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(848, 422)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_alldetails)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.tbx_username)
        Me.Controls.Add(Me.btn_finddetails)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgv_bookinghistory)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BookingHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BookingHistory"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_bookinghistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_bookinghistory As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents tbx_username As TextBox
    Friend WithEvents btn_finddetails As Button
    Friend WithEvents btn_alldetails As Button
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
End Class
