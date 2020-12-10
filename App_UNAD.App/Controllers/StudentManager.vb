Imports App_UNAD.App.App_UNAD.App

Public Class StudentManager
    Public Function Insert(ByVal email As String, ByVal document As String, ByVal password As String)
        Try
            Using context As New UnadAppEntities
                Dim student As New Student
                Dim wrapper As New Simple3Des("keyPass")
                Dim cipherText As String = wrapper.EncryptData(password)

                student.Email = email
                student.Document = document
                student.Password = cipherText

                context.Student.Add(student)
                context.SaveChanges()
            End Using

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function CheckUser(ByVal email As String, ByVal password As String)
        Try
            Using context As New UnadAppEntities
                Dim student As New Student
                Dim wrapper As New Simple3Des("keyPass")
                Dim cipherText As String = wrapper.EncryptData(password)

                Dim result = context.Student.Where(Function(x) x.Email = email And x.Password = cipherText).FirstOrDefault()

                If result IsNot Nothing Then
                    Return True
                End If
            End Using
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
