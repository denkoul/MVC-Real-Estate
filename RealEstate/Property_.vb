Public Class Property_
    Public id As String
    Public name As String
    Public addr As String
    Public date_of_aval As String
    Public purpose As String
    Public size As Double
    Public price As Double
    Public features As String
    Public Sub New(id As String, name As String, addr As String, date_of_aval As String, purpose As String, size As Double, price As Double, features As String)
        Me.id = id
        Me.addr = addr
        Me.name = name
        Me.date_of_aval = date_of_aval
        Me.purpose = purpose
        Me.size = size
        Me.price = price
        Me.features = features
    End Sub


End Class
