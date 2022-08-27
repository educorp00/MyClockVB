<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Display
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.timeNow = New System.Windows.Forms.Label()
        Me.secTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'timeNow
        '
        Me.timeNow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.timeNow.Font = New System.Drawing.Font("MS UI Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.timeNow.Location = New System.Drawing.Point(0, 0)
        Me.timeNow.Name = "timeNow"
        Me.timeNow.Size = New System.Drawing.Size(174, 86)
        Me.timeNow.TabIndex = 0
        Me.timeNow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'secTimer
        '
        Me.secTimer.Enabled = True
        Me.secTimer.Interval = 1000
        '
        'Display
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(174, 86)
        Me.ControlBox = False
        Me.Controls.Add(Me.timeNow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Display"
        Me.ShowIcon = False
        Me.Text = "MyClock"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents timeNow As Label
    Friend WithEvents secTimer As Timer
End Class
