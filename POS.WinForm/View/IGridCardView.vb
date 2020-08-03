Public Interface IGridCardView

    Property CodiceFiliale As String
    Property Saldo As String


    Sub SetComboBoxData(data As List(Of FidelityFilialeViewModel))

    Sub ClearGrid()

    Sub AddGrid(resultRepository As List(Of FidelityCardViewModel))

    Sub SelectedItemList(row As Integer)

    Sub UpdateSaldo(saldo As String)
    Sub EnableForm()
End Interface
