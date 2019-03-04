Imports System.Reflection
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Console.WriteLine(#3/4/2019#.PreviousDay(DayOfWeek.Monday, False))
        Dim mondayOfLastWeek As Date = Now.AddDays(-CInt(Fix(Now.DayOfWeek)) - 6)
        Console.WriteLine(mondayOfLastWeek)
    End Sub
End Class
Public Module Extensions
    <Runtime.CompilerServices.Extension>
    Public Function PreviousDay(dt As Date, dow As DayOfWeek) As Date
        Return dt.PreviousDay(dow, False)
    End Function

    <Runtime.CompilerServices.Extension>
    Public Function PreviousDay(dt As Date, dow As DayOfWeek, includeThis As Boolean) As Date
        Dim diff As Integer = dt.DayOfWeek - dow
        If (includeThis AndAlso diff < 0) OrElse ((Not includeThis) AndAlso diff <= 0) Then
            diff += 7
        End If
        Return dt.Date.AddDays(-diff)
    End Function
End Module