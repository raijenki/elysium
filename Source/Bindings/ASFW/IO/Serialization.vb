Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml.Serialization

Namespace ASFW.IO
    Public Module Serialization
        ''' <summary>
        ''' Saves a public serializable class object as XML data in the specified file.
        ''' </summary>
        Public Sub SaveXml(Of T)(ByVal path As String, ByVal obj As Object)
            Dim serializer As XmlSerializer = New XmlSerializer(GetType(T))

            Using streamWriter As StreamWriter = New StreamWriter(path)
                serializer.Serialize(streamWriter, obj)
            End Using
        End Sub

        ''' <summary>
        ''' Loads XML data from the specified file as a public serializable class object.
        ''' </summary>
        Public Function LoadXml(Of T)(ByVal path As String) As Object
            Dim serializer As XmlSerializer = New XmlSerializer(GetType(T))

            Using streamReader As StreamReader = New StreamReader(path)
                Return serializer.Deserialize(streamReader)
            End Using
        End Function


        ''' <summary>
        ''' Returns a byte array from a serializable class object.
        ''' </summary>
        Public Function FromObject(ByVal [Object] As Object) As Byte()
            Using ms = New MemoryStream()
                Call New BinaryFormatter().Serialize(ms, [Object])
                Return ms.GetBuffer()
            End Using
        End Function


        ''' <summary>
        ''' Returns an object from a byte array.
        ''' </summary>
        Public Function ToObject(ByVal bytes As Byte()) As Object
            Using ms = New MemoryStream(bytes)
                Return New BinaryFormatter().Deserialize(ms)
            End Using
        End Function
    End Module
End Namespace