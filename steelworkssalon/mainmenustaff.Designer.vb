<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainmenustaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainmenustaff))
        Me.btn_personaldetails = New System.Windows.Forms.Button()
        Me.btn_shifts = New System.Windows.Forms.Button()
        Me.btn_booking = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbx_exit = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_personaldetails
        '
        Me.btn_personaldetails.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_personaldetails.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_personaldetails.ForeColor = System.Drawing.Color.Linen
        Me.btn_personaldetails.Location = New System.Drawing.Point(177, 220)
        Me.btn_personaldetails.Name = "btn_personaldetails"
        Me.btn_personaldetails.Size = New System.Drawing.Size(315, 36)
        Me.btn_personaldetails.TabIndex = 2
        Me.btn_personaldetails.Text = "Personal details"
        Me.btn_personaldetails.UseVisualStyleBackColor = False
        '
        'btn_shifts
        '
        Me.btn_shifts.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_shifts.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_shifts.ForeColor = System.Drawing.Color.Linen
        Me.btn_shifts.Location = New System.Drawing.Point(177, 179)
        Me.btn_shifts.Name = "btn_shifts"
        Me.btn_shifts.Size = New System.Drawing.Size(315, 36)
        Me.btn_shifts.TabIndex = 1
        Me.btn_shifts.Text = "Shifts Timetable"
        Me.btn_shifts.UseVisualStyleBackColor = False
        '
        'btn_booking
        '
        Me.btn_booking.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_booking.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_booking.ForeColor = System.Drawing.Color.Linen
        Me.btn_booking.Location = New System.Drawing.Point(177, 137)
        Me.btn_booking.Name = "btn_booking"
        Me.btn_booking.Size = New System.Drawing.Size(315, 36)
        Me.btn_booking.TabIndex = 0
        Me.btn_booking.Text = "Booking timetable"
        Me.btn_booking.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.steelworkssalon.My.Resources.Resources.logo3
        Me.PictureBox1.Location = New System.Drawing.Point(5, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label4.Location = New System.Drawing.Point(514, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 20)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Call: +44 1792 897711"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Location = New System.Drawing.Point(261, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 35)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Main Menu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 21.75!)
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(97, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 35)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Steel Works"
        '
        'pbx_exit
        '
        Me.pbx_exit.Image = CType(resources.GetObject("pbx_exit.Image"), System.Drawing.Image)
        Me.pbx_exit.Location = New System.Drawing.Point(636, 332)
        Me.pbx_exit.Name = "pbx_exit"
        Me.pbx_exit.Size = New System.Drawing.Size(38, 46)
        Me.pbx_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbx_exit.TabIndex = 31
        Me.pbx_exit.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.steelworkssalon.My.Resources.Resources.leaf
        Me.PictureBox7.Location = New System.Drawing.Point(115, 199)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(86, 72)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 41
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.steelworkssalon.My.Resources.Resources.leaf_reflected
        Me.PictureBox8.Location = New System.Drawing.Point(473, 199)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(86, 72)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 42
        Me.PictureBox8.TabStop = False
        '
        'mainmenustaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(686, 390)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbx_exit)
        Me.Controls.Add(Me.btn_personaldetails)
        Me.Controls.Add(Me.btn_shifts)
        Me.Controls.Add(Me.btn_booking)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mainmenustaff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainmenustaff"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_personaldetails As Button
    Friend WithEvents btn_shifts As Button
    Friend WithEvents btn_booking As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pbx_exit As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
End Class
