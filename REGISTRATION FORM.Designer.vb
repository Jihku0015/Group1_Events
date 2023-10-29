<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REGISTRATION_FORM
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(REGISTRATION_FORM))
        Panel1 = New Panel()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        RegButton = New Button()
        TextBoxEmail = New TextBox()
        LabelEmail = New Label()
        TextBoxRegPass = New TextBox()
        TextBoxRegUser = New TextBox()
        LabelRegPass = New Label()
        LabelRegUser = New Label()
        Label1 = New Label()
        Button1 = New Button()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(GroupBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(478, 0)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(526, 518)
        Panel1.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.WhiteSmoke
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(RegButton)
        GroupBox1.Controls.Add(TextBoxEmail)
        GroupBox1.Controls.Add(LabelEmail)
        GroupBox1.Controls.Add(TextBoxRegPass)
        GroupBox1.Controls.Add(TextBoxRegUser)
        GroupBox1.Controls.Add(LabelRegPass)
        GroupBox1.Controls.Add(LabelRegUser)
        GroupBox1.Location = New Point(30, 112)
        GroupBox1.Margin = New Padding(2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(2)
        GroupBox1.Size = New Size(464, 332)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.SteelBlue
        Label2.Location = New Point(141, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(189, 30)
        Label2.TabIndex = 10
        Label2.Text = "Register Form"
        ' 
        ' RegButton
        ' 
        RegButton.BackColor = Color.DodgerBlue
        RegButton.Font = New Font("Rockwell", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        RegButton.ForeColor = Color.White
        RegButton.Location = New Point(269, 232)
        RegButton.Margin = New Padding(2)
        RegButton.Name = "RegButton"
        RegButton.Size = New Size(121, 40)
        RegButton.TabIndex = 9
        RegButton.Text = "Register"
        RegButton.UseVisualStyleBackColor = False
        ' 
        ' TextBoxEmail
        ' 
        TextBoxEmail.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxEmail.ForeColor = Color.DarkGray
        TextBoxEmail.Location = New Point(222, 176)
        TextBoxEmail.Margin = New Padding(2)
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.Size = New Size(213, 36)
        TextBoxEmail.TabIndex = 5
        TextBoxEmail.Text = "Email Address"
        TextBoxEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' LabelEmail
        ' 
        LabelEmail.AutoSize = True
        LabelEmail.Font = New Font("Rockwell", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        LabelEmail.ForeColor = Color.SteelBlue
        LabelEmail.Location = New Point(22, 183)
        LabelEmail.Margin = New Padding(2, 0, 2, 0)
        LabelEmail.Name = "LabelEmail"
        LabelEmail.Size = New Size(196, 26)
        LabelEmail.TabIndex = 4
        LabelEmail.Text = "EMAIL ADDRESS:"
        ' 
        ' TextBoxRegPass
        ' 
        TextBoxRegPass.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxRegPass.ForeColor = Color.DarkGray
        TextBoxRegPass.Location = New Point(222, 129)
        TextBoxRegPass.Margin = New Padding(2)
        TextBoxRegPass.Name = "TextBoxRegPass"
        TextBoxRegPass.Size = New Size(213, 36)
        TextBoxRegPass.TabIndex = 3
        TextBoxRegPass.Text = "Password"
        TextBoxRegPass.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBoxRegUser
        ' 
        TextBoxRegUser.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxRegUser.ForeColor = Color.DarkGray
        TextBoxRegUser.Location = New Point(222, 78)
        TextBoxRegUser.Margin = New Padding(2)
        TextBoxRegUser.Name = "TextBoxRegUser"
        TextBoxRegUser.Size = New Size(213, 36)
        TextBoxRegUser.TabIndex = 2
        TextBoxRegUser.Text = "Username"
        TextBoxRegUser.TextAlign = HorizontalAlignment.Center
        ' 
        ' LabelRegPass
        ' 
        LabelRegPass.AutoSize = True
        LabelRegPass.Font = New Font("Rockwell", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        LabelRegPass.ForeColor = Color.SteelBlue
        LabelRegPass.Location = New Point(74, 136)
        LabelRegPass.Margin = New Padding(2, 0, 2, 0)
        LabelRegPass.Name = "LabelRegPass"
        LabelRegPass.Size = New Size(144, 26)
        LabelRegPass.TabIndex = 1
        LabelRegPass.Text = "PASSWORD:"
        ' 
        ' LabelRegUser
        ' 
        LabelRegUser.AutoSize = True
        LabelRegUser.Font = New Font("Rockwell", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        LabelRegUser.ForeColor = Color.SteelBlue
        LabelRegUser.Location = New Point(74, 85)
        LabelRegUser.Margin = New Padding(2, 0, 2, 0)
        LabelRegUser.Name = "LabelRegUser"
        LabelRegUser.Size = New Size(142, 26)
        LabelRegUser.TabIndex = 0
        LabelRegUser.Text = "USERNAME:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Rockwell", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(30, 37)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(460, 42)
        Label1.TabIndex = 0
        Label1.Text = "Event Management System"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.Red
        Button1.Location = New Point(-1, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(26, 27)
        Button1.TabIndex = 1
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' REGISTRATION_FORM
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1001, 516)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2)
        Name = "REGISTRATION_FORM"
        StartPosition = FormStartPosition.CenterScreen
        Text = "REGISTRATION FORM"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents LabelEmail As Label
    Friend WithEvents TextBoxRegPass As TextBox
    Friend WithEvents TextBoxRegUser As TextBox
    Friend WithEvents LabelRegPass As Label
    Friend WithEvents LabelRegUser As Label
    Friend WithEvents RegButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
End Class
