

Public Class Form1


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
End Class


