Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Debug.WriteLine("Lista de Tareas")
        Debug.WriteLine("")
        Debug.WriteLine("Count: " & TaskIO.GetTasks.Count)
        Debug.WriteLine("")

        For Each task As Task In TaskIO.GetTasks
            Debug.WriteLine("Id: " & task.Id)
            Debug.WriteLine("Titulo: " & task.Titulo)
            Debug.WriteLine("Completado: " & task.Completado)
            Debug.WriteLine("")
        Next

        ' Agregar tarea
        Dim ntask = New Task()
        With ntask
            .Id = TaskIO.NextId()
            .Titulo = "Nueva Tarea"
            .Completado = True
        End With
        TaskIO.AddTask(ntask)

        For Each task As Task In TaskIO.GetTasks
            Debug.WriteLine("Id: " & task.Id)
            Debug.WriteLine("Titulo: " & task.Titulo)
            Debug.WriteLine("Completado: " & task.Completado)
            Debug.WriteLine("")
        Next

        ' Eliminar tarea
        TaskIO.DeleteTask(4)

        For Each task As Task In TaskIO.GetTasks
            Debug.WriteLine("Id: " & task.Id)
            Debug.WriteLine("Titulo: " & task.Titulo)
            Debug.WriteLine("Completado: " & task.Completado)
            Debug.WriteLine("")
        Next

        ' Eliminar tarea
        TaskIO.DeleteTask(4)

        Dim mytask = From task In TaskIO.GetTasks
                     Where task.Id = 2 And task.Completado = True

        Debug.WriteLine(mytask(0).Titulo)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class