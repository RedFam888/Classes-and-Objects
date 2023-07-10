Option Strict On
Option Explicit On
Option Infer Off
'Classes and Objects Practice
'Mason Merritt

Imports System.Windows.Forms.Design

Public Class Form1
    Private Sub btnExample1Slides_Click(sender As Object, e As EventArgs) Handles btnExample1Slides.Click

        'EXAMPLE 1 From Slide Presentation-- A Class that contains only Public Variables

        'Creates a new customerPool object from the RectangularPool Class
        Dim customerPool As New RectangularPool

        'Variables and Tryparse Input into variables
        Dim gallons As Double

        Double.TryParse(txtLength.Text, customerPool.length)
        Double.TryParse(txtWidth.Text, customerPool.width)
        Double.TryParse(txtDepth.Text, customerPool.depth)

        'Variable will be equal to the result from the Function that CustomerPool data is being passed into ByVal
        gallons = GetGallons(customerPool)

        'Display final Results to the User
        txtGallonsResult.Text = gallons.ToString("n0")

    End Sub

    Private Function GetGallons(ByVal pool As RectangularPool) As Double

        'Variable for water cubic feet 
        Const cubicFeet As Double = 7.48

        'Function takes data from CustomerPool and recieves it into the pool object of the function returning the gallons needed to fill pool
        Return pool.length * pool.width * pool.depth * cubicFeet
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Add Length, Width and Prices to Listboxes for Carpet Galore Application
        Dim number As Double = 5
        While number < 60
            lstLength.Items.Add(number)
            lstWidth.Items.Add(number)
            lstPrice.Items.Add(number)
            number += 0.5
        End While

        'Add TestScores to ListBoxes
        Dim score As Integer = 100
        While score > 0
            lstTest1.Items.Add(score)
            lstTest2.Items.Add(score)
            score -= 1
        End While
        lstTest1.SelectedIndex = 8
        lstTest2.SelectedIndex = 8

        'Add Hours,PayRate and Salary to ListBoxes
        Dim hoursANDpay As Double
        Dim salary As Double = 40000

        While hoursANDpay <= 100
            lstHours.Items.Add(hoursANDpay)
            lstPayRate.Items.Add(hoursANDpay)
            hoursANDpay += 1
        End While

        While salary <= 200000
            lstSalary.Items.Add(salary)
            salary += 500
        End While
    End Sub

    Private Sub btnCarpetsGalore_Click(sender As Object, e As EventArgs) Handles btnCarpetsGalore.Click

        'Variable for Rectangle Object
        Dim floor As Rectangle

        'Variables and Tryparse to assign Input Data
        Dim price As Double
        Dim sqYards As Double
        Dim cost As Double
        Dim roomLen As Double
        Dim roomWid As Double

        Double.TryParse(lstLength.SelectedItem.ToString, roomLen)
        Double.TryParse(lstWidth.SelectedItem.ToString, roomWid)
        Double.TryParse(lstPrice.SelectedItem.ToString, price)

        'Instantiate and Initialize the Rectangle Object using the Parameterized Constructor
        floor = New Rectangle(roomLen, roomWid)

        'Calculate Square Yards which is the Area divided by 9
        sqYards = floor.GetArea / 9

        'Calculate cost
        cost = sqYards * price

        'Display Output
        txtSQYardsResults.Text = sqYards.ToString("n1")
        txtCarpetsCost.Text = cost.ToString("c2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Objects, Variables, and TryParses for UserInput
        Dim entirePizza As New Rectangle
        Dim pizzaSlice As New Rectangle
        Dim pizzaArea As Double
        Dim sliceArea As Double
        Dim numSlices As Double

        'These TryParses pass UserInput into the Public Properties of the Rectangle Class
        Double.TryParse(txtEntirePizza.Text, entirePizza.length)
        Double.TryParse(txtEntirePizza.Text, entirePizza.width)
        Double.TryParse(txtPizzaSlice.Text, pizzaSlice.length)
        Double.TryParse(txtPizzaSlice.Text, pizzaSlice.width)

        'Calculate Areas
        pizzaArea = entirePizza.GetArea
        sliceArea = pizzaSlice.GetArea

        'Calculate Number Of Slices

        If sliceArea > 0 Then
            numSlices = pizzaArea / sliceArea
        Else
            numSlices = 0
        End If

        'Display Resuls
        txtNumOfSlices.Text = numSlices.ToString("n0")
    End Sub

    Private Sub btnGradeCalculator_Click(sender As Object, e As EventArgs) Handles btnGradeCalculator.Click

        'Instantiate New CourseGrade Object
        Dim studentGrade As New CourseGrade

        'Assign UserInput to new Object's appropriate variables
        Integer.TryParse(lstTest1.SelectedItem.ToString, studentGrade.score1)
        Integer.TryParse(lstTest2.SelectedItem.ToString, studentGrade.score2)

        'Calculate Grade using Class CourseGrade DetermineGrade Method by having the new studentGrade object call the Procedure
        studentGrade.DetermineGrade()

        'Display the results of the Procedure based on UserInput
        txtGradeResult.Text = studentGrade.letterGrade
    End Sub

    Private Sub btnEmployeeCalculator_Click(sender As Object, e As EventArgs) Handles btnEmployeeCalculator.Click
        'This is an example of OVERLOADED METHODS. The Class has a Function Called GETGROSS and recieves different variables from
        'instantiated PERSON Object. If the Person is a Hourly Employee the object will pass the hours and payrate variables
        'into the Class FUnction GETGROSS. If the Person is a Salary Employee then theobject will pass the annualSalary variable

        'Object, Variables and Tryparses
        Dim person As New Employee(txtEmpNumber.Text, txtEmpName.Text)
        Dim annualSalary As Double
        Dim empHours As Double
        Dim empRate As Double
        Dim grosspay As Double

        'Determine which radio button is clicked
        If radHourly.Checked Then
            Double.TryParse(lstHours.SelectedItem.ToString, empHours)
            Double.TryParse(lstPayRate.SelectedItem.ToString, empRate)
            grosspay = person.GetGross(empHours, empRate)
        ElseIf radSalary.Checked Then
            Double.TryParse(lstSalary.SelectedItem.ToString, annualSalary)
            grosspay = person.GetGross(annualSalary)
        End If

        'Display Grosspay and Report
        txtEmpGross.Text = grosspay.ToString("c2")
        txtReport.Text = person.number.PadRight(6) & person.name.PadRight(25) & grosspay.ToString("c2").PadLeft(9) & vbCrLf
    End Sub

    Private Sub radHourly_CheckedChanged(sender As Object, e As EventArgs) Handles radHourly.CheckedChanged
        lstSalary.Visible = False
        lstHours.Visible = True
        lstPayRate.Visible = True
    End Sub

    Private Sub radSalary_CheckedChanged(sender As Object, e As EventArgs) Handles radSalary.CheckedChanged
        lstHours.Visible = False
        lstPayRate.Visible = False
        lstSalary.Visible = True
    End Sub

    Private Sub btnAreaCube_Click(sender As Object, e As EventArgs) Handles btnAreaCube.Click

        'Objects,Variables, and TryParse
        Dim myCube As New Shapes.Cube
        Dim area As Double

        Double.TryParse(txtSideMeasurement.Text, myCube.side)

        'Calculate the area of the Cube
        area = myCube.GetArea()

        'Display results to the User
        txtAreaResults.Text = "The Area of the Cube is " & area.ToString("n1")
    End Sub

    Private Sub btnAreaSquare_Click(sender As Object, e As EventArgs) Handles btnAreaSquare.Click

        'Objects,Variables, and TryParse
        Dim mySquare As New Shapes.Square
        Dim area As Double

        Double.TryParse(txtSideMeasurement.Text, mySquare.side)

        'Calculate area of the Square
        area = mySquare.GetArea()

        'Display the Results to the User
        txtAreaResults.Text = area.ToString("n1")
    End Sub

    Private Sub btnYouCanDotIt1and2_Click(sender As Object, e As EventArgs) Handles btnYouCanDotIt1and2.Click

        'Variables,Tryparse and Assignment to new Objecct instantiated from the Circle Class
        Dim myCircle As New Circle
        Double.TryParse(txtYouDoIt1and2.Text, myCircle.radius)
        Dim area As Double

        'Calculation
        area = myCircle.GetCircleArea()

        'Display Results
        txtYouDoIt1and2Results.Text = area.ToString("n2")
    End Sub

    Private Sub btnYouCanDoIt3_Click(sender As Object, e As EventArgs) Handles btnYouCanDoIt3.Click

        'Variables,TryParse and Assignment to new Object instantiated from the Square Class
        Dim mySquare As New Shapes.Square
        Double.TryParse(txtDoIt3.Text, mySquare.side)
        Dim perimeter As Double

        'Calculation
        perimeter = mySquare.GetPerimeter()

        'Display Results
        txtYouCanDoIt3Results.Text = perimeter.ToString("n2")
    End Sub


End Class
