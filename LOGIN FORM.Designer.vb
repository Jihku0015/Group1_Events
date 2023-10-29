<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN_FORM
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(LOGIN_FORM))
        Panel1 = New Panel()
        Label3 = New Label()
        Label1 = New Label()
        LinkLabelReg = New LinkLabel()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        LoginButton = New Button()
        TextBoxPass = New TextBox()
        TextBoxUser = New TextBox()
        Button1 = New Button()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(LinkLabelReg)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Location = New Point(-3, -1)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(516, 520)
        Panel1.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(140, 437)
        Label3.Name = "Label3"
        Label3.Size = New Size(170, 20)
        Label3.TabIndex = 8
        Label3.Text = "Don't Have An Account?"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Rockwell", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(32, 59)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(460, 42)
        Label1.TabIndex = 0
        Label1.Text = "Event Management System"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' LinkLabelReg
        ' 
        LinkLabelReg.AutoSize = True
        LinkLabelReg.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabelReg.LinkColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        LinkLabelReg.Location = New Point(315, 437)
        LinkLabelReg.Margin = New Padding(2, 0, 2, 0)
        LinkLabelReg.Name = "LinkLabelReg"
        LinkLabelReg.Size = New Size(67, 20)
        LinkLabelReg.TabIndex = 7
        LinkLabelReg.TabStop = True
        LinkLabelReg.Text = "Register!"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(LoginButton)
        GroupBox1.Controls.Add(TextBoxPass)
        GroupBox1.Controls.Add(TextBoxUser)
        GroupBox1.Location = New Point(58, 151)
        GroupBox1.Margin = New Padding(2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(2)
        GroupBox1.Size = New Size(390, 250)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Rockwell", 15.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.SteelBlue
        Label2.Location = New Point(149, 22)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 30)
        Label2.TabIndex = 1
        Label2.Text = "LOGIN"
        ' 
        ' LoginButton
        ' 
        LoginButton.BackColor = Color.SteelBlue
        LoginButton.Font = New Font("Rockwell", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        LoginButton.ForeColor = Color.White
        LoginButton.Location = New Point(147, 180)
        LoginButton.Margin = New Padding(2)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(90, 34)
        LoginButton.TabIndex = 6
        LoginButton.Text = "Sign In"
        LoginButton.UseVisualStyleBackColor = False
        ' 
        ' TextBoxPass
        ' 
        TextBoxPass.Font = New Font("Segoe UI", 13.0F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxPass.ForeColor = Color.DarkGray
        TextBoxPass.Location = New Point(102, 124)
        TextBoxPass.Margin = New Padding(2)
        TextBoxPass.Name = "TextBoxPass"
        TextBoxPass.Size = New Size(187, 36)
        TextBoxPass.TabIndex = 5
        TextBoxPass.Text = "Password"
        TextBoxPass.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBoxUser
        ' 
        TextBoxUser.Font = New Font("Segoe UI", 13.0F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxUser.ForeColor = Color.DarkGray
        TextBoxUser.Location = New Point(102, 75)
        TextBoxUser.Margin = New Padding(2)
        TextBoxUser.Name = "TextBoxUser"
        TextBoxUser.Size = New Size(187, 36)
        TextBoxUser.TabIndex = 4
        TextBoxUser.Text = "Username"
        TextBoxUser.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.Red
        Button1.Location = New Point(979, -1)
        Button1.Name = "Button1"
        Button1.Size = New Size(23, 26)
        Button1.TabIndex = 1
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' LOGIN_FORM
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
        Name = "LOGIN_FORM"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LOGIN FORM"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LinkLabelReg As LinkLabel
    Friend WithEvents LoginButton As Button
    Friend WithEvents TextBoxPass As TextBox
    Friend WithEvents TextBoxUser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
