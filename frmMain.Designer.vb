<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtHSV = New System.Windows.Forms.TextBox()
        Me.txtCMYK = New System.Windows.Forms.TextBox()
        Me.txtHEX = New System.Windows.Forms.TextBox()
        Me.btnLock = New System.Windows.Forms.Button()
        Me.txtRGB = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtMSHEX = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPressAny = New System.Windows.Forms.Label()
        Me.picLock = New System.Windows.Forms.PictureBox()
        Me.btnCopy6 = New System.Windows.Forms.Button()
        Me.btnCopy5 = New System.Windows.Forms.Button()
        Me.btnCopy4 = New System.Windows.Forms.Button()
        Me.btnCopy3 = New System.Windows.Forms.Button()
        Me.btnCopy2 = New System.Windows.Forms.Button()
        Me.btnCopy1 = New System.Windows.Forms.Button()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtHSV
        '
        Me.txtHSV.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtHSV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHSV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtHSV.Location = New System.Drawing.Point(159, 168)
        Me.txtHSV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHSV.Name = "txtHSV"
        Me.txtHSV.ReadOnly = True
        Me.txtHSV.Size = New System.Drawing.Size(95, 20)
        Me.txtHSV.TabIndex = 11
        Me.txtHSV.TabStop = False
        '
        'txtCMYK
        '
        Me.txtCMYK.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtCMYK.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCMYK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtCMYK.Location = New System.Drawing.Point(159, 140)
        Me.txtCMYK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCMYK.Name = "txtCMYK"
        Me.txtCMYK.ReadOnly = True
        Me.txtCMYK.Size = New System.Drawing.Size(95, 20)
        Me.txtCMYK.TabIndex = 10
        Me.txtCMYK.TabStop = False
        '
        'txtHEX
        '
        Me.txtHEX.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtHEX.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHEX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtHEX.Location = New System.Drawing.Point(159, 56)
        Me.txtHEX.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHEX.Name = "txtHEX"
        Me.txtHEX.ReadOnly = True
        Me.txtHEX.Size = New System.Drawing.Size(95, 20)
        Me.txtHEX.TabIndex = 9
        Me.txtHEX.TabStop = False
        '
        'btnLock
        '
        Me.btnLock.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLock.Location = New System.Drawing.Point(19, 56)
        Me.btnLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(56, 160)
        Me.btnLock.TabIndex = 8
        Me.btnLock.UseVisualStyleBackColor = False
        '
        'txtRGB
        '
        Me.txtRGB.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtRGB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRGB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtRGB.Location = New System.Drawing.Point(159, 112)
        Me.txtRGB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRGB.Name = "txtRGB"
        Me.txtRGB.ReadOnly = True
        Me.txtRGB.Size = New System.Drawing.Size(95, 20)
        Me.txtRGB.TabIndex = 7
        Me.txtRGB.TabStop = False
        '
        'txtPosition
        '
        Me.txtPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtPosition.Location = New System.Drawing.Point(159, 196)
        Me.txtPosition.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.ReadOnly = True
        Me.txtPosition.Size = New System.Drawing.Size(95, 20)
        Me.txtPosition.TabIndex = 6
        Me.txtPosition.TabStop = False
        '
        'Timer1
        '
        '
        'txtMSHEX
        '
        Me.txtMSHEX.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.txtMSHEX.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMSHEX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtMSHEX.Location = New System.Drawing.Point(159, 84)
        Me.txtMSHEX.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMSHEX.Name = "txtMSHEX"
        Me.txtMSHEX.ReadOnly = True
        Me.txtMSHEX.Size = New System.Drawing.Size(95, 20)
        Me.txtMSHEX.TabIndex = 12
        Me.txtMSHEX.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bebas", 10.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(15, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(88, 20)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.Text = "ColorPAD Pro"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Bebas", 8.0!)
        Me.lblInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.lblInfo.Location = New System.Drawing.Point(149, 4)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(154, 17)
        Me.lblInfo.TabIndex = 14
        Me.lblInfo.Text = "Build 12072020 | By Verdin.io"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(121, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "HEX"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(99, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "MS-HEX"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(123, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "RGB"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(112, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "CMYK"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(122, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "HSV"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(93, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 20)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Position"
        '
        'lblPressAny
        '
        Me.lblPressAny.AutoSize = True
        Me.lblPressAny.Font = New System.Drawing.Font("Bebas", 8.0!)
        Me.lblPressAny.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.lblPressAny.Location = New System.Drawing.Point(170, 230)
        Me.lblPressAny.Name = "lblPressAny"
        Me.lblPressAny.Size = New System.Drawing.Size(119, 17)
        Me.lblPressAny.TabIndex = 27
        Me.lblPressAny.Text = "Press any key to lock"
        Me.lblPressAny.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picLock
        '
        Me.picLock.BackgroundImage = Global.ColorPAD_Pro.My.Resources.Resources.lock
        Me.picLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLock.Location = New System.Drawing.Point(19, 227)
        Me.picLock.Name = "picLock"
        Me.picLock.Size = New System.Drawing.Size(20, 20)
        Me.picLock.TabIndex = 28
        Me.picLock.TabStop = False
        Me.picLock.Visible = False
        '
        'btnCopy6
        '
        Me.btnCopy6.BackgroundImage = Global.ColorPAD_Pro.My.Resources.Resources.copy
        Me.btnCopy6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCopy6.FlatAppearance.BorderSize = 0
        Me.btnCopy6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopy6.Location = New System.Drawing.Point(264, 196)
        Me.btnCopy6.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCopy6.Name = "btnCopy6"
        Me.btnCopy6.Size = New System.Drawing.Size(20, 20)
        Me.btnCopy6.TabIndex = 26
        Me.btnCopy6.UseVisualStyleBackColor = True
        '
        'btnCopy5
        '
        Me.btnCopy5.BackgroundImage = Global.ColorPAD_Pro.My.Resources.Resources.copy
        Me.btnCopy5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCopy5.FlatAppearance.BorderSize = 0
        Me.btnCopy5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopy5.Location = New System.Drawing.Point(264, 168)
        Me.btnCopy5.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCopy5.Name = "btnCopy5"
        Me.btnCopy5.Size = New System.Drawing.Size(20, 20)
        Me.btnCopy5.TabIndex = 25
        Me.btnCopy5.UseVisualStyleBackColor = True
        '
        'btnCopy4
        '
        Me.btnCopy4.BackgroundImage = Global.ColorPAD_Pro.My.Resources.Resources.copy
        Me.btnCopy4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCopy4.FlatAppearance.BorderSize = 0
        Me.btnCopy4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopy4.Location = New System.Drawing.Point(264, 140)
        Me.btnCopy4.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCopy4.Name = "btnCopy4"
        Me.btnCopy4.Size = New System.Drawing.Size(20, 20)
        Me.btnCopy4.TabIndex = 24
        Me.btnCopy4.UseVisualStyleBackColor = True
        '
        'btnCopy3
        '
        Me.btnCopy3.BackgroundImage = Global.ColorPAD_Pro.My.Resources.Resources.copy
        Me.btnCopy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCopy3.FlatAppearance.BorderSize = 0
        Me.btnCopy3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopy3.Location = New System.Drawing.Point(264, 112)
        Me.btnCopy3.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCopy3.Name = "btnCopy3"
        Me.btnCopy3.Size = New System.Drawing.Size(20, 20)
        Me.btnCopy3.TabIndex = 23
        Me.btnCopy3.UseVisualStyleBackColor = True
        '
        'btnCopy2
        '
        Me.btnCopy2.BackgroundImage = Global.ColorPAD_Pro.My.Resources.Resources.copy
        Me.btnCopy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCopy2.FlatAppearance.BorderSize = 0
        Me.btnCopy2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopy2.Location = New System.Drawing.Point(264, 84)
        Me.btnCopy2.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCopy2.Name = "btnCopy2"
        Me.btnCopy2.Size = New System.Drawing.Size(20, 20)
        Me.btnCopy2.TabIndex = 22
        Me.btnCopy2.UseVisualStyleBackColor = True
        '
        'btnCopy1
        '
        Me.btnCopy1.BackgroundImage = Global.ColorPAD_Pro.My.Resources.Resources.copy
        Me.btnCopy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCopy1.FlatAppearance.BorderSize = 0
        Me.btnCopy1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopy1.Location = New System.Drawing.Point(264, 56)
        Me.btnCopy1.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCopy1.Name = "btnCopy1"
        Me.btnCopy1.Size = New System.Drawing.Size(20, 20)
        Me.btnCopy1.TabIndex = 21
        Me.btnCopy1.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(307, 265)
        Me.Controls.Add(Me.picLock)
        Me.Controls.Add(Me.lblPressAny)
        Me.Controls.Add(Me.btnCopy6)
        Me.Controls.Add(Me.btnCopy5)
        Me.Controls.Add(Me.btnCopy4)
        Me.Controls.Add(Me.btnCopy3)
        Me.Controls.Add(Me.btnCopy2)
        Me.Controls.Add(Me.btnCopy1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtMSHEX)
        Me.Controls.Add(Me.txtHSV)
        Me.Controls.Add(Me.txtCMYK)
        Me.Controls.Add(Me.txtHEX)
        Me.Controls.Add(Me.btnLock)
        Me.Controls.Add(Me.txtRGB)
        Me.Controls.Add(Me.txtPosition)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Bebas", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ColorPAD Pro"
        Me.TopMost = True
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtHSV As TextBox
    Friend WithEvents txtCMYK As TextBox
    Friend WithEvents txtHEX As TextBox
    Friend WithEvents btnLock As Button
    Friend WithEvents txtRGB As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtMSHEX As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCopy1 As Button
    Friend WithEvents btnCopy2 As Button
    Friend WithEvents btnCopy3 As Button
    Friend WithEvents btnCopy4 As Button
    Friend WithEvents btnCopy5 As Button
    Friend WithEvents btnCopy6 As Button
    Friend WithEvents lblPressAny As Label
    Friend WithEvents picLock As PictureBox
End Class
