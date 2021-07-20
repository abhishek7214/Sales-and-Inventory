Public Class frmmain

    Private Sub mnu_category_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_category.Click
        With frmcategory
            .MdiParent = Me
            .WindowState = FormWindowState.Normal

            .Show()
        End With
    End Sub

    

    Private Sub mnu_product_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_product.Click
        With frmproduct
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()

        End With
    End Sub

    Private Sub mnu_supplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_supplier.Click
        With frmsupplier
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()

        End With
    End Sub

    Private Sub mnu_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_search.Click
        With frmsearch
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()

        End With
    End Sub

    Private Sub CUSTOMERORDERSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUSTOMERORDERSToolStripMenuItem.Click
        With frmpurchase
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()

        End With
    End Sub

    Private Sub SUPPLIERORDERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUPPLIERORDERToolStripMenuItem.Click
        status = "YES"
        With frmsupplierorder
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Show()

        End With
    End Sub

End Class