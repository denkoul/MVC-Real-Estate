Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub upload_Click(sender As Object, e As EventArgs) Handles upload.Click
        Response.Redirect("Vupload.aspx")
    End Sub

    Protected Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        Response.Redirect("VSearch.aspx")
    End Sub
End Class