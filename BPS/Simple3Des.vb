Imports System.Security.Cryptography
Public NotInheritable Class Simple3Des
    Private TripleDes As New TripleDESCryptoServiceProvider
    Private Function TruncateHash(ByVal key As String, ByVal length As Integer) As Byte()
        Dim sha1 As New SHA1CryptoServiceProvider
        Dim keyBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = sha1.ComputeHash(keyBytes)
        ReDim Preserve hash(length - 1)
        Return hash
    End Function
    Sub New(ByVal key As String)
        TripleDes.Key = TruncateHash(key, TripleDes.KeySize \ 8)
        TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
    End Sub
    Public Function encryptData(ByVal plaintext As String) As String
        Dim plaintextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)
        Dim ms As New System.IO.MemoryStream
        Dim encstream As New CryptoStream(ms, TripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)
        encstream.Write(plaintextBytes, 0, plaintextBytes.Length)
        Return Convert.ToBase64String(ms.ToArray)
    End Function
    Public Function DecryptData(ByVal Encryptedtext As String) As String
        Dim Encryptedbytes() As Byte = Convert.FromBase64String(Encryptedtext)
        Dim ms As New System.IO.MemoryStream
        Dim decstream As New CryptoStream(ms, TripleDes.CreateDecryptor(), System.Security.Cryptography.CryptoStreamMode.Write)
        decstream.Write(Encryptedbytes, 0, Encryptedbytes.Length)
        decstream.FlushFinalBlock()
        Return System.Text.Encoding.Unicode.GetString(ms.ToArray)
    End Function
End Class
