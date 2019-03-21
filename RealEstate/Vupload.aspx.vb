Public Class Vupload
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub
    Protected Sub DropDownList2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList2.SelectedIndexChanged
        If DropDownList2.SelectedIndex = 1 Then
            'Floor.Visible = False
            floorbox.Enabled = False
            'Floors.Visible = True
            floorsbox.Enabled = True
            'Rooms.Visible = True
            roomsbox.Enabled = True
            'construction.Visible = True
            constructbox.Enabled = True
        End If
        If DropDownList2.SelectedIndex = 2 Then
            'Floors.Visible = False
            floorsbox.Enabled = False
            'Floor.Visible = True
            floorbox.Enabled = True
            'Rooms.Visible = True
            roomsbox.Enabled = True
            'construction.Visible = True
            constructbox.Enabled = True
        End If
        If DropDownList2.SelectedIndex = 0 Then
            'Floors.Visible = False
            floorsbox.Enabled = False
            'Floor.Visible = False
            floorbox.Enabled = False
            'Rooms.Visible = False
            roomsbox.Enabled = False
            'construction.Visible = False
            constructbox.Enabled = False
        End If

    End Sub

    Protected Sub Upload_Click(sender As Object, e As EventArgs) Handles Upload.Click
        Dim c1 As New Control(namebox.Text, datebox.Text, DropDownList1.SelectedItem.Text, addrbox.Text, DropDownList2.SelectedIndex, sizebox.Text, pricebox.Text, floorbox.Text, floorsbox.Text, roomsbox.Text, constructbox.Text, featurebox.Text, terms_accept.Checked)
        errorlabel.Text = c1.check()
        errorlabel.Visible = True
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("index.aspx")
    End Sub

    Protected Sub terms_accept_CheckedChanged(sender As Object, e As EventArgs) Handles terms_accept.CheckedChanged

    End Sub
End Class