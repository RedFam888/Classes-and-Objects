Public Class Circle
    Public Property radius As Double

    Public Sub New()
        _radius = 0
    End Sub

    Public Sub New(ByVal R As Double)
        radius = R
    End Sub

    Public Function GetCircleArea() As Double
        Return _radius * 3.141592
    End Function
End Class
