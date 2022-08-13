Public NotInheritable Class MainPage
    Inherits Page
    ''Note: Most of the coding is in the HTML file.
    ''SmarticalcCommandBar subroutines
    Private Sub RefreshButton_Click(sender As Object, e As RoutedEventArgs) Handles RefreshButton.Click
        Navi.Refresh()
    End Sub
    Private Sub StopButton_Click(sender As Object, e As RoutedEventArgs) Handles RefreshButton.Click
        Navi.Stop()
    End Sub
End Class
