Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Public Class Model
    Dim cn As New SqlConnection("Data Source=195.251.248.152,22;Initial Catalog=p3160129;User ID=********;Password=********;")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader

    Public Sub New()
    End Sub

    Public Sub insertBuilding(ByVal data As Building)
        cmd.Connection = cn
        cmd.CommandText = "insert into property values (" & data.id & ", '" & data.name & "', '" & data.addr &
            "', '" & data.date_of_aval & "', '" & data.purpose & "', " & data.size & ", " & data.price & ", '" &
        data.features & "', null, " & data.floors & ", " & data.rooms & ", " & data.year_of_construction & ", 1)"


        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Public Sub insertProperty(ByVal data As Property_)
        cmd.Connection = cn
        cmd.CommandText = "insert into property values (" & data.id & ", '" & data.name & "', '" & data.addr &
            "', '" & data.date_of_aval & "', '" & data.purpose & "', " & data.size & ", " & data.price & ", '" &
        data.features & "', " & "null" & ", " & "null" & ", " & "null" & ", " & "null" & ", 0)"


        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()

    End Sub
    Public Sub insertAppartment(ByVal data As Appartment)
        cmd.Connection = cn
        cmd.CommandText = "insert into property values (" & data.id & ", '" & data.name & "', '" & data.addr &
            "', '" & data.date_of_aval & "', '" & data.purpose & "', " & data.size & ", " & data.price & ", '" &
        data.features & "', " & data.floor & ", " & "null" & ", " & data.rooms & ", " & data.year_of_construction & ", 2)"


        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()

    End Sub

    Function getLastId() As Integer
        Dim ret As Integer
        cmd.Connection = cn
        cmd.CommandText = "select max(id) from property"
        cn.Open()

        ret = cmd.ExecuteScalar()
        cn.Close()

        If ret = Nothing Then
            Return 0
        End If
        Return ret
    End Function


    Function search(type As Integer, purpose As String, price_min As String, price_max As String, size_min As String, size_max As String) As List(Of List(Of String))
        Dim l As New List(Of List(Of String))
        Dim c As Integer
        Dim output As String
        Dim _select As String

        _select = "select * from property where type_of_prop = " & type & "  And purpose = '" & purpose & "' "

        If price_min = Nothing Then
            price_min = "0"
        End If
        If Not price_max = Nothing Then
            _select = _select + " and price between " & price_min & " and " & price_max
        Else
            _select = _select + " and price >= " & price_min
        End If

        If size_min = Nothing Then
            size_min = "0"
        End If
        If Not size_max = Nothing Then
            _select = _select + " and size between " & size_min & " and " & size_max
        Else
            _select = _select + " and size >= " & size_min
        End If

        cmd.Connection = cn
        cmd.CommandText = _select
        cn.Open()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then

            While (dr.Read())
                Dim r As New List(Of String)


                c = 0
                output = " "
                While c < dr.FieldCount

                    output = Convert.ToString(dr.GetSqlValue(c))
                    r.Add(output)
                    c = c + 1
                End While


                l.Add(r)
            End While
        End If
        cn.Close()


        Return l



    End Function


End Class
