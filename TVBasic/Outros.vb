'------------------------------'
' Desenvolvido por Davyd Maker '
'------------------------------'

Module Outros
    'Arrays com lista de canais
    Public Documentario() As String = {"Discovery Channel", "Discovery Home & Health", "History Channel", "National Geographic"}
    Public Esportes() As String = {"ESPN", "ESPN HD", "ESPN Brasil", "Esporte Interativo", "Fox Sports", "Speed"}
    Public Filmes() As String = {"Cinemax", "HBO", "HBO 2", "HBO Family", "HBO Plus", "Max", "Max Prime", "Megapix", "MGM Channel", "Space", "Telecine Cultura", "Telecine Action", "Telecine Touch", "Telecine Fun", "Telecine Pipoca", "Telecine Premium", "TNT", "TruTV"}
    Public Infantil() As String = {"Boomerang", "Cartoon Network", "Discovery Kids", "Disney Channel", "Disney Junior", "Disney XD", "Nickelodeon", "Nickelodeon Junior", "Tooncast"}
    Public OutrosCanais() As String = {"MTV"}
    Public Series() As String = {"A&E", "Animal Planet", "AXN", "Fox", "Fox Life", "FX", "Sony", "Sony Spin", "SyFy", "Universal Channel", "Warner Bross"}
    Public TVAberta() As String = {"Record News", "Rede Record", "RedeTV!", "SBT", "TV Cultura", "TV Gazeta"}
    Public Variedades() As String = {"Multishow", "TV Senado", "TV Câmara", "Viva"}

    'Retornar URL para assistir canal
    Public Function canais(ByVal nomeCanal As String, ByVal categoria As String)
        Dim urlStream As String = ""
        If categoria = "TV Aberta" Then
            Select Case (nomeCanal)
                Case "SBT"
                    urlStream = "http://fast.player.liquidplatform.com/pApiv2/embed/8fcdc5f0f8df8d4de56b22a2c6660470?alternateLive=http://gbbrlive2.sambatech.com.br/liveevent/sbt3_8fcdc5f0f8df8d4de56b22a2c6660470/livestream/playlist.m3u8"
                    Exit Select
            End Select
        End If
        Return urlStream
    End Function
End Module
