Imports System
Imports System.IO
Imports System.Text
Imports System.Threading.Tasks
Imports System.Security.Cryptography
Imports System.Collections.Generic



Namespace ASFW.IO.Encryption
    ''' <summary>
    ''' Simple encryption methods performed over a static password.
    ''' </summary>
    Public Module Generic
        Public Function EncryptBytes(ByVal value As Byte(), ByVal password As String, ByVal iterations As Integer) As Byte()
            Dim len = value.Length
            Dim salt = New Byte(31) {}
            Dim rgbIv = New Byte(31) {}
            Dim buffer As Byte()

            Using bytes = New Rfc2898DeriveBytes(password, salt, iterations)
                Dim rm = New RijndaelManaged With {
                    .BlockSize = 256,
                    .Mode = CipherMode.CBC,
                    .Padding = PaddingMode.PKCS7
                }

                Using es = rm.CreateEncryptor(bytes.GetBytes(32), rgbIv)

                    Using ms = New MemoryStream()

                        Using cs = New CryptoStream(ms, es, CryptoStreamMode.Write)
                            cs.Write(value, 0, len)
                            cs.FlushFinalBlock()
                            buffer = ms.ToArray()
                        End Using
                    End Using
                End Using

                len = buffer.Length
                value = New Byte(64 + len - 1) {}
                System.Buffer.BlockCopy(salt, 0, value, 0, 32)
                System.Buffer.BlockCopy(rgbIv, 0, value, 32, 32)
                System.Buffer.BlockCopy(buffer, 0, value, 64, len)
                Return value
            End Using
        End Function

        Public Async Function EncryptBytesAsync(ByVal value As Byte(), ByVal password As String, ByVal iterations As Integer) As Task(Of Byte())
            Dim len = value.Length
            Dim salt = New Byte(31) {}
            Dim rgbIv = New Byte(31) {}
            Dim buffer As Byte()

            Using bytes = New Rfc2898DeriveBytes(password, salt, iterations)
                Dim rm = New RijndaelManaged With {
                    .BlockSize = 256,
                    .Mode = CipherMode.CBC,
                    .Padding = PaddingMode.PKCS7
                }

                Using es = rm.CreateEncryptor(bytes.GetBytes(32), rgbIv)

                    Using ms = New MemoryStream()

                        Using cs = New CryptoStream(ms, es, CryptoStreamMode.Write)
                            Await cs.WriteAsync(value, 0, len)
                            cs.FlushFinalBlock()
                            buffer = ms.ToArray()
                        End Using
                    End Using
                End Using

                len = buffer.Length
                value = New Byte(64 + len - 1) {}
                System.Buffer.BlockCopy(salt, 0, value, 0, 32)
                System.Buffer.BlockCopy(rgbIv, 0, value, 32, 32)
                System.Buffer.BlockCopy(buffer, 0, value, 64, len)
                Return value
            End Using
        End Function

        Public Function EncryptString(ByVal value As String, ByVal password As String, ByVal iterations As Integer) As String
            Dim buffer = EncryptBytes(Encoding.UTF8.GetBytes(value), password, iterations)
            Return Convert.ToBase64String(buffer)
        End Function

        Public Async Function EncryptStringAsync(ByVal value As String, ByVal password As String, ByVal iterations As Integer) As Task(Of String)
            Dim buffer = Await EncryptBytesAsync(Encoding.UTF8.GetBytes(value), password, iterations)
            Return Convert.ToBase64String(buffer)
        End Function

        Public Function DecryptBytes(ByVal value As Byte(), ByVal password As String, ByVal iterations As Integer) As Byte()
            Dim len = value.Length - 64
            Dim salt = New Byte(31) {}
            Dim rgbIv = New Byte(31) {}
            Dim buffer = New Byte(len - 1) {}
            System.Buffer.BlockCopy(value, 0, salt, 0, 32)
            System.Buffer.BlockCopy(value, 32, rgbIv, 0, 32)
            System.Buffer.BlockCopy(value, 64, buffer, 0, len)
            Dim rm = New RijndaelManaged With {
                .BlockSize = 256,
                .Mode = CipherMode.CBC,
                .Padding = PaddingMode.PKCS7
            }

            Using bytes = New Rfc2898DeriveBytes(password, salt, iterations)

                Using ds = rm.CreateDecryptor(bytes.GetBytes(32), rgbIv)

                    Using ms = New MemoryStream()

                        Using cs = New CryptoStream(ms, ds, CryptoStreamMode.Write)
                            cs.Write(buffer, 0, len)
                            cs.FlushFinalBlock()
                            Return ms.ToArray()
                        End Using
                    End Using
                End Using
            End Using
        End Function

        Public Async Function DecryptBytesAsync(ByVal value As Byte(), ByVal password As String, ByVal iterations As Integer) As Task(Of Byte())
            Dim len = value.Length - 64
            Dim salt = New Byte(31) {}
            Dim rgbIv = New Byte(31) {}
            Dim buffer = New Byte(len - 1) {}
            System.Buffer.BlockCopy(value, 0, salt, 0, 32)
            System.Buffer.BlockCopy(value, 32, rgbIv, 0, 32)
            System.Buffer.BlockCopy(value, 64, buffer, 0, len)
            Dim rm = New RijndaelManaged With {
                .BlockSize = 256,
                .Mode = CipherMode.CBC,
                .Padding = PaddingMode.PKCS7
            }

            Using bytes = New Rfc2898DeriveBytes(password, salt, iterations)

                Using ds = rm.CreateDecryptor(bytes.GetBytes(32), rgbIv)

                    Using ms = New MemoryStream()

                        Using cs = New CryptoStream(ms, ds, CryptoStreamMode.Write)
                            Await cs.WriteAsync(buffer, 0, len)
                            cs.FlushFinalBlock()
                            Return ms.ToArray()
                        End Using
                    End Using
                End Using
            End Using
        End Function

        Public Function DecryptString(ByVal value As String, ByVal password As String, ByVal iterations As Integer) As String
            Dim buffer = DecryptBytes(Convert.FromBase64String(value), password, iterations)
            Return Encoding.UTF8.GetString(buffer)
        End Function

        Public Async Function DecryptStrinAsync(ByVal value As String, ByVal password As String, ByVal iterations As Integer) As Task(Of String)
            Dim buffer = Await DecryptBytesAsync(Convert.FromBase64String(value), password, iterations)
            Return Encoding.UTF8.GetString(buffer)
        End Function
    End Module


    ''' <summary>
    ''' Advanced encryption methods performed over a generated Async Keypair Code.
    ''' </summary>
    Public NotInheritable Class KeyPair



        ''' <summary>
        ''' Honestly have no idea what these are for, but they are used in key
        ''' generation so if anyone knows their purpose they'll still have the
        ''' ability to use them.
        ''' </summary>
        Public Enum KeyType
            Signature = 1
            Exchange = 2
        End Enum

        ' Check if bugs later // Auto-implemented property

        'Property Csp As CspParameters = New CspParameters()
        Public Property _rsaMgr As RSA
        Public _rsa = _rsaMgr.Create()
        'Public _rsa As RSACryptoServiceProvider

        Public Sub Dispose()
            _rsaMgr.Dispose()
            _rsaMgr = Nothing
        End Sub


        ''' <summary>
        ''' Returns if only a Public/Encryption key was loaded.
        ''' </summary>
        Public ReadOnly Property PublicOnly As Boolean
            Get
                If _rsa Is Nothing Then Throw New Exception("Key(s) not found!")
                Return _rsa.PublicOnly
            End Get
        End Property


        ''' <summary>
        ''' Generates a new Public/Encryption and Private/Decryption Keypair.
        ''' </summary>
        Public Sub GenerateKeys(ByVal Optional type As KeyType = KeyType.Signature)
            Dim _rsa = _rsaMgr.Create()
        End Sub


        ''' <summary>
        ''' Returns the string data of the Key Code(s). This functions
        ''' primary use is for retrieving Key(s) so they can be passed
        ''' to other KeyPair objects without access to a file. (EX: over a network)
        ''' </summary>
        Public Function ExportKeyString(ByVal Optional exportPrivate As Boolean = False) As String
            Dim _rsa = _rsaMgr.Create()
            Return _rsa.ToXmlString(exportPrivate)
        End Function


        ''' <summary>
        ''' Saves the string data of the Key Code(s) to a file for reuse.
        ''' </summary>
        Public Sub ExportKey(ByVal file As String, ByVal Optional exportPrivate As Boolean = True)
            Dim stream = New StreamWriter(file, False)
            stream.Write(_rsa.ToXmlString(exportPrivate))
            stream.Close()
        End Sub


        ''' <summary>
        ''' Loads the string data of the Key Code(s) for use.
        ''' </summary>
        Public Sub ImportKeyString(ByVal key As String)
            _rsa.FromXmlString(key)
        End Sub


        ''' <summary>
        ''' Loads the string data of the Key Code(s) from a file for use.
        ''' </summary>
        Public Sub ImportKey(ByVal file As String)
            Dim stream = New StreamReader(file)
            _rsa.FromXmlString(stream.ReadToEnd())
            stream.Close()
        End Sub

        Public Function EncryptBytes(ByVal value As Byte()) As Byte()
            If _rsa Is Nothing Then Throw New Exception("Key not set.")
            Dim rm = New RijndaelManaged With {
                .KeySize = 256,
                .BlockSize = 256,
                .Mode = CipherMode.CBC
            }

            Using ms = New MemoryStream()
                ms.Write(_rsa.Encrypt(rm.Key, False), 0, 256)
                ms.Write(rm.IV, 0, 32)

                Using es = rm.CreateEncryptor()

                    Using cs = New CryptoStream(ms, es, CryptoStreamMode.Write)
                        cs.Write(value, 0, value.Length)
                        cs.FlushFinalBlock()
                    End Using
                End Using

                Return ms.ToArray()
            End Using
        End Function

        Public Async Function EncryptBytesAsync(ByVal value As Byte()) As Task(Of Byte())
            If _rsa Is Nothing Then Throw New Exception("Key not set.")
            Dim rm = New RijndaelManaged With {
                .KeySize = 256,
                .BlockSize = 256,
                .Mode = CipherMode.CBC
            }

            Using ms = New MemoryStream()
                Await ms.WriteAsync(_rsa.Encrypt(rm.Key, False), 0, 256)
                Await ms.WriteAsync(rm.IV, 0, 32)

                Using es = rm.CreateEncryptor()

                    Using cs = New CryptoStream(ms, es, CryptoStreamMode.Write)
                        Await cs.WriteAsync(value, 0, value.Length)
                        cs.FlushFinalBlock()
                    End Using
                End Using

                Return ms.ToArray()
            End Using
        End Function

        Public Function EncryptBytes(ByVal value As Byte(), ByVal offset As Integer, ByVal size As Integer) As Byte()
            If _rsa Is Nothing Then Throw New Exception("Key not set.")
            Dim rm = New RijndaelManaged With {
                .KeySize = 256,
                .BlockSize = 256,
                .Mode = CipherMode.CBC
            }

            Using es = rm.CreateEncryptor()

                Using ms = New MemoryStream()
                    ms.Write(_rsa.Encrypt(rm.Key, False), 0, 256)
                    ms.Write(rm.IV, 0, 32)

                    Using cs = New CryptoStream(ms, es, CryptoStreamMode.Write)
                        cs.Write(value, offset, size)
                        cs.FlushFinalBlock()
                    End Using

                    Return ms.ToArray()
                End Using
            End Using
        End Function

        Public Async Function EncryptBytesAsync(ByVal value As Byte(), ByVal offset As Integer, ByVal size As Integer) As Task(Of Byte())
            If _rsa Is Nothing Then Throw New Exception("Key not set.")
            Dim rm = New RijndaelManaged With {
                .KeySize = 256,
                .BlockSize = 256,
                .Mode = CipherMode.CBC
            }

            Using es = rm.CreateEncryptor()

                Using ms = New MemoryStream()
                    Await ms.WriteAsync(_rsa.Encrypt(rm.Key, False), 0, 256)
                    Await ms.WriteAsync(rm.IV, 0, 32)

                    Using cs = New CryptoStream(ms, es, CryptoStreamMode.Write)
                        Await cs.WriteAsync(value, offset, size)
                        cs.FlushFinalBlock()
                    End Using

                    Return ms.ToArray()
                End Using
            End Using
        End Function

        Public Function EncryptString(ByVal value As String) As String
            If _rsa Is Nothing Then Throw New Exception("Key not set.")
            Return Convert.ToBase64String(EncryptBytes(Encoding.UTF8.GetBytes(value)))
        End Function

        Public Async Function EncryptStringAsync(ByVal value As String) As Task(Of String)
            If _rsa Is Nothing Then Throw New Exception("Key not set.")
            Return Convert.ToBase64String(Await EncryptBytesAsync(Encoding.UTF8.GetBytes(value)))
        End Function

        Public Sub EncryptFile(ByVal srcFile As String, ByVal dstFile As String)
            If _rsa Is Nothing Then Throw New Exception("Key not set.")
            File.WriteAllBytes(dstFile, EncryptBytes(File.ReadAllBytes(srcFile)))
        End Sub

        Public Async Function EncryptFileAsync(ByVal srcFile As String, ByVal dstFile As String) As Task
            If _rsa Is Nothing Then Throw New Exception("Key not set.")
            File.WriteAllBytes(dstFile, Await EncryptBytesAsync(File.ReadAllBytes(srcFile)))
        End Function

        Public Function DecryptBytes(ByVal value As Byte()) As Byte()
            If _rsa Is Nothing Then Throw New Exception("Key not set.")
            If _rsa.PublicOnly Then Return Nothing
            If value.Length < 288 Then Return Nothing
            Dim rm = New RijndaelManaged With {
                .KeySize = 256,
                .BlockSize = 256,
                .Mode = CipherMode.CBC
            }
            Dim rgb = New Byte(255) {}
            Dim iv = New Byte(31) {}
            Dim len = value.Length - 288
            Dim buffer = New Byte(len - 1) {}
            System.Buffer.BlockCopy(value, 0, rgb, 0, 256)
            System.Buffer.BlockCopy(value, 256, iv, 0, 32)
            System.Buffer.BlockCopy(value, 288, buffer, 0, len)

            Using ds = rm.CreateDecryptor(_rsa.Decrypt(rgb, False), iv)

                Using ms = New MemoryStream()

                    Using cs = New CryptoStream(ms, ds, CryptoStreamMode.Write)
                        cs.Write(buffer, 0, len)
                        cs.FlushFinalBlock()
                        Return ms.ToArray()
                    End Using
                End Using
            End Using
        End Function

        Public Async Function DecryptBytesAsync(ByVal value As Byte()) As Task(Of Byte())
            If _rsa Is Nothing Then Throw New Exception("Key not set.")
            If _rsa.PublicOnly Then Return Nothing
            If value.Length < 288 Then Return Nothing
            Dim rm = New RijndaelManaged With {
                .KeySize = 256,
                .BlockSize = 256,
                .Mode = CipherMode.CBC
            }
            Dim rgb = New Byte(255) {}
            Dim iv = New Byte(31) {}
            Dim len = value.Length - 288
            Dim buffer = New Byte(len - 1) {}
            System.Buffer.BlockCopy(value, 0, rgb, 0, 256)
            System.Buffer.BlockCopy(value, 256, iv, 0, 32)
            System.Buffer.BlockCopy(value, 288, buffer, 0, len)

            Using ds = rm.CreateDecryptor(_rsa.Decrypt(rgb, False), iv)

                Using ms = New MemoryStream()

                    Using cs = New CryptoStream(ms, ds, CryptoStreamMode.Write)
                        Await cs.WriteAsync(buffer, 0, len)
                        cs.FlushFinalBlock()
                        Return ms.ToArray()
                    End Using
                End Using
            End Using
        End Function

        Public Function DecryptBytes(ByVal value As Byte(), ByVal offset As Integer, ByVal size As Integer) As Byte()
            If _rsa Is Nothing Then Throw New Exception("Key not set.")
            If _rsa.PublicOnly Then Return Nothing
            If value.Length < 288 Then Return Nothing
            If value.Length < offset + size Then Return Nothing
            Dim rm = New RijndaelManaged With {
                .KeySize = 256,
                .BlockSize = 256,
                .Mode = CipherMode.CBC
            }
            Dim rgb = New Byte(255) {}
            Dim iv = New Byte(31) {}
            Dim len = size - 288
            Dim buffer = New Byte(len - 1) {}
            System.Buffer.BlockCopy(value, offset, rgb, 0, 256)
            System.Buffer.BlockCopy(value, offset + 256, iv, 0, 32)
            System.Buffer.BlockCopy(value, offset + 288, buffer, 0, len)

            Using ds = rm.CreateDecryptor(_rsa.Decrypt(rgb, False), iv)

                Using ms = New MemoryStream()

                    Using cs = New CryptoStream(ms, ds, CryptoStreamMode.Write)
                        cs.Write(buffer, 0, len)
                        cs.FlushFinalBlock()
                        Return ms.ToArray()
                    End Using
                End Using
            End Using
        End Function

        Public Async Function DecryptBytesAsync(ByVal value As Byte(), ByVal offset As Integer, ByVal size As Integer) As Task(Of Byte())
            If _rsa Is Nothing Then Throw New Exception("Key not set.")
            If _rsa.PublicOnly Then Return Nothing
            If value.Length < 288 Then Return Nothing
            If value.Length < offset + size Then Return Nothing
            Dim rm = New RijndaelManaged With {
                .KeySize = 256,
                .BlockSize = 256,
                .Mode = CipherMode.CBC
            }
            Dim rgb = New Byte(255) {}
            Dim iv = New Byte(31) {}
            Dim len = size - 288
            Dim buffer = New Byte(len - 1) {}
            System.Buffer.BlockCopy(value, offset, rgb, 0, 256)
            System.Buffer.BlockCopy(value, offset + 256, iv, 0, 32)
            System.Buffer.BlockCopy(value, offset + 288, buffer, 0, len)

            Using ds = rm.CreateDecryptor(_rsa.Decrypt(rgb, False), iv)

                Using ms = New MemoryStream()

                    Using cs = New CryptoStream(ms, ds, CryptoStreamMode.Write)
                        Await cs.WriteAsync(buffer, 0, len)
                        cs.FlushFinalBlock()
                        Return ms.ToArray()
                    End Using
                End Using
            End Using
        End Function

        Public Function DecryptString(ByVal value As String) As String
            If _rsa Is Nothing Then Throw New Exception("Key not set.")
            If _rsa.PublicOnly Then Return Nothing
            Dim buffer = Convert.FromBase64String(value)
            If buffer.Length < 288 Then Return ""
            Return Encoding.UTF8.GetString(DecryptBytes(buffer))
        End Function

        Public Async Function DecryptStringAsync(ByVal value As String) As Task(Of String)
            If _rsa Is Nothing Then Throw New Exception("Key not set.")
            If _rsa.PublicOnly Then Return Nothing
            Dim buffer = Convert.FromBase64String(value)
            If buffer.Length < 288 Then Return ""
            Return Encoding.UTF8.GetString(Await DecryptBytesAsync(buffer))
        End Function

        Public Sub DecryptFile(ByVal srcFile As String, ByVal dstFile As String)
            If _rsa Is Nothing Then Throw New Exception("Key not set.")
            If _rsa.PublicOnly Then Return
            Dim buffer = DecryptBytes(File.ReadAllBytes(srcFile))
            If buffer Is Nothing Then Throw New Exception("File contents were empty!")
            File.WriteAllBytes(dstFile, buffer)
        End Sub

        Public Async Function DecryptFileAsync(ByVal srcFile As String, ByVal dstFile As String) As Task
            If _rsa Is Nothing Then Throw New Exception("Key not set.")
            If _rsa.PublicOnly Then Return
            Dim buffer = Await DecryptBytesAsync(File.ReadAllBytes(srcFile))
            If buffer Is Nothing Then Throw New Exception("File contents were empty!")
            File.WriteAllBytes(dstFile, buffer)
        End Function
    End Class
End Namespace