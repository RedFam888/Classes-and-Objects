Public Class Shapes
    'BASE CLASS
    Public Class Square
        Public Property side As Double

        Public Sub New()
            _side = 0
        End Sub

        Public Sub New(ByVal S As Double)
            If S > 0 Then
                side = S
            Else
                side = 0
            End If
        End Sub

        Public Overridable Function GetArea() As Double
            Return _side ^ 2
        End Function

        'Adding a Function to get the Perimeter of a Square for You Can Do It 3 from Textbook
        Public Function GetPerimeter() As Double
            Return _side * 4
        End Function
    End Class

    Public Class Cube
        Inherits Square

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal S As Double)
            MyBase.New(S)
        End Sub

        Public Overrides Function GetArea() As Double
            Return MyBase.GetArea() * 6
        End Function
    End Class
End Class
