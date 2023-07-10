
'Creating a New Rectangle Class
Public Class Rectangle
    'Creates Private Variables Which can not be accessed directly by the Program 
    Private _length As Double
    Private _width As Double


    'The Public Properties act as MiddleMen between the Application and the Private Variables of the Class

    'In this Instance the Property is getting the Private Varible (_length) if the Value being checked is validated then the
    'Private Variable will be set equal to whatever Value was else will be 0
    Public Property length As Double
        Get
            Return _length
        End Get
        Set(value As Double)
            If value > 0 Then
                _length = value
            Else
                _length = 0
            End If
        End Set
    End Property

    'In this Instance the Property is getting the Private Varible (_width) if the Value being checked is validated then the
    'Private Variable will be set equal to whatever Value was else will be 0
    Public Property width As Double
        Get
            Return _width
        End Get
        Set(value As Double)
            If value > 0 Then
                _width = value
            Else
                _width = 0
            End If
        End Set
    End Property

    'This is a Default Constructor that sets the Private Variables Directly to 0
    Public Sub New()
        _length = 0
        _width = 0
    End Sub

    'This is a paramterized Constructor that uses the Public Properties to check User Input before assigning to Private Variables
    Public Sub New(ByVal L As Double, ByVal W As Double)
        length = L
        width = W
    End Sub

    'A Method other than a Constructor- Function to GetArea of the Rectangle
    Public Function GetArea() As Double
        Return _length * _width
    End Function
End Class
