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
        lblSalida = New Label()
        cmdEjecutar = New Button()
        SuspendLayout()
        ' 
        ' lblSalida
        ' 
        lblSalida.AutoSize = True
        lblSalida.Location = New Point(447, 271)
        lblSalida.Name = "lblSalida"
        lblSalida.Size = New Size(63, 25)
        lblSalida.TabIndex = 0
        lblSalida.Text = "Label1"
        ' 
        ' cmdEjecutar
        ' 
        cmdEjecutar.Location = New Point(444, 213)
        cmdEjecutar.Name = "cmdEjecutar"
        cmdEjecutar.Size = New Size(112, 34)
        cmdEjecutar.TabIndex = 1
        cmdEjecutar.Text = "Ejecutar"
        cmdEjecutar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cmdEjecutar)
        Controls.Add(lblSalida)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblSalida As Label
    Friend WithEvents cmdEjecutar As Button

End Class
