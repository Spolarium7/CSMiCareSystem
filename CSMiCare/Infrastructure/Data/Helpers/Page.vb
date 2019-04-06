Public Class Page(Of T)
    Public Property TotalPageCount As Integer
    Public Property CurrentPage As Integer
    Public Property PageSize As Integer
    Public Property TotalItemCount As Integer
    Public Property Keyword As String
    Public Property Data As List(Of T)
End Class
