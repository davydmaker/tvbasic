<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lstCanais = New System.Windows.Forms.ListBox
        Me.mcbCategorias = New MetroFramework.Controls.MetroComboBox
        Me.wbStream = New System.Windows.Forms.WebBrowser
        Me.mlNomeDoCanal = New MetroFramework.Controls.MetroLabel
        Me.SuspendLayout()
        '
        'lstCanais
        '
        Me.lstCanais.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lstCanais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstCanais.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCanais.ForeColor = System.Drawing.Color.White
        Me.lstCanais.FormattingEnabled = True
        Me.lstCanais.ItemHeight = 16
        Me.lstCanais.Location = New System.Drawing.Point(23, 98)
        Me.lstCanais.Name = "lstCanais"
        Me.lstCanais.Size = New System.Drawing.Size(230, 274)
        Me.lstCanais.Sorted = True
        Me.lstCanais.TabIndex = 1
        '
        'mcbCategorias
        '
        Me.mcbCategorias.ForeColor = System.Drawing.SystemColors.WindowText
        Me.mcbCategorias.FormattingEnabled = True
        Me.mcbCategorias.ItemHeight = 23
        Me.mcbCategorias.Items.AddRange(New Object() {"Documentário", "Esportes", "Filmes", "Infantil", "Outros", "Séries", "TV Aberta", "Variedades"})
        Me.mcbCategorias.Location = New System.Drawing.Point(23, 63)
        Me.mcbCategorias.Name = "mcbCategorias"
        Me.mcbCategorias.PromptText = "Selecione a categoria..."
        Me.mcbCategorias.Size = New System.Drawing.Size(230, 29)
        Me.mcbCategorias.TabIndex = 2
        Me.mcbCategorias.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mcbCategorias.UseSelectable = True
        '
        'wbStream
        '
        Me.wbStream.Location = New System.Drawing.Point(269, 68)
        Me.wbStream.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbStream.Name = "wbStream"
        Me.wbStream.ScriptErrorsSuppressed = True
        Me.wbStream.ScrollBarsEnabled = False
        Me.wbStream.Size = New System.Drawing.Size(450, 304)
        Me.wbStream.TabIndex = 3
        '
        'mlNomeDoCanal
        '
        Me.mlNomeDoCanal.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.mlNomeDoCanal.Location = New System.Drawing.Point(310, 37)
        Me.mlNomeDoCanal.Name = "mlNomeDoCanal"
        Me.mlNomeDoCanal.Size = New System.Drawing.Size(375, 23)
        Me.mlNomeDoCanal.TabIndex = 4
        Me.mlNomeDoCanal.Text = "Ola"
        Me.mlNomeDoCanal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mlNomeDoCanal.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 390)
        Me.Controls.Add(Me.mlNomeDoCanal)
        Me.Controls.Add(Me.wbStream)
        Me.Controls.Add(Me.mcbCategorias)
        Me.Controls.Add(Me.lstCanais)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "TVBasic"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstCanais As System.Windows.Forms.ListBox
    Friend WithEvents mcbCategorias As MetroFramework.Controls.MetroComboBox
    Friend WithEvents wbStream As System.Windows.Forms.WebBrowser
    Friend WithEvents mlNomeDoCanal As MetroFramework.Controls.MetroLabel

End Class
