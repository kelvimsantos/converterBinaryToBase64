Imports System.IO

Module Module1
    Sub Main()
        ' Ler o arquivo de imagem em bytes
        Dim imagePath As String = "caminho/para/a/imagem.jpg"
        Dim imageBytes As Byte() = File.ReadAllBytes(imagePath)

        ' Converter os bytes da imagem para Base64
        Dim base64String As String = Convert.ToBase64String(imageBytes)

        ' Imprimir o resultado
        Console.WriteLine("Imagem em Base64:")
        Console.WriteLine(base64String)
    End Sub
End Module
