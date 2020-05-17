Imports System.IO
Imports System.Xml.Serialization
Imports ASFW.IO.Serialization

Public Class SettingsDef

    Public GameName As String = "Elysium.NET"
    Public Website As String = "http://www.mmodev.com.br"

    Public Welcome As String = "Bem vindo ao elysium.net, aproveite sua estadia e visite nosso forum http://www.mmodev.com.br!"
    Public Port As Integer = 7001

    Public StartMap As Integer = 1
    Public StartX As Integer = 13
    Public StartY As Integer = 7

End Class

Friend Module modSettings
    Public Settings As New SettingsDef

    Friend Sub LoadSettings()
        Dim cf As String = Path.Config()
        If Not Directory.Exists(cf) Then
            Directory.CreateDirectory(cf)
        End If : cf = cf & "\Settings.xml"

        If Not File.Exists(cf) Then
            File.Create(cf).Dispose()
            ASFW.IO.Serialization.SaveXml(Of SettingsDef)(cf, New SettingsDef)
        End If : Settings = ASFW.IO.Serialization.LoadXml(Of SettingsDef)(cf)

    End Sub

    Friend Sub SaveSettings()
        Dim cf As String = Path.Config()
        If Not Directory.Exists(cf) Then
            Directory.CreateDirectory(cf)
        End If : cf = cf & "\Settings.xml"

        ASFW.IO.Serialization.SaveXml(Of SettingsDef)(cf, Settings)
    End Sub

End Module