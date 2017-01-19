Public Class Form1

    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click

        'set default directory to cherry pick folder
        OpenFileDialog1.InitialDirectory = "C:\Users\Administrator\Documents\EVO Programs\384-Well CherryPicks"
        'open csv files only
        OpenFileDialog1.Filter = "csv files (*.csv)|*.csv"
        OpenFileDialog1.ShowDialog()

        'close form if openfiledialog was cancelled
        If OpenFileDialog1.FileName = "" Then
            Close()
        End If

        'saving location of cherry pick file
        cpfilepath.Text = OpenFileDialog1.FileName

    End Sub

End Class

