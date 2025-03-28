Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Sub LoadNotifications()
        ListBox1.Items.Clear()
        Dim query As String = "SELECT ID, Message FROM Notifications ORDER BY DateCreated DESC"
        Dim cmd As New OleDbCommand(query, conn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim notificationID As Integer = reader("NotificationID")
            Dim message As String = reader("Message")
            ListBox1.Items.Add(notificationID & " - " & message) ' Display ID & Message
        End While

        reader.Close()
        UpdateUnreadCount()
    End Sub





End Class
