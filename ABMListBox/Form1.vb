

Public Class Form1

    Dim alfa As Boolean = False


    Dim enumerado As Boolean = False





    Private Sub Alta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Alta.Click
        '"no perder el foco
        TextBox1.Focus()
        '"elimina espacios en blanco
        If TextBox1.Text.Trim = "" Then Exit Sub

        TextBox1.Text.TrimStart()





        ListBox1.Items.Add(TextBox1.Text.Trim)
        '"limpia el cuadro de texto
        TextBox1.Clear()

    End Sub

    Private Sub baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles baja.Click
        TextBox1.Focus()
        '"funciona solo si selecciono un elemento de la lista
        If ListBox1.SelectedIndex = -1 Then Exit Sub
        '"remueve los items seleccionados
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)


        TextBox1.Clear()


    End Sub

    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click



        TextBox1.Text = ListBox1.Items.Item(ListBox1.SelectedIndex)


        TextBox1.Focus()

    End Sub

    Private Sub Modificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Modificar.Click
        TextBox1.Focus()
        If ListBox1.SelectedIndex = -1 Then Exit Sub


        ListBox1.Items.Item(ListBox1.SelectedIndex) = TextBox1.Text
        TextBox1.Clear()

        ListBox1.ClearSelected()

    End Sub

    Private Sub Enumerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Enumerar.Click
        Dim x As Integer

        If enumerado Then Exit Sub

        For x = 0 To ListBox1.Items.Count - 1


            ListBox1.Items.Item(x) = CStr(x) + " " + ListBox1.Items.Item(x).ToString


        Next


        TextBox1.Focus()
        enumerado = True


    End Sub


    Private Sub Alfabetizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Alfabetizar.Click
        Dim x As Integer

        If alfa Then Exit Sub
        For x = 0 To ListBox1.Items.Count - 1


            ListBox1.Items.Item(x) = Chr(x + 65) + " " + ListBox1.Items.Item(x).ToString



        Next
        TextBox1.Focus()
        alfa = True

    End Sub
End Class


