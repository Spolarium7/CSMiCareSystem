Imports CSMiCare.PatientsBLL
Class MainWindow
    Dim bll As New PatientsBLL()

    Private Sub BtnPatients_Click(sender As Object, e As RoutedEventArgs) Handles btnPatients.Click
        Dim patientsIndex As New PatientsIndex()
        patientsIndex.Show()
    End Sub

    Private Sub cboPatientSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles cboPatientSearch.KeyUp
        Dim patientLookupValues = bll.Lookup(cboPatientSearch.Text)

        cboPatientSearch.ItemsSource = patientLookupValues
        cboPatientSearch.DisplayMemberPath = "Text"
        cboPatientSearch.IsDropDownOpen = True
    End Sub

    Private Sub cboPatientSearch_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles cboPatientSearch.SelectionChanged
        MessageBox.Show("You chose PatientId " & DirectCast(cboPatientSearch.SelectedValue, TextValuePair).Value.ToString())
    End Sub
End Class
