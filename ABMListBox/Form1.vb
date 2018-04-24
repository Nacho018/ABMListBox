
Imports System.Xml
Imports System.IO

Public Class Form1


    Dim alfa As Boolean = False

    Dim mayus As Boolean = False


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

        ListBox1.ClearSelected()

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


        ListBox1.ClearSelected()
        TextBox1.Clear()
    End Sub

    Private Sub Enumerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Enumerar.Click
        Dim x As Integer

        If enumerado Or alfa Then Exit Sub

        For x = 0 To ListBox1.Items.Count - 1


            ListBox1.Items.Item(x) = CStr(x) + "-" + ListBox1.Items.Item(x).ToString


        Next


        TextBox1.Focus()
        enumerado = True


    End Sub


    Private Sub Alfabetizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Alfabetizar.Click
        Dim x As Integer

        If alfa Or enumerado Then Exit Sub

        For x = 0 To ListBox1.Items.Count - 1


            ListBox1.Items.Item(x) = Chr(x + 65) + "-" + ListBox1.Items.Item(x).ToString



        Next
        TextBox1.Focus()
        alfa = True

    End Sub

    Private Sub quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quitar.Click
        Dim x, G As Integer

        For x = 0 To ListBox1.Items.Count - 1
            'g obtiene el valor de la columna donde esta el guion


            G = ListBox1.Items.Item(x).ToString.IndexOf("-")


            'devuelve la cadena desde G mayuscula hasta el final

            ListBox1.Items.Item(x) = ListBox1.Items.Item(x).Substring(G + 1).ToString.ToLower




            enumerado = False

            alfa = False

            mayus = False



        Next

    End Sub

    Private Sub mayuscula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mayuscula.Click

        If mayus Then Exit Sub
        Dim x As Integer

        If mayus Then Exit Sub
        For x = 0 To ListBox1.Items.Count - 1



            ListBox1.Items.Item(x) = ListBox1.Items.Item(x).ToString.ToUpper


        Next
        mayus = True

        TextBox1.Focus()

    End Sub

    Private Sub GrabarXml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrabarXml.Click
        Dim ruta As String

        ruta = CurDir.Substring(0, CurDir.Length - 9)
        Dim escritor As New XmlTextWriter(ruta + "Lista.xml", System.Text.Encoding.UTF8)
        escritor.WriteStartDocument(True)

        escritor.Formatting = Formatting.Indented

        escritor.Indentation = 4

        escritor.writeStartElement("lista")
        Dim x As Integer


        For x = 0 To ListBox1.Items.Count - 1

            escritor.writeStartElement("elemento")
            escritor.WriteString(ListBox1.Items.Item(x).ToString)
            escritor.writeEndElement()






        Next


        escritor.writeEndElement()
        escritor.writeEndDocument()
        escritor.Close()

        MsgBox(" El mensaje ha sido guardado ")
        TextBox1.Focus()





    End Sub

    Private Sub Leer_Xml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Leer_Xml.Click

        Dim xmld As New XmlDocument
        Dim ListaNodos As XmlNodeList
        Dim nodo As XmlNode
        Dim ruta As String
        ruta = CurDir().Substring(0, CurDir().Length - 9)


        If Not File.Exists(ruta + "lista.xml") Then Exit Sub
        xmld.Load(ruta + "lista.xml")

        ListaNodos = xmld.SelectNodes("lista/elemento")

        For Each nodo In ListaNodos
            ListBox1.Items.Add(nodo.InnerText)





        Next



        TextBox1.Focus()








    End Sub
End Class


