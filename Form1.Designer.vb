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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtNIP = New TextBox()
        txtNama = New TextBox()
        cmbFakultas = New ComboBox()
        cmbJurusan = New ComboBox()
        btnProses = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(57, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 22)
        Label1.TabIndex = 0
        Label1.Text = "NIP"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(57, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 22)
        Label2.TabIndex = 1
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(57, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 22)
        Label3.TabIndex = 2
        Label3.Text = "Fakultas"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(57, 193)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 22)
        Label4.TabIndex = 3
        Label4.Text = "Jurusan"
        ' 
        ' txtNIP
        ' 
        txtNIP.Location = New Point(223, 33)
        txtNIP.Name = "txtNIP"
        txtNIP.Size = New Size(253, 27)
        txtNIP.TabIndex = 4
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(223, 82)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(440, 27)
        txtNama.TabIndex = 5
        ' 
        ' cmbFakultas
        ' 
        cmbFakultas.FormattingEnabled = True
        cmbFakultas.Location = New Point(223, 137)
        cmbFakultas.Name = "cmbFakultas"
        cmbFakultas.Size = New Size(186, 28)
        cmbFakultas.TabIndex = 6
        ' 
        ' cmbJurusan
        ' 
        cmbJurusan.FormattingEnabled = True
        cmbJurusan.Location = New Point(223, 187)
        cmbJurusan.Name = "cmbJurusan"
        cmbJurusan.Size = New Size(345, 28)
        cmbJurusan.TabIndex = 8
        ' 
        ' btnProses
        ' 
        btnProses.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnProses.Location = New Point(87, 269)
        btnProses.Name = "btnProses"
        btnProses.Size = New Size(94, 29)
        btnProses.TabIndex = 9
        btnProses.Text = "Prosess"
        btnProses.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnProses)
        Controls.Add(cmbJurusan)
        Controls.Add(cmbFakultas)
        Controls.Add(txtNama)
        Controls.Add(txtNIP)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNIP As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents cmbFakultas As ComboBox
    Friend WithEvents cmbJurusan As ComboBox
    Friend WithEvents btnProses As Button

End Class
