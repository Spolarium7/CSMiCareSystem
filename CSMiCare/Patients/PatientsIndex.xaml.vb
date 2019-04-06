Public Class PatientsIndex
    Dim bll As New CSMiCare.PatientsBLL()
    Dim pageIndex As Integer
    Dim pageSize As Integer
    Dim totalPages As Integer
    Dim keyword As String

    Private Sub PatientsIndex_Loaded(sender As Object, e As RoutedEventArgs) Handles PatientsIndex.Loaded
        LoadPage(1, 10, "")
    End Sub

    Private Sub btnConfirmDelete_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim patient As Patient = TryCast((CType(sender, FrameworkElement)).DataContext, Patient)

        If (MessageBox.Show("Are you sure your want to delete " & patient.FullName & "?", "Delete Patient", vbYesNo) = vbYes) Then
            If (bll.Delete(patient.Id) > 0) Then
                MessageBox.Show("You deleted " + patient.Id.ToString())
                LoadPage(1, 10, "")
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim patient As Patient = TryCast((CType(sender, FrameworkElement)).DataContext, Patient)
        Dim editForm As New PatientsEdit(patient.Id, Me)
        editForm.Show()
    End Sub

    Public Sub LoadPage(Optional pageIndex As Int32 = 1, Optional pageSize As Int32 = 10, Optional keyword As String = "")
        Dim patients = bll.SearchPatients(pageIndex, pageSize, keyword)
        grPatients.ItemsSource = patients.Data
        grPatients.CanUserAddRows = False
        grPatients.CanUserDeleteRows = False
        grPatients.CanUserReorderColumns = False

        Me.pageIndex = patients.CurrentPage
        Me.pageSize = patients.PageSize
        Me.totalPages = patients.TotalPageCount
        Me.keyword = patients.Keyword

        lblPageDescription.Content = " Page " & Me.pageIndex & " of " & Me.totalPages
    End Sub

    Private Sub BtnNewPatient_Click(sender As Object, e As RoutedEventArgs) Handles btnNewPatient.Click
        Dim addForm As New PatientsAdd(Me)
        addForm.Show()
    End Sub

    Private Sub BtnFirst_Click(sender As Object, e As RoutedEventArgs) Handles btnFirst.Click
        LoadPage(1, pageSize, "")
    End Sub

    Private Sub BtnPrev_Click(sender As Object, e As RoutedEventArgs) Handles btnPrev.Click
        Dim prevPage = Me.pageIndex - 1
        If (prevPage < 1) Then
            prevPage = 1
        End If
        LoadPage(prevPage, pageSize, keyword)
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As RoutedEventArgs) Handles btnNext.Click
        Dim nextPage = Me.pageIndex + 1
        If (nextPage > Me.totalPages) Then
            nextPage = Me.totalPages
        End If
        LoadPage(nextPage, pageSize, keyword)
    End Sub

    Private Sub BtnLast_Click(sender As Object, e As RoutedEventArgs) Handles btnLast.Click
        LoadPage(Me.totalPages, pageSize, keyword)
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Key = Key.Enter Then
            If (String.IsNullOrEmpty(txtSearch.Text) = False) Then
                LoadPage(1, 10, txtSearch.Text)
            Else
                LoadPage(1, 10, "")
            End If
        End If
    End Sub
End Class
