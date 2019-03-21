Public Class VSearch
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c1 As New Control
        Dim list As New List(Of List(Of String))
        list = c1.search(DropDownList2.SelectedIndex, DropDownList1.SelectedItem.Text, price_more_than.Text, price_less_than.Text, size_more_than.Text, size_less_than.Text)


        Dim title_row As New TableRow


        Dim id As New TableCell
        id.Text = "Property ID"
        title_row.Cells.Add(id)
        Dim name As New TableCell
        name.Text = "Owner's Name"
        title_row.Cells.Add(name)
        Dim address As New TableCell
        address.Text = "Address"
        title_row.Cells.Add(address)
        Dim dofaval As New TableCell
        dofaval.Text = "Date of avaliability"
        title_row.Cells.Add(dofaval)
        Dim purp As New TableCell
        purp.Text = "Purpose"
        title_row.Cells.Add(purp)
        Dim size_ As New TableCell
        size_.Text = "Size"
        title_row.Cells.Add(size_)
        Dim price As New TableCell
        price.Text = "Price"
        title_row.Cells.Add(price)
        Dim feat As New TableCell
        feat.Text = "Features"
        title_row.Cells.Add(feat)
        Dim floor As New TableCell
        floor.Text = "Floor"
        title_row.Cells.Add(floor)
        Dim floors As New TableCell
        floors.Text = "Floors"
        title_row.Cells.Add(floors)
        Dim roomss As New TableCell
        roomss.Text = "Rooms"
        title_row.Cells.Add(roomss)
        Dim cat As New TableCell
        cat.Text = "Constructed at"
        title_row.Cells.Add(cat)
        Dim typ As New TableCell
        typ.Text = "Type of property"
        title_row.Cells.Add(typ)


        Table1.Rows.Add(title_row)

        For Each i As List(Of String) In list
            Dim r As New TableRow

            For Each j As String In i
                Dim c As New TableCell



                c.Text = j
                r.Cells.Add(c)

                If r.Cells.GetCellIndex(c) = 12 Then
                    If c.Text = "0" Then
                        c.Text = "Empty Property"
                    End If
                    If c.Text = "1" Then
                        c.Text = "Building"
                    End If
                    If c.Text = "2" Then
                        c.Text = "Appartment"
                    End If
                End If
            Next



            Table1.Rows.Add(r)
        Next



    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("index.aspx")
    End Sub
End Class