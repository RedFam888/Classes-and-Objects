
'Auto-Implemented Properties enables you to specify the Property of a Class in a SINGLE line of Code
'Visual Basic will automatically create a hidden "Private Variable" that associates with the Property.
'It will also create a Hideen "GET and SET Block"
'No need to create the Private Variable nor do you need to Enter in the get and Set Blocks
'Example 5 and 6 from the Slides shared the Same Program Example except one did not use Auto-Implemented Properties
'I did not make a 2nd program simply commented out the previous Public Properties that had Get and Set Blocks and
'Implmented the Public Properties within the Class Decleration Statement

Public Class CourseGrade
    Public Property score1 As Integer
    Public Property score2 As Integer
    Private _letterGrade As String

    'Public Property score1 As Integer
    'Get
    'Return _score1
    '   End Get
    '  Set(value As Integer)
    '   If value > 0 Then
    '              _score1 = value
    ' Else
    '            _score1 = 0
    'End If
    'End Set
    'End Property

    'Public Property score2 As Integer
    'Get
    'Return _score2
    'End Get
    'Set(value As Integer)
    'If value > 0 Then
    '           _score2 = value
    'Else
    '           _score2 = 0
    'End If
    'End Set
    'End Property

    Public ReadOnly Property letterGrade As String
        Get
            Return _letterGrade
        End Get
    End Property

    Public Sub New()
        _score1 = 0
        _score2 = 0
    End Sub

    Public Sub New(ByVal S1 As Integer, ByVal S2 As Integer)
        score1 = S1
        score2 = S2
    End Sub

    Public Sub DetermineGrade()
        Select Case _score1 + _score2
            Case Is >= 180
                _letterGrade = "A"
            Case Is >= 160
                _letterGrade = "B"
            Case Is >= 140
                _letterGrade = "C"
            Case Is >= 120
                _letterGrade = "D"
            Case Else
                _letterGrade = "F"
        End Select
    End Sub
End Class
