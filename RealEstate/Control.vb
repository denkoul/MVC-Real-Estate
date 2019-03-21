Public Class Control
    Dim name As String
    Dim date_aval As String
    Dim purpose As String
    Dim address As String
    Dim type As String
    Dim size As String
    Dim price As String
    Dim floor As String
    Dim floors As String
    Dim rooms As String
    Dim yocnstr As String
    Dim features As String
    Dim checked As Boolean

    Dim last_id As Integer

    Public Sub New(name As String, date_aval As String, purpose As String, address As String, type As String, size As String, price As String, floor As String, floors As String, rooms As String, yocnstr As String, features As String, checked As Boolean)
        Me.name = name
        Me.date_aval = date_aval
        Me.purpose = purpose
        Me.address = address
        Me.type = type
        Me.size = size 'double
        Me.price = price 'double
        Me.floor = floor 'int
        Me.floors = floors 'int
        Me.rooms = rooms 'int
        Me.yocnstr = yocnstr 'int
        Me.features = features
        Me.checked = checked
    End Sub

    Public Sub New()

    End Sub

    Function check() As String
        Dim chars() As Char = name
        For Each c As Char In chars
            If IsNumeric(c) Then
                Return "Name contains number"
                Exit For
            End If
        Next
        If Not IsNumeric(size) Then
            Return "Size is empty or contains text"
        End If

        If Not IsNumeric(price) Then
            Return "Price is empty or contains text"
        End If

        If Not checked Then
            Return "Terms not accepted"
        End If

        If IsNumeric(date_aval) Then
            Return "Date not correct"
        End If


        Dim m As New Model()


        last_id = m.getLastId()
        last_id = last_id + 1


        If (type = 0) Then


            Dim p1 = New Property_(last_id, name, address, date_aval, purpose, Double.Parse(size), Double.Parse(price), features)

            m.insertProperty(p1)


        Else

            If Not IsNumeric(yocnstr) Then
                Return "Year of construction is empty or contains text"
            End If

            If Not IsNumeric(rooms) Then
                Return "Rooms is empty or contains text"
            End If

            If type = 1 Then
                If Not IsNumeric(floors) Then
                    Return "Floors is empty or contains text"
                End If


                Dim b1 = New Building(last_id, name, address, date_aval, purpose, Double.Parse(size), Double.Parse(price), features, Integer.Parse(floors), Integer.Parse(yocnstr), Integer.Parse(rooms))

                m.insertBuilding(b1)
            End If

            If type = 2 Then
                If Not IsNumeric(floor) Then
                    Return "Floor is empty or contains text"
                End If

                Dim a1 = New Appartment(last_id, name, address, date_aval, purpose, Double.Parse(size), Double.Parse(price), features, Integer.Parse(floor), Integer.Parse(yocnstr), Integer.Parse(rooms))

                m.insertAppartment(a1)

            End If



        End If
        Return "Upload successful"

    End Function

    Function search(type As Integer, purpose As String, price_min As String, price_max As String, size_min As String, size_max As String) As List(Of List(Of String))
        Dim list As New List(Of List(Of String))
        Dim m As New Model()
        Dim error_found As Boolean = False
        Dim no_price_min = False, no_price_max = False, no_size_min = False, no_size_max = False
        Dim _price_min, _price_max, _size_min, _size_max As Double


        If Not price_min = Nothing Then
            If Not IsNumeric(price_min) Then
                Dim text1 As New List(Of String)
                text1.Add("Min price is not a number")
                list.Add(text1)
                error_found = True
            Else
                _price_min = Double.Parse(price_min)
            End If
        Else
            no_price_min = True
        End If

        If Not price_max = Nothing Then
            If Not IsNumeric(price_max) Then
                Dim text2 As New List(Of String)
                text2.Add("Max price is not a number")
                list.Add(text2)
                error_found = True
            Else
                _price_max = Double.Parse(price_max)
            End If

        Else
            no_price_max = True
        End If

        If Not size_min = Nothing Then

            If Not IsNumeric(size_min) Then

                Dim text3 As New List(Of String)
                text3.Add("Min size is not a number")
                list.Add(text3)
                error_found = True

            Else
                _size_min = Double.Parse(size_min)
            End If
        Else
            no_size_min = True
        End If

        If Not size_max = Nothing Then

            If Not IsNumeric(size_max) Then

                Dim text4 As New List(Of String)
                text4.Add("Max size is not a number")
                list.Add(text4)
                error_found = True

            Else

                _size_max = Double.Parse(size_max)
            End If

        Else
            no_size_max = True
        End If

        If Not error_found Then

            If no_price_max = False And no_price_min = False Then
                If _price_min > _price_min Then
                    Dim text5 As New List(Of String)
                    text5.Add("Min price larger than max price")
                    list.Add(text5)
                    error_found = True
                End If
            End If

            If no_size_max = False And no_size_min = False Then
                If _size_min > _size_max Then
                    Dim text6 As New List(Of String)
                    text6.Add("Min size larger than max price")
                    list.Add(text6)
                    error_found = True
                End If
            End If


            If Not error_found Then
                list = m.search(type, purpose, price_min, price_max, size_min, size_max)
            End If

        End If


        Return list




    End Function


End Class
