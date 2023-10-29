<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MainPage))
        Panel1 = New Panel()
        GroupBox1 = New GroupBox()
        Venue = New TextBox()
        Label9 = New Label()
        EventNameBox = New TextBox()
        Label8 = New Label()
        EndTime = New DateTimePicker()
        StartTime = New DateTimePicker()
        Label7 = New Label()
        Label6 = New Label()
        EndingDate = New DateTimePicker()
        Label5 = New Label()
        StartingDate = New DateTimePicker()
        Label4 = New Label()
        Button2 = New Button()
        Panel2 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Label1 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.NavajoWhite
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(802, 598)
        Panel1.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.SteelBlue
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Venue)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(EventNameBox)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(EndTime)
        GroupBox1.Controls.Add(StartTime)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(EndingDate)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(StartingDate)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Location = New Point(32, 173)
        GroupBox1.Margin = New Padding(2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(2)
        GroupBox1.Size = New Size(732, 395)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' Venue
        ' 
        Venue.Location = New Point(388, 111)
        Venue.Name = "Venue"
        Venue.Size = New Size(260, 27)
        Venue.TabIndex = 20
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(388, 88)
        Label9.Name = "Label9"
        Label9.Size = New Size(59, 17)
        Label9.TabIndex = 19
        Label9.Text = "Venue:"
        ' 
        ' EventNameBox
        ' 
        EventNameBox.Location = New Point(62, 111)
        EventNameBox.Name = "EventNameBox"
        EventNameBox.Size = New Size(258, 27)
        EventNameBox.TabIndex = 18
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(62, 88)
        Label8.Name = "Label8"
        Label8.Size = New Size(97, 17)
        Label8.TabIndex = 17
        Label8.Text = "Event Name:"
        ' 
        ' EndTime
        ' 
        EndTime.Format = DateTimePickerFormat.Time
        EndTime.Location = New Point(388, 180)
        EndTime.Name = "EndTime"
        EndTime.Size = New Size(108, 27)
        EndTime.TabIndex = 16
        ' 
        ' StartTime
        ' 
        StartTime.Format = DateTimePickerFormat.Time
        StartTime.Location = New Point(62, 180)
        StartTime.Name = "StartTime"
        StartTime.Size = New Size(108, 27)
        StartTime.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(387, 157)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 17)
        Label7.TabIndex = 14
        Label7.Text = "End Time:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(62, 157)
        Label6.Name = "Label6"
        Label6.Size = New Size(107, 17)
        Label6.TabIndex = 13
        Label6.Text = "Starting Time:"
        ' 
        ' EndingDate
        ' 
        EndingDate.Location = New Point(387, 248)
        EndingDate.Name = "EndingDate"
        EndingDate.Size = New Size(260, 27)
        EndingDate.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Rockwell Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(388, 225)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 18)
        Label5.TabIndex = 11
        Label5.Text = "End Date:"
        ' 
        ' StartingDate
        ' 
        StartingDate.Location = New Point(62, 248)
        StartingDate.Name = "StartingDate"
        StartingDate.Size = New Size(258, 27)
        StartingDate.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(63, 225)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 17)
        Label4.TabIndex = 9
        Label4.Text = "Starting Date:"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.Font = New Font("Rockwell", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.SteelBlue
        Button2.Location = New Point(277, 314)
        Button2.Name = "Button2"
        Button2.Size = New Size(163, 41)
        Button2.TabIndex = 8
        Button2.Text = "Add Event"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.SteelBlue
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label1)
        Panel2.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(0, 0, 0, 5)
        Panel2.Size = New Size(802, 145)
        Panel2.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Rockwell", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(369, 33)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 30)
        Label3.TabIndex = 2
        Label3.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(233, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 29)
        Label2.TabIndex = 0
        Label2.Text = "Welcome!,"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.BackgroundImageLayout = ImageLayout.Center
        Button1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.Red
        Button1.Location = New Point(779, 0)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(23, 23)
        Button1.TabIndex = 1
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Baskerville Old Face", 31.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(94, 35)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(621, 59)
        Label1.TabIndex = 0
        Label1.Text = "Events Management System"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(32, 94)
        Label10.Name = "Label10"
        Label10.Size = New Size(737, 37)
        Label10.TabIndex = 2
        Label10.Text = "_____________________________________________"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.ForeColor = Color.White
        Label11.Location = New Point(32, -14)
        Label11.Name = "Label11"
        Label11.Size = New Size(737, 37)
        Label11.TabIndex = 3
        Label11.Text = "_____________________________________________"
        ' 
        ' MainPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(802, 598)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2)
        Name = "MainPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Event Title"
        Panel1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents StartTime As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents EndingDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents StartingDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents EndTime As DateTimePicker
    Friend WithEvents Venue As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents EventNameBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
End Class
