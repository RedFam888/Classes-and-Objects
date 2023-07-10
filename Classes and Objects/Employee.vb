Public Class Employee
    Public Property number As String
    Public Property name As String

    Public Sub New()
        _number = ""
        _name = ""
    End Sub

    Public Sub New(ByVal empNumber As String, ByVal empName As String)
        number = empNumber
        name = empName
    End Sub

    Public Function GetGross(ByVal salary As Double) As Double
        Return salary / 24
    End Function

    Public Function GetGross(ByVal hours As Double, ByVal rate As Double) As Double
        Dim grosspay As Double

        If hours <= 40 Then
            grosspay = hours * rate
        ElseIf hours > 40 Then
            grosspay = (40 * rate) + ((hours - 40) * (rate * 1.5))
        End If
        Return grosspay
    End Function
End Class
