<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        TextBox1 = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Button5 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(160, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(611, 50)
        Label1.TabIndex = 0
        Label1.Text = "CALCULATE AVERAGE OF MARKS "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.LightGray
        Label2.Font = New Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(40, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(162, 32)
        Label2.TabIndex = 1
        Label2.Text = "ENTER MARKS"
        ' 
        ' Label3
        ' 
        Label3.BackColor = SystemColors.Info
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(734, 154)
        Label3.Name = "Label3"
        Label3.Size = New Size(251, 329)
        Label3.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.BackColor = SystemColors.Info
        Label4.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DarkGoldenrod
        Label4.Location = New Point(738, 116)
        Label4.Name = "Label4"
        Label4.Size = New Size(247, 38)
        Label4.TabIndex = 4
        Label4.Text = "Marks Obtained "
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.LightGray
        Label5.Font = New Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(40, 250)
        Label5.Name = "Label5"
        Label5.Size = New Size(158, 31)
        Label5.TabIndex = 5
        Label5.Text = "AVERAGE"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        Button1.Location = New Point(560, 120)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 7
        Button1.Text = "OK"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        Button2.Location = New Point(555, 260)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 32)
        Button2.TabIndex = 8
        Button2.Text = "AVERAGE"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Button3.Location = New Point(209, 431)
        Button3.Name = "Button3"
        Button3.Size = New Size(131, 36)
        Button3.TabIndex = 9
        Button3.Text = "RESET"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Button4.Location = New Point(448, 431)
        Button4.Name = "Button4"
        Button4.Size = New Size(144, 32)
        Button4.TabIndex = 10
        Button4.Text = "QUIT"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Snow
        TextBox1.Location = New Point(336, 125)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(169, 31)
        TextBox1.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Snow
        Label6.Location = New Point(336, 256)
        Label6.Name = "Label6"
        Label6.Size = New Size(169, 36)
        Label6.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.LightGray
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ActiveCaptionText
        Label7.Location = New Point(40, 308)
        Label7.Name = "Label7"
        Label7.Size = New Size(144, 40)
        Label7.TabIndex = 13
        Label7.Text = "GRADE"
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.Snow
        Label8.Location = New Point(336, 315)
        Label8.Name = "Label8"
        Label8.Size = New Size(169, 33)
        Label8.TabIndex = 14
        ' 
        ' Label9
        ' 
        Label9.BackColor = Color.LightGray
        Label9.Font = New Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ActiveCaptionText
        Label9.Location = New Point(40, 187)
        Label9.Name = "Label9"
        Label9.Size = New Size(183, 37)
        Label9.TabIndex = 15
        Label9.Text = "TOTAL MARKS"
        ' 
        ' Label10
        ' 
        Label10.BackColor = Color.Snow
        Label10.Location = New Point(336, 187)
        Label10.Name = "Label10"
        Label10.Size = New Size(169, 37)
        Label10.TabIndex = 16
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Button5.Location = New Point(560, 188)
        Button5.Name = "Button5"
        Button5.Size = New Size(107, 34)
        Button5.TabIndex = 17
        Button5.Text = "TOTAL"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(997, 492)
        Controls.Add(Button5)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(TextBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button5 As Button

End Class
