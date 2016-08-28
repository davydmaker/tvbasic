'------------------------------'
' Desenvolvido por Davyd Maker '
'------------------------------'

Public Class Form1
    'Colocar fundo da ListBox da mesma cor da form
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstCanais.BackColor = System.Drawing.Color.FromArgb(17, 17, 17)
    End Sub

    'Mudar canais na listbox quando for mudado de tipo de canal
    Private Sub mcbCategorias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mcbCategorias.SelectedIndexChanged
        lstCanais.Items.Clear()
        Select Case mcbCategorias.SelectedIndex
            Case 0
                lstCanais.Items.AddRange(Documentario)
                Exit Select
            Case 1
                lstCanais.Items.AddRange(Esportes)
                Exit Select
            Case 2
                lstCanais.Items.AddRange(Filmes)
                Exit Select
            Case 3
                lstCanais.Items.AddRange(Infantil)
                Exit Select
            Case 4
                lstCanais.Items.AddRange(OutrosCanais)
                Exit Select
            Case 5
                lstCanais.Items.AddRange(Series)
                Exit Select
            Case 6
                lstCanais.Items.AddRange(TVAberta)
                Exit Select
            Case 7
                lstCanais.Items.AddRange(Variedades)
                Exit Select
        End Select
    End Sub

    'Quando selecionado canal abrir URL de acordo com retorno dela na função no modulo Outros
    Private Sub lstCanais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCanais.SelectedIndexChanged
        mlNomeDoCanal.Text = lstCanais.SelectedItem
        wbStream.Navigate(canais(lstCanais.SelectedItem, mcbCategorias.SelectedItem))
    End Sub
End Class
