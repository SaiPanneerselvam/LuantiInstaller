Imports System.Net
Imports System.IO
Imports IWshRuntimeLibrary ' For creating shortcuts
Imports Shell32 ' For extracting ZIP files

Public Class Form1

    Private Sub option1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles option1.Click
        If option1.Text = "Start" Then
            title.Text = "Ready to install?"
            description.Text = "The Luanti installer (formerly Minetest) downloads the latest version of Luanti files from the official GitHub page and sets up an easily accessible app in the Start Menu for the user, so you don't need to manually open it from the folder."
            option1.Text = "Begin"
            option2.Show()
            option2.Text = "Back"
        ElseIf option1.Text = "Begin" Then
            title.Text = "Installing Luanti..."
            description.Text = "It may look like not much is happening, but rest assured, things are in progress."
            option1.BackColor = Color.Gray
            option1.Enabled = False
            option2.BackColor = Color.Gray
            option2.Enabled = False
            closebutton.BackColor = Color.Gray
            closebutton.Enabled = False

            Try
                ' 1. Define paths
                Dim username As String = Environment.UserName
                Dim downloadUrl As New String("https://github.com/minetest/minetest/releases/download/5.10.0/luanti-5.10.0-win32.zip")
                Dim zipFilePath As String = Path.Combine(Path.GetTempPath(), "temp.zip")

                ' Concatenate paths using string concatenation
                Dim extractPath As String = "C:\Users\" & username & "\Luanti"
                Dim shortcutPath As String
                If Settings.usingcustomlocation = False Then

                    shortcutPath = "C:\Users\" & username & "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Luanti 5.10.0.lnk"

                Else
                    Try
                        shortcutPath = Settings.boxinstalllocation
                    Catch ex As Exception
                        MsgBox("The location that was specified for installation in the settings page is not correctly formatted, or the location my not exist.")
                        MsgBox("Terminating Install...")
                        MsgBox("App will close now. (press OK or Close button to finish...)")
                        Me.Close()
                    End Try
                End If

                Dim minetestExePath As String = extractPath & "\bin\luanti.exe"

                ' 2. Download the ZIP file
                DownloadFile(downloadUrl, zipFilePath)

                ' 3. Extract the ZIP file to the target directory
                ExtractZipFile(zipFilePath, extractPath)

                ' 4. Create a shortcut for minetest.exe
                CreateShortcut(minetestExePath, shortcutPath)

                ' Let the user know the process was successful
                MessageBox.Show("Luanti has been successfully downloaded, extracted, and the shortcut has been created.")
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try

            description.Text = "Installation Complete."
            option1.Enabled = True
            option2.Enabled = True
            option2.BackColor = Color.FromArgb(240, 240, 240)
            option1.BackColor = Color.FromArgb(240, 240, 240)
            closebutton.BackColor = Color.Red
            closebutton.Enabled = True
        End If
    End Sub

    ' Function to download a file
    Private Sub DownloadFile(ByVal url As String, ByVal destination As String)
        ' Ensure TLS 1.2 is used for modern secure connections
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 Or SecurityProtocolType.Ssl3

        Using client As New WebClient()
            client.DownloadFile(url, destination)
        End Using
    End Sub

    ' Function to extract a ZIP file using Shell32
    Public Sub ExtractZipFile(ByVal zipFilePath As String, ByVal extractTo As String)
        Dim shellApp As New Shell()

        ' Ensure the destination directory exists; create if it doesn't
        If Not Directory.Exists(extractTo) Then
            Directory.CreateDirectory(extractTo)
        End If

        ' Use Shell32 to extract the ZIP file
        shellApp.NameSpace(extractTo).CopyHere(shellApp.NameSpace(zipFilePath).Items, 4)
    End Sub

    ' Function to create a shortcut
    Private Sub CreateShortcut(ByVal targetPath As String, ByVal shortcutPath As String)
        If System.IO.File.Exists(targetPath) Then
            ' Create a WshShell object to interact with Windows Script Host
            Dim shell As New WshShell()
            ' Create a shortcut object at the specified path
            Dim shortcut As IWshShortcut = CType(shell.CreateShortcut(shortcutPath), IWshShortcut)

            ' Set the properties of the shortcut
            shortcut.TargetPath = targetPath
            shortcut.WorkingDirectory = Path.GetDirectoryName(targetPath)
            shortcut.Description = "Luanti"
            shortcut.IconLocation = targetPath ' You can change the icon if needed
            shortcut.Save() ' Save the shortcut
        Else
            Throw New FileNotFoundException("The target file is missing!")
        End If
    End Sub

    ' Event handler for closing the form
    Private Sub closebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebutton.Click
        Close()
    End Sub

    ' Event handler for the "Back" button
    Private Sub option2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles option2.Click
        If option2.Text = "Back" Then
            title.Text = "Luanti Installer"
            description.Text = "Install Luanti on your PC."
            option1.Text = "Start"
            option2.Hide()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Settings.ShowDialog()
    End Sub
End Class
