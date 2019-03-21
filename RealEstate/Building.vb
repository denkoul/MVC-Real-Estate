Public Class Building
    Inherits Property_
    Public floors As Integer
    Public year_of_construction As Integer
    Public rooms As Integer
    Public Sub New(id As String, name As String, addr As String, date_of_aval As String, purpose As String, size As Double, price As Double, features As String, floors As Integer, year_of_construction As Integer, rooms As Integer)
        MyBase.New(id, name, addr, date_of_aval, purpose, size, price, features)
        Me.floors = floors
        Me.year_of_construction = year_of_construction
        Me.rooms = rooms
    End Sub
End Class
