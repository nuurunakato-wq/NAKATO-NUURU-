Public class Form1
    private sub Form1_Load(sender As Object, e As EventArgs)Handles MyBase.Form1_Load
    'Assignment :Assign values to a multidimensional array
Dim studentMarks(,) As Integer = {
    {75, 80, 90, 85},
    {80, 85, 95, 90},
    {90, 95, 81, 80},
    {85, 90, 80, 75}
}
'Assignment : Display the multidimensional array
Console.WriteLine("Student Marks:")

For i As Integer = 0 To studentMarks.GetLength(0) - 1
    For j As Integer = 0 To studentMarks.GetLength(1) - 1
        Console.Write(studentMarks(i, j) & vbTab)
    Next
    Console.WriteLine()
Next
console.ReadLine()
End sub
End class