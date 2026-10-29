Imports System.IO

Module Module1
    Sub Main()
        Dim filePath As String = "StudentMarks.txt"

        ' 1. Write student marks to the file using StreamWriter
        Using writer As New StreamWriter(filePath)
            writer.WriteLine("ST001, Shaminah, 85")
            writer.WriteLine("ST002, Mahoro, 84")
            writer.WriteLine("ST003, Saum, 82")
            writer.WriteLine("ST004, Henry, 95")
        End Using

        Console.WriteLine("Student marks written to 'StudentMarks.txt' successfully.")
        Console.WriteLine(vbCrLf & "Reading marks from the file:")
        Console.WriteLine("----------------------------------------")

        ' 2. Read the marks back from the file using StreamReader
        If File.Exists(filePath) Then
            Using reader As New StreamReader(filePath)
                Dim line As String = reader.ReadLine()
                While line IsNot Nothing
                    Console.WriteLine(line)
                    line = reader.ReadLine()
                End While
            End Using
        Else
            Console.WriteLine("The file does not exist.")
        End If

        Console.WriteLine("----------------------------------------")
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module